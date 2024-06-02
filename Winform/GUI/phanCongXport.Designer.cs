namespace GUI
{
    partial class phanCongXport
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
            this.rptPhanCong = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptPhanCong
            // 
            this.rptPhanCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptPhanCong.LocalReport.ReportEmbeddedResource = "GUI.Report2.rdlc";
            this.rptPhanCong.Location = new System.Drawing.Point(0, 0);
            this.rptPhanCong.Name = "rptPhanCong";
            this.rptPhanCong.ServerReport.BearerToken = null;
            this.rptPhanCong.Size = new System.Drawing.Size(1179, 673);
            this.rptPhanCong.TabIndex = 0;
            // 
            // phanCongXport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 673);
            this.Controls.Add(this.rptPhanCong);
            this.Name = "phanCongXport";
            this.Text = "phanCongXport";
            this.Load += new System.EventHandler(this.phanCongXport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptPhanCong;
    }
}