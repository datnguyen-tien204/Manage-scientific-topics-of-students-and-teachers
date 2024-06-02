using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class uc_Manage_Details_OpenEnroll : UserControl
    {
        public uc_Manage_Details_OpenEnroll()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        BLL.BLL_Registration bllRegis = new BLL.BLL_Registration();
        private List<object[]> addBatchtoDatalist(int year)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = bllRegis.getBatchInfo(year);
            foreach (DataRow row in topicData.Rows)
            {
                string STT = row[0].ToString();
                string batchID = row[1].ToString();
                string batchName = row[2].ToString();
                DateTime startTime_ = DateTime.Parse(row[3].ToString());
                string startTime = startTime_.ToString("MM/dd/yyyy");
                DateTime subTime_ = DateTime.Parse(row[4].ToString());
                string submisionTime = subTime_.ToString("MM/dd/yyyy");
                DateTime endTime_ = DateTime.Parse(row[5].ToString());
                string endTime = endTime_.ToString("MM/dd/yyyy");
                string type = row[6].ToString();
                dataList.Add(new object[] { STT, batchID, batchName, startTime, submisionTime, endTime, type});
            }
            return dataList;
        }

        private void uc_Manage_Details_OpenEnroll_Load(object sender, EventArgs e)
        {
            List<object[]> dataList = addBatchtoDatalist(2024);
            foreach (object[] row in dataList)
            {
                dgvBatch.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvBatch.Rows.Clear();
            int year = int.Parse(cboYear.Text);
            List<object[]> dataList = addBatchtoDatalist(year);
            foreach (object[] row in dataList)
            {
                dgvBatch.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmAddBatch frm = new frmAddBatch();
            frm.ShowDialog();
        }
        private void OpenDialogForm(int id)
        {
            using (var dialogForm = new frmEditBatch())
            {
                dialogForm.id = id;
                dialogForm.ShowDialog();
            }
        }
        private bool deleteBatch(int id)
        {
            return bllRegis.deleteBatch(id);
        }

        private void dgvBatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string endTime = dgvBatch.Rows[e.RowIndex].Cells[5].Value.ToString();
                DateTime endTime_ = DateTime.Parse(endTime);
                if (endTime_ > DateTime.Now)
                {

                    if (dgvBatch.Columns[e.ColumnIndex].Name == "Edit")
                    {
                        string batchID = dgvBatch.Rows[e.RowIndex].Cells[1].Value.ToString();
                        int batchIDInt = int.Parse(batchID);

                        OpenDialogForm(batchIDInt);
                    }
                }
                

                string startTime = dgvBatch.Rows[e.RowIndex].Cells[3].Value.ToString();
                DateTime startTime_ = DateTime.Parse(startTime);
                if (dgvBatch.Columns[e.ColumnIndex].Name == "Delete")
                {

                    if (DateTime.Now - startTime_ > TimeSpan.FromDays(30))
                    {
                        MessageBox.Show("Can't delete batch after 30 days from start date", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DialogResult diag = MessageBox.Show("Do you want to delete?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        {
                            if (diag == DialogResult.Yes)
                            {
                                string batchID = dgvBatch.Rows[e.RowIndex].Cells[1].Value.ToString();
                                int batchIDInt = int.Parse(batchID);
                                if (deleteBatch(batchIDInt))
                                {
                                    MessageBox.Show("Delete batch successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }
            catch { }

        }
        private DataSet ConvertDataGridViewToDataSet()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            // Define new column names
            string[] columnNames = { "MaDot", "TenDon", "NgayBatDau", "HanNopBai", "NgayKetThuc", "GhiChu"};

            // Add columns to the DataTable
            for (int i = 1; i < dgvBatch.Columns.Count - 2; i++)
            {
                dt.Columns.Add(columnNames[i - 1]);
            }
            foreach (DataGridViewRow row in dgvBatch.Rows)
            {
                DataRow dr = dt.NewRow();
                for (int i = 1; i < dgvBatch.Columns.Count - 2; i++)
                {
                    dr[i - 1] = row.Cells[i].Value;
                }
                dt.Rows.Add(dr);
            }

            ds.Tables.Add(dt);
            return ds;
        }
        private void OpenFormDiaglog()
        {
            var dialogForm = new frmBatchXport();
            {
                dialogForm.dataSet_get = ConvertDataGridViewToDataSet();
                dialogForm.ShowDialog();
            }
        }

        private void cboExport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboExport.SelectedIndex==0)
            {
                OpenFormDiaglog();
            }    
        }
    }
}
