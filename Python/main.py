import os
from flask import Flask, request, jsonify
from PyPDF2 import PdfReader
from langchain.text_splitter import RecursiveCharacterTextSplitter
from langchain_community.vectorstores import FAISS
from langchain_google_genai import GoogleGenerativeAIEmbeddings, ChatGoogleGenerativeAI
from langchain.chains.question_answering import load_qa_chain
from langchain.prompts import PromptTemplate
from dotenv import load_dotenv
import google.generativeai as genai
import json

load_dotenv()
os.getenv("langchain_google_genai")
os.environ['GOOGLE_API_KEY'] = 'AIzaSyAVFvEwx35owbCnkCpP5w2jbk6SXppFegs'
genai.configure(api_key="AIzaSyAVFvEwx35owbCnkCpP5w2jbk6SXppFegs")

app = Flask(__name__)
DATA_DIRECTORY = 'files'

k=True
def get_pdf_text(pdf_docs):
    text = ""
    for pdf in pdf_docs:
        pdf_reader = PdfReader(pdf)
        for page in pdf_reader.pages:
            text += page.extract_text()
    return text


def get_text_chunks(text):
    text_splitter = RecursiveCharacterTextSplitter(chunk_size=10000, chunk_overlap=1000)
    chunks = text_splitter.split_text(text)
    return chunks


def get_vector_store(text_chunks):
    embeddings = GoogleGenerativeAIEmbeddings(model="models/embedding-001")
    vector_store = FAISS.from_texts(text_chunks, embedding=embeddings)
    vector_store.save_local("faiss_index")


def get_conversational_chain():
    prompt_template = """
    Answer the question as detailed as possible from the provided context, make sure to provide all the details, if the answer is not in
    provided context just say, "answer is not available in the context", don't provide the wrong answer\n\n
    Context:\n {context}?\n
    Question: \n{question}\n

    Answer:
    """

    model = ChatGoogleGenerativeAI(model="gemini-pro", temperature=0.7)

    prompt = PromptTemplate(template=prompt_template, input_variables=["context", "question"])
    chain = load_qa_chain(model, chain_type="stuff", prompt=prompt)

    return chain


@app.route('/upload', methods=['POST'])
def upload_file():
    if 'file' not in request.files:
        return jsonify({'message': 'No file part in the request'}), 400

    file = request.files['file']
    if file.filename == '':
        return jsonify({'message': 'No selected file'}), 400

    if not os.path.exists(DATA_DIRECTORY):
        os.makedirs(DATA_DIRECTORY)

    file_path = os.path.join(DATA_DIRECTORY, file.filename)
    file.save(file_path)

    # Process the uploaded file
    pdf_docs = [file_path]
    raw_text = get_pdf_text(pdf_docs)
    text_chunks = get_text_chunks(raw_text)
    get_vector_store(text_chunks)

    return jsonify({'message': 'File uploaded and processed successfully'}), 200


@app.route('/delete', methods=['POST'])
def delete_files():
    if os.path.exists(DATA_DIRECTORY):
        for file in os.listdir(DATA_DIRECTORY):
            file_path = os.path.join(DATA_DIRECTORY, file)
            try:
                if os.path.isfile(file_path):
                    os.unlink(file_path)
            except Exception as e:
                return jsonify({'message': f'Error deleting files: {str(e)}'}), 500
    return jsonify({'message': 'All files deleted successfully'}), 200


@app.route('/qa', methods=['POST'])
def qa_endpoint():
    data = request.json
    user_question = data.get('question')

    embeddings = GoogleGenerativeAIEmbeddings(model="models/embedding-001")
    new_db = FAISS.load_local("faiss_index", embeddings)
    docs = new_db.similarity_search(user_question)

    chain = get_conversational_chain()
    response = chain({"input_documents": docs, "question": user_question}, return_only_outputs=True)

    # Convert response dictionary to JSON string with ensure_ascii=False to keep Unicode characters
    response_json = json.dumps(response, ensure_ascii=False)
    return response_json


def process_all_pdfs_in_directory(directory):
    try:
        pdf_files = [os.path.join(directory, f) for f in os.listdir(directory) if f.lower().endswith('.pdf')]
        if not pdf_files:
            return

        raw_text = get_pdf_text(pdf_files)
        text_chunks = get_text_chunks(raw_text)
        get_vector_store(text_chunks)
    except Exception as e:
        print(e)


if __name__ == '__main__':
    # Initialize by processing all PDFs in the data directory
    if not os.path.exists(DATA_DIRECTORY):
        os.makedirs(DATA_DIRECTORY)
    process_all_pdfs_in_directory(DATA_DIRECTORY)

    app.run(host='0.0.0.0', port=5000)