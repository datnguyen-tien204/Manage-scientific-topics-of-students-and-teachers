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
    public partial class uc_TeacherStudents_ManageProject : UserControl
    {
        public uc_TeacherStudents_ManageProject()
        {
            InitializeComponent();
        }

        public string idLogin { get; set; }
        public string vaitroLogin { get; set; }

        BLL.BLL_Registration bllRegis = new BLL.BLL_Registration();
        private List<object[]> addTopicstoDatalist()
        {
            try
            {
                List<object[]> dataList = new List<object[]>();
                if (vaitroLogin == "sinhvien")
                {
                    DataTable topicData = bllRegis.getTopicInformationforSinhVienGiaoVien(idLogin, 0);
                    foreach (DataRow row in topicData.Rows)
                    {
                        string STT = row[0].ToString();
                        string topicID = row[1].ToString();
                        string topicName = row[2].ToString();
                        string idGVHD = row[3].ToString();
                        string idBatch = row[4].ToString();
                        string kinhPhi = row[5].ToString();
                        string ketqua = row[6].ToString();
                        string linknopbai = row[7].ToString();
                        string status = row[8].ToString();
                        string ghiChu = row[10].ToString();
                        dataList.Add(new object[] { STT, topicID, topicName, idGVHD, idBatch, kinhPhi, ketqua, linknopbai, status, ghiChu });
                    }
                    return dataList;
                }
                else
                {
                    DataTable topicData = bllRegis.getTopicInformationforSinhVienGiaoVien(idLogin, 1);
                    foreach (DataRow row in topicData.Rows)
                    {
                        string STT = row[0].ToString();
                        string topicID = row[1].ToString();
                        string topicName = row[2].ToString();
                        string idGVHD = row[3].ToString();
                        string idBatch = row[4].ToString();
                        string kinhPhi = row[5].ToString();
                        string ketqua = row[6].ToString();
                        string linknopbai = row[7].ToString();
                        string status = row[8].ToString();
                        string ghiChu = row[10].ToString();
                        dataList.Add(new object[] { STT, topicID, topicName, idGVHD, idBatch, kinhPhi, ketqua, linknopbai, status, ghiChu });
                    }
                    return dataList;
                }
            }
            catch
            {
                return null;
            }
        }
        /*
        private void uc_Student_CreateNewProject_Load(object sender, EventArgs e)
        {
             // Gán danh sách làm nguồn dữ liệu cho DataGridView
        }
        */
        private void LoadData()
        {
            List<object[]> dataList = addTopicstoDatalist();

            foreach (object[] row in dataList)
            {
                dgvBatch.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9]);
            }
        }
        private void uc_TeacherStudents_ManageProject_Load(object sender, EventArgs e)
        {
            List<object[]> dataList = addTopicstoDatalist();

            foreach (object[] row in dataList)
            {
                dgvBatch.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9]);
            }
        
        }

        private void dgvBatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBatch.Columns[e.ColumnIndex].Name == "Delete")
                {
                    string status_detai = dgvBatch.Rows[e.RowIndex].Cells[9].Value.ToString();
                    int status_detai_int = int.Parse(status_detai);
                    if (status_detai_int != 1)
                    {
                        MessageBox.Show("This topic is not available for editing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (status_detai_int == 1)
                    {
                        string topicID = dgvBatch.Rows[e.RowIndex].Cells[1].Value.ToString();
                        int topicID_int = int.Parse(topicID);
                        if (vaitroLogin == "sinhvien")
                        {
                            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this topic?", "Delete confirm", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                if (bllRegis.deleteTopic(topicID_int, 0))
                                {
                                    MessageBox.Show("Delete topic successfully!", "Successfully", MessageBoxButtons.OK);
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("Delete topic failed!", "Failed", MessageBoxButtons.OK);
                                }
                            }
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this topic?", "Delete confirm", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                if (bllRegis.deleteTopic(topicID_int, 1))
                                {
                                    MessageBox.Show("Delete topic successfully!", "Successfully", MessageBoxButtons.OK);
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("Delete topic failed!", "Failed", MessageBoxButtons.OK);
                                }
                            }
                        }
                    }
                }
                if (dgvBatch.Columns[e.ColumnIndex].Name == "Edit")
                {
                    string topicID = dgvBatch.Rows[e.RowIndex].Cells[1].Value.ToString();
                    int topicID_int = int.Parse(topicID);
                    string status = dgvBatch.Rows[e.RowIndex].Cells[8].Value.ToString();
                    using (var dialogForm = new frmStudent_Teacher_TopicEdit())
                    {
                        dialogForm.idLogin = idLogin;
                        dialogForm.vaitro = vaitroLogin;
                        dialogForm.idTopic = topicID;
                        dialogForm.status = status;
                        dialogForm.ShowDialog();
                    }

                }


                if (dgvBatch.Columns[e.ColumnIndex].Name == "sublink")
                {
                    string link = dgvBatch.Rows[e.RowIndex].Cells[7].Value.ToString();
                    if (link != "")
                    {
                        System.Diagnostics.Process.Start(link);
                    }
                    else
                    {
                        MessageBox.Show("This topic has no submission link", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex) { }
        }
    }
}
