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
    public partial class frm_Teacher_ExpReport : Form
    {
        public frm_Teacher_ExpReport()
        {
            InitializeComponent();
        }
        BLL_expToFile bLL_ExpToFile = new BLL_expToFile();
        public DataSet dataSet_get { get; set; }
        private void DisplayDataSet(DataSet ds)
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataTable table in ds.Tables)
            {
                sb.AppendLine("Table: " + table.TableName);
                sb.AppendLine(new string('-', 50));

                // Add column headers
                foreach (DataColumn column in table.Columns)
                {
                    sb.Append(column.ColumnName + "\t");
                }
                sb.AppendLine();

                // Add rows
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        sb.Append(item.ToString() + "\t");
                    }
                    sb.AppendLine();
                }
                sb.AppendLine(new string('-', 50));
            }

            MessageBox.Show(sb.ToString(), "DataSet Contents", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void frm_Teacher_ExpReport_Load(object sender, EventArgs e)
        {
            //DisplayDataSet(dataSet_get);
            DataSet ds = dataSet_get;
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("teacherList", ds.Tables[0]);
            this.rptMain.LocalReport.DataSources.Clear();
            this.rptMain.LocalReport.DataSources.Add(rds);
            this.rptMain.RefreshReport();
            this.rptMain.RefreshReport();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
