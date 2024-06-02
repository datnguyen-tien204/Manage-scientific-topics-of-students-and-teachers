using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class uc_GradeTotal : UserControl
    {
        public uc_GradeTotal()
        {
            InitializeComponent();
        }
        public string idgv { get; set; }
        BLL_Councils BLL_Councils = new BLL_Councils();

        //Thêm mã hội đồng vào combobox
        private List<object[]> addtoDatalistIDCouncils(string maGV)
        {
            try
            {
                List<object[]> dataList = new List<object[]>();
                DataTable topicData = BLL_Councils.PROC_getIDCouncil_getIDTopics(maGV, 0, 0);
                foreach (DataRow row in topicData.Rows)
                {
                    string hd = row[0].ToString();
                    dataList.Add(new object[] { hd });
                }
                return dataList;
            }
            catch { return null; }
        }
        private void fitIDCouncilsToCombobox()
        {
            List<object[]> dataList = addtoDatalistIDCouncils(idgv);
            foreach (object[] data in dataList)
            {
                cboChooseCouncils.Items.Add(data[0].ToString());
            }

        }

        //Thêm mã đề tài vào combobox
        private List<object[]> addtoDatalistIDTopics(int mahoidong)
        {
            try
            {
                List<object[]> dataList = new List<object[]>();
                DataTable topicData = BLL_Councils.PROC_getIDCouncil_getIDTopics("0", mahoidong, 1);
                foreach (DataRow row in topicData.Rows)
                {
                    string detai = row[0].ToString();
                    dataList.Add(new object[] { detai });
                }
                return dataList;
            }
            catch { return null; }
        }
        private void fitIDToCombobox(int mahoidong)
        {
            List<object[]> dataList = addtoDatalistIDTopics(mahoidong);         
            foreach (object[] data in dataList)
            {
                cboChooseTopics.Items.Add(data[0].ToString());
            }
            

        }

        //Hiển thị thông tin đề tài
        private List<object[]> getDataToTopics(int madetai, int mahoidong)
        {
            try
            {
                List<object[]> dataListAll = new List<object[]>();
                DataTable data = BLL_Councils.PROC_getInformationForGradeTotal(madetai, mahoidong);
                foreach (DataRow row in data.Rows)
                {
                    string idHoiDong = row[0].ToString();
                    string tenhoidong = row[1].ToString();
                    string iddetai = row[2].ToString();
                    string tendetai = row[3].ToString();
                    string linknopbai = row[4].ToString();
                    string kinhphi = row[5].ToString();
                    string magv = row[6].ToString();
                    string tendot = row[7].ToString();
                    dataListAll.Add(new object[] { idHoiDong, tenhoidong, iddetai, tendetai, linknopbai, kinhphi, magv, tendot });
                }
                return dataListAll;
            }
            catch { return null; }
        }

        private void fitDataToTopics(int madetai, int mahoidong)
        {
            try
            {
                List<object[]> dataList = getDataToTopics(madetai, mahoidong);
                foreach (object[] data in dataList)
                {
                    lblCouncilID.Text = data[0].ToString();
                    lblCouncilName.Text = data[1].ToString();
                    lblTopicID.Text = data[2].ToString();
                    lblTopicName.Text = data[3].ToString();

                    lblExpense.Text = data[5].ToString();
                    lblInstructorID.Text = data[6].ToString();
                    lblBatch.Text = data[7].ToString();
                }
            }
            catch { }
        }

        private void uc_GradeTotal_Load(object sender, EventArgs e)
        {
            fitIDCouncilsToCombobox();
        }

        private void cboChooseCouncils_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboChooseTopics.Items.Clear();
                int madetai = int.Parse(cboChooseCouncils.SelectedItem.ToString().TrimEnd());
                fitIDToCombobox(madetai);
            }
            catch { }
        }
        private void ClearAll()
        {
            txtMark.Text = "";
            txtOpinion.Text = "";
            txtNotes.Text = "";
            lblBatch.Text = "";
            lblCouncilID.Text = "";
            lblCouncilName.Text = "";
            lblExpense.Text = "";
            lblInstructorID.Text = "";
            lblTopicID.Text = "";
            lblTopicName.Text = "";
        }

        private void cboChooseTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
                int madetai = int.Parse(cboChooseTopics.SelectedItem.ToString().TrimEnd());
                int mahoidong = int.Parse(cboChooseCouncils.SelectedItem.ToString().TrimEnd());
                fitDataToTopics(madetai, mahoidong);
            }
            catch { }

        }
        private string getLinkNopBai(int madetai,int mahoidong)
        {
            try
            {
                List<object[]> dataList = getDataToTopics(madetai, mahoidong);
                foreach (object[] data in dataList)
                {
                    string link = data[4].ToString();
                    return link;
                }
                return "";
            }
            catch { return ""; }
        }

        private void linkTopicLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                int madetai = int.Parse(cboChooseTopics.SelectedItem.ToString());
                int mahoidong = int.Parse(cboChooseCouncils.SelectedItem.ToString());
                string link = getLinkNopBai(madetai, mahoidong);

                //Process.Start("microsoft-edge:http://google.com");
                Process.Start("microsoft-edge:" + link);
            }
            catch { }
        }
        // Day thong tin len server
        
        private bool checking()
        {
            if(cboChooseCouncils.Text == "" || cboChooseTopics.Text == "")
            {
                MessageBox.Show("Please choose the council and topic", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(lblCouncilID.Text == "" || lblCouncilName.Text == "" || lblTopicID.Text == "" || lblTopicName.Text == "" || lblExpense.Text == "" || lblInstructorID.Text == "" || lblBatch.Text == "")
            {
                MessageBox.Show("Please choose the council and topic", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtMark.Text == "")
            {
                MessageBox.Show("Please enter the mark before confirm", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(txtOpinion.TextLength>=150)
            {
                MessageBox.Show("Opinion must be less than 150 characters", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            int mark;
            if (!int.TryParse(txtMark.Text, out mark))
            {
                MessageBox.Show("Please enter a valid mark (a number between 0 and 10)", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (mark < 0 || mark > 10)
            {
                MessageBox.Show("The mark must be between 0 and 10", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(txtOpinion.Text == "")
            {
                MessageBox.Show("Please enter the opinion before confirm", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(txtNotes.Text == "")
            {
                MessageBox.Show("Please enter the notes before confirm", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(!ValidateNotes(txtNotes.Text))
            {
                return false;
            }
            return true;
           
        }
        //check html expression
        private bool ValidateNotes(string notes)
        {
            string pattern = @"[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)";
            if (!Regex.IsMatch(notes, pattern))
            {
                MessageBox.Show("Invalid link format. Please enter a valid link format.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(checking())
            {
                DialogResult diag= MessageBox.Show("Are you sure you want to mark this topic?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(diag == DialogResult.Yes)
                {
                    int madetai = int.Parse(cboChooseTopics.SelectedItem.ToString().TrimEnd());
                    int mahoidong = int.Parse(cboChooseCouncils.SelectedItem.ToString().TrimEnd());
                    float mark = float.Parse(txtMark.Text);
                    string opinion = txtOpinion.Text;
                    string notes = txtNotes.Text;
                    if (BLL_Councils.PROC_updateInformation(madetai,mahoidong,mark,opinion,notes))
                    {
                        MessageBox.Show("Mark successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mark failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }    
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Are you sure you want to cancel this topic?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diag == DialogResult.Yes)
            {
                txtMark.Text = "";
                txtOpinion.Text = "";
                txtNotes.Text = "";
            }
        }
    }
}
