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
    public partial class uc_Manage_Notification : UserControl
    {
        public uc_Manage_Notification()
        {
            InitializeComponent();
            uc_Manage_Teacher_Notification uAdminMainPage = new uc_Manage_Teacher_Notification();
            addUserControl(uAdminMainPage);
        }
        public string manguoidung { get; set; }
        public string vaitro { get; set; }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

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



        private void btn_TopicManagement_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_Manage_Teacher_Notification)))
            {
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_Manage_Teacher_Notification ucProjects = new uc_Manage_Teacher_Notification();
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btn_TopicManagement.FillColor = Color.LightGray;
                btn_openEnrol.FillColor = Color.White;
            }
        }

        private void btn_openEnrol_Click_1(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_Manage_Student_Notification)))
            {
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_Manage_Student_Notification ucProjects = new uc_Manage_Student_Notification();
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btn_TopicManagement.FillColor = Color.White;
                btn_openEnrol.FillColor = Color.LightGray;
            }
        }

        private void pnl_Container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
