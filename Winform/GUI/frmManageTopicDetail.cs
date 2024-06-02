using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmManageTopicDetail : Form
    {
        public frmManageTopicDetail()
        {
            InitializeComponent();
        }

        public string id_topic { get; set; }
        BLL_Topics topics = new BLL_Topics();
        private void frmManageTopicDetail_Load(object sender, EventArgs e)
        {
            int id_topic_int = int.Parse(id_topic);
            activeFunction();
        }
        private string[] getIntrustorName(string id)
        {
            DataTable topicData = topics.getInstructor_Details(id);
            string[] rowData = new string[topicData.Columns.Count];

            foreach (DataRow row in topicData.Rows)
            {
                rowData[1] = row[1].ToString();
                rowData[2] = row[5].ToString();
            }
            return rowData;

        }
        private string[] getInforBatch(string id)
        {
            DataTable topicData = topics.getBatchInfo(int.Parse(id));
            string[] rowData = new string[topicData.Columns.Count];

            foreach (DataRow row in topicData.Rows)
            {
                rowData[1] = row[1].ToString();
                rowData[2] = row[2].ToString();
                rowData[3] = row[3].ToString();
                rowData[4] = row[4].ToString();
            }
            return rowData;
        }
        private string[] getStatusInfor(string id)
        {
            DataTable topicData = topics.getStatusInfor(int.Parse(id));
            string[] rowData = new string[topicData.Columns.Count];

            foreach (DataRow row in topicData.Rows)
            {
                rowData[1] = row[1].ToString();
            }
            return rowData;
        }
        public void buttonChangeName()
        {
            if(lblStatus.Text== "Pending")
            {
                btnChangeStatus.Text = "Change approved";
            }    
            if(lblStatus.Text== "Approved")
            {
                btnChangeStatus.Text = "Change waiting for thesis defense";
            }
            if(lblStatus.Text== "Waiting for thesis defense")
            {
                btnChangeStatus.Text = "Defending thesis";
            }
            if(lblStatus.Text== "Defending thesis")
            {
                btnChangeStatus.Text = "Defensing thesis completed";
            }
            if(lblStatus.Text== "Defensing thesis completed")
            {
                btnChangeStatus.Hide();
            }
        }

        private void activeFunction()
        {
            int id_topic_int = int.Parse(id_topic);
            DataTable topicData = topics.getTopic_Details(id_topic_int);
            foreach (DataRow row in topicData.Rows)
            {
                //Topic
                string topicID = row[0].ToString();
                string topicName = row[1].ToString();

                //Instructor
                string instructorID = row[2].ToString().TrimEnd();
                string[] rowData = getIntrustorName(instructorID);
                string instructorName = rowData[1];
                string instructorPN = rowData[2];

                //Batch
                string[] rowBatchData = getInforBatch(row[13].ToString());

                string batchName = rowBatchData[1];


                DateTime batchStart_ = DateTime.Parse(rowBatchData[2].ToString());
                string batchStart= batchStart_.ToString("dd/MM/yyyy");


                DateTime batchDeadline_ = DateTime.Parse(rowBatchData[3].ToString());
                string batchDeadline = batchDeadline_.ToString("dd/MM/yyyy");

                DateTime batchEnd_ = DateTime.Parse(rowBatchData[4].ToString());
                string batchEnd = batchEnd_.ToString("dd/MM/yyyy");

                //Status
                string statusName = row[9].ToString();

                //Expense
                string expense = row[3].ToString();

                //Link
                string link = row[5].ToString();

                //Result
                string result = row[4].ToString();

                lblTopicID.Text = topicID;
                txtTopicName.Text = topicName;
                txtInstructorID.Text = instructorID;
                lblInstructorName.Text = instructorName;
                lblInstructorPN.Text = instructorPN;
                lblBatch.Text = batchName;
                lblStartTime.Text = batchStart;
                lblEndtime.Text = batchEnd;
                lblSubmisionDeadline.Text = batchDeadline;
                lblStatus.Text = statusName;
                txtExpense.Text = expense;
                lblResult.Text = result;

                if(link=="")
                {
                    lblLink.Text = "None";
                }    
                else
                {
                    lblLink.Text = link;
                }    
            }
            buttonChangeName();
            disableFunction();
        }
        public void disableFunction()
        {
            if(lblStatus.Text!= "Pending")
            {
                txtTopicName.Enabled = false;
                txtInstructorID.Enabled = false;
                txtExpense.Enabled = false;
                label14.Hide();
                btnChooseFile.Hide();
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {

        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {

        }
        private void upDateStatusofTopics(int madetai)
        {
            if(lblStatus.Text== "Pending")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to change the status of this topic to approved?", "Change status", MessageBoxButtons.YesNo);
                if(dialogResult==DialogResult.Yes)
                {
                    topics.UPDATE_STaTus_2(madetai);
                    lblStatus.Text = "Approved";
                    buttonChangeName();
                }
            }
            if(lblStatus.Text== "Approved")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to change the status of this topic to waiting for thesis defense?", "Change status", MessageBoxButtons.YesNo);
                if(dialogResult==DialogResult.Yes)
                {
                    topics.updateNewStatus(madetai,3);
                    lblStatus.Text = "Waiting for thesis defense";
                    buttonChangeName();
                }
            }
            if(lblStatus.Text== "Waiting for thesis defense")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to change the status of this topic to defending thesis?", "Change status", MessageBoxButtons.YesNo);
                if(dialogResult==DialogResult.Yes)
                {
                    topics.updateNewStatus(madetai, 4);
                    lblStatus.Text = "Defending thesis";
                    buttonChangeName();
                }
            }
            if(lblStatus.Text== "Defending thesis")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to change the status of this topic to defending thesis completed?", "Change status", MessageBoxButtons.YesNo);
                if(dialogResult==DialogResult.Yes)
                {
                    topics.updateNewStatus(madetai, 5);
                    lblStatus.Text = "Defensing thesis completed";
                    buttonChangeName();
                }
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            upDateStatusofTopics(int.Parse(id_topic));
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            try
            {
                string link = lblLink.Text;
                //Process.Start("microsoft-edge:http://google.com");
                Process.Start("microsoft-edge:" + link);
            }
            catch { }
        }
    }

}
