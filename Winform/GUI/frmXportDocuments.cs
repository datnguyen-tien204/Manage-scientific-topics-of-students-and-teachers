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
    public partial class frmXportDocuments : Form
    {
        public frmXportDocuments()
        {
            InitializeComponent();
        }
        public DataSet dataSet_get { get; set; }

        private void frmXportDocuments_Load(object sender, EventArgs e)
        {
            DataSet ds = dataSet_get;
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("documentList", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
