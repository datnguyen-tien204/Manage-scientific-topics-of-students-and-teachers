using BLL;
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
    public partial class uc_Leader_Councils : UserControl
    {
        public uc_Leader_Councils()
        {
            InitializeComponent();
        }
        public string idgv { get; set; }
        BLL_Councils BLL_Councils = new BLL_Councils();
        private List<object[]> addtoDatalist(int maGV)
        {
            List<object[]> dataList = new List<object[]>();
            DataTable topicData = BLL_Councils.getAllOpinion(maGV);
            foreach (DataRow row in topicData.Rows)
            {
                string gv = row[0].ToString();
                string ykien = row[1].ToString();
                string diem = row[2].ToString();
                string ghichu = row[3].ToString();
                dataList.Add(new object[] { gv,ykien,diem,ghichu});
            }
            return dataList;
        }
        private void fitToBox(int idgv)
        {
            List<object[]> dataList = addtoDatalist(idgv);
            List<object[]> dataList2 = new List<object[]>();
            foreach (object[] row in dataList)
            {
                dataList2.Add(new object[] { row[0], row[1], row[2], row[3] });
            }

            if (dataList2.Count > 0)
            {
                //Phó trưởng nhóm
                object[] firstRow = dataList2[1];
                deptID.Text = firstRow[0].ToString();
                txtDeptOpinion.Text = firstRow[1].ToString();
                txtDeptMark.Text = firstRow[2].ToString();
                txtDeptNotes.Text = firstRow[3].ToString();

                //Thư ký
                object[] secondRow = dataList2[2];
                secID.Text = secondRow[0].ToString();
                txtSecOpin.Text = secondRow[1].ToString();
                txtSecMark.Text = secondRow[2].ToString();
                txtSecNote.Text = secondRow[3].ToString();

                //Thành viên
                object[] thirdRow = dataList2[3];
                mem1ID.Text = thirdRow[0].ToString();
                txtMem1Opin.Text = thirdRow[1].ToString();
                txtMem1Mark.Text = thirdRow[2].ToString();
                txtMem1Notes.Text = thirdRow[3].ToString();

                object[] fourthRow = dataList2[4];
                mem2ID.Text = fourthRow[0].ToString();
                txtMem2Opin.Text = fourthRow[1].ToString();
                txtMem2Mark.Text = fourthRow[2].ToString();
                txtMem2Notes.Text = fourthRow[3].ToString();
            }
        }
        private void getMaHoiDong(string maGV)
        {
            DataTable topicData = BLL_Councils.PROC_getIDCouncilFromTeacher(maGV);
            foreach (DataRow row in topicData.Rows)
            {
                string maHD = row[0].ToString();
                cboChooseTopic.Items.Add(maHD);
            }
        }

        private void uc_Leader_Councils_Load(object sender, EventArgs e)
        {
            getMaHoiDong(idgv);
        }

        private void cboChooseTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maHoiDong = int.Parse(cboChooseTopic.Text);
            fitToBox(maHoiDong);
        }
    }
}
