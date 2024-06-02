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
    public partial class frmEditFunds : Form
    {
        public frmEditFunds()
        {
            InitializeComponent();
        }
        public int topicID { get; set; }
        public string topicName { get; set; }
        public string type { get; set; }
        public string instructorID { get; set; }
        public string expense { get; set; }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult dig= MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dig == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private int PROC_getStatusDeTai(int madetai)
        {
            BLL.BLL_Expense bllExpense = new BLL.BLL_Expense();
            DataTable dt = bllExpense.PROC_getStatusDeTai(madetai);
            foreach (DataRow row in dt.Rows)
            {
                string status = row[0].ToString();
                int statusInt = Convert.ToInt32(status);
                return statusInt;
            }
            return 0;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int status = PROC_getStatusDeTai(Convert.ToInt32(lblTopicID.Text));
                if (status == 3 || status == 4 || status == 5)
                {
                    MessageBox.Show("This topic has been approved or rejected, you can't edit the funds", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtExpense.Text == "")
                    {
                        MessageBox.Show("Please enter the funds", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtExpense.Text, "^[0-9]*$"))
                    {
                        MessageBox.Show("Please enter only numbers", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtExpense.Text = "";
                    }
                    else
                    {
                        BLL.BLL_Expense bllExpense = new BLL.BLL_Expense();
                        if (bllExpense.PROC_updateExpense(Convert.ToInt32(lblTopicID.Text), txtExpense.Text))
                        {
                            MessageBox.Show("Update funds successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update funds failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update funds failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmEditFunds_Load(object sender, EventArgs e)
        {
            lblInstructorID.Text = instructorID;
            lblTopicID.Text = topicID.ToString();
            lblTopicName.Text = topicName;
            lblType.Text = type;
            txtExpense.Text = expense;
        }

        private void txtExpense_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
