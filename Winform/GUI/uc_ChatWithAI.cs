using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net.Http;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace GUI
{
    public partial class uc_ChatWithAI : UserControl
    {
        public uc_ChatWithAI()
        {
            InitializeComponent();
            selectedFilePaths = new List<string>();
            client = new HttpClient();
        }

        //Thiết lập API send file
        private readonly HttpClient client;
        private readonly string serverUrl = "http://127.17.0.1:5000";
        public async Task<string> SendDataToPython(string data)
        {
            try
            {
                // Sử dụng JsonConvert.SerializeObject để mã hóa chuỗi JSON
                string jsonData = JsonConvert.SerializeObject(new { question = data });
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                Console.WriteLine(content);

                HttpResponseMessage response = await client.PostAsync($"{serverUrl}/qa", content);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException httpRequestException)
            {
                Console.WriteLine($"HTTP Request Error: {httpRequestException.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Có lỗi xảy ra: {ex.Message}");
                return null;
            }
        }

        public async Task<string> UploadFileToPython(string filePath)
        {
            try
            {
                var form = new MultipartFormDataContent();
                var fileContent = new ByteArrayContent(System.IO.File.ReadAllBytes(filePath)); // Sử dụng ReadAllBytes thay vì ReadAllBytesAsync
                fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/pdf");
                form.Add(fileContent, "file", System.IO.Path.GetFileName(filePath));

                HttpResponseMessage response = await client.PostAsync($"{serverUrl}/upload", form);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Occured: {ex.Message}");
                return null;
            }
        }

        public async Task<string> DeleteFilesOnPython()
        {
            try
            {
                HttpResponseMessage response = await client.PostAsync($"{serverUrl}/delete", null);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Có lỗi xảy ra: {ex.Message}");
                return null;
            }
        }



        //Chọn file
        private List<string> selectedFilePaths;
        private async void btnChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] filePaths = openFileDialog.FileNames;
                    Console.WriteLine("Selected file: " + string.Join(", ", filePaths));
                    string[] fileNames = Array.ConvertAll(filePaths, Path.GetFileName);
                    lblSelectedFile.Text = string.Join(", ", fileNames);
                    selectedFilePaths.AddRange(filePaths);
                }
            }

            await DeleteFilesOnPython();
            foreach (string filePath in selectedFilePaths)
            {
                this.pdfViewer1.Refresh();
                this.pdfViewer1.LoadFromFile(filePath);
                int newWidth = (int)(this.pdfViewer1.Width * 0.9);
                int newHeight = (int)(this.pdfViewer1.Height * 0.9);
                this.pdfViewer1.ClientSize = new Size(newWidth, newHeight);

                Console.WriteLine("Selected file: " + filePath);
                await UploadFileToPython(filePath); 

            }
        }


        private void uc_ChatWithAI_Load(object sender, EventArgs e)
        {

        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (lblSelectedFile.Text == "")
            {
                MessageBox.Show("Please choose file before use!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (lblSelectedFile.Text != "" && txtQuestion.Text != "")
            {
                string question = txtQuestion.Text.TrimEnd();
                if (question == "")
                {
                    MessageBox.Show("Please input question before!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        string response = await SendDataToPython(question);
                        string jsonString = response;
                        JObject jsonObject = JObject.Parse(jsonString);
                        string outputText = (string)jsonObject["output_text"];
                        lblAns.Text = outputText;
                    }
                    catch (Exception ex) { }
                }

            }
        }

        private void lblSelectedFile_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblAns.Text = "";
            txtQuestion.Text = "";
        }
    }
}
