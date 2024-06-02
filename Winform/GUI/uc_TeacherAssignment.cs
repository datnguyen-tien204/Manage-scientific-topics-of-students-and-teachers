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
    public partial class uc_TeacherAssignment : UserControl
    {
        public string magv { get; set; }
        public uc_TeacherAssignment()
        {
            InitializeComponent();
        }
        
        private System.Windows.Forms.UserControl currentControl;
        private void addUserControl(System.Windows.Forms.UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainers.Controls.Clear();
            pnlContainers.Controls.Add(userControl);
            userControl.BringToFront();

            currentControl = userControl;
        }

        private void pnlContainers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_Teacher_Assign_Notification)))
            {
                // Xoá UserControl hiện tại
                pnlContainers.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_Teacher_Assign_Notification ucProjects = new uc_Teacher_Assign_Notification();
                ucProjects.idgv=magv;
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btnNotification.FillColor = Color.LightGray;
                btn_EnrollConditional.FillColor = Color.White;
                btn_openEnrol.FillColor = Color.White;
            }
        }

        private void uc_TeacherAssignment_Load(object sender, EventArgs e)
        {
            if (getLeader(magv))
            {
                btn_EnrollConditional.Show();
            }
            else
            {
                btn_EnrollConditional.Hide();
            }    
            uc_Teacher_Assign_Notification uAdminMainPage = new uc_Teacher_Assign_Notification();
            uAdminMainPage.idgv = magv;
            addUserControl(uAdminMainPage);
        }
        BLL_Councils bllCouncils = new BLL_Councils();
        private List<object[]> getMaHoiDong(string maGV)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = bllCouncils.PROC_getIDCouncilFromTeacher(maGV);
            foreach (DataRow row in topicData.Rows)
            {
                string maPC = row[0].ToString();
                dataList.Add(new object[] { maPC });
            }
            return dataList;
        }
        private bool getLeader(string idgv)
        {
            List<object[]> dataList = getMaHoiDong(idgv);
            foreach (object[] data in dataList)
            {
                int mahoidong = int.Parse(data[0].ToString());
                DataTable dataLeader = bllCouncils.PROC_getLeaderFromCouncils(mahoidong);
                foreach (DataRow row in dataLeader.Rows)
                {
                    if (row[0].ToString().TrimEnd() == idgv)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;

        }

        private void btn_openEnrol_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_Teacher_GradeTopics)))
            {
                // Xoá UserControl hiện tại
                pnlContainers.Controls.Remove(currentControl);
                currentControl.Dispose();

                if(getLeader(magv))
                {
                    uc_Leader_Councils ucProjects = new uc_Leader_Councils();
                    ucProjects.idgv = magv;
                    addUserControl(ucProjects);
                    currentControl = ucProjects;

                    btnNotification.FillColor = Color.White;
                    btn_EnrollConditional.FillColor = Color.White;
                    btn_openEnrol.FillColor = Color.LightGray;
                }
                else
                {
                    uc_Teacher_GradeTopics ucProjects = new uc_Teacher_GradeTopics();
                    ucProjects.idgv = magv;
                    addUserControl(ucProjects);
                    currentControl = ucProjects;

                    btnNotification.FillColor = Color.White;
                    btn_EnrollConditional.FillColor = Color.White;
                    btn_openEnrol.FillColor = Color.LightGray;
                }

                
            }
        }

        private void btn_EnrollConditional_Click(object sender, EventArgs e)
        {
            if (!currentControl.GetType().Equals(typeof(uc_GradeTotal)))
            {
                // Xoá UserControl hiện tại
                pnlContainers.Controls.Remove(currentControl);
                currentControl.Dispose();

                uc_GradeTotal ucProjects = new uc_GradeTotal();
                ucProjects.idgv = magv;
                addUserControl(ucProjects);
                currentControl = ucProjects;

                btnNotification.FillColor = Color.White;
                btn_EnrollConditional.FillColor = Color.LightGray;
                btn_openEnrol.FillColor = Color.White;
            }
        }
    }
}
