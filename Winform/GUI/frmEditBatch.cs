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
    public partial class frmEditBatch : Form
    {
        public frmEditBatch()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        BLL.BLL_Registration bllRegis = new BLL.BLL_Registration();
        private List<object[]> addBatchtoDatalist(int id)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = bllRegis.getBtchInformation_withID(id);
            foreach (DataRow row in topicData.Rows)
            {
                string batchID = row[0].ToString();
                string batchName = row[1].ToString();
                DateTime startTime_ = DateTime.Parse(row[2].ToString());
                string startTime = startTime_.ToString("MM/dd/yyyy");
                DateTime subTime_ = DateTime.Parse(row[3].ToString());
                string submisionTime = subTime_.ToString("MM/dd/yyyy");
                DateTime endTime_ = DateTime.Parse(row[4].ToString());
                string endTime = endTime_.ToString("MM/dd/yyyy");
                string type = row[5].ToString();
                dataList.Add(new object[] {batchID, batchName, startTime, submisionTime, endTime, type});
            }
            return dataList;
        }
        private void disableEdit(DateTime date)
        {
            if (DateTime.Now - date > TimeSpan.FromDays(30))
            {
                txtBatchName.Enabled = false;
                dtpStartDate.Enabled = false;
                dtpSubmisionDeadline.Enabled = false;
                dtpEndDate.Enabled = false;
                cboType.Enabled = false;
                btnConfirm.Enabled = false;
            }
        }
        private void frmEditBatch_Load(object sender, EventArgs e)
        {
            List<object[]> dataList = addBatchtoDatalist(id);

            foreach (object[] row in dataList)
            {
                lblbatchID.Text = row[0].ToString().Trim();
                txtBatchName.Text = row[1].ToString().Trim();
                dtpStartDate.Value = DateTime.Parse(row[2].ToString());
                dtpSubmisionDeadline.Value = DateTime.Parse(row[3].ToString());
                dtpEndDate.Value = DateTime.Parse(row[4].ToString());
                string type = row[5].ToString();
                if (type == "Sinh viên")
                {
                    cboType.SelectedIndex = 1;
                }
                if (type == "Sinh viên+Giáo viên")
                {
                    cboType.SelectedIndex = 2;
                }
                if(type == "Giáo viên")
                {
                    cboType.SelectedIndex = 0;
                }
                disableEdit(dtpStartDate.Value);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult diag= MessageBox.Show("Do you want to cancel?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(diag==DialogResult.Yes)
            {
                this.Close();
            }
        }
        private bool checkInformation()
        {

            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Start Date can't bigger than End Date", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtBatchName.Text == "")
            {
                MessageBox.Show("Batch Name can't be empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpStartDate.Value < DateTime.Now)
            {
                MessageBox.Show("Start Date can't be smaller than current date", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpStartDate.Value == dtpEndDate.Value)
            {
                MessageBox.Show("Start Date can't be equal to End Date", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpStartDate.Value > dtpSubmisionDeadline.Value)
            {
                MessageBox.Show("Start Date can't be bigger than Submision Deadline", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpSubmisionDeadline.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Submision Deadline can't be bigger than End Date", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboType.Text == "")
            {
                MessageBox.Show("Type can't be empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpSubmisionDeadline.Value - dtpStartDate.Value < TimeSpan.FromDays(100))
            {
                MessageBox.Show("Submision Deadline can't be smaller than 70 days from Start Date", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpEndDate.Value - dtpSubmisionDeadline.Value < TimeSpan.FromDays(60))
            {
                MessageBox.Show("Submision Deadline can't be smaller than 60 days from EndDate", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if (checkInformation())
            {
                int index = cboType.SelectedIndex;
                BLL.BLL_Registration bllRegistration = new BLL.BLL_Registration();
                int batchID = int.Parse(lblbatchID.Text);
                try
                {


                    if (index == 0)
                    {
                        if (bllRegis.updateBatch(batchID, txtBatchName.Text, dtpStartDate.Value, dtpSubmisionDeadline.Value, dtpEndDate.Value, "Giáo viên"))
                        {
                            MessageBox.Show("Update new Batch successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update new Batch failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (index == 1)
                    {
                        if (bllRegis.updateBatch(batchID, txtBatchName.Text, dtpStartDate.Value, dtpSubmisionDeadline.Value, dtpEndDate.Value, "Sinh viên"))
                        {
                            MessageBox.Show("Update new Batch successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update new Batch failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (index == 2)
                    {
                        if (bllRegis.updateBatch(batchID,txtBatchName.Text, dtpStartDate.Value, dtpSubmisionDeadline.Value, dtpEndDate.Value, "Sinh viên+Giáo viên"))
                        {
                            MessageBox.Show("Update new Batch successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update new Batch failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch {}
            }
        }

        private void txtBatchName_TextChanged(object sender, EventArgs e)
        {
            if(txtBatchName.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtBatchName.Text, "^[a-zA-Z0-9 ]*$"))
                {
                    MessageBox.Show("Please enter only letters and numbers", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBatchName.Text = "";
                }
            }
            if(txtBatchName.Text.Length > 50)
            {
                MessageBox.Show("Batch Name can't be longer than 50 characters", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBatchName.Text = "";
            }
        }
    }
}
