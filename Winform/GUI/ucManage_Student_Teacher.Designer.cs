namespace GUI
{
    partial class ucManage_Student_Teacher
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_openEnrol = new Guna.UI2.WinForms.Guna2Button();
            this.btn_TopicManagement = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_Container = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.btn_openEnrol);
            this.guna2CustomGradientPanel2.Controls.Add(this.btn_TopicManagement);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1737, 85);
            this.guna2CustomGradientPanel2.TabIndex = 39;
            // 
            // btn_openEnrol
            // 
            this.btn_openEnrol.Animated = true;
            this.btn_openEnrol.AnimatedGIF = true;
            this.btn_openEnrol.BackColor = System.Drawing.Color.Transparent;
            this.btn_openEnrol.BorderRadius = 10;
            this.btn_openEnrol.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_openEnrol.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_openEnrol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_openEnrol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_openEnrol.FillColor = System.Drawing.Color.White;
            this.btn_openEnrol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_openEnrol.ForeColor = System.Drawing.Color.Black;
            this.btn_openEnrol.Image = global::GUI.Properties.Resources.icons8_student_48;
            this.btn_openEnrol.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btn_openEnrol.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_openEnrol.Location = new System.Drawing.Point(170, 8);
            this.btn_openEnrol.Name = "btn_openEnrol";
            this.btn_openEnrol.Size = new System.Drawing.Size(141, 67);
            this.btn_openEnrol.TabIndex = 32;
            this.btn_openEnrol.Text = "Student";
            this.btn_openEnrol.Click += new System.EventHandler(this.btn_openEnrol_Click);
            // 
            // btn_TopicManagement
            // 
            this.btn_TopicManagement.Animated = true;
            this.btn_TopicManagement.AnimatedGIF = true;
            this.btn_TopicManagement.BackColor = System.Drawing.Color.Transparent;
            this.btn_TopicManagement.BorderRadius = 10;
            this.btn_TopicManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TopicManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TopicManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TopicManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TopicManagement.FillColor = System.Drawing.Color.LightGray;
            this.btn_TopicManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_TopicManagement.ForeColor = System.Drawing.Color.Black;
            this.btn_TopicManagement.Image = global::GUI.Properties.Resources.icons8_teacher_96;
            this.btn_TopicManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_TopicManagement.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btn_TopicManagement.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_TopicManagement.Location = new System.Drawing.Point(14, 8);
            this.btn_TopicManagement.Name = "btn_TopicManagement";
            this.btn_TopicManagement.Size = new System.Drawing.Size(141, 67);
            this.btn_TopicManagement.TabIndex = 34;
            this.btn_TopicManagement.Text = "Teacher";
            this.btn_TopicManagement.TextOffset = new System.Drawing.Point(30, 0);
            this.btn_TopicManagement.Click += new System.EventHandler(this.btn_TopicManagement_Click);
            // 
            // pnl_Container
            // 
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 85);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(1737, 915);
            this.pnl_Container.TabIndex = 40;
            // 
            // ucManage_Student_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Name = "ucManage_Student_Teacher";
            this.Size = new System.Drawing.Size(1737, 1000);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button btn_openEnrol;
        private Guna.UI2.WinForms.Guna2Button btn_TopicManagement;
        private Guna.UI2.WinForms.Guna2Panel pnl_Container;
    }
}
