using OfficeOpenXml;
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

namespace GUI
{
    public partial class uc_StudentsManage : UserControl
    {
        public uc_StudentsManage()
        {
            InitializeComponent();
        }
        BLL.BLL_Users bllUsers = new BLL.BLL_Users();
        private List<object[]> dataList;
        private List<object[]> filteredDataList;
        private DataTable teacherData = new DataTable();
        private List<object[]> addUserToDataList(int status)
        {
            List<object[]> dataList = new List<object[]>();
            teacherData = bllUsers.PROC_getUserList(status);
            foreach (DataRow row in teacherData.Rows)
            {
                string STT = row[0].ToString();
                string studentID = row[1].ToString();
                string studentName = row[2].ToString();
                string studentSex = row[3].ToString();
                if (studentSex == "1") { studentSex = "Male"; } else { studentSex = "Female"; }
                string IdentityCode = row[4].ToString();
                string studentPhone = row[5].ToString();
                string studentEmail = row[6].ToString();
                string studentAddress = row[7].ToString();
                string idClass = row[8].ToString(); 
                dataList.Add(new object[] { STT, studentID, studentName, studentSex, IdentityCode ,studentPhone, studentEmail, studentAddress,idClass});
            }
            return dataList;
        }

        private void uc_StudentsManage_Load(object sender, EventArgs e)
        {
            dataList = addUserToDataList(0);
            foreach (object[] row in dataList)
            {
                dgvBatch.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }
            filteredDataList = dataList;
        }
        private void OpenDialogForm(int status, string idSinhVien)
        {
            using (var dialogForm = new frm_addANDeditStudent())
            {
                dialogForm.trangthaiSuaXOA = status;
                dialogForm.idSinhVien = idSinhVien;
                dialogForm.ShowDialog();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenDialogForm(1, "");
            dgvBatch.Rows.Clear();
            uc_StudentsManage_Load(sender, e);
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
                    uc_StudentsManage_Load(sender, e);
                }
                if (dgvBatch.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult diag = MessageBox.Show("Do you want to delete this student?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diag == DialogResult.Yes)
                    {
                        string teacherID = dgvBatch.Rows[e.RowIndex].Cells[1].Value.ToString();
                        bool k = bllUsers.PROC_deleteUser(teacherID, 0);
                        if (k)
                        {
                            MessageBox.Show("Delete student successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvBatch.Rows.Clear();
                            uc_StudentsManage_Load(sender, e);


                        }
                        else
                        {
                            MessageBox.Show("Delete student failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string ID = dgvBatch.SelectedCells[1].Value.ToString();
            OpenDialogForm(0, ID);
            dgvBatch.Rows.Clear();
            uc_StudentsManage_Load(sender, e);
        }

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
                        string teacherName = row[5].ToString();
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
                        string teacherName = row[6].ToString();
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
                        string teacherName = row[7].ToString();
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
                        string teacherName = row[8].ToString();
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
            string[] columnNames = { "MaSV", "TenSV", "GioiTinh", "CCCD","SDT", "Email", "DiaChi"};

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
            var dialogForm = new frm_StudentXport();
            {
                dialogForm.dataSet_get = ConvertDataGridViewToDataSet();
                dialogForm.ShowDialog();
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(guna2ComboBox1.SelectedIndex==0)
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
            if(guna2ComboBox1.SelectedIndex==1)
            {
                OpenFormDiaglog();
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            SearchTeacher(guna2TextBox1.Text);
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
