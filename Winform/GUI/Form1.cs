using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }
        BLL_Account_Auth bllManageAccount = new BLL_Account_Auth();
        private void pbx_showPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '●')
            {
                pbx_HidePass.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        bool Authentication(string username, string password,int permision)
        {
            return bllManageAccount.LoginAuthentication(username, password, permision);
        }
        private bool checking()
        {
            if(txtPassword.Text == "" || txtUsername.Text == "")
            {
                return false;
            }
            if(txtPassword.TextLength>=50||txtUsername.TextLength>=15)
            {
                return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(checking() == false)
            {
                MessageBox.Show("Please fill in all the information");
                return;
            }
            string accountID = txtUsername.Text.ToString().TrimEnd();
            string accountPassword = txtPassword.Text.ToString().TrimEnd();


            if(Authentication(accountID,accountPassword,1))
            {
                this.Hide();
                new frm_Management_Main().ShowDialog();

            }
             
            else if(Authentication(accountID, accountPassword, 2))
            {

                this.Hide();
                using (var diagform = new frm_Student_Main())
                {
                    diagform.vaitroLogin = accountID;
                    diagform.idLogin = accountID;
                    diagform.ShowDialog();
                }
                
                
            }
            else if(Authentication(accountID, accountPassword, 3))
            {
                this.Hide();
                using (var diagform = new frm_Student_Main())
                {
                    diagform.vaitroLogin = "sinhvien";
                    diagform.idLogin = accountID;
                    diagform.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Wrong password or username. Please rewrite password or username");
            }
            
           
        }

        private void pbx_HidePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                pbx_showPass.BringToFront();
                txtPassword.PasswordChar = '●';
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        PrivateFontCollection pfc = Custom_config.Init_CustomLabel_Font(1);
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "1218";
            txtUsername.Text = "1218";
            //Custom font
            for(int i=0; i< this.Controls.Count; i++)
            {
                if (this.Controls[i] is Label)
                {
                    this.Controls[i].Font = new Font(pfc.Families[0], this.Controls[i].Font.Size, FontStyle.Regular);
                }
            }
            //End Custom font
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoginFaceID_Click(object sender, EventArgs e)
        {
            var form = new frmLoginWithFID();
            this.Hide();
            form.ShowDialog();
            
        }
    }
}
