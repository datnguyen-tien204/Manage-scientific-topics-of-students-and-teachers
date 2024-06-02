namespace GUI
{
    partial class frm_StudentXport
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
            this.rptSinhVien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptSinhVien
            // 
            this.rptSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptSinhVien.LocalReport.ReportEmbeddedResource = "GUI.studentList.rdlc";
            this.rptSinhVien.Location = new System.Drawing.Point(0, 0);
            this.rptSinhVien.Name = "rptSinhVien";
            this.rptSinhVien.ServerReport.BearerToken = null;
            this.rptSinhVien.Size = new System.Drawing.Size(1249, 555);
            this.rptSinhVien.TabIndex = 0;
            // 
            // frm_StudentXport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 555);
            this.Controls.Add(this.rptSinhVien);
            this.Name = "frm_StudentXport";
            this.Text = "frm_StudentXport";
            this.Load += new System.EventHandler(this.frm_StudentXport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptSinhVien;
    }
}