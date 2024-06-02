using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Net.Http;


namespace GUI
{
    public partial class frmViewTaiLieu : Form
    {
        public frmViewTaiLieu()
        {
            InitializeComponent();
        }
        public int matailieu { get; set; }
        BLL_Search bllSearch = new BLL_Search();
    

        private List<object[]> addUserToDataList(int matailieu_input)
        {
            DataTable teacherData = new DataTable();
            List<object[]> dataList = new List<object[]>();
            teacherData = bllSearch.PROC_getLinkTaiLieu(matailieu_input);
            foreach (DataRow row in teacherData.Rows)
            {
                string link = row[0].ToString().TrimEnd();
                string MLA = row[1].ToString().TrimEnd();
                string APA = row[2].ToString().TrimEnd();
                string BibText = row[3].ToString().TrimEnd();
                dataList.Add(new object[] { link, MLA, APA, BibText });
            }
            return dataList;
        }
        //Xử lí link lấy ID của link
        private string ExtractArxivId(string url)
        {
            try
            {
                string pattern = @"arxiv\.org/abs/(\d+\.\d+)";
                Match match = Regex.Match(url, pattern);
                if (match.Success)
                {
                    return match.Groups[1].Value;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        //Tải file từ link
        private async Task DownloadPdfAsync(string pdfUrl, string outputPath)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(pdfUrl);
                    response.EnsureSuccessStatusCode();
                    byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();
                    File.WriteAllBytes(outputPath, fileBytes);

                    Console.WriteLine($"File PDF đã được tải thành công và lưu tại: {outputPath}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Có lỗi xảy ra: {ex.Message}");
                }
            }
        }
        private string download(string orginalLink)
        {
            string id= ExtractArxivId(orginalLink);
            string relink = $"https://arxiv.org/pdf/{id}";
            return relink;
        }



        private void frmViewTaiLieu_Load(object sender, EventArgs e)
        {
            string testFilePath = "test.pdf";
            if (File.Exists(testFilePath))
            {
                try
                {
                    File.Delete(testFilePath);
                    Console.WriteLine("File test.pdf đã được xóa.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Có lỗi xảy ra khi xóa file: {ex.Message}");
                }
            }

            // Lấy link gốc từ cơ sở dữ liệu
            string orginalLink = bllSearch.PROC_getLinkTaiLieu(matailieu).Rows[0][0].ToString();
            string link = download(orginalLink);
            Task.Run(async () =>
            {
                await DownloadPdfAsync(link, testFilePath);
                this.Invoke((Action)(() =>
                {
                    this.pdfViewer1.LoadFromFile(testFilePath);
                }));
            });
        }

        private void btnAPA_Click(object sender, EventArgs e)
        {
            string textToCopy = bllSearch.PROC_getLinkTaiLieu(matailieu).Rows[0][2].ToString();
            Clipboard.SetText(textToCopy);
            MessageBox.Show("Copied APA to clipboard");
            
        }

        private void btnMLA_Click(object sender, EventArgs e)
        {
            string textToCopy = bllSearch.PROC_getLinkTaiLieu(matailieu).Rows[0][1].ToString();
            Clipboard.SetText(textToCopy);
            MessageBox.Show("Copied MLA to clipboard");
        }

        private void btnBibText_Click(object sender, EventArgs e)
        {
            string textToCopy = bllSearch.PROC_getLinkTaiLieu(matailieu).Rows[0][3].ToString();
            Clipboard.SetText(textToCopy);
            MessageBox.Show("Copied BibTeX to clipboard");
        }
    }
}
