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
    public partial class uc_Manage_Topic_Details : UserControl
    {
        public uc_Manage_Topic_Details()
        {
            InitializeComponent();

            srcollManage(scrlPending, pnlPending);
            srcollManage(scrlApproved, pnlApproved);
            srcollManage(scrlDefendingCompleted, pnlDefendingThesisCompleted);
            srcollManage(scrlWaitingforThesis, pnlWaitingforThesisDefense);
            srcollManage(scrlDefendingThesis, pnlDefendingThesis);
        }
        private void srcollManage(Guna.UI2.WinForms.Guna2VScrollBar scroll, System.Windows.Forms.FlowLayoutPanel pnl)
        {
            scroll.Value = pnl.VerticalScroll.Value;
            scroll.Minimum = pnl.VerticalScroll.Minimum;
            scroll.Maximum = pnl.VerticalScroll.Maximum;
        }
        BLL_Topics topics = new BLL_Topics();
        private void uc_Manage_Topic_Details_Load(object sender, EventArgs e)
        {
            //Load number of topics
            int pending = topics.GetNumberOfTopics(1);
            int approved = topics.GetNumberOfTopics(2);
            int waitingforThesis = topics.GetNumberOfTopics(3);
            int DefendingThesis = topics.GetNumberOfTopics(4);
            int DefendingCompleted = topics.GetNumberOfTopics(5);
            txtPending.Text = $"Pending ({pending.ToString()})";
            txtApproved.Text = $"Approved ({approved.ToString()})";
            txtWaitingForThesisDefense.Text = $"Waiting for thesis defense ({waitingforThesis.ToString()})";
            txtDefendingThesis.Text = $"Defending thesis ({DefendingThesis.ToString()})";
            txtDefendingThesisCompleted.Text = $"Defending thesis completed ({DefendingCompleted.ToString()})";

            //Load topics
            //dgvTest.DataSource=topics.getTopic_NameTopic_andSubject(1);
            activePendingFlowLayout(pnlPending,1);
            activePendingFlowLayout(pnlApproved,2);
            activePendingFlowLayout(pnlWaitingforThesisDefense,3);
            activePendingFlowLayout(pnlDefendingThesis,4);
            activePendingFlowLayout(pnlDefendingThesisCompleted, 5);
        }

        private void guna2TextBox1_Load(object sender, EventArgs e)
        {

        }

        private void scrlPending_Scroll(object sender, ScrollEventArgs e)
        {
            pnlPending.VerticalScroll.Value = scrlPending.Value;
            pnlDefendingThesisCompleted.VerticalScroll.Value = scrlDefendingCompleted.Value;
            pnlDefendingThesis.VerticalScroll.Value = scrlDefendingThesis.Value;
            pnlWaitingforThesisDefense.VerticalScroll.Value = scrlWaitingforThesis.Value;
            pnlApproved.VerticalScroll.Value = scrlApproved.Value;
        }

       
        private void activePendingFlowLayout(System.Windows.Forms.FlowLayoutPanel pnl, int mode)
        {
            DataTable topicData = topics.getTopic_NameTopic_andSubject(mode);
            foreach (DataRow row in topicData.Rows)
            {
                string projectID= row[0].ToString();
                string projectName = row[1].ToString();
                string proj= projectName;
                string projectType = row[3].ToString();
                string projectPerson = row[4].ToString();
                string project_typeOut = "";
                if (projectType == "KHMT")
                {
                    project_typeOut = "#KHMT";
                }
                else if (projectType == "KTPM")
                {
                    project_typeOut = "#KTPM";
                }
                else if (projectType == "CNTT")
                {
                    project_typeOut = "#CNTT";
                }
                try
                {
                    if (projectName.Length > 6)
                    {
                        projectName = projectName.Substring(0, 20) + "...";
                    }
                    if (projectPerson == "Giáo viên")
                    {
                        projectPerson = "#Giáo viên";
                    }
                    else if (projectPerson == "Sinh viên")
                    {
                        projectPerson = "#Sinh viên";
                    }
                }
                catch { }
                Random random = new Random();
                string[] topics = { "#Research", "#Design", "#Prototype" };
                string topic = topics[random.Next(0, topics.Length)];
                pnl.Controls.Add(new GUI_Custom_Topic_Designer(project_typeOut,topic,projectPerson,projectID)
                {
                    Text = projectName,
                    Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = System.Drawing.Color.Black,
                    Location = new System.Drawing.Point(3, 3),
                    Name = "guna2GroupBox1",
                    Size = new System.Drawing.Size(300, 125),
                    LineColor = System.Drawing.Color.White
                });
            }
        }
        private void DisplaySearchResults(DataTable result, int status)
        {
            // Xóa các điều khiển hiện tại trong các panel trước khi thêm kết quả mới
            pnlPending.Controls.Clear();
            pnlApproved.Controls.Clear();
            pnlDefendingThesisCompleted.Controls.Clear();
            pnlWaitingforThesisDefense.Controls.Clear();
            pnlDefendingThesis.Controls.Clear();

            // Gọi phương thức activePendingFlowLayout cho từng panel với chế độ tương ứng
            if (status == 1)
            {
                activePendingFlowLayout(pnlPending, 1);
            }
            else if (status == 2)
            {
                activePendingFlowLayout(pnlApproved, 2);
            }
            else if (status == 3)
            {
                activePendingFlowLayout(pnlWaitingforThesisDefense, 3);
            }
            else if (status == 4)
            {
                activePendingFlowLayout(pnlDefendingThesis, 4);
            }
            else if (status == 5)
            {
                activePendingFlowLayout(pnlDefendingThesisCompleted, 5);
            }
            else
            {
                activePendingFlowLayout(pnlPending, 1);
                activePendingFlowLayout(pnlApproved, 2);
                activePendingFlowLayout(pnlWaitingforThesisDefense, 3);
                activePendingFlowLayout(pnlDefendingThesis, 4);
                activePendingFlowLayout(pnlDefendingThesisCompleted, 5);
            }
        }




        private void pnlPending_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlApproved_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(guna2ComboBox1.SelectedIndex==0)
            {
                var frm=new frmTopicsXport();
                frm.statusid = 0;
                frm.ShowDialog();
            }    
            if(guna2ComboBox1.SelectedIndex == 1)
            {
                var frm = new frmTopicsXport();
                frm.statusid = 1;
                frm.ShowDialog();
            }
            if (guna2ComboBox1.SelectedIndex == 2)
            {
                var frm = new frmTopicsXport();
                frm.statusid = 2;
                frm.ShowDialog();
            }
            if (guna2ComboBox1.SelectedIndex == 3)
            {
                var frm = new frmTopicsXport();
                frm.statusid = 3;
                frm.ShowDialog();
            }
            if (guna2ComboBox1.SelectedIndex == 4)
            {
                var frm = new frmTopicsXport();
                frm.statusid = 4;
                frm.ShowDialog();
            }
            if (guna2ComboBox1.SelectedIndex == 5)
            {
                var frm = new frmTopicsXport();
                frm.statusid = 5;
                frm.ShowDialog();
            }
        }


        private void PerformSearch()
        {
            string searchText = txtSearch.Text.Trim();
            int status = cmbStatus.SelectedIndex; // Lấy chỉ số của trạng thái

            // Nếu chọn "All", đặt status = -1 để tìm kiếm tất cả
            if (status == 0)
            {
                status = -1; // Sử dụng -1 để đại diện cho "All"
            }

            DataTable result = topics.searchTopicsByName(searchText, status);
            DisplaySearchResults(result, status);
        }


        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }
    }
}
