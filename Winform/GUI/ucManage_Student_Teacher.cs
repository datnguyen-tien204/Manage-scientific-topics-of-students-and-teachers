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
    public partial class ucManage_Student_Teacher : UserControl
    {
        public ucManage_Student_Teacher()
        {
            InitializeComponent();
            uc_Teacher_Manage ucTeacher= new uc_Teacher_Manage();
            addUserControl(ucTeacher);
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
            if (!currentControl.GetType().Equals(typeof(uc_Teacher_Manage)))
            {
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_Teacher_Manage ucProjects = new uc_Teacher_Manage();
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btn_TopicManagement.FillColor = Color.LightGray;
                btn_openEnrol.FillColor = Color.White;
            }
        }

        private void btn_openEnrol_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_StudentsManage)))
            {
                // Xoá UserControl hiện tại
                pnl_Container.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_StudentsManage ucProjects = new uc_StudentsManage();
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btn_TopicManagement.FillColor = Color.White;
                btn_openEnrol.FillColor = Color.LightGray;
            }
        }
    }
}
