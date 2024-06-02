using BLL;
using Guna.Charts.WinForms;
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
    public partial class uc_ManageMainPage : UserControl
    {
        public uc_ManageMainPage()
        {
            InitializeComponent();
        }
        BLL_Statistics bll_ua = new BLL_Statistics();
        System.Data.DataTable AnalysisPercentageByAgeRange()
        {
            return bll_ua.AnalysisByRoLe();
        }
        System.Data.DataTable AnalysisPercentageBySex()
        {
            return bll_ua.AnalysisBySex();
        }
        void LoadAnalysisByAgeRangePercentage()
        {
            System.Data.DataTable analysisByAgeRange = AnalysisPercentageByAgeRange();

            pgb_Students.Value = Convert.ToInt32(analysisByAgeRange.Rows[4]["Percentage"]);
            lbl_Student.Text = analysisByAgeRange.Rows[4]["Percentage"].ToString() + "%";

            pgb_Trainee.Value = Convert.ToInt32(analysisByAgeRange.Rows[0]["Percentage"]);
            lbl_Trainee.Text = analysisByAgeRange.Rows[0]["Percentage"].ToString() + "%";

            pgb_Master.Value = Convert.ToInt32(analysisByAgeRange.Rows[1]["Percentage"]);
            lbl_Master.Text = analysisByAgeRange.Rows[1]["Percentage"].ToString() + "%";

            pgb_Doctoral.Value = Convert.ToInt32(analysisByAgeRange.Rows[2]["Percentage"]);
            lbl_Doctoral.Text = analysisByAgeRange.Rows[2]["Percentage"].ToString() + "%";

            pgb_AssProf.Value = Convert.ToInt32(analysisByAgeRange.Rows[3]["Percentage"]);
            lbl_Assoc_Prof.Text = analysisByAgeRange.Rows[3]["Percentage"].ToString() + "%";
        }
        void LoadAnalysisByAgeRangeAmount()
        {
            System.Data.DataTable analysisByAgeRange = AnalysisPercentageByAgeRange();

            lbl_Student.Text = analysisByAgeRange.Rows[4]["SoLuong"].ToString();
            lbl_Trainee.Text = analysisByAgeRange.Rows[0]["SoLuong"].ToString();
            lbl_Master.Text = analysisByAgeRange.Rows[1]["SoLuong"].ToString();
            lbl_Doctoral.Text = analysisByAgeRange.Rows[2]["SoLuong"].ToString();
            lbl_Assoc_Prof.Text = analysisByAgeRange.Rows[3]["SoLuong"].ToString();
        }



        //Sex
        void LoadAnalysisBySexPercentage()
        {
            System.Data.DataTable analysisBySex = AnalysisPercentageBySex();

            pgb_malePercentage.Value = Convert.ToInt32(analysisBySex.Rows[0]["Percentage"]);
            lbl_malePercentage.Text= analysisBySex.Rows[0]["Percentage"].ToString() + "%";

            pgb_femalePercentage.Value = Convert.ToInt32(analysisBySex.Rows[1]["Percentage"]);
            lbl_femalePercentage.Text = analysisBySex.Rows[1]["Percentage"].ToString() + "%";
        }

        void LoadAnalysisAboutGenderAmount()
        {
            System.Data.DataTable analysisByGender = AnalysisPercentageBySex();

            lbl_malePercentage.Text = analysisByGender.Rows[0]["SoLuong"].ToString();
            lbl_femalePercentage.Text = analysisByGender.Rows[1]["SoLuong"].ToString();

        }

        private void uc_ManageMainPage_Load(object sender, EventArgs e)
        {
            LoadAnalysisByAgeRangePercentage();
            LoadAnalysisBySexPercentage();
            LoadAnalyticsSubscriberIn7DaysAgo();
            LoadAnalysisByGeographical();
            LoadAnalyticsByTopics();
        }

        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsw_changeAnalysisType_CheckedChanged(object sender, EventArgs e)
        {
            if (tsw_changeAnalysisType.Checked == false)
            {
                LoadAnalysisByAgeRangePercentage();
                LoadAnalysisBySexPercentage();
            }
            else
            {
                LoadAnalysisAboutGenderAmount();
                LoadAnalysisByAgeRangeAmount();
            }
        }


        System.Data.DataTable PROC_TotalNewPhanCongIn7Daysy()
        {
            return bll_ua.PROC_TotalNewPhanCongIn7Days();
        }

        System.Data.DataTable PROC_TotalNewPhanCongIn13Days()
        {
            return bll_ua.PROC_TotalNewPhanCongIn13Days();
        }

        System.Data.DataTable PROC_TotalNewPhanCongIn21Days()
        {
            return bll_ua.PROC_TotalNewPhanCongIn21Days();
        }

        System.Data.DataTable PROC_TotalNewPhanCongIn28Days()
        {
            return bll_ua.PROC_TotalNewPhanCongIn28Days();
        }

        System.Data.DataTable PROC_TotalNewPhanCongIn30Days()
        {
            return bll_ua.PROC_TotalNewPhanCongIn30Days();
        }
        System.Data.DataTable PROC_TotalNewPhanCongIn90Days()
        {
            return bll_ua.PROC_TotalNewPhanCongIn90Days();
        }
        System.Data.DataTable PROC_TotalNewPhanCongIn180Days()
        {
            return bll_ua.PROC_TotalNewPhanCongIn180Days();
        }
        System.Data.DataTable PROC_TotalNewPhanCongIn365Days()
        {
            return bll_ua.PROC_TotalNewPhanCongIn365Days();
        }
        System.Data.DataTable PROC_TotalNewPhanCongInPeriod(string startdate,string enddate)
        {
            return bll_ua.PROC_TotalNewPhanCongInPeriod(startdate,enddate);
        }
        System.Data.DataTable AnalysisByTopics()
        {
            return bll_ua.AnalysisByTopics();
        }

        void LoadAnalyticsByTopics()
        {
            System.Data.DataTable chartData = AnalysisByTopics();
            //chart.YAxes.GridLines.Display = false;

            var dataset = new Guna.Charts.WinForms.GunaBarDataset();
            chtNumberTopicsFields.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            chtNumberTopicsFields.YAxes.Display = true;
            chtNumberTopicsFields.XAxes.Display = true;


            // Lặp qua từng dòng trong DataTable và thêm các điểm dữ liệu vào Dataset
            foreach (DataRow row in chartData.Rows)
            {
                string trangthai = row["TrangThai_e"].ToString();
                int count = (int)row["Counting"];
                dataset.DataPoints.Add(trangthai,count);
            }
            chtNumberTopicsFields.Datasets.Add(dataset);

            chtNumberTopicsFields.Update();
        }




        //Thống kê bar
        void LoadAnalyticsSubscriberIn7DaysAgo()
        {
            System.Data.DataTable chartData = PROC_TotalNewPhanCongIn7Daysy();

            var dataset = new Guna.Charts.WinForms.GunaSplineAreaDataset();
            dataset.PointRadius = 2;
            dataset.PointStyle = PointStyle.Circle;

            // Lặp qua từng dòng trong DataTable và thêm các điểm dữ liệu vào Dataset
            foreach (DataRow row in chartData.Rows)
            {
                DateTime date = (DateTime)row["RegistrationDate"];
                int count = (int)row["TotalRegistrations"];
                dataset.DataPoints.Add(date.ToString("dd-MM-yyyy"), count);
            }

            // Thêm Dataset vào chart
            cht_AnalyticsSubscriber.Datasets.Add(dataset);

            dataset.Label = "Number new assignment";
            dataset.FillColor = Color.FromArgb(117, 66, 137);
            dataset.BorderColor = Color.FromArgb(117, 66, 137);


            // Cập nhật chart để hiển thị dữ liệu mới
            cht_AnalyticsSubscriber.Update();

            lbl_Intervals.Text = "Last 7 days";
        }
        void LoadAnalyticsSubscriberIn13DaysAgo()
        {
            System.Data.DataTable chartData = PROC_TotalNewPhanCongIn13Days();

            var dataset = new Guna.Charts.WinForms.GunaSplineAreaDataset();
            dataset.PointRadius = 2;
            dataset.PointStyle = PointStyle.Circle;

            // Lặp qua từng dòng trong DataTable và thêm các điểm dữ liệu vào Dataset
            foreach (DataRow row in chartData.Rows)
            {
                DateTime date = (DateTime)row["RegistrationDate"];
                int count = (int)row["TotalRegistrations"];
                dataset.DataPoints.Add(date.ToString("dd-MM-yyyy"), count);
            }

            // Thêm Dataset vào chart
            cht_AnalyticsSubscriber.Datasets.Add(dataset);

            dataset.Label = "Number new assignment";
            dataset.FillColor = Color.FromArgb(117, 66, 137);
            dataset.BorderColor = Color.FromArgb(117, 66, 137);


            // Cập nhật chart để hiển thị dữ liệu mới
            cht_AnalyticsSubscriber.Update();

            lbl_Intervals.Text = "Last 13 days";
        }
        void LoadAnalyticsSubscriberIn21DaysAgo()
        {
            System.Data.DataTable chartData = PROC_TotalNewPhanCongIn21Days();

            var dataset = new Guna.Charts.WinForms.GunaSplineAreaDataset();
            dataset.PointRadius = 2;
            dataset.PointStyle = PointStyle.Circle;

            // Lặp qua từng dòng trong DataTable và thêm các điểm dữ liệu vào Dataset
            foreach (DataRow row in chartData.Rows)
            {
                DateTime date = (DateTime)row["RegistrationDate"];
                int count = (int)row["TotalRegistrations"];
                dataset.DataPoints.Add(date.ToString("dd-MM-yyyy"), count);
            }

            // Thêm Dataset vào chart
            cht_AnalyticsSubscriber.Datasets.Add(dataset);

            dataset.Label = "Number new assignment";
            dataset.FillColor = Color.FromArgb(117, 66, 137);
            dataset.BorderColor = Color.FromArgb(117, 66, 137);


            // Cập nhật chart để hiển thị dữ liệu mới
            cht_AnalyticsSubscriber.Update();

            lbl_Intervals.Text = "Last 21 days";
        }
        void LoadAnalyticsSubscriberIn28DaysAgo()
        {
            System.Data.DataTable chartData = PROC_TotalNewPhanCongIn28Days();

            var dataset = new Guna.Charts.WinForms.GunaSplineAreaDataset();
            dataset.PointRadius = 2;
            dataset.PointStyle = PointStyle.Circle;

            // Lặp qua từng dòng trong DataTable và thêm các điểm dữ liệu vào Dataset
            foreach (DataRow row in chartData.Rows)
            {
                DateTime date = (DateTime)row["RegistrationDate"];
                int count = (int)row["TotalRegistrations"];
                dataset.DataPoints.Add(date.ToString("dd-MM-yyyy"), count);
            }

            // Thêm Dataset vào chart
            cht_AnalyticsSubscriber.Datasets.Add(dataset);

            dataset.Label = "Number new assignment";
            dataset.FillColor = Color.FromArgb(117, 66, 137);
            dataset.BorderColor = Color.FromArgb(117, 66, 137);


            // Cập nhật chart để hiển thị dữ liệu mới
            cht_AnalyticsSubscriber.Update();

            lbl_Intervals.Text = "Last 28 days";
        }
        void LoadAnalyticsSubscriberIn30DaysAgo()
        {
            System.Data.DataTable chartData = PROC_TotalNewPhanCongIn30Days();

            var dataset = new Guna.Charts.WinForms.GunaSplineAreaDataset();
            dataset.PointRadius = 2;
            dataset.PointStyle = PointStyle.Circle;

            // Lặp qua từng dòng trong DataTable và thêm các điểm dữ liệu vào Dataset
            foreach (DataRow row in chartData.Rows)
            {
                DateTime date = (DateTime)row["RegistrationDate"];
                int count = (int)row["TotalRegistrations"];
                dataset.DataPoints.Add(date.ToString("dd-MM-yyyy"), count);
            }

            // Thêm Dataset vào chart
            cht_AnalyticsSubscriber.Datasets.Add(dataset);

            dataset.Label = "Number new assignment";
            dataset.FillColor = Color.FromArgb(117, 66, 137);
            dataset.BorderColor = Color.FromArgb(117, 66, 137);


            // Cập nhật chart để hiển thị dữ liệu mới
            cht_AnalyticsSubscriber.Update();

            lbl_Intervals.Text = "Last 30 days";
        }
        void LoadAnalyticsSubscriberIn90DaysAgo()
        {
            System.Data.DataTable chartData = PROC_TotalNewPhanCongIn90Days();

            var dataset = new Guna.Charts.WinForms.GunaSplineAreaDataset();
            dataset.PointRadius = 2;
            dataset.PointStyle = PointStyle.Circle;

            // Lặp qua từng dòng trong DataTable và thêm các điểm dữ liệu vào Dataset
            foreach (DataRow row in chartData.Rows)
            {
                DateTime date = (DateTime)row["RegistrationDate"];
                int count = (int)row["TotalRegistrations"];
                dataset.DataPoints.Add(date.ToString("dd-MM-yyyy"), count);
            }

            // Thêm Dataset vào chart
            cht_AnalyticsSubscriber.Datasets.Add(dataset);

            dataset.Label = "Number new assignment";
            dataset.FillColor = Color.FromArgb(117, 66, 137);
            dataset.BorderColor = Color.FromArgb(117, 66, 137);


            // Cập nhật chart để hiển thị dữ liệu mới
            cht_AnalyticsSubscriber.Update();

            lbl_Intervals.Text = "Last 90 days";
        }
        void LoadAnalyticsSubscriberIn180DaysAgo()
        {
            System.Data.DataTable chartData = PROC_TotalNewPhanCongIn180Days();

            var dataset = new Guna.Charts.WinForms.GunaSplineAreaDataset();
            dataset.PointRadius = 2;
            dataset.PointStyle = PointStyle.Circle;

            // Lặp qua từng dòng trong DataTable và thêm các điểm dữ liệu vào Dataset
            foreach (DataRow row in chartData.Rows)
            {
                DateTime date = (DateTime)row["RegistrationDate"];
                int count = (int)row["TotalRegistrations"];
                dataset.DataPoints.Add(date.ToString("dd-MM-yyyy"), count);
            }

            // Thêm Dataset vào chart
            cht_AnalyticsSubscriber.Datasets.Add(dataset);

            dataset.Label = "Number new assignment";
            dataset.FillColor = Color.FromArgb(117, 66, 137);
            dataset.BorderColor = Color.FromArgb(117, 66, 137);


            // Cập nhật chart để hiển thị dữ liệu mới
            cht_AnalyticsSubscriber.Update();

            lbl_Intervals.Text = "Last 180 days";
        }
        void LoadAnalyticsSubscriberIn365DaysAgo()
        {
            System.Data.DataTable chartData = PROC_TotalNewPhanCongIn365Days();

            var dataset = new Guna.Charts.WinForms.GunaSplineAreaDataset();
            dataset.PointRadius = 2;
            dataset.PointStyle = PointStyle.Circle;

            // Lặp qua từng dòng trong DataTable và thêm các điểm dữ liệu vào Dataset
            foreach (DataRow row in chartData.Rows)
            {
                DateTime date = (DateTime)row["RegistrationDate"];
                int count = (int)row["TotalRegistrations"];
                dataset.DataPoints.Add(date.ToString("dd-MM-yyyy"), count);
            }

            // Thêm Dataset vào chart
            cht_AnalyticsSubscriber.Datasets.Add(dataset);

            dataset.Label = "Number new assignment";
            dataset.FillColor = Color.FromArgb(117, 66, 137);
            dataset.BorderColor = Color.FromArgb(117, 66, 137);


            // Cập nhật chart để hiển thị dữ liệu mới
            cht_AnalyticsSubscriber.Update();

            lbl_Intervals.Text = "Last 365 days";
        }
        void LoadAnalyticsSubscriberInAnyDaysAgo()
        {
            DateTime startdate = dtpStartDate.Value;
            string start = startdate.ToString("yyyy-MM-dd");

            DateTime enddate = dtpEnddate.Value;
            string end = enddate.ToString("yyyy-MM-dd");

            System.Data.DataTable chartData = PROC_TotalNewPhanCongInPeriod(start,end);

            var dataset = new Guna.Charts.WinForms.GunaSplineAreaDataset();
            dataset.PointRadius = 2;
            dataset.PointStyle = PointStyle.Circle;

            // Lặp qua từng dòng trong DataTable và thêm các điểm dữ liệu vào Dataset
            foreach (DataRow row in chartData.Rows)
            {
                DateTime date = (DateTime)row["RegistrationDate"];
                int count = (int)row["TotalRegistrations"];
                dataset.DataPoints.Add(date.ToString("dd-MM-yyyy"), count);
            }

            // Thêm Dataset vào chart
            cht_AnalyticsSubscriber.Datasets.Add(dataset);

            dataset.Label = "Number new assignment";
            dataset.FillColor = Color.FromArgb(117, 66, 137);
            dataset.BorderColor = Color.FromArgb(117, 66, 137);


            // Cập nhật chart để hiển thị dữ liệu mới
            cht_AnalyticsSubscriber.Update();

            lbl_Intervals.Text = "";
        }

        private void btn_AnalyticOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cht_AnalyticsSubscriber.Datasets.Clear();

                if (btn_AnalyticOptions.SelectedIndex == 0)
                {
                    LoadAnalyticsSubscriberIn7DaysAgo();
                }
                if (btn_AnalyticOptions.SelectedIndex == 1)
                {
                    LoadAnalyticsSubscriberIn13DaysAgo();
                }
                if (btn_AnalyticOptions.SelectedIndex == 2)
                {
                    LoadAnalyticsSubscriberIn21DaysAgo();
                }
                if (btn_AnalyticOptions.SelectedIndex == 3)
                {
                    LoadAnalyticsSubscriberIn28DaysAgo();
                }
                if (btn_AnalyticOptions.SelectedIndex == 4)
                {
                    LoadAnalyticsSubscriberIn30DaysAgo();
                }
                if (btn_AnalyticOptions.SelectedIndex == 5)
                {
                    LoadAnalyticsSubscriberIn90DaysAgo();
                }
                if (btn_AnalyticOptions.SelectedIndex == 6)
                {
                    LoadAnalyticsSubscriberIn90DaysAgo();
                }
                if (btn_AnalyticOptions.SelectedIndex == 7)
                {
                    LoadAnalyticsSubscriberIn90DaysAgo();
                }
            }
            catch
            {}
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            cht_AnalyticsSubscriber.Datasets.Clear();
            LoadAnalyticsSubscriberInAnyDaysAgo();
        }

        System.Data.DataTable AnalysisByGeographical()
        {
            return bll_ua.PROC_getGeographical();
        }
        void LoadAnalysisByGeographical()
        {
            System.Data.DataTable analysisByGeographical = AnalysisByGeographical();

            cht_AnaysisByGeoGraphical.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            cht_AnaysisByGeoGraphical.XAxes.Display = false;
            cht_AnaysisByGeoGraphical.YAxes.Display = false;

            var dataset = new Guna.Charts.WinForms.GunaDoughnutDataset();

            foreach (DataRow row in analysisByGeographical.Rows)
            {
                string province = row["Provinces"].ToString();
                int userCount = Convert.ToInt32(row["UserCount"]);
                float percentage = Convert.ToSingle(row["Percentage"]);

                dataset.DataPoints.Add(province, userCount);
            }

            cht_AnaysisByGeoGraphical.Datasets.Add(dataset);

            cht_AnaysisByGeoGraphical.Update();
        }

        private void cht_AnaysisByGeoGraphical_Load(object sender, EventArgs e)
        {

        }
    }
}
