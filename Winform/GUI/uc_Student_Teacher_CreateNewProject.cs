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
    public partial class uc_Student_Teacher_CreateNewProject : UserControl
    {
        public uc_Student_Teacher_CreateNewProject()
        {
            InitializeComponent();
        }
        public string vai_tro { get; set; }
        public string id { get; set; }
        
        BLL.BLL_Student_Teacher_Batch bllTopics = new BLL.BLL_Student_Teacher_Batch();
        private List<object[]> addBatchtoDatalist(int year)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = bllTopics.getBatchInfor(year);
            foreach (DataRow row in topicData.Rows)
            {
                string STT = row[0].ToString();
                string batchID = row[1].ToString();
                string batchName = row[2].ToString();
                DateTime startTime_ = DateTime.Parse(row[3].ToString()); 
                string startTime = startTime_.ToString("MM/dd/yyyy");
                DateTime subTime_ = DateTime.Parse(row[4].ToString()); 
                string submisionTime = subTime_.ToString("MM/dd/yyyy");
                DateTime endTime_ = DateTime.Parse(row[5].ToString());
                string endTime = endTime_.ToString("MM/dd/yyyy");
                string type = row[6].ToString();
                string status = row[7].ToString();
                dataList.Add(new object[] { STT, batchID, batchName, startTime, submisionTime, endTime, type, status });
            }
            return dataList;
        }

        private void uc_Student_CreateNewProject_Load(object sender, EventArgs e)
        {
            List<object[]> dataList = addBatchtoDatalist(2024);
            
            foreach (object[] row in dataList)
            {
                dgvBatch.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
                Console.WriteLine(row[4]);
            }// Lấy danh sách từ phương thức addBatchtoDatalist và lưu vào biến dataList
            
            //dgvBatch.DataSource = dataList.ToList(); // Gán danh sách làm nguồn dữ liệu cho DataGridView
        }


        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = guna2ComboBox1.SelectedItem.ToString();
            int valueInt = int.Parse(value);
            dgvBatch.DataSource = bllTopics.getBatchInfor(valueInt);
        }
        private void OpenDialogForm(string madot,string vaitro)
        {
            using (var dialogForm = new frm_Teacher_Students_TopicsRegistrationForm())
            {
                dialogForm.dot_get = madot;
                dialogForm.vaiTro_get = vaitro;
                dialogForm.id_get = id;
                dialogForm.ShowDialog();
            }
        }
        private void dgvBatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBatch.Rows[e.RowIndex].Cells[7].Value.ToString() != "Closed")
                {
                    if (dgvBatch.Columns[e.ColumnIndex].Name == "Enroll")
                    {
                        string batchID = dgvBatch.Rows[e.RowIndex].Cells[1].Value.ToString();

                        OpenDialogForm(batchID,vai_tro);
                    }
                }
                else
                {
                    dgvBatch.Rows[e.RowIndex].Cells[8].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
            }

        }
    }
}
