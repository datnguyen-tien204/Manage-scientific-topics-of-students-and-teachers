namespace GUI
{
    partial class frm_Teacher_ExpReport
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.rptMain = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2CustomGradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(0, 633);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1181, 38);
            this.guna2CustomGradientPanel2.TabIndex = 1;
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.Controls.Add(this.rptMain);
            this.guna2CustomGradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(1181, 633);
            this.guna2CustomGradientPanel3.TabIndex = 2;
            // 
            // rptMain
            // 
            this.rptMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptMain.LocalReport.ReportEmbeddedResource = "GUI.teacherList_report.rdlc";
            this.rptMain.Location = new System.Drawing.Point(0, 0);
            this.rptMain.Name = "rptMain";
            this.rptMain.ServerReport.BearerToken = null;
            this.rptMain.Size = new System.Drawing.Size(1181, 633);
            this.rptMain.TabIndex = 0;
            // 
            // frm_Teacher_ExpReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 671);
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Name = "frm_Teacher_ExpReport";
            this.Text = "frm_Teacher_ExpReport";
            this.Load += new System.EventHandler(this.frm_Teacher_ExpReport_Load);
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Microsoft.Reporting.WinForms.ReportViewer rptMain;
    }
}