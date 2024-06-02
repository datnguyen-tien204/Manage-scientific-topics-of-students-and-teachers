using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class uc_Teacher_GradeTopics : UserControl
    {
        public uc_Teacher_GradeTopics()
        {
            InitializeComponent();
        }
        public string idgv { get; set; }
        BLL.BLL_Councils bllCouncils = new BLL.BLL_Councils();


       
        //
        private List<object[]> addtoDatalist(string maGV)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = bllCouncils.getMaPhanCongtuMaGiaoVien(maGV);
            foreach (DataRow row in topicData.Rows)
            {
                string maPC = row[0].ToString();
                dataList.Add(new object[] { maPC });
            }
            return dataList;
        }
        private void fitDataToBox(int maphancong)
        {
            DataTable data = bllCouncils.getFullInfTopics(maphancong,idgv);
            foreach (DataRow row in data.Rows)
            {
                txtOpinion.Text = row[0].ToString();
                txtMark.Text = row[1].ToString();
                txtNotes.Text = row[2].ToString();
            }
        }
        private int getStatus(int maphancong)
        {
            DataTable data = bllCouncils.getFullInfTopics(maphancong,idgv);
            foreach (DataRow row in data.Rows)
            {
                if (row[3].ToString() != "")
                {
                    return int.Parse(row[3].ToString());
                }
                else
                {
                    return -1;
                }    
            }
            return -1;
        }
        private void fitToCombobox()
        {
            List<object[]> dataList = addtoDatalist(idgv);
            foreach (object[] data in dataList)
            {
                cboChooseTopic.Items.Add(data[0].ToString());
            }   

        }
        private void fitTopicToBox(int maphancong)
        {
            DataTable data = bllCouncils.getInfOfTopics(maphancong);
            foreach (DataRow row in data.Rows)
            {
                lblTopicID.Text = row[1].ToString();
                lblTopicName.Text = row[2].ToString();
                lblExpense.Text = row[4].ToString();
                lblInstructorID.Text = row[5].ToString();

            }
        }
        private string getLinkNopBai(int maphancong)
        {
            DataTable data = bllCouncils.getInfOfTopics(maphancong);
            foreach (DataRow row in data.Rows)
            {
                return row[3].ToString();
            }
            return "";
        }
        private void uc_Teacher_GradeTopics_Load(object sender, EventArgs e)
        {
            fitToCombobox();
        }

        private void linkTopicLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string link = getLinkNopBai(int.Parse(cboChooseTopic.SelectedItem.ToString()));
            //Process.Start("microsoft-edge:http://google.com");
            Process.Start("microsoft-edge:" + link);
        }

        private void cboChooseTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maphancong = int.Parse(cboChooseTopic.SelectedItem.ToString());
            fitDataToBox(maphancong);
            fitTopicToBox(maphancong);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int status = getStatus(int.Parse(cboChooseTopic.SelectedItem.ToString()));
                if (status == -1)
                {
                    int maphancong = int.Parse(cboChooseTopic.SelectedItem.ToString());

                    string opinion = txtOpinion.Text;
                    string mark = txtMark.Text;
                    string notes = txtNotes.Text;
                    string magv = idgv;
                    int statusUpdate = 0;
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to mark this topic?", "Update Topic", MessageBoxButtons.YesNo);
                    {
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (bllCouncils.InsertNewYKien(magv, maphancong, opinion, float.Parse(mark), notes, statusUpdate))
                            {
                                MessageBox.Show("Update successfully");
                            }
                            else
                            {
                                MessageBox.Show("Update failed");
                            }
                        }
                    }
                }
                if(status==0)
                {
                    DialogResult dialogResult = MessageBox.Show("This topic has been marked, do you want to update it?", "Update Topic", MessageBoxButtons.YesNo);
                    {
                        if (dialogResult == DialogResult.Yes)
                        {
                            int maphancong = int.Parse(cboChooseTopic.SelectedItem.ToString());

                            string opinion = txtOpinion.Text;
                            string mark = txtMark.Text;
                            string notes = txtNotes.Text;
                            string magv = idgv;
                            if (bllCouncils.updateYKien(magv, opinion, float.Parse(mark), notes))
                            {
                                MessageBox.Show("Update successfully");
                            }
                            else
                            {
                                MessageBox.Show("Update failed");
                            }
                        }
                    }
                }    
            }
            catch { }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset this topic?", "Reset Topic", MessageBoxButtons.YesNo);
            {
                if (dialogResult == DialogResult.Yes)
                {
                    txtOpinion.Text = "";
                    txtMark.Text = "";
                    txtNotes.Text = "";
                    cboChooseTopic.SelectedIndex = -1;
                    lblTopicID.Text = "";
                    lblTopicName.Text = "";
                    lblExpense.Text = "";
                    lblInstructorID.Text = "";
                }
            }
        }
    }
}
