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
    public partial class frmAddBatch : Form
    {
        public frmAddBatch()
        {
            InitializeComponent();
        }
        public string idBatch { get; set; }
        private bool checkInformation()
        {
            if(dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Start Date can't bigger than End Date", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtBatchName.Text == "")
            {
                MessageBox.Show("Batch Name can't be empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(dtpStartDate.Value < DateTime.Now)
            {
                MessageBox.Show("Start Date can't be smaller than current date", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(dtpStartDate.Value == dtpEndDate.Value)
            {
                MessageBox.Show("Start Date can't be equal to End Date", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(dtpStartDate.Value>dtpSubmisionDeadline.Value)
            {
                MessageBox.Show("Start Date can't be bigger than Submision Deadline", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(dtpSubmisionDeadline.Value>dtpEndDate.Value)
            {
                MessageBox.Show("Submision Deadline can't be bigger than End Date", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(cboType.Text=="")
            {
                MessageBox.Show("Type can't be empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }    
            if(dtpSubmisionDeadline.Value-dtpStartDate.Value<TimeSpan.FromDays(100))
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

            if(checkInformation())
            {
                int index = cboType.SelectedIndex;
                BLL.BLL_Registration bllRegistration = new BLL.BLL_Registration();
                if (index == 0)
                {
                    if (bllRegistration.insertnewBatch(txtBatchName.Text, dtpStartDate.Value, dtpSubmisionDeadline.Value, dtpEndDate.Value, "Giáo viên"))
                    {
                        MessageBox.Show("Insert new Batch successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Insert new Batch failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if(index==1)
                {
                    if (bllRegistration.insertnewBatch(txtBatchName.Text, dtpStartDate.Value, dtpSubmisionDeadline.Value, dtpEndDate.Value, "Sinh viên"))
                    {
                        MessageBox.Show("Insert new Batch successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Insert new Batch failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if(index==2)
                {
                    if (bllRegistration.insertnewBatch(txtBatchName.Text, dtpStartDate.Value, dtpSubmisionDeadline.Value, dtpEndDate.Value, "Sinh viên+Giáo viên"))
                    {
                        MessageBox.Show("Insert new Batch successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Insert new Batch failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult diag=MessageBox.Show("Do you want to cancel?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(diag==DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void frmAddBatch_Load(object sender, EventArgs e)
        {

        }
    }
}
