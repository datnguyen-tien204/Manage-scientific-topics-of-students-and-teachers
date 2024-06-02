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
    public partial class frmNewAssignment : Form
    {
        public frmNewAssignment()
        {
            InitializeComponent();
        }
        BLL.BLL_Councils bll_Councils = new BLL.BLL_Councils();
        public int idDetai { get; set; }

        private DataTable pcData = new DataTable();

        //Thông tin đề tài
        public List<object[]> ttThanhVienDeTai(int id)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = bll_Councils.getCouncilName(id);
            foreach (DataRow row in topicData.Rows)
            {
                string tenhd = row[0].ToString();
                string mabomon = row[1].ToString();
                if (mabomon == "1") { mabomon = "KHMT"; } else if (mabomon == "2") { mabomon = "Software Engineering"; } else { mabomon = "Infomation Technology"; }
                dataList.Add(new object[] { tenhd,mabomon });
            }
            return dataList;
        }
        List<int> ints = new List<int>();

        //Đưa thông tin hội đồng vào combobox
        public void addCouncilsToCombobox()
        {
            ints = bll_Councils.GetAllMaHoiDong();
            foreach (int i in ints)
            {
                guna2ComboBox1.Items.Add(i);
            }

        }
        //Đưa thông tin đề tài vào combobox
        public List<object[]> ttDeTai(int id)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = bll_Councils.getTopicsName(id);
            foreach (DataRow row in topicData.Rows)
            {
                string tenhd = row[0].ToString();
                dataList.Add(new object[] { tenhd});
            }
            return dataList;
        }

        private void frmNewAssignment_Load(object sender, EventArgs e)
        {
            lblTopicsID.Text = idDetai.ToString();
            List<object[]> dataList = ttDeTai(idDetai);
            foreach (object[] row in dataList)
            {
                lblTopicsName.Text = row[0].ToString();
            }
            addCouncilsToCombobox();
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
        public bool checkingInf()
        {
            if(guna2ComboBox1.Text == "")
            {
                MessageBox.Show("Please select a council", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(lblCCName.Text == "")
            {
                MessageBox.Show("This council has no information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(lblNumTopicsDef.Text == "5")
            {
                DialogResult diag =MessageBox.Show("This council has already had 5 topics to defend. Please choose other", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(diag == DialogResult.Yes)
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
            if (checkingInf())
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to assign this topic to this council?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int mahoidong = int.Parse(guna2ComboBox1.Text);
                    string ngayphancong = DateTime.Now.ToString("yyyy-MM-dd");
                    int trangthai = 1;
                    if (bll_Councils.PROC_assignFORCouncils(mahoidong, idDetai, ngayphancong, trangthai))
                    {
                        MessageBox.Show("Assign successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Assign failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
