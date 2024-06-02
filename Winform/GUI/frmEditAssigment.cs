using BLL;
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
    public partial class frmEditAssigment : Form
    {
        public frmEditAssigment()
        {
            InitializeComponent();
        }
        public int idDetai { get; set; }
        BLL_Councils bll_Councils = new BLL_Councils();

        //Lấy thông tin Council ID



        //Lấy thông tin đề tài

        public List<object[]> getAllInf(int madetai)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = bll_Councils.getInforForEditAssignment(madetai);
            foreach (DataRow row in topicData.Rows)
            {
                string mahoidong = row[0].ToString();
                string tenhoidong = row[1].ToString();
                string tenbomon = row[2].ToString();
                if (tenbomon == "KHMT") { tenbomon = "Computer Science"; } else if (tenbomon == "KTPM") { tenbomon = "Software Engineering"; } else { tenbomon = "Infomation Technology"; }
                string tendetai = row[3].ToString();
                string iddetai_ = row[4].ToString();
                DateTime endTime_ = DateTime.Parse(row[5].ToString());
                string ngaythang = endTime_.ToString("MM/dd/yyyy");
                dataList.Add(new object[] {mahoidong,tenhoidong,tenbomon,tendetai,iddetai_,ngaythang});
            }
            return dataList;
        }
        List<int> ints = new List<int>();
        public void addCouncilsToCombobox()
        {
            ints = bll_Councils.GetAllMaHoiDong();
            foreach (int i in ints)
            {
                guna2ComboBox1.Items.Add(i);
            }

        }
        private void fitToDataList(int madetai)
        {
            List<object[]> dataList = getAllInf(madetai);
            foreach (object[] row in dataList)
            {
                guna2ComboBox1.Text = row[0].ToString();
                lblCCName.Text = row[1].ToString();
                lblCCMajor.Text = row[2].ToString();
                lblTopicsName.Text = row[3].ToString();
                lblTopicsID.Text = row[4].ToString();
                dtpAssignDate.Value = DateTime.Parse(row[5].ToString());

                int numtopics = bll_Councils.getCountTopicsDefend(int.Parse(row[0].ToString()));
                lblNumTopicsDef.Text = numtopics.ToString();
            }
        }

        private void frmEditAssigment_Load(object sender, EventArgs e)
        {
            addCouncilsToCombobox();
            fitToDataList(idDetai);

        }
        public List<object[]> ttThanhVienDeTai(int id)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = bll_Councils.getCouncilName(id);
            foreach (DataRow row in topicData.Rows)
            {
                string tenhd = row[0].ToString();
                string mabomon = row[1].ToString();
                if (mabomon == "1") { mabomon = "Computer Science"; } else if (mabomon == "2") { mabomon = "Software Engineering"; } else { mabomon = "Infomation Technology"; }
                dataList.Add(new object[] { tenhd, mabomon });
            }
            return dataList;
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mahoidong = int.Parse(guna2ComboBox1.Text);
            List<object[]> dataList = ttThanhVienDeTai(mahoidong);
            if (dataList.Count == 0)
            {
                lblCCMajor.Text = "";
                lblCCName.Text = "";
                lblNumTopicsDef.Text = "";
            }
            else
            {
                int numtopics = bll_Councils.getCountTopicsDefend(mahoidong);
                lblNumTopicsDef.Text = numtopics.ToString();
                foreach (object[] row in dataList)
                {
                    lblCCName.Text = row[0].ToString();
                    lblCCMajor.Text = row[1].ToString();
                }
            }
        }
        private bool checkingInf()
        {
            if(guna2ComboBox1.Text == "")
            {
                MessageBox.Show("Please choose a council ID");
                return false;
            }
            if(lblCCName.Text == "")
            {
                MessageBox.Show("This council has no information");
                return false;
            }
            if(dtpAssignDate.Value > DateTime.Now)
            {
                MessageBox.Show("Please choose a valid date");
                return false;
            }
            if (lblNumTopicsDef.Text == "5")
            {
                DialogResult diag = MessageBox.Show("This council has already had 5 topics to defend. Please choose other", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (diag == DialogResult.Yes)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(checkingInf())
            {
                DialogResult diag = MessageBox.Show("Are you sure you want to update this topic to this council?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    string madetai = lblTopicsID.Text;
                    string mahoidong = guna2ComboBox1.Text;
                    string ngayphancong = dtpAssignDate.Value.ToString("yyyy-MM-dd");
                    if (diag == DialogResult.Yes)
                    {
                        if (bll_Councils.updateNewInforPhanCong(int.Parse(madetai), int.Parse(mahoidong), ngayphancong))
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Do you want to cancel?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diag == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
