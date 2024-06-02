namespace GUI
{
    partial class frmCouncilsXport
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
            this.rptCouncils = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptCouncils
            // 
            this.rptCouncils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptCouncils.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";
            this.rptCouncils.Location = new System.Drawing.Point(0, 0);
            this.rptCouncils.Name = "rptCouncils";
            this.rptCouncils.ServerReport.BearerToken = null;
            this.rptCouncils.Size = new System.Drawing.Size(1207, 611);
            this.rptCouncils.TabIndex = 0;
            // 
            // frmCouncilsXport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 611);
            this.Controls.Add(this.rptCouncils);
            this.Name = "frmCouncilsXport";
            this.Text = "frmCouncilsXport";
            this.Load += new System.EventHandler(this.frmCouncilsXport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptCouncils;
    }
}