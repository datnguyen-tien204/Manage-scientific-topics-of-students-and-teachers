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
    public partial class phanCongXport : Form
    {
        public phanCongXport()
        {
            InitializeComponent();
        }
        public DataSet dataSet_get { get; set; }
        private void phanCongXport_Load(object sender, EventArgs e)
        {

            DataSet ds = dataSet_get;
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("phancongList", ds.Tables[0]);
            this.rptPhanCong.LocalReport.DataSources.Clear();
            this.rptPhanCong.LocalReport.DataSources.Add(rds);

            this.rptPhanCong.RefreshReport();
        }
    }
}
