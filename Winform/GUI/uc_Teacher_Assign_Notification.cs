using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class uc_Teacher_Assign_Notification : UserControl
    {
        public uc_Teacher_Assign_Notification()
        {
            InitializeComponent();
        }

        public string idgv { get; set; }

        //Lấy thông tin dữ liệu về trưởng nhóm bảo vệ
        BLL.BLL_Councils bllCouncils = new BLL.BLL_Councils();
        private List<object[]> addtoDatalist(string maGV)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = bllCouncils.getMaPhanCongtuMaGiaoVien(maGV);
            foreach (DataRow row in topicData.Rows)
            {
                string maPC = row[0].ToString();
                dataList.Add(new object[] {maPC});
            }
            return dataList;
        }

        //Lấy thông tin dữ liệu về các thành viên trong hội đồng
        private List<object[]> addInf_Teacher_to_Datalist(int pc)
        {
            List<object[]> dataList_tc = new List<object[]>();
            DataTable topicData = bllCouncils.getInf_of_LeaderAssign(pc);
            foreach (DataRow row in topicData.Rows)
            {
                string maTV = row[0].ToString();
                string maHd = row[1].ToString();
                string maPC = row[2].ToString();
                dataList_tc.Add(new object[] { maTV,maHd,maPC });
            }
            return dataList_tc;
        }

        //Tạo một dictionary với key là mã hội đồng, value là danh sách mã giáo viên
        private Dictionary<int, List<int>> CreateDictionary(List<object[]> dataList, List<object[]> dataList_tc2)
        {
            Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();

            HashSet<int> uniqueKeys = new HashSet<int>();

            foreach (object[] row in dataList_tc2)
            {
                int key = Convert.ToInt32(row[2]);
                int value = Convert.ToInt32(row[0]);

                uniqueKeys.Add(key);

                if (!dictionary.ContainsKey(key))
                {
                    dictionary[key] = new List<int>();
                }

                dictionary[key].Add(value);
            }
            foreach(var kvp in dictionary)
            {
                Console.WriteLine(kvp.Key);
                foreach(var value in kvp.Value)
                {
                    Console.WriteLine(value);
                }
            }


            // Loại bỏ các key không có trong uniqueKeys
            var keysToRemove = new List<int>();
            foreach (var key in dictionary.Keys)
            {
                if (!uniqueKeys.Contains(key))
                {
                    keysToRemove.Add(key);
                }
            }

            foreach (var key in keysToRemove)
            {
                dictionary.Remove(key);
            }
            return dictionary;
        }

        private List<int> GetMatchedKeys(Dictionary<int, List<int>> dictionary)
        {
            List<int> matchedKeys = new List<int>();

            foreach (var kvp in dictionary)
            {
                int key = kvp.Key;
                List<int> values = kvp.Value;

                if (values.Count > 0 && values[0] == int.Parse(idgv))
                {
                    matchedKeys.Add(key);
                }
            }

            return matchedKeys;
        }



        //Kiểm tra xem giáo viên có phải là trưởng nhóm bảo vệ không

        private List<object[]> isLeader()
        {
            List<object[]> dataList = addtoDatalist(idgv);
            List<object[]> dataList_tc = new List<object[]>();
            foreach (object[] row in dataList)
            {
             
                foreach (object[] row2 in addInf_Teacher_to_Datalist(int.Parse(row[0].ToString())))
                {
                    dataList_tc.Add(row2);

                }
            }
            Dictionary<int, List<int>> resultDict = CreateDictionary(dataList, dataList_tc);

            List<int> matchedKeys = GetMatchedKeys(resultDict);

            // In ra các keys mà giá trị đầu tiên tương ứng trùng với idgv
            List<object[]> maPCisLeader = new List<object[]>();
            foreach (int key in matchedKeys)
            {
                maPCisLeader.Add(new object[] { key });
            }
            return maPCisLeader;
        }

        //Truy vấn danh sách phân công và ấn tiếp nhận

        //Chỉnh image notification
        public void changeImageNotification()
        {
            List<object[]> dataList = isLeader();
            int lenDataList = dataList.Count;
            if (lenDataList == 0)
            {
                pcbNotification.Image = Properties.Resources.not0;
                lblNoti.Text = "You have no assignment";
            }
            if(lenDataList == 1)
            {
                pcbNotification.Image = Properties.Resources.not1;
                lblNoti.Text="You have 1 assignment need to confirm";
            }
            if (lenDataList == 2)
            {
                pcbNotification.Image = Properties.Resources.not2;
                lblNoti.Text = "You have 2 assignment need to confirm";
            }
            if (lenDataList == 3)
            {
                pcbNotification.Image = Properties.Resources.not3;
                lblNoti.Text = "You have 3 assignment need to confirm";
            }
            if (lenDataList == 4)
            {
                pcbNotification.Image = Properties.Resources.not4;
                lblNoti.Text = "You have 4 assignment need to confirm";
            }
            if (lenDataList == 5)
            {
                pcbNotification.Image = Properties.Resources.not5;
                lblNoti.Text = "You have 5 assignment need to confirm";
            }
            if (lenDataList > 5)
            {
                pcbNotification.Image = Properties.Resources.not5_;
                lblNoti.Text = "You have 5+ assignment need to confirm";
            }
        }   
        private void fitDataTocboAssign()
        {
            List<object[]> dataList = isLeader();
            foreach (object[] row in dataList)
            {
                cboAssignmentID.Items.Add(row[0].ToString());
            }
        }
        public bool checkingInf()
        {
            if(lblCouncilID.Text== "You don't have assignment to obtain")
            {
                MessageBox.Show("You don't have assignment to obtain or cancel", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }


        private void uc_Teacher_Assign_Notification_Load(object sender, EventArgs e)
        {
            changeImageNotification();
            fitDataTocboAssign();
            int selectedIndex = 0;
            cboAssignmentID.SelectedIndex = selectedIndex;
        }

        private void cboAssignmentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int maPC = int.Parse(cboAssignmentID.Text);
                DataTable topicData = bllCouncils.getDetailPhanCong(maPC);

                if (topicData.Rows.Count == 0)
                {
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label7.Hide();
                    lblCouncilID.Text = "You don't have assignment to obtain";
                }
                else
                {
                    label3.Show();
                    label4.Show();
                    label5.Show();
                    label7.Show();
                    foreach (DataRow row in topicData.Rows)
                    {
                        lblCouncilID.Text = row[1].ToString();
                        lblTopicID.Text = row[2].ToString();
                        lblTopicName.Text = row[3].ToString();
                        lblInstructorID.Text = row[4].ToString();
                        DateTime date_ = DateTime.Parse(row[5].ToString());
                        string date = date_.ToString("dd/MM/yyyy");
                        lblAssignDate.Text = date;
                    }
                }
            }
            catch 
            {
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label7.Hide();
                lblCouncilID.Text = "You don't have assignment to obtain";
            }

          
        }

        private void btnObtain_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkingInf())
                {
                    DialogResult result = MessageBox.Show("Do you want to obtain this assignment?", "Obtain Assignment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int maPC = int.Parse(cboAssignmentID.Text);
                        bool check = bllCouncils.updateHDBVWhenAccept(maPC, 0);
                        if (check)
                        {
                            MessageBox.Show("Obtain successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            changeImageNotification();
                            cboAssignmentID.Items.Clear();
                            fitDataTocboAssign();
                        }
                        else
                        {
                            MessageBox.Show("Obtain failed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch { }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkingInf())
                {

                    DialogResult dialogResult = MessageBox.Show("Do you want to cancel this assignment?", "Cancel Assignment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int maPC = int.Parse(cboAssignmentID.Text);
                        bool check = bllCouncils.updateHDBVWhenAccept(maPC, 1);
                        if (check)
                        {
                            MessageBox.Show("Cancel successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            changeImageNotification();
                            cboAssignmentID.Items.Clear();
                            fitDataTocboAssign();
                        }
                        else
                        {
                            MessageBox.Show("Cancel failed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch { }
        }
    }
}
