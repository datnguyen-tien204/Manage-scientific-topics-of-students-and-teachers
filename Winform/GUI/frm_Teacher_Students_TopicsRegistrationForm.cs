using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class frm_Teacher_Students_TopicsRegistrationForm : Form
    {
        public frm_Teacher_Students_TopicsRegistrationForm()
        {
            InitializeComponent();
        }
        public string dot_get { get; set; }
        public string vaiTro_get { get; set; }
        public string id_get { get; set; }

        private void cboSoLuongTV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSoLuongTV.SelectedIndex == 0)
            {
                label14.Visible = true;
                txtTruongNhom.Visible = true;
                label19.Visible = true;
                lblTenTruongNhom.Visible = true;

                label18.Visible = false;
                txtTV1.Visible = false;
                label23.Visible = false;
                lblTenTV1.Visible = false;

                label17.Visible = false;
                txtTV2.Visible = false;
                label20.Visible = false;
                lbltenTV2.Visible = false;

                label16.Visible = false;
                txtTV3.Visible = false;
                label21.Visible = false;
                lblTenTV3.Visible = false;

                label15.Visible = false;
                txtTV4.Visible = false;
                label22.Visible = false;
                lblTenTV4.Visible = false;


            }
            if (cboSoLuongTV.SelectedIndex == 1)
            {
                label14.Visible = true;
                txtTruongNhom.Visible = true;
                label19.Visible = true;
                lblTenTruongNhom.Visible = true;

                label18.Visible = true;
                txtTV1.Visible = true;
                label23.Visible = true;
                lblTenTV1.Visible = true;

                label17.Visible = false;
                txtTV2.Visible = false;
                label20.Visible = false;
                lbltenTV2.Visible = false;

                label16.Visible = false;
                txtTV3.Visible = false;
                label21.Visible = false;
                lblTenTV3.Visible = false;

                label15.Visible = false;
                txtTV4.Visible = false;
                label22.Visible = false;
                lblTenTV4.Visible = false;
            }
            if (cboSoLuongTV.SelectedIndex == 2)
            {
                label14.Visible = true;
                txtTruongNhom.Visible = true;
                label19.Visible = true;
                lblTenTruongNhom.Visible = true;

                label18.Visible = true;
                txtTV1.Visible = true;
                label23.Visible = true;
                lblTenTV1.Visible = true;

                label17.Visible = true;
                txtTV2.Visible = true;
                label20.Visible = true;
                lbltenTV2.Visible = true;

                label16.Visible = false;
                txtTV3.Visible = false;
                label21.Visible = false;
                lblTenTV3.Visible = false;

                label15.Visible = false;
                txtTV4.Visible = false;
                label22.Visible = false;
                lblTenTV4.Visible = false;
            }
            if (cboSoLuongTV.SelectedIndex == 3)
            {
                label14.Visible = true;
                txtTruongNhom.Visible = true;
                label19.Visible = true;
                lblTenTruongNhom.Visible = true;

                label18.Visible = true;
                txtTV1.Visible = true;
                label23.Visible = true;
                lblTenTV1.Visible = true;

                label17.Visible = true;
                txtTV2.Visible = true;
                label20.Visible = true;
                lbltenTV2.Visible = true;

                label16.Visible = true;
                txtTV3.Visible = true;
                label21.Visible = true;
                lblTenTV3.Visible = true;

                label15.Visible = false;
                txtTV4.Visible = false;
                label22.Visible = false;
                lblTenTV4.Visible = false;
            }
            if (cboSoLuongTV.SelectedIndex == 4)
            {
                label14.Visible = true;
                txtTruongNhom.Visible = true;
                label19.Visible = true;
                lblTenTruongNhom.Visible = true;

                label18.Visible = true;
                txtTV1.Visible = true;
                label23.Visible = true;
                lblTenTV1.Visible = true;

                label17.Visible = true;
                txtTV2.Visible = true;
                label20.Visible = true;
                lbltenTV2.Visible = true;

                label16.Visible = true;
                txtTV3.Visible = true;
                label21.Visible = true;
                lblTenTV3.Visible = true;

                label15.Visible = true;
                txtTV4.Visible = true;
                label22.Visible = true;
                lblTenTV4.Visible = true;
            }
        }

        private void soLuongTVLoad()
        {
            label14.Visible = true;
            txtTruongNhom.Visible = true;
            label19.Visible = true;
            lblTenTruongNhom.Visible = true;

            label18.Visible = false;
            txtTV1.Visible = false;
            label23.Visible = false;
            lblTenTV1.Visible = false;

            label17.Visible = false;
            txtTV2.Visible = false;
            label20.Visible = false;
            lbltenTV2.Visible = false;

            label16.Visible = false;
            txtTV3.Visible = false;
            label21.Visible = false;
            lblTenTV3.Visible = false;

            label15.Visible = false;
            txtTV4.Visible = false;
            label22.Visible = false;
            lblTenTV4.Visible = false;
        }
        public void dkGVHD(string vaitro)
        {
            if (vaitro == "sinhvien")
            {
                lblHocHamToiThieu.Text = "No";
                lblHocViToiThieu.Text = "Master";
            }
            if (vaitro != "sinhvien")
            {
                List<object[]> dataList = trinhDoHocVan(vaitro);

                foreach (object[] row in dataList)
                {
                    string maTrinhDoHocVan = row[3].ToString();
                    if (maTrinhDoHocVan == "1")
                    {
                        lblHocHamToiThieu.Text = "No";
                        lblHocViToiThieu.Text = "Master";
                    }
                    if (maTrinhDoHocVan == "2")
                    {
                        lblHocHamToiThieu.Text = "No";
                        lblHocViToiThieu.Text = "Doctoral";
                    }
                    if (maTrinhDoHocVan == "3")
                    {
                        lblHocHamToiThieu.Text = "Assoc. Prof";
                        lblHocViToiThieu.Text = "Doctoral";
                    }
                    if (maTrinhDoHocVan == "4")
                    {
                        lblHocHamToiThieu.Text = "Prof. ";
                        lblHocViToiThieu.Text = "Doctoral";
                    }

                }
            }
        }
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

        private void frm_Teacher_Students_TopicsRegistrationForm_Load(object sender, EventArgs e)
        {
            soLuongTVLoad();
            lblDot.Text = dot_get;
            //lblHocHamToiThieu.Text=vaiTro_get;
            dkGVHD(vaiTro_get);
            leaderGroupInformation(id_get);
        }
        private void leaderGroupInformation(string id)
        {
            lblTenTruongNhom.Enabled = false;
            txtTruongNhom.Enabled = false;
            if (vaiTro_get == "sinhvien")
            {
                List<object[]> dataList = ttThanhVienDeTai(id, 1);

                if (dataList.Count == 0)
                {
                    lblTenTruongNhom.Text = "";
                }
                else
                {
                    foreach (object[] row in dataList)
                    {
                        lblTenTruongNhom.Text = row[1].ToString();
                        txtTruongNhom.Text = id.Trim();
                        
                    }
                }
            }
            else
            {
                List<object[]> dataList = ttThanhVienDeTai(id, 2);
                if (dataList.Count == 0)
                {
                    lblTenTruongNhom.Text = "";
                }
                else
                {
                    foreach (object[] row in dataList)
                    {
                        lblTenTruongNhom.Text = row[1].ToString();
                        txtTruongNhom.Text = id.Trim();
                    }
                }
            }
        }
        private void getGroupInformation(Guna.UI2.WinForms.Guna2TextBox txtInput, System.Windows.Forms.Label labelShow)
        {
            if (vaiTro_get == "sinhvien")
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
        private void lblHocHamToiThieu_Click(object sender, EventArgs e)
        {

        }

        private void btnGVHD_search_Click(object sender, EventArgs e)
        {
            if (txtIGVHD.Text == "")
            {
                MessageBox.Show("Please input teacher ID");
            }
            else
            {
                List<object[]> dataList = trinhDoHocVan(txtIGVHD.Text);
                foreach (object[] row in dataList)
                {
                    lblID.Text = row[0].ToString();
                    lblTen.Text = row[1].ToString();
                    lblSDT.Text = row[2].ToString();
                    string trinhDoHocVan = row[3].ToString();
                    if (trinhDoHocVan == "1")
                    {
                        lblHocHam.Text = "No";
                        lblHocVi.Text = "No";
                    }
                    if (trinhDoHocVan == "2")
                    {
                        lblHocHam.Text = "No";
                        lblHocVi.Text = "Master";
                    }
                    if (trinhDoHocVan == "3")
                    {
                        lblHocHam.Text = "No";
                        lblHocVi.Text = "Doctoral";
                    }
                    if (trinhDoHocVan == "4")
                    {
                        lblHocHam.Text = "Assoc. Prof";
                        lblHocVi.Text = "Doctoral";
                    }
                    if (trinhDoHocVan == "5")
                    {
                        lblHocHam.Text = "Prof. ";
                        lblHocVi.Text = "Doctoral";
                    }
                    if (trinhDoHocVan == "")
                    {
                        MessageBox.Show("Teacher ID not found");
                    }
                }
            }
        }

        private void txtTruongNhom_TextChanged(object sender, EventArgs e)
        {
            //getGroupInformation(txtTruongNhom, lblTenTruongNhom);
        }

        private void txtTV1_TextChanged(object sender, EventArgs e)
        {
            getGroupInformation(txtTV1, lblTenTV1);
        }

        private void txtTV2_TextChanged(object sender, EventArgs e)
        {
            getGroupInformation(txtTV2, lbltenTV2);
        }

        private void txtTV3_TextChanged(object sender, EventArgs e)
        {
            getGroupInformation(txtTV3, lblTenTV3);
        }

        private void txtTV4_TextChanged(object sender, EventArgs e)
        {
            getGroupInformation(txtTV4, lblTenTV4);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private bool checkHocHamHocVi(string vaitro)
        {
            if (vaitro == "sinhvien")
            {
                
                if (lblHocVi.Text != "No")
                {
                    return true;
                }
                else if (lblHocHam.Text == "" && lblHocVi.Text == "")
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
                List<object[]> dataList = trinhDoHocVan(txtIGVHD.Text);
                foreach (object[] row in dataList)
                {
                    string trinhDoHocVan = row[3].ToString();
                    if (trinhDoHocVan == "1")
                    {
                        if (lblHocVi.Text != "No")
                        {
                            return true;
                        }
                        else if (lblHocHam.Text == "" && lblHocVi.Text == "")
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
                        if ((lblHocHam.Text != "Master" && lblHocVi.Text != "No") && (lblHocHam.Text != "No" && lblHocVi.Text != "No"))
                        {
                            return true;
                        }
                        else if (lblHocHam.Text == "" && lblHocVi.Text == "")
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
                        if ((lblHocHam.Text == "Doctoral" && lblHocVi.Text == "Phó giáo sư") && (lblHocHam.Text == "Doctoral" && lblHocVi.Text == "Giáo sư"))
                        {
                            return true;
                        }
                        else if (lblHocHam.Text == "" && lblHocVi.Text == "")
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
                        if ((lblHocHam.Text == "Doctoral" && lblHocVi.Text == "Giáo sư"))
                        {
                            return true;
                        }
                        else if (lblHocHam.Text == "" && lblHocVi.Text == "")
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
        private bool checkTVNhom()
        {
            if(cboSoLuongTV.SelectedIndex == 0)
            {
                if(lblTenTruongNhom.Text != ""&&txtTruongNhom.Text!="")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (cboSoLuongTV.SelectedIndex == 1)
            {
                if (lblTenTruongNhom.Text != "" && txtTruongNhom.Text != "" && lblTenTV1.Text != "" && txtTV1.Text != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if(cboSoLuongTV.SelectedIndex == 2)
            {
                if (lblTenTruongNhom.Text != "" && txtTruongNhom.Text != "" && lblTenTV1.Text != "" && txtTV1.Text != "" && lbltenTV2.Text != "" && txtTV2.Text != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if(cboSoLuongTV.SelectedIndex == 3)
            {
                if (lblTenTruongNhom.Text != "" && txtTruongNhom.Text != "" && lblTenTV1.Text != "" && txtTV1.Text != "" && lbltenTV2.Text != "" && txtTV2.Text != "" && lblTenTV3.Text != "" && txtTV3.Text != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if(cboSoLuongTV.SelectedIndex == 4)
            {
                if (lblTenTruongNhom.Text != "" && txtTruongNhom.Text != "" && lblTenTV1.Text != "" && txtTV1.Text != "" && lbltenTV2.Text != "" && txtTV2.Text != "" && lblTenTV3.Text != "" && txtTV3.Text != "" && lblTenTV4.Text != "" && txtTV4.Text != "")
                {
                    return true;
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
        private bool checkingInformation()
        {
            bool checkingHocHamHocVi = checkHocHamHocVi(vaiTro_get);
            bool checkingTVNhom = checkTVNhom();
            if(checkingHocHamHocVi == true && checkingTVNhom == true && txtTenDeTai.Text!="")
            {
                return true;
            }
            if(checkingHocHamHocVi==false )
            {
                MessageBox.Show("Please check the information of the teacher");
                return false;
            }    
            if(checkingTVNhom == false)
            {
                MessageBox.Show("Please check the information of the group");
                return false;
            }
            if(txtTenDeTai.Text == "")
            {
                MessageBox.Show("Please input the topic name");
                return false;
            }
            if(txtTenNhom.Text == "")
            {
                MessageBox.Show("Please input the group name");
                return false;
            }
            else
            {
                return false;
            }
        }
        bool topicsRegistration(string tenDeTai, string idGVHD, int maDotToChuc, string kinhPhi, int matrangthai)
        {
            return bllRegis.topicRegistration(tenDeTai, idGVHD, maDotToChuc, kinhPhi, matrangthai);
        }
        bool groupRegistration(string tenNhom, int soluongTV, string tenDeTai)
        {
            return bllRegis.groupRegistration(tenNhom, soluongTV, tenDeTai);
        }
        bool newMenberRegistration(string tenDeTai, string mathanhviennhom, int isTeacher)
        {
            return bllRegis.newMenberRegistration(tenDeTai, mathanhviennhom, isTeacher);
        }
        private bool checkIsSame()
        {
            int numMem = cboSoLuongTV.SelectedIndex + 1;
            if (numMem == 2)
            {
                if (txtTruongNhom.Text == txtTV1.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
            }
            if (numMem == 3)
            {
                if (txtTruongNhom.Text == txtTV1.Text || txtTruongNhom.Text == txtTV2.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
                if (txtTV1.Text == txtTV2.Text )
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
            }
            if (numMem == 4)
            {
                if (txtTruongNhom.Text == txtTV1.Text || txtTruongNhom.Text == txtTV2.Text || txtTruongNhom.Text == txtTV3.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
                if (txtTV1.Text == txtTV2.Text || txtTV1.Text == txtTV3.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
                if (txtTV2.Text == txtTV3.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
            }
            if (numMem == 5)
            {
                if (txtTruongNhom.Text == txtTV1.Text || txtTruongNhom.Text == txtTV2.Text || txtTruongNhom.Text == txtTV3.Text || txtTruongNhom.Text == txtTV4.Text)
                {
                    MessageBox.Show("The leader of the group cannot be the same as the group member ID");
                    return false;
                }
                if (txtTV1.Text == txtTV2.Text || txtTV1.Text == txtTV3.Text || txtTV1.Text == txtTV4.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
                if (txtTV2.Text == txtTV3.Text || txtTV2.Text == txtTV4.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
                if (txtTV3.Text == txtTV4.Text)
                {
                    MessageBox.Show("Group members cannot be the same ID");
                    return false;
                }
            }
            return true;
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if(txtTenDeTai.Text == "" || txtIGVHD.Text=="")
            {
                MessageBox.Show("Please fill in all the information");
            }
            else
            {
                bool check=checkingInformation();
                if (check)
                {   
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to register?", "Register", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string tenDeTai = txtTenDeTai.Text;
                        string idGVHD = txtIGVHD.Text;
                        string kinhPhi= txtKinhPhi.Text;
                        if(kinhPhi=="")
                        {
                            kinhPhi = "0";
                        }

                        int maDTC = int.Parse(dot_get);
                        string soLuongTV = cboSoLuongTV.Text;
                        int soluongTV_int = int.Parse(soLuongTV);
                        string tenNhom = txtTenNhom.Text;
                        string truongNhom = txtTruongNhom.Text;
                        string tv1 = txtTV1.Text;
                        string tv2 = txtTV2.Text;
                        string tv3 = txtTV3.Text;
                        string tv4 = txtTV4.Text;

                        try
                        {
                            if (checkIsSame())
                            {
                                if (topicsRegistration(tenDeTai, idGVHD, maDTC, kinhPhi, 1))
                                {
                                    if (groupRegistration(tenNhom, soluongTV_int, tenDeTai))
                                    {
                                        if (vaiTro_get != "sinhvien")
                                        {
                                            try
                                            {
                                                if (soluongTV_int == 1)
                                                {
                                                    newMenberRegistration(tenDeTai, truongNhom, 1);
                                                    MessageBox.Show("Registration successful");
                                                }
                                                if (soluongTV_int == 2)
                                                {
                                                    newMenberRegistration(tenDeTai, truongNhom, 1);
                                                    newMenberRegistration(tenDeTai, tv1, 1);
                                                    MessageBox.Show("Registration successful");
                                                }
                                                if (soluongTV_int == 3)
                                                {
                                                    newMenberRegistration(tenDeTai, truongNhom, 1);
                                                    newMenberRegistration(tenDeTai, tv1, 1);
                                                    newMenberRegistration(tenDeTai, tv2, 1);
                                                    MessageBox.Show("Registration successful");
                                                }
                                                if (soluongTV_int == 4)
                                                {
                                                    newMenberRegistration(tenDeTai, truongNhom, 1);
                                                    newMenberRegistration(tenDeTai, tv1, 1);
                                                    newMenberRegistration(tenDeTai, tv2, 1);
                                                    newMenberRegistration(tenDeTai, tv3, 1);
                                                    MessageBox.Show("Registration successful");
                                                }
                                                if (soluongTV_int == 5)
                                                {
                                                    newMenberRegistration(tenDeTai, truongNhom, 1);
                                                    newMenberRegistration(tenDeTai, tv1, 1);
                                                    newMenberRegistration(tenDeTai, tv2, 1);
                                                    newMenberRegistration(tenDeTai, tv3, 1);
                                                    newMenberRegistration(tenDeTai, tv4, 1);
                                                    MessageBox.Show("Registration successful");
                                                }
                                            }
                                            catch
                                            {
                                                MessageBox.Show("Error");
                                            }
                                        }
                                        else
                                        {
                                            try
                                            {
                                                if (soluongTV_int == 1)
                                                {
                                                    newMenberRegistration(tenDeTai, truongNhom, 0);
                                                    MessageBox.Show("Registration successful");
                                                }
                                                if (soluongTV_int == 2)
                                                {
                                                    newMenberRegistration(tenDeTai, truongNhom, 0);
                                                    newMenberRegistration(tenDeTai, tv1, 0);
                                                    MessageBox.Show("Registration successful");
                                                }
                                                if (soluongTV_int == 3)
                                                {
                                                    newMenberRegistration(tenDeTai, truongNhom, 0);
                                                    newMenberRegistration(tenDeTai, tv1, 0);
                                                    newMenberRegistration(tenDeTai, tv2, 0);
                                                    MessageBox.Show("Registration successful");
                                                }
                                                if (soluongTV_int == 4)
                                                {
                                                    newMenberRegistration(tenDeTai, truongNhom, 0);
                                                    newMenberRegistration(tenDeTai, tv1, 0);
                                                    newMenberRegistration(tenDeTai, tv2, 0);
                                                    newMenberRegistration(tenDeTai, tv3, 0);
                                                    MessageBox.Show("Registration successful");
                                                }
                                                if (soluongTV_int == 5)
                                                {
                                                    newMenberRegistration(tenDeTai, truongNhom, 0);
                                                    newMenberRegistration(tenDeTai, tv1, 0);
                                                    newMenberRegistration(tenDeTai, tv2, 0);
                                                    newMenberRegistration(tenDeTai, tv3, 0);
                                                    newMenberRegistration(tenDeTai, tv4, 0);
                                                    MessageBox.Show("Registration successful");
                                                }
                                            }
                                            catch
                                            {
                                                MessageBox.Show("Error");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch
                        {
                        }
                    }                  
                }
                else
                {

                }
            }
        }
    }
}
