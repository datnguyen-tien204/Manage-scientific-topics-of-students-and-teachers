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
    public partial class frmCouncilsXport : Form
    {
        public frmCouncilsXport()
        {
            InitializeComponent();
        }
        public DataSet dataSet_get { get; set; }

        private void frmCouncilsXport_Load(object sender, EventArgs e)
        {
            DataSet ds = dataSet_get;
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("councilList", ds.Tables[0]);
            this.rptCouncils.LocalReport.DataSources.Clear();
            this.rptCouncils.LocalReport.DataSources.Add(rds);
            this.rptCouncils.RefreshReport();
            this.rptCouncils.RefreshReport();
            this.rptCouncils.RefreshReport();
            this.rptCouncils.RefreshReport();
        }
    }
}
