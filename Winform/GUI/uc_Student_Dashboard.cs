using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class uc_Student_Dashboard : UserControl
    {
        public uc_Student_Dashboard()
        {
            InitializeComponent();
        }
        public string vaitro { get; set; }
        public string idNguoiDung { get; set; }
        BLL.BLL_Statistics bll_ua = new BLL.BLL_Statistics();

        System.Data.DataTable AnalysisByTopics(string mathanhvien,int status)
        {
            return bll_ua.PROC_countTopicsbyBatch(mathanhvien,status);
        }

        void LoadAnalysisByGeographical(string mathanhvien,int status)
        {
            System.Data.DataTable analysisByGeographical = AnalysisByTopics(mathanhvien, status);

            chtThongKe.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            chtThongKe.XAxes.Display = false;
            chtThongKe.YAxes.Display = false;
            var dataset = new Guna.Charts.WinForms.GunaDoughnutDataset();

            foreach (DataRow row in analysisByGeographical.Rows)
            {
                string province = row["MaDot"].ToString();
                int userCount = Convert.ToInt32(row["TotalDeTai"]);

                dataset.DataPoints.Add(province, userCount);
            }

            chtThongKe.Datasets.Add(dataset);

            chtThongKe.Update();
        }

        private void uc_Student_Dashboard_Load(object sender, EventArgs e)
        {
            if(vaitro == "sinhvien")
            {
                LoadAnalysisByGeographical(idNguoiDung, 0);
            }
            else
            {
                LoadAnalysisByGeographical(idNguoiDung, 1);
            }
        }
        
        private void OpenDialogForm(string idNguoiDung_,string vaitro_)
        {
            using (var dialogForm = new frm_CheckStatusProject())
            {
                dialogForm.idNguoiDung = idNguoiDung_;
                dialogForm.vaitro = vaitro_;
                dialogForm.ShowDialog();
            }
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            OpenDialogForm(idNguoiDung, vaitro);
        }
    }
}
