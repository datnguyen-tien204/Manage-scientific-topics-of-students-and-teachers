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
    public partial class uc_Student_Teacher_FindDocument : UserControl
    {
        public uc_Student_Teacher_FindDocument()
        {
            InitializeComponent();
        }
        BLL.BLL_Search bllSearch = new BLL.BLL_Search();
        private List<object[]> dataList;
        private DataTable teacherData = new DataTable();
        private List<object[]> addUserToDataList(string tentailieu)
        {
            List<object[]> dataList = new List<object[]>();
            teacherData = bllSearch.TimTaiLieu(tentailieu);
            foreach (DataRow row in teacherData.Rows)
            {
                string matailieu = row[0].ToString();
                string tentailieu2= row[1].ToString();
                dataList.Add(new object[] { matailieu,tentailieu2 });
            }
            return dataList;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                dataList = addUserToDataList(txtSearch.Text);
                dgvInf.Rows.Clear();
                foreach (object[] item in dataList)
                {
                    dgvInf.Rows.Add(item[0], item[1]);
                }
            }
            else
            {
                dgvInf.Rows.Clear();
            }
        }

        private void uc_Student_Teacher_FindDocument_Load(object sender, EventArgs e)
        {

        }
        private void OpenFormDiagLog(int matailieu)
        {
            frmViewTaiLieu form = new frmViewTaiLieu();
            form.matailieu = matailieu;
            form.ShowDialog();
        }

        private void dgvInf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvInf.Rows[e.RowIndex];
            string matailieu = row.Cells[0].Value.ToString().TrimEnd();
            OpenFormDiagLog(int.Parse(matailieu));
        }
    }
}
