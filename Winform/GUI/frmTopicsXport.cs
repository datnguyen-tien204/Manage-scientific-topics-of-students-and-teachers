using BLL;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
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
    public partial class frmTopicsXport : Form
    {
        public frmTopicsXport()
        {
            InitializeComponent();
        }
        public int statusid { get; set; }

        public DataSet dataSet_get { get; set; }
        BLL_expToFile bLL_ExpToFile = new BLL_expToFile();
        private void frmTopicsXport_Load(object sender, EventArgs e)
        {
            if (statusid == 0)
            {
                DataSet ds = bLL_ExpToFile.getInformationFromTopicsXport();
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("topicList", ds.Tables[0]);
                this.rptTopics.LocalReport.DataSources.Clear();
                this.rptTopics.LocalReport.DataSources.Add(rds);
                this.rptTopics.RefreshReport();
            }
            if (statusid == 1)
            {
                DataSet ds = bLL_ExpToFile.getInforTopicWithStatus(1);
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("topicList", ds.Tables[0]);
                this.rptTopics.LocalReport.DataSources.Clear();
                this.rptTopics.LocalReport.DataSources.Add(rds);
                this.rptTopics.RefreshReport();
            }
            if (statusid == 2)
            {
                DataSet ds = bLL_ExpToFile.getInforTopicWithStatus(2);
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("topicList", ds.Tables[0]);
                this.rptTopics.LocalReport.DataSources.Clear();
                this.rptTopics.LocalReport.DataSources.Add(rds);
                this.rptTopics.RefreshReport();
            }
            if (statusid == 3)
            {
                DataSet ds = bLL_ExpToFile.getInforTopicWithStatus(3);
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("topicList", ds.Tables[0]);
                this.rptTopics.LocalReport.DataSources.Clear();
                this.rptTopics.LocalReport.DataSources.Add(rds);
                this.rptTopics.RefreshReport();
            }
            if (statusid == 4)
            {
                DataSet ds = bLL_ExpToFile.getInforTopicWithStatus(4);
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("topicList", ds.Tables[0]);
                this.rptTopics.LocalReport.DataSources.Clear();
                this.rptTopics.LocalReport.DataSources.Add(rds);
                this.rptTopics.RefreshReport();
            }
            if (statusid == 5)
            {
                DataSet ds = bLL_ExpToFile.getInforTopicWithStatus(5);
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("topicList", ds.Tables[0]);
                this.rptTopics.LocalReport.DataSources.Clear();
                this.rptTopics.LocalReport.DataSources.Add(rds);
                this.rptTopics.RefreshReport();
            }
        }
    }
}
