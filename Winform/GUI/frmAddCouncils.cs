using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAddCouncils : Form
    {
        public frmAddCouncils()
        {
            InitializeComponent();
        }
        //0 là insert, 1 là edit
        public int statusEditInsert { get; set; }
        public int idCouncil { get; set; }
        public void disableSys(int status)
        {
            if (status == 0)
            {
                txtID.Hide();
                label1.Hide();
            }
            else
            {
                txtID.Enabled = false;
                txtTruongNhom.Enabled = false;
                label14.Enabled = false;
            }
        }
        BLL.BLL_Councils bllCouncils = new BLL.BLL_Councils();
        BLL.BLL_Registration bllRegis = new BLL.BLL_Registration();
        private bool checkingInformation()
        {
            if(txtTenHD.Text==""||txtDateEtablish.Text==""||cboMajor.Text=="")
            {
                MessageBox.Show("Please fill in all the information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(txtLeader.Text=="" || txtMem1.Text==""||txtTruongNhom.Text=="" ||txtSecretary.Text=="" ||txtMem1.Text=="" ||txtMem2.Text=="")
            {
                MessageBox.Show("Please fill in all the information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void insertnewCouncil()
        {
            if (checkingInformation())
            {
                DialogResult result = MessageBox.Show("Do you want to add this student?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string tenHoiDong = txtTenHD.Text;
                    int major = cboMajor.SelectedIndex;
                    string dateEta = DateTime.Now.ToString("MM/dd/yyyy");
                    string phoNhom = txtLeader.Text;
                    string TruongNhom = txtTruongNhom.Text;
                    string secRettary = txtSecretary.Text;
                    string mem1 = txtMem1.Text;
                    string mem2 = txtMem2.Text;


                    if (bllCouncils.PROC_insertCouncil(tenHoiDong,dateEta,major+1,5))
                    {
                        if(bllCouncils.PROC_insertNewMemberToCouncil(tenHoiDong,phoNhom))
                        {
                            if(bllCouncils.PROC_insertNewMemberToCouncil(tenHoiDong, TruongNhom))
                            {
                                if(bllCouncils.PROC_insertNewMemberToCouncil(tenHoiDong, secRettary))
                                {
                                    if(bllCouncils.PROC_insertNewMemberToCouncil(tenHoiDong, mem1))
                                    {
                                        if(bllCouncils.PROC_insertNewMemberToCouncil(tenHoiDong, mem2))
                                        {
                                            MessageBox.Show("Add new council successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Add new council failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void updateCouncil()
        {
           try
           { 
                if (checkingInformation())
                {
                    DialogResult diag = MessageBox.Show("Do you want to update this councils?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diag == DialogResult.Yes)
                    {
                        int maHoiDong = idCouncil;
                        string tenHoiDong = txtTenHD.Text;
                        int major = cboMajor.SelectedIndex;
                        if (major == 0) { major = 1; } else if (major == 1) { major = 2; } else { major = 3; }
                        string dateEta = txtDateEtablish.Text;
                        string[] parts = dateEta.Split('/');
                        string formattedDate = parts[2] + "/" + parts[1] + "/" + parts[0];



                        string phoNhom = txtLeader.Text;
                        string TruongNhom = txtTruongNhom.Text;
                        string secRettary = txtSecretary.Text;
                        string mem1 = txtMem1.Text;
                        string mem2 = txtMem2.Text;


                        if (bllCouncils.PROC_editCouncil(maHoiDong, tenHoiDong, formattedDate, major, 5))
                        {
                            if (bllCouncils.PROC_updateMemCouncils(maHoiDong, "", 0))
                            {
                                if (bllCouncils.PROC_updateMemCouncils(maHoiDong, TruongNhom, 1))
                                {
                                    if (bllCouncils.PROC_updateMemCouncils(maHoiDong, phoNhom, 1))
                                    {
                                        if (bllCouncils.PROC_updateMemCouncils(maHoiDong, secRettary, 1))
                                        {
                                            if (bllCouncils.PROC_updateMemCouncils(maHoiDong, mem1, 1))
                                            {
                                                if (bllCouncils.PROC_updateMemCouncils(maHoiDong, mem2, 1))
                                                {
                                                    MessageBox.Show("Update council successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                            }
                                        }
                                    }
                                }   
                            }
                        }
                        else
                        {
                            MessageBox.Show("Update council failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }       
                    }
                }
           }
           catch (Exception ex) { }
        }
        private void getInformationMem(string id, int status,System.Windows.Forms.Label label)
        {
            DataTable dt = bllRegis.getInformationMember(id, status);
            foreach (DataRow row in dt.Rows)
            {
                string a = row[1].ToString();
                label.Text=a;
            }

        }



        private void addUserToDataList(int id)
        {
            try
            {
                DataTable teacherData = bllCouncils.PROC_getCouncilList(id, 1);

                foreach (DataRow row in teacherData.Rows)
                {
                    txtID.Text = row[0].ToString();
                    txtTenHD.Text = row[1].ToString();
                    DateTime date_ = DateTime.Parse(row[2].ToString());
                    string date = date_.ToString("dd/MM/yyyy");
                    txtDateEtablish.Text = date;
                    string idBoMon = row[3].ToString();
                    int idBoMon_int = int.Parse(idBoMon);
                    if (idBoMon_int == 1) { cboMajor.SelectedIndex = 0; } else if (idBoMon_int == 2) { cboMajor.SelectedIndex = 1; } else if (idBoMon_int == 3) { cboMajor.SelectedIndex = 2; }
                }
                DataTable memberData = bllCouncils.PROC_getMemCouncils(id);
                foreach (DataRow row1 in memberData.Rows)
                {
                    txtTruongNhom.Text = row1[0].ToString().TrimEnd();
                    getInformationMem(txtTruongNhom.Text, 1, lblLeader);
                    txtLeader.Text = row1[1].ToString().TrimEnd();
                    getInformationMem(txtLeader.Text, 1, lblDept);
                    txtSecretary.Text = row1[2].ToString().TrimEnd();
                    getInformationMem(txtSecretary.Text, 1, lblSecret);
                    txtMem1.Text = row1[3].ToString().TrimEnd();
                    getInformationMem(txtMem1.Text, 1, lblMember1);
                    txtMem2.Text = row1[4].ToString().TrimEnd();
                    getInformationMem(txtMem2.Text, 1, lblMember2);
                }
            }
            catch (Exception ex) { }
        }
        public List<object[]> ttThanhVienDeTai(string id, int status)
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
        private void getGroupInformation(Guna.UI2.WinForms.Guna2TextBox txtInput, System.Windows.Forms.Label labelShow)
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
        private void frmAddCouncils_Load(object sender, EventArgs e)
        {
            if (statusEditInsert == 0)
            {
                disableSys(0);
            }
            else
            {
                disableSys(1);
                addUserToDataList(idCouncil);
            }
        }

        private void txtTruongNhom_TextChanged(object sender, EventArgs e)
        {
            getGroupInformation(txtTruongNhom, lblLeader);
        }

        private void txtLeader_TextChanged(object sender, EventArgs e)
        {
            getGroupInformation(txtLeader, lblDept);
        }

        private void txtSecretary_TextChanged(object sender, EventArgs e)
        {
            getGroupInformation(txtSecretary, lblSecret);
        }

        private void txtMem1_TextChanged(object sender, EventArgs e)
        {
            getGroupInformation(txtMem1, lblMember1);
        }

        private void txtMem2_TextChanged(object sender, EventArgs e)
        {
            getGroupInformation(txtMem2, lblMember2);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(statusEditInsert==1)
            {
                updateCouncil();
            }
            else
            {
                insertnewCouncil();

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
