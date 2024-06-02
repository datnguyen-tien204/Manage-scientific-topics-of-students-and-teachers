namespace GUI
{
    partial class uc_Student_Dashboard
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
            Guna.Charts.WinForms.ChartFont chartFont9 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont10 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont11 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont12 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid4 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick4 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont13 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid5 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick5 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont14 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid6 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel2 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont15 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick6 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont16 = new Guna.Charts.WinForms.ChartFont();
            this.btnNotification = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.chtThongKe = new Guna.Charts.WinForms.GunaChart();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNotification
            // 
            this.btnNotification.Animated = true;
            this.btnNotification.AnimatedGIF = true;
            this.btnNotification.BackColor = System.Drawing.Color.Transparent;
            this.btnNotification.BorderRadius = 10;
            this.btnNotification.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnNotification.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNotification.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNotification.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNotification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNotification.FillColor = System.Drawing.Color.LightGray;
            this.btnNotification.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNotification.ForeColor = System.Drawing.Color.Black;
            this.btnNotification.Image = global::GUI.Properties.Resources.icons8_notification_64;
            this.btnNotification.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNotification.ImageOffset = new System.Drawing.Point(14, 0);
            this.btnNotification.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNotification.Location = new System.Drawing.Point(31, 22);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(230, 67);
            this.btnNotification.TabIndex = 35;
            this.btnNotification.Text = "Check status topics";
            this.btnNotification.TextOffset = new System.Drawing.Point(30, 0);
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.chtThongKe);
            this.guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(31, 171);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(595, 462);
            this.guna2CustomGradientPanel1.TabIndex = 36;
            // 
            // chtThongKe
            // 
            this.chtThongKe.BackColor = System.Drawing.Color.White;
            this.chtThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            chartFont9.FontName = "Arial";
            this.chtThongKe.Legend.LabelFont = chartFont9;
            this.chtThongKe.Location = new System.Drawing.Point(0, 0);
            this.chtThongKe.Name = "chtThongKe";
            this.chtThongKe.Size = new System.Drawing.Size(595, 462);
            this.chtThongKe.TabIndex = 0;
            chartFont10.FontName = "Arial";
            chartFont10.Size = 12;
            chartFont10.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.chtThongKe.Title.Font = chartFont10;
            chartFont11.FontName = "Arial";
            this.chtThongKe.Tooltips.BodyFont = chartFont11;
            chartFont12.FontName = "Arial";
            chartFont12.Size = 9;
            chartFont12.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.chtThongKe.Tooltips.TitleFont = chartFont12;
            this.chtThongKe.XAxes.GridLines = grid4;
            chartFont13.FontName = "Arial";
            tick4.Font = chartFont13;
            this.chtThongKe.XAxes.Ticks = tick4;
            this.chtThongKe.YAxes.GridLines = grid5;
            chartFont14.FontName = "Arial";
            tick5.Font = chartFont14;
            this.chtThongKe.YAxes.Ticks = tick5;
            this.chtThongKe.ZAxes.GridLines = grid6;
            chartFont15.FontName = "Arial";
            pointLabel2.Font = chartFont15;
            this.chtThongKe.ZAxes.PointLabels = pointLabel2;
            chartFont16.FontName = "Arial";
            tick6.Font = chartFont16;
            this.chtThongKe.ZAxes.Ticks = tick6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(190, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Number topics though batch";
            // 
            // uc_Student_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.btnNotification);
            this.Name = "uc_Student_Dashboard";
            this.Size = new System.Drawing.Size(1314, 733);
            this.Load += new System.EventHandler(this.uc_Student_Dashboard_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnNotification;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.Charts.WinForms.GunaChart chtThongKe;
        private System.Windows.Forms.Label label1;
    }
}
