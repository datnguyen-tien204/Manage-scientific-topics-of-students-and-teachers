using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class uc_Manage_Documents : UserControl
    {
        public uc_Manage_Documents()
        {
            InitializeComponent();
        }
        BLL.BLL_Search bllSearch = new BLL.BLL_Search();
        private List<object[]> dataList;
        private List<object[]> filteredDataList;
        private DataTable teacherData = new DataTable();
        private List<object[]> addUserToDataList()
        {
            List<object[]> dataList = new List<object[]>();
            teacherData = bllSearch.PROC_getAllInfDocument();
            foreach (DataRow row in teacherData.Rows)
            {
                string STT = row[0].ToString();
                string docID = row[2].ToString();
                string docName = row[1].ToString();
                string docLink = row[3].ToString();
                string facultName = row[4].ToString();
                string APA = row[5].ToString();
                string MLA = row[6].ToString();
                string BibTex = row[7].ToString();
                dataList.Add(new object[] { STT, docID, docName, docLink, facultName, APA, MLA, BibTex });
            }
            return dataList;
        }
        private void uc_Manage_Documents_Load(object sender, EventArgs e)
        {
            dataList = addUserToDataList();
            foreach (object[] row in dataList)
            {
                dgvBatch.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
            }
            filteredDataList = dataList;
        }
        private void OpenLink(string link)
        {
            System.Diagnostics.Process.Start(link);
        }
        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void OpenDialogForm(int status, string idSinhVien)
        {
            using (var dialogForm = new frmEditAndNewDocument())
            {
                dialogForm.docID = idSinhVien;
                dialogForm.status = status;
                dialogForm.ShowDialog();
            }
        }
        //0 là thêm
        //1 là sửa
        private void dgvBatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBatch.Columns[e.ColumnIndex].Name == "link")
            {
                string teacherID = dgvBatch.Rows[e.RowIndex].Cells[3].Value.ToString();
                try
                {
                    string link = teacherID;
                    //Process.Start("microsoft-edge:http://google.com");
                    Process.Start("microsoft-edge:" + link);
                }
                catch { }

            }
            if(dgvBatch.Columns[e.ColumnIndex].Name == "Edit")
            {
                string docID = dgvBatch.Rows[e.RowIndex].Cells[1].Value.ToString();
                OpenDialogForm(1, docID);

            }    
            if (dgvBatch.Columns[e.ColumnIndex].Name == "Delete")
            {
                string docID = dgvBatch.Rows[e.RowIndex].Cells[1].Value.ToString();
                int docIDInt = int.Parse(docID);
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this document?", "Delete confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bllSearch.PROC_deleteDocument(docIDInt);
                    MessageBox.Show("Delete successfully","Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    dgvBatch.Rows.Clear();
                    dataList = addUserToDataList();
                    foreach (object[] row in dataList)
                    {
                        dgvBatch.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
                    }
                    filteredDataList = dataList;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenDialogForm(0,"");
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cboSearch.SelectedIndex;
            if (selectedIndex == 0)
            {
                txtSearchLabel.Text = "Search by ID";
            }
            if (selectedIndex == 1)
            {
                txtSearchLabel.Text = "Search by Name";
            }
            if (selectedIndex == 2)
            {
                txtSearchLabel.Text = "Search by Link";
            }
            if (selectedIndex == 3)
            {
                txtSearchLabel.Text = "Search by Subject";
            }
            if (selectedIndex == 4)
            {
                txtSearchLabel.Text = "Search by MLA";
            }
            if (selectedIndex == 5)
            {
                txtSearchLabel.Text = "Search by APA";
            }
            if (selectedIndex == 6)
            {
                txtSearchLabel.Text = "Search by BibTeX";
            }
        }
        private void RefreshDataGridView()
        {
            dgvBatch.Rows.Clear();

            foreach (object[] row in filteredDataList)
            {
                dgvBatch.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
            }
        }
        private void SearchTeacher(string Search)
        {
            try
            {
                filteredDataList = new List<object[]>();
                int selectedIndex = cboSearch.SelectedIndex;
                if (selectedIndex == 0)
                {
                    foreach (object[] row in dataList)
                    {
                        string teacherName = row[1].ToString();
                        if (teacherName.Contains(Search))
                        {
                            filteredDataList.Add(row);
                        }
                    }
                    RefreshDataGridView();
                }
                if (selectedIndex == 1)
                {
                    foreach (object[] row in dataList)
                    {
                        string teacherName = row[2].ToString();
                        if (teacherName.Contains(Search))
                        {
                            filteredDataList.Add(row);
                        }
                    }
                    RefreshDataGridView();
                }
                if (selectedIndex == 2)
                {
                    foreach (object[] row in dataList)
                    {
                        string teacherName = row[3].ToString();
                        if (teacherName.Contains(Search))
                        {
                            filteredDataList.Add(row);
                        }
                    }
                    RefreshDataGridView();
                }
                if (selectedIndex == 3)
                {
                    foreach (object[] row in dataList)
                    {
                        string teacherName = row[4].ToString();
                        if (teacherName.Contains(Search))
                        {
                            filteredDataList.Add(row);
                        }
                    }
                    RefreshDataGridView();
                }
                if (selectedIndex == 4)
                {
                    foreach (object[] row in dataList)
                    {
                        string teacherName = row[5].ToString();
                        if (teacherName.Contains(Search))
                        {
                            filteredDataList.Add(row);
                        }
                    }
                    RefreshDataGridView();
                }
                if (selectedIndex == 5)
                {
                    foreach (object[] row in dataList)
                    {
                        string teacherName = row[6].ToString();
                        if (teacherName.Contains(Search))
                        {
                            filteredDataList.Add(row);
                        }
                    }
                    RefreshDataGridView();
                }
                if (selectedIndex == 6)
                {
                    foreach (object[] row in dataList)
                    {
                        string teacherName = row[7].ToString();
                        if (teacherName.Contains(Search))
                        {
                            filteredDataList.Add(row);
                        }
                    }
                    RefreshDataGridView();
                }
            }
            catch (Exception ex) { }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string ID = dgvBatch.SelectedCells[1].Value.ToString();
            OpenDialogForm(1, ID);
            dgvBatch.Rows.Clear();
            uc_Manage_Documents_Load(sender, e);

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            SearchTeacher(guna2TextBox1.Text);
        }
        private DataSet ConvertDataGridViewToDataSet()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            // Define new column names
            string[] columnNames = { "MaTaiLieu", "TenTaiLieu", "LinkTaiLieu", "MaBoMon", "MLA", "APA", "BibTexT" };

            // Add columns to the DataTable
            for (int i = 1; i < dgvBatch.Columns.Count - 2; i++)
            {
                dt.Columns.Add(columnNames[i - 1]);
            }

            // Add rows to the DataTable
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
        private void OpenFormDiaglog_forXport()
        {
            var dialogForm = new frmXportDocuments();
            {
                dialogForm.dataSet_get = ConvertDataGridViewToDataSet();
                dialogForm.ShowDialog();
            }
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(guna2ComboBox1.SelectedIndex == 0)
            {
                OpenFormDiaglog_forXport();
            }
        }
    }
}
