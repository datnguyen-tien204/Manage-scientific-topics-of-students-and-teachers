using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_Management_Main : Form
    {
        public frm_Management_Main()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
        }

        private System.Windows.Forms.UserControl currentControl;
        private void addUserControl(System.Windows.Forms.UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(userControl);
            userControl.BringToFront();

            currentControl = userControl; 
        }
        private void btn_AM_HomePage_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_ManageMainPage)))
            {
                label1.Text="Dashboard";
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_ManageMainPage ucProjects = new uc_ManageMainPage();
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

                btnNotification.ForeColor = Color.White;
                btnNotification.Image = Properties.Resources.icons8_notification_100__2_; //Icon white color
                btnNotification.FillColor = Color.Transparent;


                btnCouncil.ForeColor = Color.White;
                btnCouncil.Image = Properties.Resources.icons8_parliament_100; //Icon white color
                btnCouncil.FillColor = Color.Transparent;

                btnUser.ForeColor = Color.White;
                btnUser.Image = Properties.Resources.icons8_users_settings_64; //Icon white color
                btnUser.FillColor = Color.Transparent;

                btnProject.ForeColor = Color.White;
                btnProject.Image = Properties.Resources.icons8_project_100__1_; //Icon white color
                btnProject.FillColor = Color.Transparent;
            }
        }

        private void frm_Management_Main_Load(object sender, EventArgs e)
        {
            uc_ManageMainPage uMGMainPage = new uc_ManageMainPage();
            addUserControl(uMGMainPage);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(ucManage_Student_Teacher)))
            {
                label1.Text = "User management";
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                ucManage_Student_Teacher ucProjects = new ucManage_Student_Teacher();
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

                btnCouncil.ForeColor = Color.White;
                btnCouncil.Image = Properties.Resources.icons8_parliament_100 ; //Icon white color
                btnCouncil.FillColor = Color.Transparent;

                btnNotification.ForeColor = Color.White;
                btnNotification.Image = Properties.Resources.icons8_notification_100__2_; //Icon white color
                btnNotification.FillColor = Color.Transparent;

                btnSettings.ForeColor = Color.White;
                btnSettings.Image = Properties.Resources.icons8_setting_100; //Icon white color
                btnSettings.FillColor = Color.Transparent;

                btnProject.ForeColor = Color.White;
                btnProject.Image = Properties.Resources.icons8_project_100__1_; //Icon white color
                btnProject.FillColor = Color.Transparent;

                btnDocument.ForeColor = Color.White;
                btnDocument.Image = Properties.Resources.icons8_document_100; //Icon white color
                btnDocument.FillColor = Color.Transparent;
            }
        }
        private void btnProject_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_Manage_Project)))
            {
                label1.Text = "Project management";
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_Manage_Project ucProjects= new uc_Manage_Project();
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

                btnCouncil.ForeColor = Color.White;
                btnCouncil.Image = Properties.Resources.icons8_parliament_100; //Icon white color
                btnCouncil.FillColor = Color.Transparent;

                btnNotification.ForeColor = Color.White;
                btnNotification.Image = Properties.Resources.icons8_notification_100__2_; //Icon white color
                btnNotification.FillColor = Color.Transparent;

                btnSettings.ForeColor = Color.White;
                btnSettings.Image = Properties.Resources.icons8_setting_100; //Icon white color
                btnSettings.FillColor = Color.Transparent;

                btnUser.ForeColor = Color.White;
                btnUser.Image = Properties.Resources.icons8_users_settings_64; //Icon white color
                btnUser.FillColor = Color.Transparent;

                btnDocument.ForeColor = Color.White;
                btnDocument.Image = Properties.Resources.icons8_document_100; //Icon white color
                btnDocument.FillColor = Color.Transparent;
            }
        }
        private void btnDocument_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_Manage_Documents)))
            {
                label1.Text = "Document management";
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_Manage_Documents ucProjects = new uc_Manage_Documents();
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

                btnCouncil.ForeColor = Color.White;
                btnCouncil.Image = Properties.Resources.icons8_parliament_100; //Icon white color
                btnCouncil.FillColor = Color.Transparent;

                btnNotification.ForeColor = Color.White;
                btnNotification.Image = Properties.Resources.icons8_notification_100__2_; //Icon white color
                btnNotification.FillColor = Color.Transparent;

                btnSettings.ForeColor = Color.White;
                btnSettings.Image = Properties.Resources.icons8_setting_100; //Icon white color
                btnSettings.FillColor = Color.Transparent;

                btnUser.ForeColor = Color.White;
                btnUser.Image = Properties.Resources.icons8_users_settings_64; //Icon white color
                btnUser.FillColor = Color.Transparent;

                btnProject.ForeColor = Color.White;
                btnProject.Image = Properties.Resources.icons8_project_100__1_; //Icon white color
                btnProject.FillColor = Color.Transparent;
            }
        }

        private void btnCouncil_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_Manage_Council)))
            {
                label1.Text = "Council management";
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_Manage_Council ucProjects = new uc_Manage_Council();
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btnCouncil.ForeColor = Color.FromArgb(255, 128, 0);
                btnCouncil.Image = Properties.Resources.icons8_parliament_100__1_; //Icon orange color
                btnCouncil.FillColor = Color.White;

                // Button 2: Button need to reset
                btnSettings.ForeColor = Color.White;
                btnSettings.Image = Properties.Resources.icons8_setting_100; //Icon white color
                btnSettings.FillColor = Color.Transparent;

                btn_AM_HomePage.ForeColor = Color.White;
                btn_AM_HomePage.Image = Properties.Resources.icons8_dashboard_layout_48__2_; //Icon white color
                btn_AM_HomePage.FillColor = Color.Transparent;

                btnDocument.ForeColor = Color.White;
                btnDocument.Image = Properties.Resources.icons8_document_100; //Icon white color
                btnDocument.FillColor = Color.Transparent;

                btnNotification.ForeColor = Color.White;
                btnNotification.Image = Properties.Resources.icons8_notification_100__2_; //Icon white color
                btnNotification.FillColor = Color.Transparent;

                btnSettings.ForeColor = Color.White;
                btnSettings.Image = Properties.Resources.icons8_setting_100; //Icon white color
                btnSettings.FillColor = Color.Transparent;

                btnUser.ForeColor = Color.White;
                btnUser.Image = Properties.Resources.icons8_users_settings_64; //Icon white color
                btnUser.FillColor = Color.Transparent;

                btnProject.ForeColor = Color.White;
                btnProject.Image = Properties.Resources.icons8_project_100__1_; //Icon white color
                btnProject.FillColor = Color.Transparent;
            }
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_Manage_Notification)))
            {
                label1.Text = "Notification management";
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_Manage_Notification ucProjects = new uc_Manage_Notification();
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btnNotification.ForeColor = Color.FromArgb(255, 128, 0);
                btnNotification.Image = Properties.Resources.icons8_notification_100__3_; //Icon orange color
                btnNotification.FillColor = Color.White;

                // Button 2: Button need to reset
                btnSettings.ForeColor = Color.White;
                btnSettings.Image = Properties.Resources.icons8_setting_100; //Icon white color
                btnSettings.FillColor = Color.Transparent;

                btn_AM_HomePage.ForeColor = Color.White;
                btn_AM_HomePage.Image = Properties.Resources.icons8_dashboard_layout_48__2_; //Icon white color
                btn_AM_HomePage.FillColor = Color.Transparent;

                btnDocument.ForeColor = Color.White;
                btnDocument.Image = Properties.Resources.icons8_document_100; //Icon white color
                btnDocument.FillColor = Color.Transparent;

                btnCouncil.ForeColor = Color.White;
                btnCouncil.Image = Properties.Resources.icons8_parliament_100; //Icon white color
                btnCouncil.FillColor = Color.Transparent;

                btnCouncil.ForeColor = Color.White;
                btnCouncil.Image = Properties.Resources.icons8_parliament_100; //Icon white color
                btnCouncil.FillColor = Color.Transparent;

                btnUser.ForeColor = Color.White;
                btnUser.Image = Properties.Resources.icons8_users_settings_64; //Icon white color
                btnUser.FillColor = Color.Transparent;

                btnProject.ForeColor = Color.White;
                btnProject.Image = Properties.Resources.icons8_project_100__1_; //Icon white color
                btnProject.FillColor = Color.Transparent;
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

                // Button 2: Button need to reset
                btnCouncil.ForeColor = Color.White;
                btnCouncil.Image = Properties.Resources.icons8_parliament_100; //Icon white color
                btnCouncil.FillColor = Color.Transparent;

                btn_AM_HomePage.ForeColor = Color.White;
                btn_AM_HomePage.Image = Properties.Resources.icons8_dashboard_layout_48__2_; //Icon white color
                btn_AM_HomePage.FillColor = Color.Transparent;

                btnDocument.ForeColor = Color.White;
                btnDocument.Image = Properties.Resources.icons8_document_100; //Icon white color
                btnDocument.FillColor = Color.Transparent;

                btnNotification.ForeColor = Color.White;
                btnNotification.Image = Properties.Resources.icons8_notification_100__2_; //Icon white color
                btnNotification.FillColor = Color.Transparent;

                btnUser.ForeColor = Color.White;
                btnUser.Image = Properties.Resources.icons8_users_settings_64; //Icon white color
                btnUser.FillColor = Color.Transparent;

                btnProject.ForeColor = Color.White;
                btnProject.Image = Properties.Resources.icons8_project_100__1_; //Icon white color
                btnProject.FillColor = Color.Transparent;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
