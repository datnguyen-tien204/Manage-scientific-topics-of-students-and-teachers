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
    public partial class frm_addANDeditTeacher : Form
    {
        public frm_addANDeditTeacher()
        {
            InitializeComponent();
        }
        public int trangthaiSuaXOA { get; set; }
        public string idGiaoVien { get; set; }
        public void disableSys(int trangthai)
        {
            if(trangthai==0)
            {
               txtTeacherID.Enabled = false;
            }    
            else
            {
                btnResetPassword.Hide();
            }
        }
        BLL.BLL_Users bllUsers = new BLL.BLL_Users();
        private bool checkingInformation(int status)
        {
            if(status==1 && (txtTeacherID.Text==""||txtTeacherName.Text==""||txtTeacherPhone.Text==""||txtTeacherEmail.Text==""||txtTeacherAddress.Text==""||cboAcaLevel.Text=="" ||cboMajor.Text==""||cboTeacherSex.Text==""))
            {
                MessageBox.Show("Please fill in all the information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (status == 0 && (txtTeacherID.Text == "" || txtTeacherName.Text == "" || txtTeacherPhone.Text == "" || txtTeacherEmail.Text == "" || txtTeacherAddress.Text == "" || cboAcaLevel.Text == "" || cboMajor.Text == "" || cboTeacherSex.Text == ""))
            {
                MessageBox.Show("Please fill in all the information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void insertNewTeacher()
        {
            if (checkingInformation(1))
            {
                DialogResult result = MessageBox.Show("Do you want to add this teacher?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    string MaGV = txtTeacherID.Text;
                    string tenGV = txtTeacherName.Text;
                    int GioiTinh = cboTeacherSex.SelectedIndex;
                    if (GioiTinh == 0) { GioiTinh = 1; } else { GioiTinh = 0; }
                    string SDT = txtTeacherPhone.Text;
                    string Email = txtTeacherEmail.Text;
                    string DiaChi = txtTeacherAddress.Text;
                    int trinhDoHV = cboAcaLevel.SelectedIndex;
                    if (trinhDoHV == 0) { trinhDoHV = 1; } else if (trinhDoHV == 1) { trinhDoHV = 2; } else if (trinhDoHV == 2) { trinhDoHV = 3; } else if (trinhDoHV == 3) { trinhDoHV = 4; } else if (trinhDoHV == 4) { trinhDoHV = 5; }
                    int MaQuyen = 2;
                    int MaBoMon = cboMajor.SelectedIndex;
                    if (MaBoMon == 0) { MaBoMon = 1; } else if (MaBoMon == 1) { MaBoMon = 2; } else if (MaBoMon == 2) { MaBoMon = 3; }
                    if (bllUsers.PROC_insertTeacher(MaGV, tenGV, GioiTinh, SDT, Email, DiaChi, trinhDoHV, MaQuyen, MaBoMon))
                    {
                        MessageBox.Show("Add teacher successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Add teacher failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void addUserToDataList(string id, int status)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable teacherData = bllUsers.PROC_getUserInformationwithID(id,status);
            foreach (DataRow row in teacherData.Rows)
            {
                txtTeacherID.Text= row[0].ToString();
                txtTeacherName.Text = row[1].ToString();
                string teacherSex = row[2].ToString();
                if (teacherSex == "1") { cboTeacherSex.SelectedIndex=1; } else { cboTeacherSex.SelectedIndex=0; }
                txtTeacherPhone.Text = row[3].ToString();
                txtTeacherEmail.Text = row[4].ToString();
                txtTeacherAddress.Text = row[5].ToString();
                string trinhDo = row[6].ToString(); if (trinhDo == "1") { cboAcaLevel.SelectedIndex=0; } else if (trinhDo == "2") { cboAcaLevel.SelectedIndex = 1; } else if (trinhDo == "3") { cboAcaLevel.SelectedIndex = 2; } else if (trinhDo == "4") { cboAcaLevel.SelectedIndex=3; } else { cboAcaLevel.SelectedIndex = 4; }
                string idBoMon = row[7].ToString();
                int idBoMon_int = int.Parse(idBoMon);
                if (idBoMon_int == 1) { cboMajor.SelectedIndex=0; } else if (idBoMon_int == 2) { cboMajor.SelectedIndex = 1; } else if (idBoMon_int == 3) { cboMajor.SelectedIndex = 2; }
            }
        }
        private void updateTeacher()
        {
            if(checkingInformation(0))
            {
                DialogResult diag=MessageBox.Show("Do you want to update this teacher?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(diag==DialogResult.Yes)
                {
                    string eacherID = txtTeacherID.Text;
                    string tenGV = txtTeacherName.Text;
                    int GioiTinh = cboTeacherSex.SelectedIndex;
                    if (GioiTinh == 0) { GioiTinh = 1; } else { GioiTinh = 0; }
                    string SDT = txtTeacherPhone.Text;
                    string Email = txtTeacherEmail.Text;
                    string DiaChi = txtTeacherAddress.Text;
                    int trinhDoHV = cboAcaLevel.SelectedIndex;
                    if (trinhDoHV == 0) { trinhDoHV = 1; } else if (trinhDoHV == 1) { trinhDoHV = 2; } else if (trinhDoHV == 2) { trinhDoHV = 3; } else if (trinhDoHV == 3) { trinhDoHV = 4; } else if (trinhDoHV == 4) { trinhDoHV = 5; }
                    int MaQuyen = 2;
                    int MaBoMon = cboMajor.SelectedIndex;
                    if (MaBoMon == 0) { MaBoMon = 1; } else if (MaBoMon == 1) { MaBoMon = 2; } else if (MaBoMon == 2) { MaBoMon = 3; }
                    if (bllUsers.PROC_updateTeacher(eacherID, tenGV, GioiTinh, SDT, Email, DiaChi, trinhDoHV, MaQuyen, MaBoMon))
                    {
                        MessageBox.Show("Update teacher successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update teacher failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }    
            }    
        }
        private void frm_addANDeditTeacher_Load(object sender, EventArgs e)
        {
            disableSys(trangthaiSuaXOA);
            if (trangthaiSuaXOA==0)
            {
                addUserToDataList(idGiaoVien, 1);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(trangthaiSuaXOA==1)
            {
                insertNewTeacher();
            }
            else
            {
                updateTeacher();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if(trangthaiSuaXOA==0)
            {
                DialogResult diag = MessageBox.Show("Do you want to reset password?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diag == DialogResult.Yes)
                {
                    if (bllUsers.PROC_resetPassword(idGiaoVien, 1))
                    {
                        MessageBox.Show("Reset password successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Reset password failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Do you want to cancel?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diag == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
