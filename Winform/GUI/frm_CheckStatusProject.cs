using BLL;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace GUI
{
    public partial class frm_CheckStatusProject : Form
    {
        public frm_CheckStatusProject()
        {
            InitializeComponent();
        }
        BLL_Topics bll_topics = new BLL_Topics();
        public string idNguoiDung { get; set; }
        public string vaitro { get; set; }
        private void fitDataIDTopicsToCbo(string mathanhvien,int status)
        {
            try
            {
                List<object[]> dataList = new List<object[]>();
                DataTable topicData = bll_topics.getIDTopics(mathanhvien, status);
                foreach (DataRow row in topicData.Rows)
                {
                    string idtopics = row[0].ToString();
                    dataList.Add(new object[] { idtopics });
                }
                foreach (object[] row in dataList)
                {
                    cboTopicID.Items.Add(row[0].ToString());
                }
            }
            catch { }
        }

        private void fitDataTopicsToBox(int madetai,int status)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = bll_topics.getInformationAboutDeTai(madetai,status);
            foreach (DataRow row in topicData.Rows)
            {
                string idtopics = row[0].ToString();
                string tendetai = row[1].ToString();
                string ManguoiHD = row[2].ToString();
                string tendot = row[3].ToString();
                string tentrangthai = row[5].ToString();
                string mahoidong = row[6].ToString();
                string manhom = row[7].ToString();
                string diem = row[8].ToString();
                string danhgia = row[10].ToString();
                dataList.Add(new object[] { idtopics ,tendetai,ManguoiHD,tendot,tentrangthai,mahoidong,manhom,diem,danhgia});
            }
            foreach (object[] row in dataList)
            {
                lblIDTopics.Text = row[0].ToString();
                lblTopicsName.Text= row[1].ToString();
                lblInstructorID.Text= row[2].ToString();
                lblTenDot.Text = row[3].ToString();
                lblTrangThai.Text = row[4].ToString();
                lblCouncilID.Text = row[5].ToString();
                lblMaNhom.Text = row[6].ToString();
                lblDiem.Text = row[7].ToString();
                lblDanhGia.Text = row[8].ToString();  
            }
        }
        
        private void frm_CheckStatusProject_Load(object sender, EventArgs e)
        {
            if(vaitro=="sinhvien")
            {
                fitDataIDTopicsToCbo(idNguoiDung,0);
            }
            if(vaitro!="sinhvien")
            {
                fitDataIDTopicsToCbo(idNguoiDung, 1);
            }
        }

        private void lblDanhGia_Click(object sender, EventArgs e)
        {

        }
        private List<object[]> getLinkTopics(int madetai, int status)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = bll_topics.getInformationAboutDeTai(madetai, status);
            foreach (DataRow row in topicData.Rows)
            {
                string linknopbai = row[4].ToString();
                string minhchung = row[9].ToString();
                dataList.Add(new object[] { linknopbai, minhchung });
            }
            return dataList;
        }

        private void linkTopicLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                if (vaitro == "sinhvien")
                {
                    string link;
                    int madetai = int.Parse(lblIDTopics.Text.ToString().TrimEnd());
                    List<object[]> dataList = getLinkTopics(madetai, 0);
                    foreach (object[] row in dataList)
                    {
                        if (row[0].ToString().TrimEnd() != "")
                        {
                            link = row[0].ToString().TrimEnd();
                            Process.Start("microsoft-edge:" + link);
                        }
                        else
                        {
                            link = "http://google.com";
                            Process.Start("microsoft-edge:" + link);
                        }
                        
                    }                    
                }
                if (vaitro != "sinhvien")
                {
                    string link;
                    int madetai = int.Parse(lblIDTopics.Text.ToString().TrimEnd());
                    List<object[]> dataList = getLinkTopics(madetai, 1);
                    foreach (object[] row in dataList)
                    {
                        if (row[0].ToString().TrimEnd() != "")
                        {
                            link = row[0].ToString().TrimEnd();
                            Process.Start("microsoft-edge:" + link);
                        }
                        else
                        {
                            link = "http://google.com";
                            Process.Start("microsoft-edge:" + link);
                        }
                    }
                }
            }

            catch { }
           
        }

        private void lblEvaLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (vaitro == "sinhvien")
                {
                    string link;
                    int madetai = int.Parse(lblIDTopics.Text.ToString().TrimEnd());
                    List<object[]> dataList = getLinkTopics(madetai, 0);
                    foreach (object[] row in dataList)
                    {
                        if (row[0].ToString().TrimEnd() != "")
                        {
                            link = row[1].ToString().TrimEnd();
                        }
                        else
                        {
                            link = "http://google.com";
                        }
                        Process.Start("microsoft-edge:" + link);
                    }
                }
                if (vaitro != "sinhvien")
                {
                    string link;
                    int madetai = int.Parse(lblIDTopics.Text.ToString().TrimEnd());
                    List<object[]> dataList = getLinkTopics(madetai, 1);
                    foreach (object[] row in dataList)
                    {
                        if (row[0].ToString().TrimEnd() != "")
                        {
                            link = row[1].ToString().TrimEnd();
                        }
                        else
                        {
                            link = "http://google.com";
                        }
                        Process.Start("microsoft-edge:" + link);
                    }
                }
            }

            catch { }
        }

        private void cboTopicID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(vaitro=="sinhvien")
            {
                fitDataTopicsToBox(int.Parse(cboTopicID.Text.ToString().TrimEnd()), 0);
            }
            if(vaitro!="sinhvien")
            {
                fitDataTopicsToBox(int.Parse(cboTopicID.Text.ToString().TrimEnd()), 1);
            }
        }

        private void lblTopicsName_Click(object sender, EventArgs e)
        {

        }
    }
}
