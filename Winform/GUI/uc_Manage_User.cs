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
    public partial class uc_Manage_User : UserControl
    {
        public uc_Manage_User()
        {
            InitializeComponent();
        }
        BLL.BLL_Users bllUsers = new BLL.BLL_Users();
        public string iduser { get; set; }
        public string vaitro { get; set; }
        private void fitDataToBox()
        {
            disableBox(0);
            if(vaitro=="sinhvien")
            {
                List<object[]> dataList = new List<object[]>();
                DataTable topicData = bllUsers.PROC_getInfoUser(iduser,0);
                foreach (DataRow row in topicData.Rows)
                {
                    string tensv = row[0].ToString();
                    string sdt= row[1].ToString();
                    string email = row[2].ToString();
                    string cccd= row[3].ToString();
                    string gioitinh = row[4].ToString();
                    string diachi = row[5].ToString();
                    string malop = row[6].ToString();
                    string matkhau = row[7].ToString();
                    dataList.Add(new object[] { tensv, sdt, email, cccd, gioitinh, diachi, malop, matkhau });
                }
                foreach (object[] row in dataList)
                {
                    lblIDSV.Text = iduser;
                    lblName.Text = row[0].ToString();
                    txtSDT.Text = row[1].ToString();
                    txtEmail.Text = row[2].ToString();
                    lblChucVu.Text = "Student";
                    txtIDCode.Text = row[3].ToString();
                    if (row[4].ToString()=="True")
                    {
                        cboSex.SelectedIndex = 0;
                    }
                    else
                    {
                        cboSex.SelectedIndex = 1;
                    }
                    txtAddress.Text = row[5].ToString();
                    txtClassOrTrinhDoHV.Text = row[6].ToString();
                    txtOldPassWord.Text = row[7].ToString();        
                }
            }  
            if(vaitro!="sinhvien")
            {
                List<object[]> dataList = new List<object[]>();
                DataTable topicData = bllUsers.PROC_getInfoUser(iduser, 1);
                foreach (DataRow row in topicData.Rows)
                {
                    string tengv = row[0].ToString();
                    string sdt = row[1].ToString();
                    string email = row[2].ToString();
                    string tentrinhdohv = row[3].ToString();
                    string gioitinh = row[4].ToString();
                    string diachi = row[5].ToString();
                    string bm = row[6].ToString();
                    string matkhau = row[7].ToString();
                    dataList.Add(new object[] { tengv, sdt, email,tentrinhdohv, gioitinh, diachi, bm, matkhau });
                }
                label3.Hide();
                txtIDCode.Hide();
                foreach (object[] row in dataList)
                {
                    lblIDSV.Text = iduser;
                    lblName.Text = row[0].ToString();
                    txtSDT.Text = row[1].ToString();
                    txtEmail.Text = row[2].ToString();
                    string chucvu = row[3].ToString().TrimEnd();
                    if(chucvu== "Tiến sĩ") { lblChucVu.Text = "Doctoral";}
                    if (chucvu == "Thạc sĩ") { lblChucVu.Text = "Master"; }
                    if (chucvu == "Phó giáo sư") { lblChucVu.Text = "Ass.Prof"; }
                    if (chucvu == "Giáo sư") { lblChucVu.Text = "Prof"; }
                    if (chucvu == "Thực tập sinh") { lblChucVu.Text = "Trainee"; }
                    if (row[4].ToString() == "False")
                    {
                        cboSex.SelectedIndex = 0;
                    }
                    else
                    {
                        cboSex.SelectedIndex = 1;
                    }
                    txtAddress.Text = row[5].ToString();
                    txtClassOrTrinhDoHV.Text = row[6].ToString();
                    txtOldPassWord.Text = row[7].ToString().TrimEnd();
                }
            }    
        }    
        private void disableBox(int status)
        {
            if (status == 0)
            {
                btnUpdate.Enabled = false;
                lblIDSV.Enabled = false;
                lblName.Enabled = false;
                txtSDT.Enabled = false;
                txtEmail.Enabled = false;
                lblChucVu.Enabled = false;
                txtIDCode.Enabled = false;
                cboSex.Enabled = false;
                txtAddress.Enabled = false;
                txtClassOrTrinhDoHV.Enabled = false;
                txtOldPassWord.Enabled = false;
                txtNewPass.Enabled = false;
                txtRePass.Enabled = false;
            }
            if(status==1)
            {
                btnUpdate.Enabled= true;
                lblIDSV.Enabled = true;
                lblName.Enabled = true;
                txtSDT.Enabled = true;
                txtEmail.Enabled = true;
                lblChucVu.Enabled = true;
                txtIDCode.Enabled = true;
                cboSex.Enabled = true;
                txtAddress.Enabled = true;
                txtClassOrTrinhDoHV.Enabled = true;
                txtOldPassWord.Enabled = false;
                txtNewPass.Enabled = true;
                txtRePass.Enabled = true;
            }    

        }
        private void uc_Manage_User_Load(object sender, EventArgs e)
        {
            fitDataToBox();
        }
        private void pbx_showPass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.PasswordChar == '●')
            {
                pbx_HidePass.BringToFront();
                txtNewPass.PasswordChar = '\0';
            }
        }
        private void pbx_HidePass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.PasswordChar == '\0')
            {
                pbx_showPass.BringToFront();
                txtNewPass.PasswordChar = '●';
            }
        }
        private void btnEditProf_Click(object sender, EventArgs e)
        {
            disableBox(1);
        }
        private bool checkingInf()
        {
            if(txtEmail.Text=="" || txtSDT.Text=="" || txtAddress.Text=="" || txtClassOrTrinhDoHV.Text=="")
            {
                MessageBox.Show("Please fill in the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkingInf())
            {
                if (vaitro == "sinhvien")
                {
                    string manguoidung = iduser;
                    int status = 0;
                    string email = txtEmail.Text;
                    string sdt = txtSDT.Text;
                    string gioitinh = cboSex.SelectedIndex.ToString();
                    int gioitinh1 = int.Parse(gioitinh);
                    string diachi = txtAddress.Text;
                    string malop = txtClassOrTrinhDoHV.Text;
                    string matkhau = txtOldPassWord.Text;
                    string cccd = txtIDCode.Text;
                    DialogResult diag = MessageBox.Show("Are you sure to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (diag == DialogResult.No)
                    {
                        return;
                    }

                    if (bllUsers.UPDATE_InformationUser(manguoidung, status, email, sdt, gioitinh1, diachi, malop, matkhau, cccd))
                    {
                        MessageBox.Show("Update successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fitDataToBox();
                        disableBox(0);
                    }
                    else
                    {
                        MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (vaitro != "sinhvien")
                {

                    string manguoidung = iduser;
                    int status = 1;
                    string email = txtEmail.Text;
                    string sdt = txtSDT.Text;
                    string gioitinh = cboSex.SelectedIndex.ToString();
                    int gioitinh1 = int.Parse(gioitinh);
                    string diachi = txtAddress.Text;
                    string malop = txtClassOrTrinhDoHV.Text;
                    string matkhau = txtOldPassWord.Text;
                    DialogResult diag = MessageBox.Show("Are you sure to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (diag == DialogResult.No)
                    {
                        return;
                    }

                    if (bllUsers.UPDATE_InformationUser(manguoidung, status, email, sdt, gioitinh1, diachi, malop, matkhau, ""))
                    {
                        MessageBox.Show("Update successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNewPass.Text="";
                        txtRePass.Text = "";
                        fitDataToBox();
                        disableBox(0);
                    }
                    else
                    {
                        MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text.ToString().TrimEnd()==txtRePass.Text.ToString().TrimEnd())
            {
                txtOldPassWord.Text = txtNewPass.Text;
            }
            if(txtNewPass.Text=="" || txtRePass.Text=="")
            {
                MessageBox.Show("Please fill in the password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(txtNewPass.ToString().TrimEnd() != txtRePass.ToString().TrimEnd())
            {
                MessageBox.Show("Password is not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
