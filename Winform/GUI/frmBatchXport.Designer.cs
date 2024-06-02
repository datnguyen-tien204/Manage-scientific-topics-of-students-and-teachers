namespace GUI
{
    partial class frmBatchXport
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
            this.rptBatch = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptBatch
            // 
            this.rptBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptBatch.LocalReport.ReportEmbeddedResource = "GUI.Report3.rdlc";
            this.rptBatch.Location = new System.Drawing.Point(0, 0);
            this.rptBatch.Name = "rptBatch";
            this.rptBatch.ServerReport.BearerToken = null;
            this.rptBatch.Size = new System.Drawing.Size(1199, 575);
            this.rptBatch.TabIndex = 0;
            // 
            // frmBatchXport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 575);
            this.Controls.Add(this.rptBatch);
            this.Name = "frmBatchXport";
            this.Text = "frmBatchXport";
            this.Load += new System.EventHandler(this.frmBatchXport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBatch;
    }
}