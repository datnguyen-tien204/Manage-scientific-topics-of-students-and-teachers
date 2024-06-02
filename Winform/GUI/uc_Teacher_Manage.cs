using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using OfficeOpenXml;

namespace GUI
{
    public partial class uc_Teacher_Manage : UserControl
    {
        public uc_Teacher_Manage()
        {
            InitializeComponent();
        }
        private List<object[]> dataList;
        private List<object[]> filteredDataList;
        BLL.BLL_Users bllUsers = new BLL.BLL_Users();
        private DataTable teacherData = new DataTable();
        private List<object[]> addUserToDataList(int status)
        {
            List<object[]> dataList = new List<object[]>();
            teacherData = bllUsers.PROC_getUserList(status);
            foreach (DataRow row in teacherData.Rows)
            {
                string STT = row[0].ToString();
                string teacherID = row[1].ToString();
                string teacherName = row[2].ToString();
                string teacherSex = row[3].ToString();
                if (teacherSex == "1") { teacherSex = "Female"; } else { teacherSex = "Male"; }
                string teacherPhone = row[4].ToString();
                string teacherEmail = row[5].ToString();
                string teacherAddress = row[6].ToString();
                string trinhDo = row[7].ToString(); if (trinhDo == "1") { trinhDo = "Bachelor"; } else if (trinhDo == "2") { trinhDo = "Master"; } else if (trinhDo == "3") { trinhDo = "Doctor"; } else if (trinhDo == "4") { trinhDo = "Assoc.Prof"; } else { trinhDo = "Prof"; }
                string idBoMon = row[8].ToString();
                int idBoMon_int = int.Parse(idBoMon);
                string idBM = "";
                if (idBoMon_int == 1) { idBM = "Computer Science"; } else if (idBoMon_int == 2) { idBM = "Software Engineering"; } else if (idBoMon_int == 3) { idBM = "IT"; }
                dataList.Add(new object[] { STT, teacherID, teacherName, teacherSex, teacherPhone, teacherEmail, teacherAddress, trinhDo, idBM });
            }
            return dataList;
        }
        private void uc_Teacher_Manage_Load(object sender, EventArgs e)
        {
            dataList = addUserToDataList(1);
            foreach (object[] row in dataList)
            {
                dgvBatch.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }
            filteredDataList = dataList;
        }
        private void OpenDialogForm(int status, string idGiaoVien)
        {
            using (var dialogForm = new frm_addANDeditTeacher())
            {
                dialogForm.trangthaiSuaXOA = status;
                dialogForm.idGiaoVien = idGiaoVien;
                dialogForm.ShowDialog();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenDialogForm(1, "");
            dgvBatch.Rows.Clear();
            uc_Teacher_Manage_Load(sender, e);
        }
        private void dgvBatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dgvBatch.Columns[e.ColumnIndex].Name == "Edit")
                {
                    string teacherID = dgvBatch.Rows[e.RowIndex].Cells[1].Value.ToString();

                    OpenDialogForm(0, teacherID);
                    dgvBatch.Rows.Clear();
                    uc_Teacher_Manage_Load(sender, e);
                }
                if (dgvBatch.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult diag = MessageBox.Show("Do you want to delete this teacher?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diag == DialogResult.Yes)
                    {
                        string teacherID = dgvBatch.Rows[e.RowIndex].Cells[1].Value.ToString();
                        bool k = bllUsers.PROC_deleteUser(teacherID, 1);
                        if (k)
                        {
                            MessageBox.Show("Delete teacher successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvBatch.Rows.Clear();
                            uc_Teacher_Manage_Load(sender, e);


                        }
                        else
                        {
                            MessageBox.Show("Delete teacher failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex) { }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string ID = dgvBatch.SelectedCells[1].Value.ToString();
            OpenDialogForm(0, ID);
            dgvBatch.Rows.Clear();
            uc_Teacher_Manage_Load(sender, e);
        }
        //Tìm kiếm giáo viên
        private void RefreshDataGridView()
        {
            dgvBatch.Rows.Clear();

            foreach (object[] row in filteredDataList)
            {
                dgvBatch.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
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
                        string teacherName = row[4].ToString();
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
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            SearchTeacher(txtSearch.Text);
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
                txtSearchLabel.Text = "Search by Phone";
            }
            if (selectedIndex == 3)
            {
                txtSearchLabel.Text = "Search by Email";
            }
            if (selectedIndex == 4)
            {
                txtSearchLabel.Text = "Search by Address";
            }
            if (selectedIndex == 5)
            {
                txtSearchLabel.Text = "Search by Level";
            }
        }
        private void ExportToExcel(string filePath)
        {
            try
            {
                // Tạo một đối tượng ExcelPackage để tạo file Excel mới
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // Tạo một trang tính mới trong file Excel
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Teacher Data");

                    // Viết heading
                    worksheet.Cells["A1"].Value = "TRƯỜNG ĐHSPKT HƯNG YÊN";
                    worksheet.Cells["B1"].Value = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
                    worksheet.Cells["A2"].Value = "KHOA LÝ LUẬN CHÍNH TRỊ";
                    worksheet.Cells["B2"].Value = "Độc lập - Tự do - Hạnh phúc";
                    worksheet.Cells["A3"].Value = "BỘ MÔN NLCB CỦA CN MÁC – LÊNIN";
                    worksheet.Cells["A4"].Value = "DANH SÁCH SINH VIÊN LỚP TÍN CHỈ";

                    // Merge các ô cho heading
                    worksheet.Cells["A1:B1"].Merge = true;
                    worksheet.Cells["A2:B2"].Merge = true;

                    // Ghi dữ liệu vào file Excel từ DataGridView
                    for (int i = 0; i < Math.Min(9, dgvBatch.Columns.Count); i++)
                    {
                        worksheet.Cells[5, i + 1].Value = dgvBatch.Columns[i].HeaderText;
                    }

                    for (int i = 0; i < dgvBatch.Rows.Count; i++)
                    {
                        for (int j = 0; j < Math.Min(9, dgvBatch.Columns.Count); j++)
                        {
                            worksheet.Cells[i + 6, j + 1].Value = dgvBatch.Rows[i].Cells[j].Value;
                        }
                    }

                    // Lưu file Excel
                    FileInfo excelFile = new FileInfo(filePath);
                    excelPackage.SaveAs(excelFile);
                }

                MessageBox.Show("Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while exporting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataSet ConvertDataGridViewToDataSet()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            // Define new column names
            string[] columnNames = { "MaGV", "TenGV", "GioiTinh", "SDT", "Email", "DiaChi", "MaTrinhDoHocVan", "MaBoMon" };

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
        private void OpenFormDiaglog()
        {
            var dialogForm = new frm_Teacher_ExpReport();
            {
                dialogForm.dataSet_get = ConvertDataGridViewToDataSet();
                dialogForm.ShowDialog();
            }
        }


        private void cboExport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboExport.SelectedIndex == 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx"; // Chỉ định định dạng file là XLSX
                saveFileDialog.Title = "Export to Excel";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    ExportToExcel(saveFileDialog.FileName);
                }
            }
            if(cboExport.SelectedIndex == 1)
            {
                OpenFormDiaglog();
            }
        }
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx"; // Chỉ định định dạng file là XLSX
            saveFileDialog.Title = "Export to Excel";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                ExportToExcel(saveFileDialog.FileName);
            }
        }
    }
}
