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
using System.Windows.Forms;

namespace GUI
{
    public partial class uc_CouncilManagement : UserControl
    {
        public uc_CouncilManagement()
        {
            InitializeComponent();
        }
        private List<object[]> dataList;
        private List<object[]> filteredDataList;
        BLL.BLL_Councils bllCouncils = new BLL.BLL_Councils();
        private DataTable teacherData = new DataTable();
        private List<object[]> addUserToDataList(int status)
        {
            List<object[]> dataList = new List<object[]>();
            teacherData = bllCouncils.PROC_getCouncilList(1, status);
            foreach (DataRow row in teacherData.Rows)
            {
                string STT = row[0].ToString();
                string councilID = row[1].ToString();
                string councilName = row[2].ToString();
                DateTime date_ = DateTime.Parse(row[3].ToString());
                string date = date_.ToString("dd/MM/yyyy");
                string idBoMon = row[4].ToString();
                int idBoMon_int = int.Parse(idBoMon);
                string idBM = "";
                if (idBoMon_int == 1) { idBM = "Computer Science"; } else if (idBoMon_int == 2) { idBM = "Software Engineering"; } else if (idBoMon_int == 3) { idBM = "IT"; }
                string memberCount = row[5].ToString();
                dataList.Add(new object[] { STT, councilID, councilName, date, idBM, memberCount });
            }
            return dataList;
        }
        private void RefreshDataGridView()
        {
            dgvBatch.Rows.Clear();

            foreach (object[] row in filteredDataList)
            {
                dgvBatch.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
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
                txtSearchLabel.Text = "Search by Date";
            }
            if (selectedIndex == 3)
            {
                txtSearchLabel.Text = "Search by Major";
            }
            if (selectedIndex == 4)
            {
                txtSearchLabel.Text = "Search by Member Count";
            }
        }
        private void OpenDialogForm(int status, int IDcouncil)
        {
            using (var dialogForm = new frmAddCouncils())
            {
                dialogForm.statusEditInsert = status;
                dialogForm.idCouncil = IDcouncil;
                dialogForm.ShowDialog();
            }
        }

        private void dgvBatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // 0 là insert, 1 là edit
                if (dgvBatch.Columns[e.ColumnIndex].Name == "Edit")
                {
                    string councilID = dgvBatch.Rows[e.RowIndex].Cells[1].Value.ToString();
                    int councilID_int = int.Parse(councilID);

                    OpenDialogForm(1, councilID_int);
                    dgvBatch.Rows.Clear();
                    uc_CouncilManagement_Load(sender, e);
                }

                if (dgvBatch.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult diag = MessageBox.Show("Do you want to delete this council?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diag == DialogResult.Yes)
                    {
                        string councilID = dgvBatch.Rows[e.RowIndex].Cells[1].Value.ToString();
                        int councilID_int = int.Parse(councilID);
                        if (bllCouncils.delCouncils(councilID_int, 0))
                        {
                            if (bllCouncils.delCouncils(councilID_int, 1))
                            {
                                MessageBox.Show("Delete successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvBatch.Rows.Clear();
                                uc_CouncilManagement_Load(sender, e);
                            }
                        }


                    }
                }

            }
            catch (Exception ex) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenDialogForm(0, 1);
            dgvBatch.Rows.Clear();
            uc_CouncilManagement_Load(sender, e);
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
                    for (int i = 0; i < Math.Min(5, dgvBatch.Columns.Count); i++)
                    {
                        worksheet.Cells[5, i + 1].Value = dgvBatch.Columns[i].HeaderText;
                    }

                    for (int i = 0; i < dgvBatch.Rows.Count; i++)
                    {
                        for (int j = 0; j < Math.Min(5, dgvBatch.Columns.Count); j++)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string ID = dgvBatch.SelectedCells[1].Value.ToString();
            int ID_int = int.Parse(ID);
            OpenDialogForm(1, ID_int);
            dgvBatch.Rows.Clear();
            uc_CouncilManagement_Load(sender, e);
        }

        private void cboExport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboExport.SelectedIndex == 0)
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
            if (cboExport.SelectedIndex==1)
            {
                OpenDialogForm2();
            }
        }
        private DataSet ConvertDataGridViewToDataSet()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            // Define new column names
            string[] columnNames = { "MaHoiDong", "TenHoiDong", "NgayThanhLap", "MaBoMon", "SoLuongThanhVien"};

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
        private void OpenDialogForm2()
        {
            using (var dialogForm = new frmCouncilsXport())
            {
                DataSet ds = ConvertDataGridViewToDataSet();
                dialogForm.dataSet_get = ds;
                dialogForm.ShowDialog();
            }
        }

        private void uc_CouncilManagement_Load(object sender, EventArgs e)
        {
            dataList = addUserToDataList(0);
            foreach (object[] row in dataList)
            {
                dgvBatch.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
        }

    }
}
