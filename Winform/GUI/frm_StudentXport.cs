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

namespace GUI
{
    public partial class frm_StudentXport : Form
    {
        public frm_StudentXport()
        {
            InitializeComponent();
        }
        public DataSet dataSet_get { get; set; }
        public int statusid { get; set; }
        BLL_expToFile bLL_ExpToFile = new BLL_expToFile();
        private void frm_StudentXport_Load(object sender, EventArgs e)
        {
            //DataSet ds = bLL_ExpToFile.PROC_getInforSV();
            
            DataSet ds = dataSet_get;
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("studentList", ds.Tables[0]);
            this.rptSinhVien.LocalReport.DataSources.Clear();
            this.rptSinhVien.LocalReport.DataSources.Add(rds);
            this.rptSinhVien.RefreshReport();
        }
    }
}
