using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class uc_EnrollCondition : UserControl
    {
        public uc_EnrollCondition()
        {
            InitializeComponent();
            label1.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            label2.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            lblLastUpdateDate.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            label4.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            label5.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            label6.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            lblDegree.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            label8.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            label9.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            label10.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            lblDiemRenLuyen.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            lblTBC.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            label13.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            label14.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            label15.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            label16.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            label17.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            label18.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            lblSoLuongNCKH.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            label20.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            label21.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            label22.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            lblHocvitoithieu.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);
            lblNumPersonConditioned.Font = new Font(pfc.Families[0], label1.Font.Size, FontStyle.Bold);

        }
        PrivateFontCollection pfc = Custom_config.Init_CustomLabel_Font(3);
        private void uc_EnrollCondition_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboChoose.SelectedIndex==1)
            {
                lblDegree.Text = "Doctoral";
                lblSoLuongNCKH.Text = "3";
                lblHocvitoithieu.Text = "No";
                lblNumPersonConditioned.Text = "1";
                lblDiemRenLuyen.Text = "No";
                lblTBC.Text = "No";
            }    
            if(cboChoose.SelectedIndex==2)
            {
                lblDegree.Text = "Doctoral";
                lblSoLuongNCKH.Text = "5";
                lblHocvitoithieu.Text = "Assoc. Prof";
                lblNumPersonConditioned.Text = "1";
                lblDiemRenLuyen.Text = "No";
                lblTBC.Text = "No";
            }
            if(cboChoose.SelectedIndex==0)
            {
                lblDegree.Text = "Master";
                lblSoLuongNCKH.Text = "1";
                lblHocvitoithieu.Text = "No";
                lblNumPersonConditioned.Text = "1";
                lblDiemRenLuyen.Text = "75";
                lblTBC.Text = "7";
            }    
        }

        private void guna2GroupBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
