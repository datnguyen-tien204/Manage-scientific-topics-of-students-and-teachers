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
    public partial class frmBatchXport : Form
    {
        public frmBatchXport()
        {
            InitializeComponent();
        }
        public DataSet dataSet_get { get; set; }
        private void frmBatchXport_Load(object sender, EventArgs e)
        {
            DataSet ds = dataSet_get;
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("batchList", ds.Tables[0]);
            this.rptBatch.LocalReport.DataSources.Clear();
            this.rptBatch.LocalReport.DataSources.Add(rds);
            this.rptBatch.RefreshReport();
            this.rptBatch.RefreshReport();
            
        }
    }
}
