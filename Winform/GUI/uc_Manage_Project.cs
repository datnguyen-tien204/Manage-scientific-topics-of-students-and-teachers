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
    public partial class uc_Manage_Project : UserControl
    {
        public uc_Manage_Project()
        {
            InitializeComponent();
            uc_Manage_Topic_Details uAdminMainPage = new uc_Manage_Topic_Details();
            addUserControl(uAdminMainPage);
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
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
        private void btn_UM_userRanking_Click(object sender, EventArgs e)
        {
            

            if (!currentControl.GetType().Equals(typeof(uc_Manage_Topic_Details)))
            {
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_Manage_Topic_Details ucProjects = new uc_Manage_Topic_Details();
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btn_TopicManagement.FillColor = Color.LightGray;
                btn_allocate_funds.FillColor = Color.White;
                btn_EnrollConditional.FillColor = Color.White;
                btn_openEnrol.FillColor = Color.White;
            }
        }

        private void btn_openEnrol_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_Manage_Details_OpenEnroll)))
            {
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_Manage_Details_OpenEnroll ucProjects = new uc_Manage_Details_OpenEnroll();
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btn_TopicManagement.FillColor = Color.White;
                btn_allocate_funds.FillColor = Color.White;
                btn_EnrollConditional.FillColor = Color.White;
                btn_openEnrol.FillColor = Color.LightGray;
            }
        }

        private void btn_EnrollConditional_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_EnrollCondition)))
            {
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_EnrollCondition ucProjects = new uc_EnrollCondition();
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btn_TopicManagement.FillColor = Color.White;
                btn_allocate_funds.FillColor = Color.White;
                btn_EnrollConditional.FillColor = Color.LightGray;
                btn_openEnrol.FillColor = Color.White;
            }
        }

        private void btn_allocate_funds_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_AllocatedFunds)))
            {
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_AllocatedFunds ucProjects = new uc_AllocatedFunds();
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btn_TopicManagement.FillColor = Color.White;
                btn_allocate_funds.FillColor = Color.LightGray;
                btn_EnrollConditional.FillColor = Color.White;
                btn_openEnrol.FillColor = Color.White;
            }
        }

        private void pnl_Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
