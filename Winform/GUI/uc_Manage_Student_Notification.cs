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
    public partial class uc_Manage_Student_Notification : UserControl
    {
        public uc_Manage_Student_Notification()
        {
            InitializeComponent();
        }
        BLL_Notification bllNotification = new BLL_Notification();
        private List<object[]> dataList;
        private List<object[]> filteredDataList;
        private DataTable teacherData = new DataTable();
        private List<object[]> addUserToDataList()
        {
            List<object[]> dataList = new List<object[]>();
            teacherData = bllNotification.PROC_getInfNotification(0);
            foreach (DataRow row in teacherData.Rows)
            {
                string STT = row[0].ToString();
                string mathongbao = row[1].ToString();
                string tenthongbao = row[2].ToString();
                string noiDung = row[3].ToString();
                string ngayGui = row[4].ToString();
                string maNguoiNhan = row[5].ToString();
                dataList.Add(new object[] { STT, mathongbao, tenthongbao, noiDung, ngayGui, maNguoiNhan });
            }
            return dataList;
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
            //uc_Teacher_Manage_Load(sender, e);
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
                txtSearchLabel.Text = "Search by Content";
            }
            if (selectedIndex == 3)
            {
                txtSearchLabel.Text = "Search by Send Date";
            }
            if (selectedIndex == 4)
            {
                txtSearchLabel.Text = "Search by Receiver ID";
            }
        }
        private void uc_Manage_Student_Notification_Load(object sender, EventArgs e)
        {
            dataList = addUserToDataList();
            foreach (object[] row in dataList)
            {
                dgvBatch.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
            filteredDataList = dataList;
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvBatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
