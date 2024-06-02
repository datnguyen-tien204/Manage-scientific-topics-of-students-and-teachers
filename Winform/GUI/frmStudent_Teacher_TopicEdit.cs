using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmStudent_Teacher_TopicEdit : Form
    {
        public frmStudent_Teacher_TopicEdit()
        {
            InitializeComponent();
        }
        public string vaitro { get; set; }
        public string idLogin { get; set; }
        public string idTopic { get; set; }
        public string status { get; set; }
        public int matrangthaimo { get; set; }
        
        BLL.BLL_Registration bllRegis = new BLL.BLL_Registration();
        private List<object[]> trinhDoHocVan(string id)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = bllRegis.getTT_TrinhDoHocVan(id);
            foreach (DataRow row in topicData.Rows)
            {
                string idTeacher = row[0].ToString();
                string nameTeacher = row[1].ToString();
                string SDT = row[5].ToString();
                string idTrinhDoHocVan = row[8].ToString();
                dataList.Add(new object[] { idTeacher, nameTeacher, SDT, idTrinhDoHocVan });
            }
            return dataList;
        }

        private List<object[]> getInformationNeedEdit(int id, int status)
        {
            List<object[]> dataList = new List<object[]>();
            
            DataTable topicData = bllRegis.getInforTopicNeedEdit(id, status);
            foreach (DataRow row in topicData.Rows)
            {
                string idBatch = row[0].ToString();
                string idTopics = row[1].ToString();
                string nameTopics = row[2].ToString();
                string idTeacher = row[3].ToString();
                string expense = row[4].ToString();
                string numberMemer = row[5].ToString();
                string idMembers = row[6].ToString();
                dataList.Add(new object[] { idBatch, idTopics, nameTopics, idTeacher, expense, numberMemer, idMembers});
            }
            return dataList;
        }
        private void getTeacherInformation(string id)
        {
            List<object[]> dataList = trinhDoHocVan(id);
            foreach (object[] row in dataList)
            {
                lblInstructorName.Text = row[1].ToString();
                string trinhDoHocVan = row[3].ToString();
                if (trinhDoHocVan == "1")
                {
                    lblAcaRank.Text = "No";
                    lblDegreeRank.Text = "No";
                }
                if (trinhDoHocVan == "2")
                {
                    lblAcaRank.Text = "No";
                    lblDegreeRank.Text = "Master";
                }
                if (trinhDoHocVan == "3")
                {
                    lblAcaRank.Text = "No";
                    lblDegreeRank.Text = "Doctoral";
                }
                if (trinhDoHocVan == "4")
                {
                    lblAcaRank.Text = "Assoc.Prof";
                    lblDegreeRank.Text = "Doctoral";
                }
                if (trinhDoHocVan == "5")
                {
                    lblAcaRank.Text = "Prof";
                    lblDegreeRank.Text = "Doctoral";
                }
            }
        }
        public void dkGVHD(string vaitro)
        {
            if (vaitro == "sinhvien")
            {
                lblMinimizeAcaRank.Text = "No";
                lblMinizeDegreeRank.Text = "Master";
            }
            if (vaitro != "sinhvien")
            {
                List<object[]> dataList = trinhDoHocVan(vaitro);

                foreach (object[] row in dataList)
                {
                    string maTrinhDoHocVan = row[3].ToString();
                    if (maTrinhDoHocVan == "1")
                    {
                        lblMinimizeAcaRank.Text = "No";
                        lblMinizeDegreeRank.Text = "Master";
                    }
                    if (maTrinhDoHocVan == "2")
                    {
                        lblMinimizeAcaRank.Text = "No";
                        lblMinizeDegreeRank.Text = "Doctoral";
                    }
                    if (maTrinhDoHocVan == "3")
                    {
                        lblMinimizeAcaRank.Text = "Assoc.Prof";
                        lblMinizeDegreeRank.Text = "Doctoral";
                    }
                    if (maTrinhDoHocVan == "4")
                    {
                        lblMinimizeAcaRank.Text = "Prof.";
                        lblMinizeDegreeRank.Text = "Doctoral";
                    }

                }
            }
        }
        private string[] getInformationMem(string id, int status)
        {
            DataTable dt =  bllRegis.getInformationMember(id, status);
            List<string> memberNames = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string a = row[1].ToString();
                memberNames.Add(a);
            }
            return memberNames.ToArray();

        }
        private void showInformation(int id,int status)
        {
            List<object[]> dataList = getInformationNeedEdit(id, status);
            {
                lblBatch.Text = dataList[0][0].ToString();
                lblIDTopic.Text = dataList[0][1].ToString();
                txtNameTopic.Text = dataList[0][2].ToString();
                txtInstructorID.Text = dataList[0][3].ToString().Trim();
                getTeacherInformation(dataList[0][3].ToString().Trim());
                txtExpense.Text = dataList[0][4].ToString();
            }
        }
        private void getNumberMember(int numMem)
        {
            if(numMem==1)
            {
                cboNumMem.SelectedIndex = 0;
                label3.Visible = true;
                txtLead.Visible = true;
                label23.Visible = true;
                lblLeaderName.Visible = true;
            }    
            if(numMem==2)
            {
                cboNumMem.SelectedIndex = 1;
                label3.Visible = true;
                txtLead.Visible = true;
                label23.Visible = true;
                lblLeaderName.Visible = true;
                label9.Visible = true;
                txtMem1.Visible = true;
                label14.Visible = true;
                lblMem1Name.Visible = true;
            }
            if(numMem==3)
            {
                cboNumMem.SelectedIndex = 2;
                label3.Visible = true;
                txtLead.Visible = true;
                label23.Visible = true;
                lblLeaderName.Visible = true;
                label9.Visible = true;
                txtMem1.Visible = true;
                label14.Visible = true;
                lblMem1Name.Visible = true;

                label8.Visible = true;
                txtMem2.Visible = true;
                label15.Visible = true;
                lblMem2Name.Visible = true;
            }
            if(numMem==4)
            {
                cboNumMem.SelectedIndex = 3;
                label3.Visible = true;
                txtLead.Visible = true;
                label23.Visible = true;
                lblLeaderName.Visible = true;
                label9.Visible = true;
                txtMem1.Visible = true;
                label14.Visible = true;
                lblMem1Name.Visible = true;

                label8.Visible = true;
                txtMem2.Visible = true;
                label15.Visible = true;
                lblMem2Name.Visible = true;

                label5.Visible = true;
                txtMem3.Visible = true;
                label22.Visible = true;
                lblMem3name.Visible = true;
            }
            if(numMem==5)
            {
                cboNumMem.SelectedIndex = 4;
                label3.Visible = true;
                txtLead.Visible = true;
                label23.Visible = true;
                lblLeaderName.Visible = true;
                label9.Visible = true;
                txtMem1.Visible = true;
                label14.Visible = true;
                lblMem1Name.Visible = true;

                label8.Visible = true;
                txtMem2.Visible = true;
                label15.Visible = true;
                lblMem2Name.Visible = true;

                label5.Visible = true;
                txtMem3.Visible = true;
                label22.Visible = true;
                lblMem3name.Visible = true;

                label11.Visible = true;
                txtMem4.Visible = true;
                label13.Visible = true;
                lblMem4name.Visible = true;
            }

        }
        private string[] getMemberName(int id, int status)
        {
            List<object[]> dataList = getInformationNeedEdit(id, status);
            List<string> memberNames = new List<string>();

            foreach (object[] row in dataList)
            {
                string a = row[6].ToString();
                memberNames.Add(a);
            }
            return memberNames.ToArray();
        }  
        private void transferMembertoForm(int numMem,int id,int status)
        {
            string[] a = getMemberName(id, status);
            if (numMem==1)
            {
                try
                {
                    txtLead.Text = a[0];
                    string[] b = getInformationMem(a[0], status);
                    lblLeaderName.Text = b[0];
                }
                catch
                {
                   
                }
            }
            if(numMem==2)
            {
                try
                {
                    txtLead.Text = a[0];
                    string[] b = getInformationMem(a[0], status);
                    lblLeaderName.Text = b[0];

                    txtMem1.Text = a[1];
                    string[] c = getInformationMem(a[1], status);
                    lblMem1Name.Text = c[0];
                }
                catch{}
            }
            if(numMem==3)
            {
                try
                {
                    txtLead.Text = a[0];
                    string[] b = getInformationMem(a[0], status);
                    lblLeaderName.Text = b[0];

                    txtMem1.Text = a[1];
                    string[] c = getInformationMem(a[1], status);
                    lblMem1Name.Text = c[0];

                    txtMem2.Text = a[2];
                    string[] d = getInformationMem(a[2], status);
                    lblMem2Name.Text = d[0];
                }
                catch { }
            }
            if(numMem==4)
            {
                try
                {
                    txtLead.Text = a[0];
                    string[] b = getInformationMem(a[0], status);
                    lblLeaderName.Text = b[0];

                    txtMem1.Text = a[1];
                    string[] c = getInformationMem(a[1], status);
                    lblMem1Name.Text = c[0];

                    txtMem2.Text = a[2];
                    string[] d = getInformationMem(a[2], status);
                    lblMem2Name.Text = d[0];

                    txtMem3.Text = a[3];
                    string[] e = getInformationMem(a[3], status);
                    lblMem3name.Text = e[0];
                }
                catch { }
            }
            if(numMem==5)
            {
                try
                {
                    txtLead.Text = a[0];
                    string[] b = getInformationMem(a[0], status);
                    lblLeaderName.Text = b[0];

                    txtMem1.Text = a[1];
                    string[] c = getInformationMem(a[1], status);
                    lblMem1Name.Text = c[0];

                    txtMem2.Text = a[2];
                    string[] d = getInformationMem(a[2], status);
                    lblMem2Name.Text = d[0];

                    txtMem3.Text = a[3];
                    string[] e = getInformationMem(a[3], status);
                    lblMem3name.Text = e[0];

                    txtMem4.Text = a[4];
                    string[] f = getInformationMem(a[4], status);
                    lblMem4name.Text = f[0];
                }
                catch { }
            }
        }
        private int countMember(int id, int status)
        {
            int count = 0;
            List<object[]> dataList = getInformationNeedEdit(id, status);
            foreach (object[] row in dataList)
            {
                string a = row[6].ToString();
                count++;
            }
            return count;
        }
        public void statusChecking(string status)
        {
            if(status=="1")
            {
                txtSubmisstion.Enabled = false;
                btnSubmision.Enabled = false;
            }
            if (status == "2")
            {
                txtNameTopic.Enabled = false;
                txtInstructorID.Enabled = false;
                txtExpense.Enabled = false;
                txtLead.Enabled = false;
                txtMem1.Enabled = false;
                txtMem2.Enabled = false;
                txtMem3.Enabled = false;
                txtMem4.Enabled = false;
                txtSubmisstion.Enabled = true;
                btnSubmision.Enabled = true;
            }
            else if(status == "3" || status=="4" || status=="5")
            {
                txtNameTopic.Enabled = false;
                txtInstructorID.Enabled = false;
                txtExpense.Enabled = false;
                txtLead.Enabled = false;
                txtMem1.Enabled = false;
                txtMem2.Enabled = false;
                txtMem3.Enabled = false;
                txtMem4.Enabled = false;
                txtSubmisstion.Enabled = false;
                btnSubmision.Enabled = false;
            }

        }
        private void isLeaderGroup(int idTopics, int vaitro)
        {
            string[] a = getMemberName(idTopics, vaitro);
            string a1 = a[0].ToString().Trim();
            string a2= idLogin.ToString().Trim();
            
            try
            {
                if (a1!=a2)
                {
                    txtNameTopic.Enabled = false;
                    txtInstructorID.Enabled = false;
                    txtExpense.Enabled = false;
                    txtLead.Enabled = false;
                    txtMem1.Enabled = false;
                    txtMem2.Enabled = false;
                    txtMem3.Enabled = false;
                    txtMem4.Enabled = false;
                    txtSubmisstion.Enabled = false;
                    btnSubmision.Enabled = false;
                    cboNumMem.Enabled = false;
                }
                else
                {
                    txtInstructorID.Enabled = true;
                    txtNameTopic.Enabled = true;
                    txtExpense.Enabled = true;
                    txtLead.Enabled = true;
                    txtMem1.Enabled = true;
                    txtMem2.Enabled = true;
                    txtMem3.Enabled = true;
                    txtMem4.Enabled = true;
                    txtSubmisstion.Enabled = true;
                    btnSubmision.Enabled = true;
                    cboNumMem.Enabled = true;
                }    
            }
            catch { }
        }
        private void instructorConstraint(string idLeads,string idConstructor)
        {
            try
            {
                if(idConstructor==txtMem1.Text || idConstructor==txtMem2.Text || idConstructor == txtMem3.Text || idConstructor == txtMem4.Text)
                {
                    MessageBox.Show("Instructor can't be a member of group!");
                }    
            }   
            catch { }
        }
        private void frmStudent_Teacher_TopicEdit_Load(object sender, EventArgs e)
        {
            
            dkGVHD(vaitro);
            statusChecking(status);
            if (vaitro=="sinhvien")
            {
                int numTopic_int=int.Parse(idTopic);
                int numMem = countMember(numTopic_int, 0);
                getNumberMember(numMem);
                showInformation(numTopic_int, 0);
                isLeaderGroup(numTopic_int, 0);
                transferMembertoForm(numMem, numTopic_int, 0);

            }
            else
            {
                int numTopic_int = int.Parse(idTopic);
                int numMem = countMember(numTopic_int, 1);
                getNumberMember(numMem);
               
                showInformation(numTopic_int, 1);
                transferMembertoForm(numMem, numTopic_int, 1);
                isLeaderGroup(numTopic_int, 1);
            }
            


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void guna2ControlBox4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("All form will no save. Are you sure you want to exit?", "Cancel confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private bool checkHocHamHocVi(string vaitro)
        {
            if (vaitro == "sinhvien")
            {

                if (lblDegreeRank.Text != "No")
                {
                    return true;
                }
                else if (lblAcaRank.Text == "" && lblDegreeRank.Text == "")
                {
                    MessageBox.Show("You must input Teacher ID before");
                    return false;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                List<object[]> dataList = trinhDoHocVan(txtInstructorID.Text);
                foreach (object[] row in dataList)
                {
                    string trinhDoHocVan = row[3].ToString();
                    if (trinhDoHocVan == "1")
                    {
                        if (lblDegreeRank.Text != "No")
                        {
                            return true;
                        }
                        else if (lblAcaRank.Text == "" && lblDegreeRank.Text == "")
                        {
                            MessageBox.Show("You must input Teacher ID before");
                        }
                        else
                        {
                            return false;
                        }
                    }
                    if (trinhDoHocVan == "2")
                    {
                        if ((lblAcaRank.Text != "Master" && lblDegreeRank.Text != "No") && (lblAcaRank.Text != "No" && lblDegreeRank.Text != "No"))
                        {
                            return true;
                        }
                        else if (lblAcaRank.Text == "" && lblDegreeRank.Text == "")
                        {
                            MessageBox.Show("You must input Teacher ID before");
                        }
                        else
                        {
                            return false;
                        }
                    }
                    if (trinhDoHocVan == "3")
                    {
                        if ((lblAcaRank.Text == "Doctoral" && lblDegreeRank.Text == "Assoc.Prof") && (lblAcaRank.Text == "Doctoral" && lblDegreeRank.Text == "Prof"))
                        {
                            return true;
                        }
                        else if (lblAcaRank.Text == "" && lblDegreeRank.Text == "")
                        {
                            MessageBox.Show("You must input Teacher ID before");
                        }
                        else
                        {
                            return false;
                        }
                    }
                    if (trinhDoHocVan == "4")
                    {
                        if ((lblAcaRank.Text == "Doctoral" && lblDegreeRank.Text == "Prof"))
                        {
                            return true;
                        }
                        else if (lblAcaRank.Text == "" && lblDegreeRank.Text == "")
                        {
                            MessageBox.Show("You must input Teacher ID before");
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
        }
        private bool checkingInformation()
        {
            if(lblDegreeRank.Text=="")
            {
                MessageBox.Show("Please enter the correct instructor ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }  
            if(txtNameTopic.Text=="")
            {
                MessageBox.Show("Please enter the topic name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            bool checkingHocHamHocVi = checkHocHamHocVi(vaitro);
            if (checkingHocHamHocVi == false)
            {
                MessageBox.Show("Please check the information of the teacher");
                return false;
            }
            else
            {
                return true;
            }    
        }
        private List<object[]> ttThanhVienDeTai(string id, int status)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = bllRegis.getTT_thanhVien_DeTai(id, status);
            foreach (DataRow row in topicData.Rows)
            {
                string idThanhVien = row[0].ToString();
                string name = row[1].ToString();
                dataList.Add(new object[] { idThanhVien, name });
            }
            return dataList;
        }
        private void getTeacherTextChangedInformation()
        {
            List<object[]> dataList2 = trinhDoHocVan(txtInstructorID.Text.Trim());
            lblAcaRank.Text = "";
            lblDegreeRank.Text = "";
            lblInstructorName.Text = "";
            foreach (object[] row in dataList2)
            {
                lblInstructorName.Text = row[1].ToString();
                string trinhDoHocVan = row[3].ToString().Trim();
                if (trinhDoHocVan.Length > 0)
                {
                    if (trinhDoHocVan == "1")
                    {
                        lblAcaRank.Text = "No";
                        lblDegreeRank.Text = "No";
                    }
                    if (trinhDoHocVan == "2")
                    {
                        lblAcaRank.Text = "No";
                        lblDegreeRank.Text = "Master";
                    }
                    if (trinhDoHocVan == "3")
                    {
                        lblAcaRank.Text = "No";
                        lblDegreeRank.Text = "Doctoral";
                    }
                    if (trinhDoHocVan == "4")
                    {
                        lblAcaRank.Text = "Assoc.Prof";
                        lblDegreeRank.Text = "Doctoral";
                    }
                    if (trinhDoHocVan == "5")
                    {
                        lblAcaRank.Text = "Prof";
                        lblDegreeRank.Text = "Doctoral";
                    }
                } 
                else 
                {
                    lblAcaRank.Text = "";
                    lblDegreeRank.Text = "";
                    lblInstructorName.Text = "";
                }
            }
        }

        private void txtInstructorID_TextChanged(object sender, EventArgs e)
        {
            getTeacherTextChangedInformation();
        }
        private void getGroupInformation(Guna.UI2.WinForms.Guna2TextBox txtInput, System.Windows.Forms.Label labelShow)
        {
            if (vaitro == "sinhvien")
            {
                List<object[]> dataList = ttThanhVienDeTai(txtInput.Text, 1);

                if (dataList.Count == 0)
                {
                    labelShow.Text = "";
                }
                else
                {
                    foreach (object[] row in dataList)
                    {
                        labelShow.Text = row[1].ToString();
                    }
                }
            }
            else
            {
                List<object[]> dataList = ttThanhVienDeTai(txtInput.Text, 2);
                if (dataList.Count == 0)
                {
                    labelShow.Text = "";
                }
                else
                {
                    foreach (object[] row in dataList)
                    {
                        labelShow.Text = row[1].ToString();
                    }
                }
            }
        }

        private void txtMem1_TextChanged(object sender, EventArgs e)
        {
            getGroupInformation(txtMem1, lblMem1Name);
        }

        private void txtMem2_TextChanged(object sender, EventArgs e)
        {
            getGroupInformation(txtMem2, lblMem2Name);
        }

        private void txtMem3_TextChanged(object sender, EventArgs e)
        {
            getGroupInformation(txtMem3, lblMem3name);
        }

        private void txtMem4_TextChanged(object sender, EventArgs e)
        {
            getGroupInformation(txtMem4, lblMem4name);
        }
        

        private void cboNumMem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNumMem.SelectedIndex == 1)
            {
                label3.Visible = true;
                txtLead.Visible = true;
                label23.Visible = true;
                lblLeaderName.Visible = true;
                label9.Visible = true;
                txtMem1.Visible = true;
                label14.Visible = true;
                lblMem1Name.Visible = true;
            }
            if (cboNumMem.SelectedIndex == 2)
            {
                label3.Visible = true;
                txtLead.Visible = true;
                label23.Visible = true;
                lblLeaderName.Visible = true;
                label9.Visible = true;
                txtMem1.Visible = true;
                label14.Visible = true;
                lblMem1Name.Visible = true;

                label8.Visible = true;
                txtMem2.Visible = true;
                label15.Visible = true;
                lblMem2Name.Visible = true;
            }
            if (cboNumMem.SelectedIndex == 3)
            {
                label3.Visible = true;
                txtLead.Visible = true;
                label23.Visible = true;
                lblLeaderName.Visible = true;
                label9.Visible = true;
                txtMem1.Visible = true;
                label14.Visible = true;
                lblMem1Name.Visible = true;

                label8.Visible = true;
                txtMem2.Visible = true;
                label15.Visible = true;
                lblMem2Name.Visible = true;

                label5.Visible = true;
                txtMem3.Visible = true;
                label22.Visible = true;
                lblMem3name.Visible = true;
            }
            if (cboNumMem.SelectedIndex == 4)
            {
                label3.Visible = true;
                txtLead.Visible = true;
                label23.Visible = true;
                lblLeaderName.Visible = true;
                label9.Visible = true;
                txtMem1.Visible = true;
                label14.Visible = true;
                lblMem1Name.Visible = true;

                label8.Visible = true;
                txtMem2.Visible = true;
                label15.Visible = true;
                lblMem2Name.Visible = true;

                label5.Visible = true;
                txtMem3.Visible = true;
                label22.Visible = true;
                lblMem3name.Visible = true;

                label11.Visible = true;
                txtMem4.Visible = true;
                label13.Visible = true;
                lblMem4name.Visible = true;
            }
        }
        bool topicsEdited(string tenDeTai, string idGVHD, string kinhPhi, string linknopbai,int idTopic)
        {
            return bllRegis.updateTopic(tenDeTai, idGVHD, kinhPhi, linknopbai, idTopic);
        }
        private void updateMember(int maDeTai, string maThanhVien, int status,int numMems)
        {
            if (checkIsSame())
            {
                bllRegis.updateMember(maDeTai, maThanhVien, status,numMems);
            }
        }
        private void delforUpdate(int maDeTai, int status)
        {
            bllRegis.deleteforUpdate(maDeTai, status);
        }
        private void insertToDB()
        {
            int numMem=cboNumMem.SelectedIndex+1;
            try
            {
                if (vaitro == "sinhvien")
                {
                    delforUpdate(int.Parse(lblIDTopic.Text), 0);
                    if (numMem == 1)
                    {
                        updateMember(int.Parse(lblIDTopic.Text), txtLead.Text, 0,numMem);
                    }
                    if (numMem == 2)
                    {
                        updateMember(int.Parse(lblIDTopic.Text), txtLead.Text, 0, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem1.Text, 0, numMem);
                    }
                    if (numMem == 3)
                    {
                        updateMember(int.Parse(lblIDTopic.Text), txtLead.Text, 0, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem1.Text, 0, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem2.Text, 0, numMem);
                    }
                    if (numMem == 4)
                    {
                        updateMember(int.Parse(lblIDTopic.Text), txtLead.Text, 0, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem1.Text, 0, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem2.Text, 0, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem3.Text, 0, numMem);
                    }
                    if (numMem == 5)
                    {
                        updateMember(int.Parse(lblIDTopic.Text), txtLead.Text, 0, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem1.Text, 0, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem2.Text, 0, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem3.Text, 0, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem4.Text, 0, numMem);
                    }
                }
                else
                {
                    delforUpdate(int.Parse(lblIDTopic.Text), 1);
                    if (numMem == 1)
                    {
                        updateMember(int.Parse(lblIDTopic.Text), txtLead.Text, 1, numMem);
                    }
                    if (numMem == 2)
                    {
                        updateMember(int.Parse(lblIDTopic.Text), txtLead.Text, 1, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem1.Text, 1, numMem);
                    }
                    if (numMem == 3)
                    {
                        updateMember(int.Parse(lblIDTopic.Text), txtLead.Text, 1, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem1.Text, 1, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem2.Text, 1, numMem);
                    }
                    if (numMem == 4)
                    {
                        updateMember(int.Parse(lblIDTopic.Text), txtLead.Text, 1, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem1.Text, 1, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem2.Text, 1, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem3.Text, 1, numMem);
                    }
                    if (numMem == 5)
                    {
                        updateMember(int.Parse(lblIDTopic.Text), txtLead.Text, 1, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem1.Text, 1, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem2.Text, 1, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem3.Text, 1, numMem);
                        updateMember(int.Parse(lblIDTopic.Text), txtMem4.Text, 1, numMem);
                    }
                }
            }
            catch { }

        }
        private bool checkIsSame()
        {
            int numMem = cboNumMem.SelectedIndex + 1;
            if(numMem==2)
            {
                if(txtLead.Text==txtMem1.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
            }    
            if(numMem==3)
            {
                if(txtLead.Text==txtMem1.Text || txtLead.Text == txtMem2.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
                if(txtMem1.Text==txtMem2.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
            }    
            if(numMem==4)
            {
                if(txtLead.Text==txtMem1.Text || txtLead.Text == txtMem2.Text || txtLead.Text == txtMem3.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
                if(txtMem1.Text==txtMem2.Text || txtMem1.Text == txtMem3.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
                if(txtMem2.Text==txtMem3.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
            }
            if (numMem == 5)
            {
                if (txtLead.Text == txtMem1.Text || txtLead.Text == txtMem2.Text || txtLead.Text == txtMem3.Text || txtLead.Text == txtMem4.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
                if (txtMem1.Text == txtMem2.Text || txtMem1.Text == txtMem3.Text || txtMem1.Text == txtMem4.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
                if (txtMem2.Text == txtMem3.Text || txtMem2.Text == txtMem4.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
                if (txtMem3.Text == txtMem4.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
            }
            return true;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool k=checkingInformation();
            if(k)
            {
                //(tenDeTai, idGVHD, kinhPhi, linknopbai, madetai);
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this topic?", "Update confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string tenDeTai = txtNameTopic.Text;
                    string idGVHD = txtInstructorID.Text;
                    string kinhPhi = txtExpense.Text;
                    string linknopbai = "";
                    int madetai = int.Parse(lblIDTopic.Text);
                    if(topicsEdited(tenDeTai, idGVHD, kinhPhi, linknopbai, madetai))
                    {

                        MessageBox.Show("Update topic successfully!", "Successfully", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update topic failed!", "Failed", MessageBoxButtons.OK);
                    }
                    insertToDB();
                }
            }
            
        }

        private void txtLead_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
