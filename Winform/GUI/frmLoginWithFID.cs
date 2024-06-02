using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BLL;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace GUI
{
    public partial class frmLoginWithFID : Form
    {
        private VideoCapture videoCapture;
        private Timer captureTimer;
        private int captureCount = 0;
        private const int MaxCaptures = 30; // Changed to 30 images
        private string saveFolder = "FolderSaved"; // Change to your desired folder
        private CascadeClassifier faceCascade;

        BLL.BLL_Account_Auth bllAccountAuth = new BLL.BLL_Account_Auth();
        public frmLoginWithFID()
        {
            InitializeComponent();
            // Load the Haar cascade file for face detection
            faceCascade = new CascadeClassifier("haarcascade_frontalface_default.xml");
            btn_login.Enabled = false;
        }

        private void frmLoginWithFID_Load(object sender, EventArgs e)
        {
            ClearSaveFolder();
            if (videoCapture == null)
            {
                videoCapture = new VideoCapture(0);
                videoCapture.ImageGrabbed += VideoCapture_ImageGrabbed;
                videoCapture.Start();
            }

            captureTimer = new Timer();
            captureTimer.Interval = 200; // 0.2 seconds
            captureTimer.Tick += CaptureTimer_Tick;
            captureTimer.Start();
        }

        private void ClearSaveFolder()
        {
            if (Directory.Exists(saveFolder))
            {
                var files = Directory.GetFiles(saveFolder);
                foreach (var file in files)
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Không thể xóa tệp {file}: {ex.Message}");
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(saveFolder);
            }
        }

        private void CaptureTimer_Tick(object sender, EventArgs e)
        {
            if (captureCount < MaxCaptures)
            {
                CaptureAndSaveImage();
            }
            else
            {
                captureTimer.Stop();
                btn_login.Enabled = true; // Enable login button after capturing all images
            }
        }

        private void VideoCapture_ImageGrabbed(object sender, EventArgs e)
        {
            // Retrieve the frame
            Mat frame = new Mat();
            videoCapture.Retrieve(frame);

            // Check if the frame is empty
            if (!frame.IsEmpty)
            {
                using (var image = frame.ToImage<Bgr, byte>())
                {
                    // Create a new image to hold the flipped image
                    var flippedImage = image.Flip(FlipType.Horizontal);
                    DisplayImage(flippedImage.ToBitmap());
                }
            }
            else
            {
                Console.WriteLine("Retrieved frame is empty.");
            }
        }

        private void DisplayImage(Bitmap image)
        {
            if (pbx_preview.InvokeRequired)
            {
                pbx_preview.Invoke(new Action<Bitmap>(DisplayImage), image);
            }
            else
            {
                pbx_preview.Image = image;
            }
        }

        private void CaptureAndSaveImage()
        {
            // Retrieve the frame
            Mat frame = new Mat();
            videoCapture.Retrieve(frame);

            // Check if the frame is empty
            if (!frame.IsEmpty)
            {
                using (var image = frame.ToImage<Bgr, byte>())
                {
                    // Create a new image to hold the flipped image
                    var flippedImage = image.Flip(FlipType.Horizontal);

                    // Detect faces in the image
                    var grayImage = flippedImage.Convert<Gray, byte>();
                    var faces = faceCascade.DetectMultiScale(grayImage, 1.1, 10, Size.Empty, Size.Empty);

                    foreach (var face in faces)
                    {
                        // Crop the face region from the image
                        var faceImage = flippedImage.Copy(face).Resize(100, 100, Inter.Cubic);

                        // Save the cropped face image to the specified folder
                        string filePath = Path.Combine(saveFolder, $"ImageInput_{captureCount + 1}.jpg");
                        faceImage.Save(filePath);
                        captureCount++; // Increment capture count here to ensure it's updated
                        if (captureCount >= MaxCaptures)
                        {
                            btn_login.Enabled = true; // Enable the login button
                            captureTimer.Stop(); // Stop the timer
                            return; // Exit the function
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Captured frame is empty.");
            }
        }

        private void getTrueImageFromSQL()
        {
            string maGiaoVien = txt_userFullName.Text.TrimEnd(); // Mã giáo viên cần tìm
            string status = cbx_UL_ClassificationUser.Text;
            if (status == "Student") status = "3";
            if (status == "Management") status = "1";
            if (status == "Teacher") status = "2";
            int statusInt = int.Parse(status);
            string folderPath = saveFolder;

            // Truy vấn thông tin từ BLL
            DataTable dt = bllAccountAuth.getInforAboutImages(maGiaoVien, statusInt); // 1 có thể là status cần thiết, thay đổi nếu cần

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                byte[][] images = new byte[10][];
                for (int i = 0; i < 10; i++)
                {
                    images[i] = (byte[])row[$"Images{i + 1}"];
                }
                for (int i = 0; i < 10; i++)
                {
                    string filePath = Path.Combine(folderPath, $"TrueImage_{i + 1}.jpg");
                    File.WriteAllBytes(filePath, images[i]);

                    // Process the saved image to detect and crop the face
                    using (var img = new Image<Bgr, byte>(filePath))
                    {
                        var grayImg = img.Convert<Gray, byte>();
                        var faces = faceCascade.DetectMultiScale(grayImg, 1.1, 10, Size.Empty, Size.Empty);

                        foreach (var face in faces)
                        {
                            var faceImg = img.Copy(face).Resize(100, 100, Inter.Cubic);
                            string faceFilePath = Path.Combine(folderPath, $"TrueImage_{i + 1}.jpg");
                            faceImg.Save(faceFilePath);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("User not exist in database! Please rewrite ID");
            }
        }

        private double CompareFaces(Image<Gray, byte> img1, Image<Gray, byte> img2)
        {
            var result = new Image<Gray, byte>(img1.Size);
            CvInvoke.MatchTemplate(img1, img2, result, TemplateMatchingType.CcoeffNormed);
            double[] minValues, maxValues;
            Point[] minLocations, maxLocations;
            result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
            return maxValues[0];
        }

        private double CompareImagesInFolder()
        {
            var imageInputFiles = Directory.GetFiles(saveFolder, "ImageInput_*.jpg");
            var trueImageFiles = Directory.GetFiles(saveFolder, "TrueImage_*.jpg");

            double totalSimilarity = 0;
            int comparisonCount = 0;

            foreach (var inputFile in imageInputFiles)
            {
                using (var imgInput = new Image<Bgr, byte>(inputFile).Convert<Gray, byte>())
                {
                    var facesInput = faceCascade.DetectMultiScale(imgInput, 1.1, 10, Size.Empty, Size.Empty);
                    if (facesInput.Length > 0)
                    {
                        var faceInput = imgInput.Copy(facesInput[0]).Resize(100, 100, Inter.Cubic);

                        foreach (var trueFile in trueImageFiles)
                        {
                            using (var imgTrue = new Image<Bgr, byte>(trueFile).Convert<Gray, byte>())
                            {
                                var facesTrue = faceCascade.DetectMultiScale(imgTrue, 1.1, 10, Size.Empty, Size.Empty);
                                if (facesTrue.Length > 0)
                                {
                                    var faceTrue = imgTrue.Copy(facesTrue[0]).Resize(100, 100, Inter.Cubic);
                                    double similarity = CompareFaces(faceInput, faceTrue);
                                    totalSimilarity += similarity;
                                    comparisonCount++;
                                    Console.WriteLine($"Similarity between {Path.GetFileName(inputFile)} and {Path.GetFileName(trueFile)}: {similarity * 100:F2}%");
                                }
                            }
                        }
                    }
                }
            }

            if (comparisonCount > 0)
            {
                double averageSimilarity = totalSimilarity / comparisonCount;
                Console.WriteLine($"Average similarity: {averageSimilarity * 100:F2}%");
                double avg_simi = double.Parse((averageSimilarity * 100).ToString());
                return Math.Round(avg_simi, 2);
            }
            else
            {
                Console.WriteLine("No faces found to compare.");
                return 0;
            }
        }

        private void frmLoginWithFID_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCapture != null)
            {
                videoCapture.Stop();
                videoCapture.Dispose();
            }
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e) { }

        private void btnStop_Click(object sender, EventArgs e) { }

        public List<object[]> getAllInf(string manguoidung, int status)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = bllAccountAuth.getInforAboutImages(manguoidung, status);
            foreach (DataRow row in topicData.Rows)
            {
                string tendangnhap = row[0].ToString();
                string matkhau = row[1].ToString();
                dataList.Add(new object[] { tendangnhap, matkhau });
            }
            return dataList;
        }

        private void getData(string manguoidung, int status)
        {
            List<object[]> dataList = getAllInf(manguoidung, status);
            if (status == 3)
            {
                foreach (object[] row in dataList)
                {
                    string username = row[0].ToString();
                    string password = row[1].ToString();

                    using (var diagform = new frm_Student_Main())
                    {
                        diagform.vaitroLogin = "sinhvien";
                        diagform.idLogin = username;
                        diagform.ShowDialog();
                    }

                }
            }
            if (status == 1)
            {
                new frm_Management_Main().ShowDialog();
            }
            if (status == 2)
            {
                foreach (object[] row in dataList)
                {
                    string username = row[0].ToString();
                    string password = row[1].ToString();
                    this.Hide();
                    using (var diagform = new frm_Student_Main())
                    {
                        diagform.vaitroLogin = username;
                        diagform.idLogin = username;
                        diagform.ShowDialog();
                    }
                }
            }
        }

        private bool checking()
        {
            if (txt_userFullName.Text == "")
            {
                MessageBox.Show("Please enter your ID");
                return false;
            }
            if (cbx_UL_ClassificationUser.Text == "")
            {
                MessageBox.Show("Please choose your role");
                return false;
            }
            return true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (checking())
            {
                getTrueImageFromSQL();
                double score = CompareImagesInFolder();
                Console.WriteLine(score);

                if (score >= 5)
                {
                    string status = cbx_UL_ClassificationUser.Text;
                    if (status == "Student") status = "3";
                    if (status == "Management") status = "1";
                    if (status == "Teacher") status = "2";
                    int statusInt = int.Parse(status);
                    getData(txt_userFullName.Text, statusInt);
                }
                else
                {
                    MessageBox.Show("Login failed! Face similarity is too low.");
                }
            }
            else
            {
                MessageBox.Show("Login failed! Please check your input.");
            }
        }

        private void pbx_preview_Click(object sender, EventArgs e) { }

        private void cbx_UL_ClassificationUser_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btn_regularLogin_Click(object sender, EventArgs e)
        {
            var frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            if (captureTimer != null && captureTimer.Enabled)
            {
                captureTimer.Stop();
            }

            // Reset the capture count
            captureCount = 0;

            // Clear existing images in the save folder
            ClearSaveFolder();

            // Restart the capture timer
            if (captureTimer != null)
            {
                captureTimer.Start();
            }

            // Re-enable the login button if it was disabled
            btn_login.Enabled = false;
        }
    }
}
