using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmEditAndNewDocument : Form
    {
        public frmEditAndNewDocument()
        {
            InitializeComponent();
        }
        public string docID { get; set; }
        public int status { get; set; }
        private List<object[]> dataList;
        private List<object[]> filteredDataList;
        private DataTable teacherData = new DataTable();
        BLL_Search bllSearch = new BLL_Search();
        private void addUserToDataList(int docID_get)
        {
            List<object[]> dataList = new List<object[]>();

            teacherData = bllSearch.PROC_getAllInfDocumentbyID(docID_get);
            foreach (DataRow row in teacherData.Rows)
            {
                string STT = row[0].ToString();
                string docID = row[2].ToString();
                string docName = row[1].ToString();
                string docLink = row[3].ToString();
                string facultName = row[4].ToString();
                string APA = row[5].ToString();
                string MLA = row[6].ToString();
                string BibTex = row[7].ToString();
                dataList.Add(new object[] { STT, docID, docName, docLink, facultName, APA, MLA, BibTex });
            }
            foreach (object[] row in dataList)
            {
                lblDocID.Text = row[2].ToString();
                txtDocName.Text = row[1].ToString().TrimEnd();
                txtDocLink.Text = row[3].ToString().TrimEnd();
                string faculty = row[4].ToString().TrimEnd();
                if(faculty== "Computer Science") { cboSubject.SelectedIndex=0; }
                if(faculty == "Software Engineering") { cboSubject.SelectedIndex = 1; }
                if (faculty == "Information Technology") { cboSubject.SelectedIndex = 2; }
                txtAPA.Text = row[5].ToString().TrimEnd();
                txtMLA.Text = row[6].ToString().TrimEnd();
                txtBibTeX.Text = row[7].ToString().TrimEnd();
            }
        }
        

        private bool checking()
        {
            string pattern = @"https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)";
            Regex regex = new Regex(pattern);
            if (string.IsNullOrEmpty(txtDocName.Text) ||string.IsNullOrEmpty(txtDocLink.Text) ||string.IsNullOrEmpty(txtAPA.Text) ||string.IsNullOrEmpty(txtMLA.Text) ||string.IsNullOrEmpty(txtBibTeX.Text))
            {
                return false;
            }
            if (!regex.IsMatch(txtDocLink.Text))
            {
                return false;
            }
            return true;
        }    

        private void frmEditAndNewDocument_Load(object sender, EventArgs e)
        {
            if(status==1)
            {
                addUserToDataList(int.Parse(docID));
            }
            if(status==0)
            {
                lblDocID.Hide();
            }    
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(status==1)
            {
                if (checking())
                {
                    int matailieu = int.Parse(lblDocID.Text);
                    int cboSelectedIndex = cboSubject.SelectedIndex+1;

                    if (bllSearch.UpdateTaiLieu(matailieu, txtDocName.Text, txtDocLink.Text, cboSelectedIndex.ToString(), txtMLA.Text, txtAPA.Text, txtBibTeX.Text))
                    {
                        MessageBox.Show("Update successfully");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update failed");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the information");
                }
            }  
            if(status==0)
            {
                if(checking())
                {
                    int cboSelectedIndex = cboSubject.SelectedIndex+1;
                    if(bllSearch.InsertTaiLieu(txtDocName.Text, txtDocLink.Text, cboSelectedIndex.ToString(), txtMLA.Text, txtAPA.Text, txtBibTeX.Text))
                    {
                        MessageBox.Show("Added successfully");
                        this.Close();
                    }    
                    else
                    {
                        MessageBox.Show("Add failed");
                    }
                }   
                else
                {
                    MessageBox.Show("Please fill all the information");
                }
            }    
        }

        private void txtDocName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtAPA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocLink_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMLA_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
