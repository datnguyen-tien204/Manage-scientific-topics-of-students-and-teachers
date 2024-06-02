using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GUI
{
    public partial class uc_AllocatedFunds : UserControl
    {
        public uc_AllocatedFunds()
        {
            InitializeComponent();
        }
        
        private void disableAll()
        {
            //txtTotalAllCostStudent.Enabled = false;
            //txtTotalAllCostTeacher.Enabled = false;
            txtStudentTotalCost.Enabled = false;
            txtMaximumTotalCost.Enabled = false;
            txtStudentUsed.Enabled = false;
            txtRemaining.Enabled = false;
            txtMasCost.Enabled = false;
            txtMasMaximum.Enabled = false;
            txtMasUsed.Enabled = false;
            txtMasRemain.Enabled = false;
            txtDocMaxi.Enabled = false;
            txtDocUsed.Enabled = false;
            txtDocRemain.Enabled = false;
            txtDocTotalCost.Enabled = false;
        }
        BLL.BLL_Registration bllRegistration = new BLL.BLL_Registration();
        private List<object[]> addTotalCostToDataList(int batch,int year, int status)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = bllRegistration.getSumExpense(batch,year,status);
            foreach (DataRow row in topicData.Rows)
            {
                string sumTeacherCost = row[0].ToString();
                string sumStudentCost = row[1].ToString();
                dataList.Add(new object[] { sumTeacherCost,sumStudentCost });
            }
            return dataList;
        }
        private void uc_AllocatedFunds_Load(object sender, EventArgs e)
        {
            disableAll();
            List<object[]> dataList = addTotalCostToDataList(1,1,0);
            foreach (object[] row in dataList)
            {
                txtTotalAllCostTeacher.Text = row[0].ToString();
                txtTotalAllCostStudent.Text = row[1].ToString();
            }
            txtStudentTotalCost.Text = addTotalCostToDataList(0).ToString();
            txtMasCost.Text = addTotalCostToDataList(1).ToString();
            txtDocTotalCost.Text = addTotalCostToDataList(2).ToString();
            txtStudentUsed.Text = addTotalCostToDataList(0).ToString();
            txtMasUsed.Text = addTotalCostToDataList(1).ToString();
            txtDocUsed.Text = addTotalCostToDataList(2).ToString();
            truTien();
            fitToDataGridView(0);
            guna2ComboBox2.SelectedIndex = 0;
        }
        private void truTien()
        {
            //Sinh Viên
            string tiensv= txtTotalAllCostStudent.Text.ToString();
            string cleanedInput= tiensv.Replace(",", "");
            double tientongSV = double.Parse(cleanedInput);
            double tienconlai= tientongSV - double.Parse(txtStudentTotalCost.Text.ToString());
            txtRemaining.Text= tienconlai.ToString();

            //Thạc sĩ
            string tienthacsi = txtTotalAllCostTeacher.Text.ToString();
            string thacsi = tienthacsi.Replace(",", "");
            double tientongthacsi = double.Parse(thacsi);
            double tienconlaithacsi = tientongthacsi - double.Parse(txtMasCost.Text.ToString());
            txtMasRemain.Text = tienconlaithacsi.ToString();

            //Tiến sĩ
            double tienconlaiTienSi= tienconlaithacsi - double.Parse(txtDocTotalCost.Text.ToString());
            txtDocRemain.Text = tienconlaiTienSi.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtTotalAllCostStudent.Enabled = true;
            txtTotalAllCostTeacher.Enabled = true;
            txtStudentTotalCost.Enabled = true;
            txtMaximumTotalCost.Enabled = true;
            txtStudentUsed.Enabled = true;
            txtRemaining.Enabled = true;
            txtMasCost.Enabled = true;
            txtMasMaximum.Enabled = true;
            txtMasUsed.Enabled = true;
            txtMasRemain.Enabled = true;
            txtDocMaxi.Enabled = true;
            txtDocUsed.Enabled = true;
            txtDocRemain.Enabled = true;
            txtDocTotalCost.Enabled = true;
        }

        private void cboChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
               
            try
            {
                if (cboBatch.SelectedIndex == 0 && cboChoose.SelectedIndex == 0)
                {
                    List<object[]> dataList = addTotalCostToDataList(1, 1, 0);
                    foreach (object[] row in dataList)
                    {
                        txtTotalAllCostTeacher.Text = row[0].ToString();
                        txtTotalAllCostStudent.Text = row[1].ToString();
                    }
                }

                else
                {
                    int yearChoose = int.Parse(cboChoose.SelectedItem.ToString());
                    int batchChoose = int.Parse(cboBatch.SelectedItem.ToString());

                    List<object[]> dataList = addTotalCostToDataList(batchChoose, yearChoose, 1);
                    foreach (object[] row in dataList)
                    {
                        txtTotalAllCostTeacher.Text = row[0].ToString();
                        txtTotalAllCostStudent.Text = row[1].ToString();
                    }
                }
            }
            catch { }
            
        }

        private void cboBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboBatch.SelectedIndex == 0 && cboChoose.SelectedIndex == 0)
                {
                    List<object[]> dataList = addTotalCostToDataList(1, 1, 0);
                    foreach (object[] row in dataList)
                    {
                        txtTotalAllCostTeacher.Text = row[0].ToString();
                        txtTotalAllCostStudent.Text = row[1].ToString();
                    }
                }
                else
                {
                    int yearChoose = int.Parse(cboChoose.SelectedItem.ToString());
                    int batchChoose = int.Parse(cboBatch.SelectedItem.ToString());


                    List<object[]> dataList = addTotalCostToDataList(batchChoose, yearChoose, 1);
                    foreach (object[] row in dataList)
                    {
                        txtTotalAllCostTeacher.Text = row[0].ToString();
                        txtTotalAllCostStudent.Text = row[1].ToString();
                    }
                }
            }
            catch { }
        }
        BLL_Expense BLL_Expense = new BLL_Expense();
        private int addTotalCostToDataList(int status)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = BLL_Expense.PROC_getTongKinhPhiSV_GV(status);
            foreach (DataRow row in topicData.Rows)
            {
                if (row[0].ToString() != "")
                {
                    string sumCost = row[0].ToString();
                    int sum = int.Parse(sumCost);
                    return sum;
                }
                else
                {
                    return 0;
                }    
            }
            return 0;
        }

        // Đưa dữ liệu vào DataGridView
        private List<object[]> dataList;
        private List<object[]> filteredDataList;

        private DataTable teacherData = new DataTable();

        private List<object[]> addDataToDataList(int status)
        {
            List<object[]> dataList = new List<object[]>();
            teacherData = BLL_Expense.getDeTaiSinhVien(status);
            foreach (DataRow row in teacherData.Rows)
            {
                string STT = row[0].ToString();
                string madetai = row[1].ToString();
                string tendetai = row[2].ToString();
                string loai = row[3].ToString();
                string manguoihuongdan = row[4].ToString();
                string kinhphi = row[5].ToString();
                dataList.Add(new object[] { STT, madetai,tendetai,loai,manguoihuongdan,kinhphi});
            }
            return dataList;
        }
        private void fitToDataGridView(int status)
        {
            if(status==0)
            {
                dgv_DeTai.Rows.Clear();
                dataList = addDataToDataList(0);
                foreach (object[] row in dataList)
                {
                    dgv_DeTai.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
                }
                filteredDataList = dataList;
            }   
            if(status==1)
            {
                dgv_DeTai.Rows.Clear();
                dataList = addDataToDataList(1);
                foreach (object[] row in dataList)
                {
                    dgv_DeTai.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
                }
                filteredDataList = dataList;
            }    
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(guna2ComboBox2.SelectedIndex==0)
            {
                fitToDataGridView(0);
            }
            if(guna2ComboBox2.SelectedIndex==1)
            {
                fitToDataGridView(1);
            }
        }
        private void OpenDialogForm(int topicID)
        {
            try
            {
                string topicName = dgv_DeTai.Rows[topicID].Cells[2].Value.ToString();
                string type = dgv_DeTai.Rows[topicID].Cells[3].Value.ToString();
                string instructorID = dgv_DeTai.Rows[topicID].Cells[4].Value.ToString();
                string expense = dgv_DeTai.Rows[topicID].Cells[5].Value.ToString();
                frmEditFunds frm = new frmEditFunds();
                frm.topicID = topicID;
                frm.topicName = topicName;
                frm.type = type;
                frm.instructorID = instructorID;
                frm.expense = expense;
                frm.ShowDialog();
            }
            catch { }
        }

        private void dgv_DeTai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_DeTai.Columns[e.ColumnIndex].Name == "edit")
            {
                string topicID = dgv_DeTai.Rows[e.RowIndex].Cells[1].Value.ToString();
                OpenDialogForm(int.Parse(topicID));
                dgv_DeTai.Rows.Clear();
                uc_AllocatedFunds_Load(sender, e);
            }
        }
    }
}
