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
    public partial class uc_TeacherStudentDocument : UserControl
    {
        public uc_TeacherStudentDocument()
        {
            InitializeComponent();
            uc_Student_Teacher_FindDocument uAdminMainPage = new uc_Student_Teacher_FindDocument();
            addUserControl(uAdminMainPage);
        }
        private System.Windows.Forms.UserControl currentControl;
        private void addUserControl(System.Windows.Forms.UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();

            currentControl = userControl;
        }

        private void btn_SearchDocument_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_Student_Teacher_FindDocument)))
            {
                // Xoá UserControl hiện tại
                pnlContainer.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_Student_Teacher_FindDocument ucProjects = new uc_Student_Teacher_FindDocument();
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btn_SearchDocument.FillColor = Color.LightGray;
                btn_findScholar.FillColor = Color.White;
                btnQuestionWithAI.FillColor = Color.White;

            }
        }

        private void btn_findScholar_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_FindScholar)))
            {
                // Xoá UserControl hiện tại
                pnlContainer.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_FindScholar ucProjects = new uc_FindScholar();
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btn_SearchDocument.FillColor = Color.White;
                btn_findScholar.FillColor = Color.LightGray;
                btnQuestionWithAI.FillColor = Color.White;

            }
        }

        private void btnQuestionWithAI_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_ChatWithAI)))
            {
                // Xoá UserControl hiện tại
                pnlContainer.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_ChatWithAI ucProjects = new uc_ChatWithAI();
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btn_SearchDocument.FillColor = Color.White;
                btn_findScholar.FillColor = Color.White;
                btnQuestionWithAI.FillColor = Color.LightGray;

            }
        }
    }
}
