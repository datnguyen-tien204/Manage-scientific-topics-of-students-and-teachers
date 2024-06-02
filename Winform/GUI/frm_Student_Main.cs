using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_Student_Main : Form
    {
        Timer timer;
        int targetWidth = 250;
        Custom_config custom = new Custom_config();
        public frm_Student_Main()
        {
            InitializeComponent();
            InitializeAnimation();
        }

        public string vaitroLogin { get; set; }
        public string idLogin { get; set; }

        private void InitializeAnimation()
        {
            timer = new Timer();
            timer.Interval = 15; 
            timer.Tick += Timer_Tick_Increase;
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
        //Animation for txtSearch
        private void Timer_Tick_Increase(object sender, EventArgs e)
        {
            if (txtSearch.Width < targetWidth)
            {
                txtSearch.Width += 7;
            }
            else
            {
                timer.Stop(); 
            }
        }   
        
        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void picNotification_Click(object sender, EventArgs e)
        {
            timer.Stop();
            txtSearch.Width = 100;
        }
        //End Animation for txtSearch
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        PrivateFontCollection pfc = Custom_config.Init_CustomLabel_Font(2);
        private void frm_Main_Load(object sender, EventArgs e)
        {
            label1.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);

            if(vaitroLogin == "sinhvien")
            {
                btnAssignment.Hide();
            }

            uc_Student_Dashboard uAdminMainPage = new uc_Student_Dashboard();
            uAdminMainPage.idNguoiDung = idLogin;
            uAdminMainPage.vaitro = vaitroLogin;
            addUserControl(uAdminMainPage);
        }
        private UserControl currentControl;
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(userControl);
            userControl.BringToFront();

            currentControl = userControl; // lưu trữ tên UserControl hiện tại
        }
        private void btn_AM_HomePage_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_Student_Dashboard)))
            {
                label1.Text = "Dashboard";
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_Student_Dashboard ucProjects = new uc_Student_Dashboard();
                ucProjects.idNguoiDung = idLogin;
                ucProjects.vaitro = vaitroLogin;
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btn_AM_HomePage.ForeColor = Color.FromArgb(255, 128, 0);
                btn_AM_HomePage.Image = Properties.Resources.icons8_dashboard_layout_48__1_; //Icon orange color
                btn_AM_HomePage.FillColor = Color.White;

                // Button 2: Button need to reset
                btnSettings.ForeColor = Color.White;
                btnSettings.Image = Properties.Resources.icons8_setting_100; //Icon white color
                btnSettings.FillColor = Color.Transparent;

                btnDocument.ForeColor = Color.White;
                btnDocument.Image = Properties.Resources.icons8_document_100; //Icon white color
                btnDocument.FillColor = Color.Transparent;

                btnUser.ForeColor = Color.White;
                btnUser.Image = Properties.Resources.icons8_users_settings_64; //Icon white color
                btnUser.FillColor = Color.Transparent;

                btnProject.ForeColor = Color.White;
                btnProject.Image = Properties.Resources.icons8_project_100__1_; //Icon white color
                btnProject.FillColor = Color.Transparent;

                btnAssignment.ForeColor = Color.White;
                btnAssignment.Image = Properties.Resources.icons8_assignment_50__2_; //Icon white color
                btnAssignment.FillColor = Color.Transparent;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_TeacherStudents_ManageProject)))
            {
                label1.Text = "Project";
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_TeacherStudents_ManageProject ucProjects = new uc_TeacherStudents_ManageProject();
                ucProjects.idLogin = idLogin;
                ucProjects.vaitroLogin = vaitroLogin;
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btnProject.ForeColor = Color.FromArgb(255, 128, 0);
                btnProject.Image = Properties.Resources.icons8_project_80; //Icon orange color
                btnProject.FillColor = Color.White;

                // Button 2: Button need to reset
                btnSettings.ForeColor = Color.White;
                btnSettings.Image = Properties.Resources.icons8_setting_100; //Icon white color
                btnSettings.FillColor = Color.Transparent;

                btn_AM_HomePage.ForeColor = Color.White;
                btn_AM_HomePage.Image = Properties.Resources.icons8_dashboard_layout_48__2_; //Icon white color
                btn_AM_HomePage.FillColor = Color.Transparent;

                btnSettings.ForeColor = Color.White;
                btnSettings.Image = Properties.Resources.icons8_setting_100; //Icon white color
                btnSettings.FillColor = Color.Transparent;

                btnUser.ForeColor = Color.White;
                btnUser.Image = Properties.Resources.icons8_users_settings_64; //Icon white color
                btnUser.FillColor = Color.Transparent;

                btnDocument.ForeColor = Color.White;
                btnDocument.Image = Properties.Resources.icons8_document_100; //Icon white color
                btnDocument.FillColor = Color.Transparent;

                btnAssignment.ForeColor = Color.White;
                btnAssignment.Image = Properties.Resources.icons8_assignment_50__2_; //Icon white color
                btnAssignment.FillColor = Color.Transparent;
            }
        }
        private void btnDocument_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_TeacherStudentDocument)))
            {
                label1.Text = "Document";
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_TeacherStudentDocument ucProjects = new uc_TeacherStudentDocument();
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btnDocument.ForeColor = Color.FromArgb(255, 128, 0);
                btnDocument.Image = Properties.Resources.icons8_document_100__1_; //Icon orange color
                btnDocument.FillColor = Color.White;

                // Button 2: Button need to reset
                btnSettings.ForeColor = Color.White;
                btnSettings.Image = Properties.Resources.icons8_setting_100; //Icon white color
                btnSettings.FillColor = Color.Transparent;

                btn_AM_HomePage.ForeColor = Color.White;
                btn_AM_HomePage.Image = Properties.Resources.icons8_dashboard_layout_48__2_; //Icon white color
                btn_AM_HomePage.FillColor = Color.Transparent;

                btnSettings.ForeColor = Color.White;
                btnSettings.Image = Properties.Resources.icons8_setting_100; //Icon white color
                btnSettings.FillColor = Color.Transparent;

                btnUser.ForeColor = Color.White;
                btnUser.Image = Properties.Resources.icons8_users_settings_64; //Icon white color
                btnUser.FillColor = Color.Transparent;

                btnProject.ForeColor = Color.White;
                btnProject.Image = Properties.Resources.icons8_project_100__1_; //Icon white color
                btnProject.FillColor = Color.Transparent;

                btnAssignment.ForeColor = Color.White;
                btnAssignment.Image = Properties.Resources.icons8_assignment_50__2_; //Icon white color
                btnAssignment.FillColor = Color.Transparent;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_Manage_Settings)))
            {
                label1.Text = "Settings";
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_Manage_Settings ucProjects = new uc_Manage_Settings();
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btnSettings.ForeColor = Color.FromArgb(255, 128, 0);
                btnSettings.Image = Properties.Resources.icons8_setting_100; //Icon orange color
                btnSettings.FillColor = Color.White;

                btn_AM_HomePage.ForeColor = Color.White;
                btn_AM_HomePage.Image = Properties.Resources.icons8_dashboard_layout_48__2_; //Icon white color
                btn_AM_HomePage.FillColor = Color.Transparent;

                btnDocument.ForeColor = Color.White;
                btnDocument.Image = Properties.Resources.icons8_document_100; //Icon white color
                btnDocument.FillColor = Color.Transparent;

                btnUser.ForeColor = Color.White;
                btnUser.Image = Properties.Resources.icons8_users_settings_64; //Icon white color
                btnUser.FillColor = Color.Transparent;

                btnProject.ForeColor = Color.White;
                btnProject.Image = Properties.Resources.icons8_project_100__1_; //Icon white color
                btnProject.FillColor = Color.Transparent;

                btnAssignment.ForeColor = Color.White;
                btnAssignment.Image = Properties.Resources.icons8_assignment_50__2_; //Icon white color
                btnAssignment.FillColor = Color.Transparent;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_Manage_User)))
            {
                label1.Text = "User management";
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_Manage_User ucProjects = new uc_Manage_User();
                ucProjects.iduser = idLogin;
                ucProjects.vaitro = vaitroLogin;
                addUserControl(ucProjects);
                currentControl = ucProjects;


                btnUser.ForeColor = Color.FromArgb(255, 128, 0);
                btnUser.Image = Properties.Resources.icons8_users_settings_64__1_; //Icon orange color
                btnUser.FillColor = Color.White;

                // Button 2: Button need to reset
                btnSettings.ForeColor = Color.White;
                btnSettings.Image = Properties.Resources.icons8_setting_100; //Icon white color
                btnSettings.FillColor = Color.Transparent;

                btn_AM_HomePage.ForeColor = Color.White;
                btn_AM_HomePage.Image = Properties.Resources.icons8_dashboard_layout_48__2_; //Icon white color
                btn_AM_HomePage.FillColor = Color.Transparent;

                btnSettings.ForeColor = Color.White;
                btnSettings.Image = Properties.Resources.icons8_setting_100; //Icon white color
                btnSettings.FillColor = Color.Transparent;

                btnProject.ForeColor = Color.White;
                btnProject.Image = Properties.Resources.icons8_project_100__1_; //Icon white color
                btnProject.FillColor = Color.Transparent;

                btnDocument.ForeColor = Color.White;
                btnDocument.Image = Properties.Resources.icons8_document_100; //Icon white color
                btnDocument.FillColor = Color.Transparent;

                btnAssignment.ForeColor = Color.White;
                btnAssignment.Image = Properties.Resources.icons8_assignment_50__2_; //Icon white color
                btnAssignment.FillColor = Color.Transparent;
            }
        }

        private void btn_AM_HomePage_Click_1(object sender, EventArgs e)
        {

        }

        private void pnl_Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateProj_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_Student_Teacher_CreateNewProject)))
            {
                label1.Text = "Create new project";
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_Student_Teacher_CreateNewProject ucProjects = new uc_Student_Teacher_CreateNewProject();
                ucProjects.vai_tro = vaitroLogin;
                ucProjects.id = idLogin;
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btn_AM_HomePage.ForeColor = Color.FromArgb(255, 128, 0);
                btn_AM_HomePage.Image = Properties.Resources.icons8_dashboard_layout_48__1_; //Icon orange color
                btn_AM_HomePage.FillColor = Color.White;

                // Button 2: Button need to reset
                btnSettings.ForeColor = Color.White;
                btnSettings.Image = Properties.Resources.icons8_setting_100; //Icon white color
                btnSettings.FillColor = Color.Transparent;

                btnDocument.ForeColor = Color.White;
                btnDocument.Image = Properties.Resources.icons8_document_100; //Icon white color
                btnDocument.FillColor = Color.Transparent;

                btnUser.ForeColor = Color.White;
                btnUser.Image = Properties.Resources.icons8_users_settings_64; //Icon white color
                btnUser.FillColor = Color.Transparent;

                btnProject.ForeColor = Color.White;
                btnProject.Image = Properties.Resources.icons8_project_100__1_; //Icon white color
                btnProject.FillColor = Color.Transparent;

                btnAssignment.ForeColor = Color.White;
                btnAssignment.Image = Properties.Resources.icons8_assignment_50__2_; //Icon white color
                btnAssignment.FillColor = Color.Transparent;
            }
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_TeacherAssignment)))
            {
                label1.Text = "Assignment";
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_TeacherAssignment ucProjects = new uc_TeacherAssignment();
                ucProjects.magv = vaitroLogin;
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btnAssignment.ForeColor = Color.FromArgb(255, 128, 0);
                btnAssignment.Image = Properties.Resources.icons8_assignment_50__3_; //Icon orange color
                btnAssignment.FillColor = Color.White;

                // Button 2: Button need to reset
                btnSettings.ForeColor = Color.White;
                btnSettings.Image = Properties.Resources.icons8_setting_100; //Icon white color
                btnSettings.FillColor = Color.Transparent;

                btnDocument.ForeColor = Color.White;
                btnDocument.Image = Properties.Resources.icons8_document_100; //Icon white color
                btnDocument.FillColor = Color.Transparent;

                btnUser.ForeColor = Color.White;
                btnUser.Image = Properties.Resources.icons8_users_settings_64; //Icon white color
                btnUser.FillColor = Color.Transparent;

                btnProject.ForeColor = Color.White;
                btnProject.Image = Properties.Resources.icons8_project_100__1_; //Icon white color
                btnProject.FillColor = Color.Transparent;

                btn_AM_HomePage.ForeColor = Color.White;
                btn_AM_HomePage.Image = Properties.Resources.icons8_dashboard_layout_48__2_; //Icon white color
                btn_AM_HomePage.FillColor = Color.Transparent;
            }
        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }
    }
}
