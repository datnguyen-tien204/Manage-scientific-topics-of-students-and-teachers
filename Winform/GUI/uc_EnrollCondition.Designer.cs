namespace GUI
{
    partial class uc_EnrollCondition
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
            this.cboChoose = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLastUpdateDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblTBC = new System.Windows.Forms.Label();
            this.lblDiemRenLuyen = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblHocvitoithieu = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblSoLuongNCKH = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblNumPersonConditioned = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboChoose
            // 
            this.cboChoose.BackColor = System.Drawing.Color.Transparent;
            this.cboChoose.BorderRadius = 5;
            this.cboChoose.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoose.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboChoose.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboChoose.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold);
            this.cboChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboChoose.ItemHeight = 30;
            this.cboChoose.Items.AddRange(new object[] {
            "Students",
            "Teacher(Master)",
            "Student(Doctoral)"});
            this.cboChoose.Location = new System.Drawing.Point(195, 44);
            this.cboChoose.Name = "cboChoose";
            this.cboChoose.Size = new System.Drawing.Size(231, 36);
            this.cboChoose.StartIndex = 0;
            this.cboChoose.TabIndex = 0;
            this.cboChoose.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Topic Type";
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(443, 44);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 36);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(70, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Edit";
            // 
            // lblLastUpdateDate
            // 
            this.lblLastUpdateDate.AutoSize = true;
            this.lblLastUpdateDate.BackColor = System.Drawing.Color.Transparent;
            this.lblLastUpdateDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold);
            this.lblLastUpdateDate.ForeColor = System.Drawing.Color.Black;
            this.lblLastUpdateDate.Location = new System.Drawing.Point(190, 114);
            this.lblLastUpdateDate.Name = "lblLastUpdateDate";
            this.lblLastUpdateDate.Size = new System.Drawing.Size(114, 28);
            this.lblLastUpdateDate.TabIndex = 4;
            this.lblLastUpdateDate.Text = "12/03/2024";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(71, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(526, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Conditions on academic titles and degrees of instructors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(115, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(493, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "The number of instructors must meet the conditions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(115, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Minimum qualifications of instructors:";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.BackColor = System.Drawing.Color.Transparent;
            this.lblDegree.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold);
            this.lblDegree.ForeColor = System.Drawing.Color.Black;
            this.lblDegree.Location = new System.Drawing.Point(544, 265);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(74, 28);
            this.lblDegree.TabIndex = 8;
            this.lblDegree.Text = "Master";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.lblTBC);
            this.guna2GroupBox1.Controls.Add(this.lblDiemRenLuyen);
            this.guna2GroupBox1.Controls.Add(this.label13);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.label14);
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.Controls.Add(this.label15);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.LightCoral;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(75, 336);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(889, 194);
            this.guna2GroupBox1.TabIndex = 9;
            this.guna2GroupBox1.Text = "Conditional 1";
            // 
            // lblTBC
            // 
            this.lblTBC.AutoSize = true;
            this.lblTBC.ForeColor = System.Drawing.Color.Blue;
            this.lblTBC.Location = new System.Drawing.Point(700, 107);
            this.lblTBC.Name = "lblTBC";
            this.lblTBC.Size = new System.Drawing.Size(22, 25);
            this.lblTBC.TabIndex = 10;
            this.lblTBC.Text = "7";
            // 
            // lblDiemRenLuyen
            // 
            this.lblDiemRenLuyen.AutoSize = true;
            this.lblDiemRenLuyen.ForeColor = System.Drawing.Color.Blue;
            this.lblDiemRenLuyen.Location = new System.Drawing.Point(603, 58);
            this.lblDiemRenLuyen.Name = "lblDiemRenLuyen";
            this.lblDiemRenLuyen.Size = new System.Drawing.Size(33, 25);
            this.lblDiemRenLuyen.TabIndex = 6;
            this.lblDiemRenLuyen.Text = "75";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(219, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(459, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "Overall academic average is greater than or equal to";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(219, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(378, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Training marks are greater than or equal to";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(155, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "have";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(155, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "have";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label15.Location = new System.Drawing.Point(12, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 25);
            this.label15.TabIndex = 8;
            this.label15.Text = "All members";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(12, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "All members";
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.lblHocvitoithieu);
            this.guna2GroupBox3.Controls.Add(this.label22);
            this.guna2GroupBox3.Controls.Add(this.label21);
            this.guna2GroupBox3.Controls.Add(this.label20);
            this.guna2GroupBox3.Controls.Add(this.lblSoLuongNCKH);
            this.guna2GroupBox3.Controls.Add(this.label18);
            this.guna2GroupBox3.Controls.Add(this.label17);
            this.guna2GroupBox3.Controls.Add(this.label16);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(75, 553);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(889, 198);
            this.guna2GroupBox3.TabIndex = 10;
            this.guna2GroupBox3.Text = "Điều kiện 2";
            this.guna2GroupBox3.Click += new System.EventHandler(this.guna2GroupBox3_Click);
            // 
            // lblHocvitoithieu
            // 
            this.lblHocvitoithieu.AutoSize = true;
            this.lblHocvitoithieu.ForeColor = System.Drawing.Color.Blue;
            this.lblHocvitoithieu.Location = new System.Drawing.Point(431, 124);
            this.lblHocvitoithieu.Name = "lblHocvitoithieu";
            this.lblHocvitoithieu.Size = new System.Drawing.Size(38, 25);
            this.lblHocvitoithieu.TabIndex = 14;
            this.lblHocvitoithieu.Text = "No";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(219, 125);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(192, 25);
            this.label22.TabIndex = 13;
            this.label22.Text = "Minumum Aca. Rank";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(155, 129);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 20);
            this.label21.TabIndex = 12;
            this.label21.Text = "have";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label20.Location = new System.Drawing.Point(12, 125);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 25);
            this.label20.TabIndex = 11;
            this.label20.Text = "Instructors";
            // 
            // lblSoLuongNCKH
            // 
            this.lblSoLuongNCKH.AutoSize = true;
            this.lblSoLuongNCKH.ForeColor = System.Drawing.Color.Blue;
            this.lblSoLuongNCKH.Location = new System.Drawing.Point(649, 66);
            this.lblSoLuongNCKH.Name = "lblSoLuongNCKH";
            this.lblSoLuongNCKH.Size = new System.Drawing.Size(20, 25);
            this.lblSoLuongNCKH.TabIndex = 8;
            this.lblSoLuongNCKH.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(219, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(407, 25);
            this.label18.TabIndex = 7;
            this.label18.Text = "The number of SCE. is greater than or equal to";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(155, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "have";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.Location = new System.Drawing.Point(12, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "Instructors";
            // 
            // lblNumPersonConditioned
            // 
            this.lblNumPersonConditioned.AutoSize = true;
            this.lblNumPersonConditioned.BackColor = System.Drawing.Color.Transparent;
            this.lblNumPersonConditioned.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F, System.Drawing.FontStyle.Bold);
            this.lblNumPersonConditioned.ForeColor = System.Drawing.Color.Black;
            this.lblNumPersonConditioned.Location = new System.Drawing.Point(638, 228);
            this.lblNumPersonConditioned.Name = "lblNumPersonConditioned";
            this.lblNumPersonConditioned.Size = new System.Drawing.Size(20, 28);
            this.lblNumPersonConditioned.TabIndex = 11;
            this.lblNumPersonConditioned.Text = "1";
            // 
            // uc_EnrollCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNumPersonConditioned);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLastUpdateDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboChoose);
            this.Name = "uc_EnrollCondition";
            this.Size = new System.Drawing.Size(1737, 919);
            this.Load += new System.EventHandler(this.uc_EnrollCondition_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cboChoose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLastUpdateDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDegree;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Label lblTBC;
        private System.Windows.Forms.Label lblDiemRenLuyen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSoLuongNCKH;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblHocvitoithieu;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblNumPersonConditioned;
    }
}
