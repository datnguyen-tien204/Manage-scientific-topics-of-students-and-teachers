using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_addANDeditStudent : Form
    {
        public frm_addANDeditStudent()
        {
            InitializeComponent();
        }
        public int trangthaiSuaXOA { get; set; }
        public string idSinhVien { get; set; }
        public void disableSys(int trangthai)
        {
            if (trangthai == 0)
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
            if (status == 1 && (txtTeacherID.Text == "" || txtTeacherName.Text == "" || txtTeacherPhone.Text == "" || txtTeacherEmail.Text == "" || txtTeacherAddress.Text == "" || cboAcaLevel.Text == ""  || cboTeacherSex.Text == ""))
            {
                MessageBox.Show("Please fill in all the information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (status == 0 && (txtTeacherID.Text == "" || txtTeacherName.Text == "" || txtTeacherPhone.Text == "" || txtTeacherEmail.Text == "" || txtTeacherAddress.Text == "" || cboAcaLevel.Text == "" || cboTeacherSex.Text == ""))
            {
                MessageBox.Show("Please fill in all the information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(txtTeacherAddress.TextLength>100)
            {
                MessageBox.Show("Address is too long", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(txtTeacherName.TextLength>100)
            {
                MessageBox.Show("Name is too long", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTeacherPhone.TextLength > 100)
            {
                MessageBox.Show("Name is too long", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void insertnewStudent()
        {
            if(checkingInformation(1))
            {
                DialogResult result = MessageBox.Show("Do you want to add this student?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    string MaGV = txtTeacherID.Text;
                    string tenGV = txtTeacherName.Text;
                    int GioiTinh = cboTeacherSex.SelectedIndex;
                    if (GioiTinh == 0) { GioiTinh = 0; } else { GioiTinh = 1; }
                    string SDT = txtTeacherPhone.Text;
                    string Email = txtTeacherEmail.Text;
                    string DiaChi = txtTeacherAddress.Text;
                    string trinhDoHV = cboAcaLevel.Text;
                    string citizenID= txtCitizenID.Text;
                
                    int MaQuyen = 3;
                    if (bllUsers.PROC_insertNewStudent(MaGV,tenGV,GioiTinh,citizenID,SDT,Email,DiaChi,trinhDoHV,MaQuyen))
                    {
                        MessageBox.Show("Update student successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update student failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }    
        }

        private void updateStudent()
        {
            try
            {
                if (checkingInformation(0))
                {
                    DialogResult diag = MessageBox.Show("Do you want to update this student?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diag == DialogResult.Yes)
                    {
                        string MaGV = txtTeacherID.Text;
                        string tenGV = txtTeacherName.Text;
                        int GioiTinh = cboTeacherSex.SelectedIndex;
                        if (GioiTinh == 0) { GioiTinh = 1; } else { GioiTinh = 0; }
                        string SDT = txtTeacherPhone.Text;
                        string Email = txtTeacherEmail.Text;
                        string DiaChi = txtTeacherAddress.Text;
                        string trinhDoHV = cboAcaLevel.Text;
                        string citizenID = txtCitizenID.Text;

                        int MaQuyen = 3;
                        if (bllUsers.PROC_updateStudent(MaGV, tenGV, GioiTinh, citizenID, SDT, Email, DiaChi, trinhDoHV, MaQuyen))
                        {
                            MessageBox.Show("Update student successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update student failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }


        private void addUserToDataList(string id, int status)
        {
            DataTable teacherData = bllUsers.PROC_getUserInformationwithID(id, status);
            foreach (DataRow row in teacherData.Rows)
            {
                txtTeacherID.Text = row[0].ToString();
                txtTeacherName.Text = row[1].ToString();
                string teacherSex = row[2].ToString();
                if (teacherSex == "1") { cboTeacherSex.SelectedIndex = 1; } else { cboTeacherSex.SelectedIndex = 0; }
                txtCitizenID.Text = row[3].ToString();
                txtTeacherPhone.Text = row[4].ToString();
                txtTeacherEmail.Text = row[5].ToString();
                txtTeacherAddress.Text = row[6].ToString();
                string trinhDo = row[7].ToString().TrimEnd(); 
                if (trinhDo == "12422TN") { cboAcaLevel.SelectedIndex = 0; } else if (trinhDo == "101221") { cboAcaLevel.SelectedIndex = 1; } else if (trinhDo == "125221") { cboAcaLevel.SelectedIndex = 2; } else if (trinhDo == "124221") { cboAcaLevel.SelectedIndex = 3; };
            }
        }

        private void frm_addANDeditStudent_Load(object sender, EventArgs e)
        {
            disableSys(trangthaiSuaXOA);
            if (trangthaiSuaXOA == 0)
            {
                addUserToDataList(idSinhVien, 0);
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (trangthaiSuaXOA == 0)
                {
                    DialogResult diag = MessageBox.Show("Do you want to reset password?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diag == DialogResult.Yes)
                    {
                        if (bllUsers.PROC_resetPassword(idSinhVien, 0))
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
            catch (Exception ex) { }
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (trangthaiSuaXOA == 1)
            {
                insertnewStudent();
            }
            else
            {
                updateStudent();
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
