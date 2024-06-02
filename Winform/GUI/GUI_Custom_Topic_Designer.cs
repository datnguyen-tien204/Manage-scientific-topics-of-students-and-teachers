using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class GUI_Custom_Topic_Designer:Guna.UI.WinForms.GunaGroupBox
    {
        private Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna2CirclePictureBox guna2CirclePictureBox3;
        private System.Windows.Forms.Label lblTag1;
        private System.Windows.Forms.Label lblTag2;
        private System.Windows.Forms.Label lblTag3;
        private System.Windows.Forms.Label lblTag4;
        private Guna2Button btn_PendingMore;

        public GUI_Custom_Topic_Designer(string tag1,string tag2,string tag3,string id_topics)
        {
            this.tag1 = tag1;
            this.tag2 = tag2;
            this.tag3 = tag3;
            this.id_topics = id_topics;
            InitializeComponents();
        }
        public string tag1 { get; set; }
        public string tag2 { get; set; }
        public string tag3 { get; set; }
        public string id_topics { get; set; }

        private void InitializeComponents()
        {
            this.guna2CirclePictureBox1 = new Guna2CirclePictureBox();
            this.guna2CirclePictureBox2 = new Guna2CirclePictureBox();
            this.guna2CirclePictureBox3 = new Guna2CirclePictureBox();
            this.lblTag1 = new System.Windows.Forms.Label();
            this.lblTag2 = new System.Windows.Forms.Label();
            this.lblTag3 = new System.Windows.Forms.Label();
            this.lblTag4 = new System.Windows.Forms.Label();
            this.btn_PendingMore = new Guna2Button();

            this.guna2CirclePictureBox1.BackColor = Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::GUI.Properties.Resources._54fd68724782ebdcb2936;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new Point(12, 85);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new Size(24, 24);
            this.guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabStop = false;

            // 
            // btn_PendingMore
            // 
            this.btn_PendingMore.Animated = true;
            this.btn_PendingMore.AnimatedGIF = true;
            this.btn_PendingMore.BorderColor = System.Drawing.Color.Transparent;
            this.btn_PendingMore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_PendingMore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_PendingMore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_PendingMore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_PendingMore.FillColor = System.Drawing.Color.White;
            this.btn_PendingMore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_PendingMore.ForeColor = System.Drawing.Color.White;
            this.btn_PendingMore.Image = global::GUI.Properties.Resources.icons8_more_100;
            this.btn_PendingMore.Location = new System.Drawing.Point(255, 9);
            this.btn_PendingMore.Margin = new System.Windows.Forms.Padding(0);
            this.btn_PendingMore.Name = "btn_PendingMore";
            this.btn_PendingMore.Size = new System.Drawing.Size(32, 32);
            this.btn_PendingMore.TabIndex = 5;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox3.Image = global::GUI.Properties.Resources.fc4ac5c5ea35466b1f241;
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(72, 85);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(24, 24);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox3.TabIndex = 4;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = global::GUI.Properties.Resources._411c7f935063fc3da5724;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(42, 85);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(24, 24);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 3;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::GUI.Properties.Resources._54fd68724782ebdcb2936;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 85);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(24, 24);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblTag2
            // 
            /*
            this.lblTag2.AutoSize = true;
            this.lblTag2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblTag2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTag2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.lblTag2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblTag2.Location = new System.Drawing.Point(72, 35);
            this.lblTag2.Name = "lblTag2";
            this.lblTag2.Size = new System.Drawing.Size(72, 22);
            this.lblTag2.TabIndex = 1;
            this.lblTag2.Text = tag2;
            */

            // 
            // lblTag1
            //
            this.lblTag1.AutoSize = true;
            this.lblTag1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag1.Location = new System.Drawing.Point(12, 50);
            this.lblTag1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTag1.Name = "lblTag1";
            this.lblTag1.Size = new System.Drawing.Size(62, 22);
            this.lblTag1.TabIndex = 0;
            this.lblTag1.Text = tag1;
            if (tag1 == "#KHMT")
            {
                this.lblTag1.BackColor = System.Drawing.Color.Transparent;  
            }
            else if (tag1=="#KTPM")
            {
                this.lblTag1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(219)))));
                this.lblTag1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(153)))), ((int)(((byte)(75)))));
            }   
            else if (tag1=="#CNTT")
            {
                this.lblTag1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
                this.lblTag1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(82)))));
            }

            //
            //lblTag3
            //
            
            if (tag3 == "#Giáo viên")
            {
                this.lblTag3.AutoSize = true;
                this.lblTag3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblTag3.Location = new System.Drawing.Point(72, 50);
                this.lblTag3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.lblTag3.Name = "lblTag3";
                this.lblTag3.Size = new System.Drawing.Size(62, 22);
                this.lblTag3.TabIndex = 1;
                this.lblTag3.Text = "#Teacher";
                this.lblTag3.BackColor = System.Drawing.Color.Transparent;
            }
            else if (tag3 == "#Sinh viên")
            {
                this.lblTag3.AutoSize = true;
                this.lblTag3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblTag3.Location = new System.Drawing.Point(72, 50);
                this.lblTag3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.lblTag3.Name = "lblTag3";
                this.lblTag3.Size = new System.Drawing.Size(62, 22);
                this.lblTag3.TabIndex = 1;
                this.lblTag3.Text = "Student";
                this.lblTag3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(219)))));
                this.lblTag3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(153)))), ((int)(((byte)(75)))));
            }
            else if (tag3 == "Sinh viên+Giáo viên")
            {
                this.lblTag3.AutoSize = true;
                this.lblTag3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblTag3.Location = new System.Drawing.Point(72, 50);
                this.lblTag3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.lblTag3.Name = "lblTag3";
                this.lblTag3.Size = new System.Drawing.Size(62, 22);
                this.lblTag3.TabIndex = 1;
                this.lblTag3.Text = "#Teacher";
                this.lblTag3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
                this.lblTag3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));

                this.lblTag4.AutoSize = true;
                this.lblTag4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblTag4.Location = new System.Drawing.Point(155, 50);
                this.lblTag4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.lblTag4.Name = "lblTag4";
                this.lblTag4.Size = new System.Drawing.Size(62, 22);
                this.lblTag4.TabIndex = 1;
                this.lblTag4.Text = "#Student";
                this.lblTag4.BackColor = System.Drawing.Color.Transparent;
                
                this.lblTag4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
                this.lblTag4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(82)))));
            }
            btn_PendingMore.Click += btn_PendingMore_Click;
            this.Click += GUI_Custom_Topic_Designer_Click;


            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.guna2CirclePictureBox3);
            this.Controls.Add(this.lblTag1);
            this.Controls.Add(this.lblTag2);
            this.Controls.Add(this.lblTag3);
            this.Controls.Add(this.lblTag4);
            this.Controls.Add(this.btn_PendingMore);
        }
        private void btn_PendingMore_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64, 64, 64);
            OpenDialogForm();
        }

        private void GUI_Custom_Topic_Designer_Click(object sender, EventArgs e)
        {
            OpenDialogForm();
        }
        private void OpenDialogForm()
        {
            using (var dialogForm = new frmManageTopicDetail())
            {
                dialogForm.id_topic = id_topics;
                dialogForm.ShowDialog();
            }
        }

    }
}
