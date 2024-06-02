FROM python:3.9.18-slim
LABEL authors="nguye"
WORKDIR /app
COPY requirements.txt .
RUN pip install -r requirements.txt
COPY . .
ENV FLASK_APP=main.py
ENV FLASK_RUN_HOST=0.0.0.0

# Mở cổng 5000
EXPOSE 5000

# Chạy ứng dụng Flask
CMD ["flask", "run"]