namespace GUI
{
    partial class frmViewTaiLieu
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
            this.pdfViewer1 = new Spire.PdfViewer.Forms.PdfViewer();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAPA = new Guna.UI2.WinForms.Guna2Button();
            this.btnMLA = new Guna.UI2.WinForms.Guna2Button();
            this.btnBibText = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.pdfViewer1.FormFillEnabled = false;
            this.pdfViewer1.IgnoreCase = false;
            this.pdfViewer1.IsToolBarVisible = true;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer1.MultiPagesThreshold = 60;
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.OnRenderPageExceptionEvent = null;
            this.pdfViewer1.Size = new System.Drawing.Size(1285, 693);
            this.pdfViewer1.TabIndex = 0;
            this.pdfViewer1.Text = "pdfViewer1";
            this.pdfViewer1.Threshold = 60;
            this.pdfViewer1.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.btnBibText);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnMLA);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnAPA);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1285, 57);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.pdfViewer1);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(0, 57);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1285, 693);
            this.guna2CustomGradientPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cite";
            // 
            // btnAPA
            // 
            this.btnAPA.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAPA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAPA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAPA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAPA.FillColor = System.Drawing.Color.White;
            this.btnAPA.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAPA.ForeColor = System.Drawing.Color.Red;
            this.btnAPA.Location = new System.Drawing.Point(107, 12);
            this.btnAPA.Name = "btnAPA";
            this.btnAPA.Size = new System.Drawing.Size(110, 39);
            this.btnAPA.TabIndex = 1;
            this.btnAPA.Text = "APA";
            this.btnAPA.Click += new System.EventHandler(this.btnAPA_Click);
            // 
            // btnMLA
            // 
            this.btnMLA.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMLA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMLA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMLA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMLA.FillColor = System.Drawing.Color.White;
            this.btnMLA.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMLA.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnMLA.Location = new System.Drawing.Point(237, 12);
            this.btnMLA.Name = "btnMLA";
            this.btnMLA.Size = new System.Drawing.Size(110, 39);
            this.btnMLA.TabIndex = 2;
            this.btnMLA.Text = "MLA";
            this.btnMLA.Click += new System.EventHandler(this.btnMLA_Click);
            // 
            // btnBibText
            // 
            this.btnBibText.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBibText.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBibText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBibText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBibText.FillColor = System.Drawing.Color.White;
            this.btnBibText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBibText.ForeColor = System.Drawing.Color.Blue;
            this.btnBibText.Location = new System.Drawing.Point(370, 12);
            this.btnBibText.Name = "btnBibText";
            this.btnBibText.Size = new System.Drawing.Size(110, 39);
            this.btnBibText.TabIndex = 3;
            this.btnBibText.Text = "BibTeX";
            this.btnBibText.Click += new System.EventHandler(this.btnBibText_Click);
            // 
            // frmViewTaiLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 750);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "frmViewTaiLieu";
            this.Text = "frmViewTaiLieu";
            this.Load += new System.EventHandler(this.frmViewTaiLieu_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Spire.PdfViewer.Forms.PdfViewer pdfViewer1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnMLA;
        private Guna.UI2.WinForms.Guna2Button btnAPA;
        private Guna.UI2.WinForms.Guna2Button btnBibText;
    }
}