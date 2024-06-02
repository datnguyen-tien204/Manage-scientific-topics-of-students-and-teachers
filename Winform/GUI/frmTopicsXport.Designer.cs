namespace GUI
{
    partial class frmTopicsXport
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
            this.rptTopics = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptTopics
            // 
            this.rptTopics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptTopics.LocalReport.ReportEmbeddedResource = "GUI.topicsReport.rdlc";
            this.rptTopics.Location = new System.Drawing.Point(0, 0);
            this.rptTopics.Name = "rptTopics";
            this.rptTopics.ServerReport.BearerToken = null;
            this.rptTopics.Size = new System.Drawing.Size(1196, 753);
            this.rptTopics.TabIndex = 0;
            // 
            // frmTopicsXport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 753);
            this.Controls.Add(this.rptTopics);
            this.Name = "frmTopicsXport";
            this.Text = "frmTopicsXport";
            this.Load += new System.EventHandler(this.frmTopicsXport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptTopics;
    }
}