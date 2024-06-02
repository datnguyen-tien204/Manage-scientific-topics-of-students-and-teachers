namespace GUI
{
    partial class uc_Teacher_Assign_Notification
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
            this.pcbNotification = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblNoti = new System.Windows.Forms.Label();
            this.cboAssignmentID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCouncilID = new System.Windows.Forms.Label();
            this.lblTopicID = new System.Windows.Forms.Label();
            this.lblTopicName = new System.Windows.Forms.Label();
            this.lblInstructorID = new System.Windows.Forms.Label();
            this.lblAssignDate = new System.Windows.Forms.Label();
            this.btnObtain = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbNotification
            // 
            this.pcbNotification.Image = global::GUI.Properties.Resources.icons8_notification_50__2_;
            this.pcbNotification.ImageRotate = 0F;
            this.pcbNotification.Location = new System.Drawing.Point(45, 28);
            this.pcbNotification.Name = "pcbNotification";
            this.pcbNotification.Size = new System.Drawing.Size(50, 50);
            this.pcbNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbNotification.TabIndex = 0;
            this.pcbNotification.TabStop = false;
            // 
            // lblNoti
            // 
            this.lblNoti.AutoSize = true;
            this.lblNoti.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblNoti.Location = new System.Drawing.Point(115, 42);
            this.lblNoti.Name = "lblNoti";
            this.lblNoti.Size = new System.Drawing.Size(216, 23);
            this.lblNoti.TabIndex = 1;
            this.lblNoti.Text = "You don\'t have notification";
            // 
            // cboAssignmentID
            // 
            this.cboAssignmentID.BackColor = System.Drawing.Color.Transparent;
            this.cboAssignmentID.BorderRadius = 8;
            this.cboAssignmentID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAssignmentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAssignmentID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboAssignmentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboAssignmentID.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.cboAssignmentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboAssignmentID.ItemHeight = 30;
            this.cboAssignmentID.Items.AddRange(new object[] {
            ""});
            this.cboAssignmentID.Location = new System.Drawing.Point(168, 120);
            this.cboAssignmentID.Name = "cboAssignmentID";
            this.cboAssignmentID.Size = new System.Drawing.Size(165, 36);
            this.cboAssignmentID.TabIndex = 2;
            this.cboAssignmentID.SelectedIndexChanged += new System.EventHandler(this.cboAssignmentID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(41, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Assignment ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(41, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Council ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(41, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Topic ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(500, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Instructor ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(500, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Assign Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(41, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Topic Name";
            // 
            // lblCouncilID
            // 
            this.lblCouncilID.AutoSize = true;
            this.lblCouncilID.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblCouncilID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCouncilID.Location = new System.Drawing.Point(164, 202);
            this.lblCouncilID.Name = "lblCouncilID";
            this.lblCouncilID.Size = new System.Drawing.Size(0, 23);
            this.lblCouncilID.TabIndex = 10;
            // 
            // lblTopicID
            // 
            this.lblTopicID.AutoSize = true;
            this.lblTopicID.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblTopicID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTopicID.Location = new System.Drawing.Point(164, 279);
            this.lblTopicID.Name = "lblTopicID";
            this.lblTopicID.Size = new System.Drawing.Size(0, 23);
            this.lblTopicID.TabIndex = 11;
            // 
            // lblTopicName
            // 
            this.lblTopicName.AutoSize = true;
            this.lblTopicName.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblTopicName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTopicName.Location = new System.Drawing.Point(164, 358);
            this.lblTopicName.Name = "lblTopicName";
            this.lblTopicName.Size = new System.Drawing.Size(0, 23);
            this.lblTopicName.TabIndex = 12;
            // 
            // lblInstructorID
            // 
            this.lblInstructorID.AutoSize = true;
            this.lblInstructorID.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblInstructorID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblInstructorID.Location = new System.Drawing.Point(638, 202);
            this.lblInstructorID.Name = "lblInstructorID";
            this.lblInstructorID.Size = new System.Drawing.Size(0, 23);
            this.lblInstructorID.TabIndex = 13;
            // 
            // lblAssignDate
            // 
            this.lblAssignDate.AutoSize = true;
            this.lblAssignDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblAssignDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblAssignDate.Location = new System.Drawing.Point(638, 276);
            this.lblAssignDate.Name = "lblAssignDate";
            this.lblAssignDate.Size = new System.Drawing.Size(0, 23);
            this.lblAssignDate.TabIndex = 14;
            // 
            // btnObtain
            // 
            this.btnObtain.Animated = true;
            this.btnObtain.AnimatedGIF = true;
            this.btnObtain.BorderRadius = 10;
            this.btnObtain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnObtain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnObtain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnObtain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnObtain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtain.ForeColor = System.Drawing.Color.White;
            this.btnObtain.Location = new System.Drawing.Point(504, 568);
            this.btnObtain.Name = "btnObtain";
            this.btnObtain.Size = new System.Drawing.Size(145, 49);
            this.btnObtain.TabIndex = 15;
            this.btnObtain.Text = "Obtain";
            this.btnObtain.Click += new System.EventHandler(this.btnObtain_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AnimatedGIF = true;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Teal;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(336, 568);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 49);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // uc_Teacher_Assign_Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnObtain);
            this.Controls.Add(this.lblAssignDate);
            this.Controls.Add(this.lblInstructorID);
            this.Controls.Add(this.lblTopicName);
            this.Controls.Add(this.lblTopicID);
            this.Controls.Add(this.lblCouncilID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAssignmentID);
            this.Controls.Add(this.lblNoti);
            this.Controls.Add(this.pcbNotification);
            this.Name = "uc_Teacher_Assign_Notification";
            this.Size = new System.Drawing.Size(1737, 915);
            this.Load += new System.EventHandler(this.uc_Teacher_Assign_Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbNotification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pcbNotification;
        private System.Windows.Forms.Label lblNoti;
        private Guna.UI2.WinForms.Guna2ComboBox cboAssignmentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCouncilID;
        private System.Windows.Forms.Label lblTopicID;
        private System.Windows.Forms.Label lblTopicName;
        private System.Windows.Forms.Label lblInstructorID;
        private System.Windows.Forms.Label lblAssignDate;
        private Guna.UI2.WinForms.Guna2Button btnObtain;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}
