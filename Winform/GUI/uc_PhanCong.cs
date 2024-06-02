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
    public partial class uc_PhanCong : UserControl
    {
        public uc_PhanCong()
        {
            InitializeComponent();
        }
        private List<object[]> dataList;
        private List<object[]> filteredDataList;
        BLL.BLL_Councils bll_Councils = new BLL.BLL_Councils();

        private DataTable pcData = new DataTable();
        private List<object[]> addUserToDataList(int status)
        {

            {
                List<object[]> dataList = new List<object[]>();
                pcData = bll_Councils.getInforAssign(0, status);
                foreach (DataRow row in pcData.Rows)
                {
                    string STT = row[0].ToString();
                    //Mã phân công
                    string assignID = row[1].ToString();
                    if (assignID == "0") { assignID = "Not assigned"; }

                    //Mã hội đồng
                    string councilsID = row[2].ToString();
                    if (councilsID == "0") { councilsID = "Not assigned"; }

                    //Tên bộ môn
                    string nameFields = row[3].ToString();

                    //Mã đề tài
                    string topicID = row[4].ToString();

                    //Tên đề tài
                    string nameTopic = row[5].ToString();
                    //Ngày phân công

                    string date = "";
                    try
                    {
                        DateTime date_ = DateTime.Parse(row[6].ToString());
                        date = date_.ToString("dd/MM/yyyy");
                    }
                    catch
                    {
                        date = "Not assigned";
                    }
                    //Trạng thái phân công
                    string status_assign = row[7].ToString(); if (status_assign == "2") { status_assign = "Obtained"; }
                    if (status_assign == "1") { status_assign = "Assigned"; } else if (status_assign == "0") { status_assign = "Not Assigned"; }

                    dataList.Add(new object[] { STT, assignID, councilsID, nameFields, topicID, nameTopic, date, status_assign });
                }
                return dataList;
            }

        }
        private void OpenDialogForm(int detai)
        {
            using (var dialogForm = new frmNewAssignment())
            {
                dialogForm.idDetai = detai;
                dialogForm.ShowDialog();
            }
        }


        private void OpenDialogFormEdit(int detai)
        {
            using (var dialogForm = new frmEditAssigment())
            {
                dialogForm.idDetai = detai;
                dialogForm.ShowDialog();
            }
        }

        private void uc_PhanCong_Load(object sender, EventArgs e)
        {
            dataList = addUserToDataList(0);
            foreach (object[] row in dataList)
            {
                dgvBatch.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
            }
            filteredDataList = dataList;
        }

        private void dgvBatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvBatch.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (id == "Not assigned" && dgvBatch.Columns[e.ColumnIndex].Name == "Edit")
            {
                MessageBox.Show("This assignment hasn't been assigned to a council, you can't edit it. You only can assign it.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBatch.Rows[e.RowIndex].Cells[9].ReadOnly = true;
            }
            if (id != "Not assigned" && dgvBatch.Columns[e.ColumnIndex].Name == "Assign")
            {
                MessageBox.Show("This assignment has been assigned or obtained to a council, you can't assign it again. You only can edit it.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Phân công
            if (id == "Not assigned" && dgvBatch.Columns[e.ColumnIndex].Name == "Assign")
            {
                string topicID = dgvBatch.Rows[e.RowIndex].Cells[4].Value.ToString();
                OpenDialogForm(int.Parse(topicID));
                /*
                string assignID = dgvBatch.Rows[e.RowIndex].Cells[1].Value.ToString();
                string councilsID = dgvBatch.Rows[e.RowIndex].Cells[2].Value.ToString();
                string nameFields = dgvBatch.Rows[e.RowIndex].Cells[3].Value.ToString();
                string topicID = dgvBatch.Rows[e.RowIndex].Cells[4].Value.ToString();
                string nameTopic = dgvBatch.Rows[e.RowIndex].Cells[5].Value.ToString();
                string date = dgvBatch.Rows[e.RowIndex].Cells[6].Value.ToString();
                string status_assign = dgvBatch.Rows[e.RowIndex].Cells[7].Value.ToString();
                OpenDialogForm(0, assignID, councilsID, nameFields, topicID, nameTopic, date, status_assign);
                dgvBatch.Rows.Clear();
                uc_PhanCong_Load(sender, e);
                */
            }
            //Sửa
            string statusDGV= dgvBatch.Rows[e.RowIndex].Cells[7].Value.ToString();
            if (id != "Not assigned" && dgvBatch.Columns[e.ColumnIndex].Name == "Edit" && statusDGV == "Obtained")
            {
                MessageBox.Show("This assignment has been obtained, you can't edit it.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (id != "Not assigned" && dgvBatch.Columns[e.ColumnIndex].Name == "Edit" && statusDGV!="Obtained")
            {
                string topicID = dgvBatch.Rows[e.RowIndex].Cells[4].Value.ToString();
                OpenDialogFormEdit(int.Parse(topicID));
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
        private void SearchInformation(string Search)
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
                        string teacherName = row[5].ToString();
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
                        string teacherName = row[6].ToString();
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
                        string teacherName = row[4].ToString();
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

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchInformation(txtSearch.Text);
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
                txtSearchLabel.Text = "Search by CouncilID";
            }
            if (selectedIndex == 2)
            {
                txtSearchLabel.Text = "Search by Type";
            }
            if (selectedIndex == 3)
            {
                txtSearchLabel.Text = "Search by TopicName";
            }
            if (selectedIndex == 4)
            {
                txtSearchLabel.Text = "Search by Assg.Date";
            }
            if (selectedIndex == 5)
            {
                txtSearchLabel.Text = "Search by TopicID";
            }
        }


        private DataSet ConvertDataGridViewToDataSet()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            // Define new column names corresponding to the selected columns
            string[] columnNames = { "MaPhanCong", "MaHoiDong", "MaDeTai", "NgayPhanCong", "TrangThai" };

            // Add columns to the DataTable
            foreach (var columnName in columnNames)
            {
                dt.Columns.Add(columnName);
            }

            // Add rows to the DataTable
            foreach (DataGridViewRow row in dgvBatch.Rows)
            {
                if (!row.IsNewRow) // Check to ensure it's not the new row placeholder
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = row.Cells[1].Value; // MaGV
                    dr[1] = row.Cells[2].Value; // TenGV
                    dr[2] = row.Cells[4].Value; // SDT
                    dr[3] = row.Cells[6].Value; // Email
                    dr[4] = row.Cells[7].Value; // DiaChi
                    dt.Rows.Add(dr);
                }
            }

            ds.Tables.Add(dt);
            return ds;
        }
        private void OpenFormDiaglog()
        {
            var dialogForm = new phanCongXport();
            {
                dialogForm.dataSet_get = ConvertDataGridViewToDataSet();
                dialogForm.ShowDialog();
            }
        }

        private void cboExport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboExport.SelectedIndex==1 || cboExport.SelectedIndex==0)
            {
                OpenFormDiaglog();
            }


        }
    }
}
