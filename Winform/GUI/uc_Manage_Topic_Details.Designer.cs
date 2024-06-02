namespace GUI
{
    partial class uc_Manage_Topic_Details
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
            this.components = new System.ComponentModel.Container();
            this.pnlApproved = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPending = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPending = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtApproved = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtWaitingForThesisDefense = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlWaitingforThesisDefense = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDefendingThesis = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlDefendingThesis = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDefendingThesisCompleted = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlDefendingThesisCompleted = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.scrlPending = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.scrlApproved = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.scrlWaitingforThesis = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.scrlDefendingThesis = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.scrlDefendingCompleted = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // pnlApproved
            // 
            this.pnlApproved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.pnlApproved.Location = new System.Drawing.Point(341, 148);
            this.pnlApproved.Name = "pnlApproved";
            this.pnlApproved.Size = new System.Drawing.Size(310, 640);
            this.pnlApproved.TabIndex = 3;
            this.pnlApproved.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlApproved_Paint);
            // 
            // pnlPending
            // 
            this.pnlPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.pnlPending.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlPending.ForeColor = System.Drawing.Color.Black;
            this.pnlPending.Location = new System.Drawing.Point(14, 148);
            this.pnlPending.Name = "pnlPending";
            this.pnlPending.Size = new System.Drawing.Size(310, 640);
            this.pnlPending.TabIndex = 2;
            this.pnlPending.WrapContents = false;
            this.pnlPending.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPending_Paint);
            // 
            // txtPending
            // 
            this.txtPending.BorderRadius = 10;
            this.txtPending.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPending.DefaultText = "";
            this.txtPending.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPending.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPending.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPending.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPending.Enabled = false;
            this.txtPending.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.txtPending.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPending.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPending.ForeColor = System.Drawing.Color.Black;
            this.txtPending.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPending.Location = new System.Drawing.Point(14, 95);
            this.txtPending.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPending.Name = "txtPending";
            this.txtPending.PasswordChar = '\0';
            this.txtPending.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPending.PlaceholderText = "Pending (4)";
            this.txtPending.SelectedText = "";
            this.txtPending.Size = new System.Drawing.Size(310, 36);
            this.txtPending.TabIndex = 4;
            this.txtPending.TextOffset = new System.Drawing.Point(10, 0);
            this.txtPending.Load += new System.EventHandler(this.guna2TextBox1_Load);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 5;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Approved",
            "Waiting for thesis defense",
            "Defending thesis",
            "Defending thesis completed"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(1587, 18);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(131, 36);
            this.guna2ComboBox1.TabIndex = 5;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // txtApproved
            // 
            this.txtApproved.BorderRadius = 10;
            this.txtApproved.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApproved.DefaultText = "";
            this.txtApproved.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApproved.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApproved.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApproved.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApproved.Enabled = false;
            this.txtApproved.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.txtApproved.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApproved.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApproved.ForeColor = System.Drawing.Color.Black;
            this.txtApproved.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApproved.Location = new System.Drawing.Point(339, 95);
            this.txtApproved.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApproved.Name = "txtApproved";
            this.txtApproved.PasswordChar = '\0';
            this.txtApproved.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtApproved.PlaceholderText = "Approved (4)";
            this.txtApproved.SelectedText = "";
            this.txtApproved.Size = new System.Drawing.Size(310, 36);
            this.txtApproved.TabIndex = 7;
            this.txtApproved.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtWaitingForThesisDefense
            // 
            this.txtWaitingForThesisDefense.BorderRadius = 10;
            this.txtWaitingForThesisDefense.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWaitingForThesisDefense.DefaultText = "";
            this.txtWaitingForThesisDefense.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWaitingForThesisDefense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWaitingForThesisDefense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWaitingForThesisDefense.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWaitingForThesisDefense.Enabled = false;
            this.txtWaitingForThesisDefense.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.txtWaitingForThesisDefense.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWaitingForThesisDefense.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaitingForThesisDefense.ForeColor = System.Drawing.Color.Black;
            this.txtWaitingForThesisDefense.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWaitingForThesisDefense.Location = new System.Drawing.Point(686, 95);
            this.txtWaitingForThesisDefense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWaitingForThesisDefense.Name = "txtWaitingForThesisDefense";
            this.txtWaitingForThesisDefense.PasswordChar = '\0';
            this.txtWaitingForThesisDefense.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtWaitingForThesisDefense.PlaceholderText = "Waiting for thesis defense(3)";
            this.txtWaitingForThesisDefense.SelectedText = "";
            this.txtWaitingForThesisDefense.Size = new System.Drawing.Size(310, 36);
            this.txtWaitingForThesisDefense.TabIndex = 8;
            this.txtWaitingForThesisDefense.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // pnlWaitingforThesisDefense
            // 
            this.pnlWaitingforThesisDefense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.pnlWaitingforThesisDefense.Location = new System.Drawing.Point(686, 148);
            this.pnlWaitingforThesisDefense.Name = "pnlWaitingforThesisDefense";
            this.pnlWaitingforThesisDefense.Size = new System.Drawing.Size(310, 640);
            this.pnlWaitingforThesisDefense.TabIndex = 9;
            // 
            // txtDefendingThesis
            // 
            this.txtDefendingThesis.BorderRadius = 10;
            this.txtDefendingThesis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDefendingThesis.DefaultText = "";
            this.txtDefendingThesis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDefendingThesis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDefendingThesis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefendingThesis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefendingThesis.Enabled = false;
            this.txtDefendingThesis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.txtDefendingThesis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefendingThesis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefendingThesis.ForeColor = System.Drawing.Color.Black;
            this.txtDefendingThesis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefendingThesis.Location = new System.Drawing.Point(1027, 95);
            this.txtDefendingThesis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDefendingThesis.Name = "txtDefendingThesis";
            this.txtDefendingThesis.PasswordChar = '\0';
            this.txtDefendingThesis.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtDefendingThesis.PlaceholderText = "Defending thesis (0)";
            this.txtDefendingThesis.SelectedText = "";
            this.txtDefendingThesis.Size = new System.Drawing.Size(310, 36);
            this.txtDefendingThesis.TabIndex = 10;
            this.txtDefendingThesis.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // pnlDefendingThesis
            // 
            this.pnlDefendingThesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.pnlDefendingThesis.Location = new System.Drawing.Point(1027, 145);
            this.pnlDefendingThesis.Name = "pnlDefendingThesis";
            this.pnlDefendingThesis.Size = new System.Drawing.Size(310, 643);
            this.pnlDefendingThesis.TabIndex = 11;
            // 
            // txtDefendingThesisCompleted
            // 
            this.txtDefendingThesisCompleted.BorderRadius = 10;
            this.txtDefendingThesisCompleted.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDefendingThesisCompleted.DefaultText = "";
            this.txtDefendingThesisCompleted.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDefendingThesisCompleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDefendingThesisCompleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefendingThesisCompleted.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDefendingThesisCompleted.Enabled = false;
            this.txtDefendingThesisCompleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.txtDefendingThesisCompleted.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefendingThesisCompleted.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefendingThesisCompleted.ForeColor = System.Drawing.Color.Black;
            this.txtDefendingThesisCompleted.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDefendingThesisCompleted.Location = new System.Drawing.Point(1379, 95);
            this.txtDefendingThesisCompleted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDefendingThesisCompleted.Name = "txtDefendingThesisCompleted";
            this.txtDefendingThesisCompleted.PasswordChar = '\0';
            this.txtDefendingThesisCompleted.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtDefendingThesisCompleted.PlaceholderText = "Defending thesis completed (10)";
            this.txtDefendingThesisCompleted.SelectedText = "";
            this.txtDefendingThesisCompleted.Size = new System.Drawing.Size(310, 36);
            this.txtDefendingThesisCompleted.TabIndex = 12;
            this.txtDefendingThesisCompleted.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // pnlDefendingThesisCompleted
            // 
            this.pnlDefendingThesisCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.pnlDefendingThesisCompleted.Location = new System.Drawing.Point(1379, 145);
            this.pnlDefendingThesisCompleted.Name = "pnlDefendingThesisCompleted";
            this.pnlDefendingThesisCompleted.Size = new System.Drawing.Size(310, 643);
            this.pnlDefendingThesisCompleted.TabIndex = 12;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.pnlApproved;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.pnlWaitingforThesisDefense;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.pnlDefendingThesis;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.pnlWaitingforThesisDefense;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.pnlDefendingThesisCompleted;
            // 
            // scrlPending
            // 
            this.scrlPending.BorderRadius = 5;
            this.scrlPending.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.scrlPending.InUpdate = false;
            this.scrlPending.LargeChange = 20;
            this.scrlPending.Location = new System.Drawing.Point(325, 148);
            this.scrlPending.Name = "scrlPending";
            this.scrlPending.ScrollbarSize = 10;
            this.scrlPending.Size = new System.Drawing.Size(10, 640);
            this.scrlPending.TabIndex = 19;
            this.scrlPending.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlPending_Scroll);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // scrlApproved
            // 
            this.scrlApproved.BorderRadius = 5;
            this.scrlApproved.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.scrlApproved.InUpdate = false;
            this.scrlApproved.LargeChange = 20;
            this.scrlApproved.Location = new System.Drawing.Point(650, 148);
            this.scrlApproved.Name = "scrlApproved";
            this.scrlApproved.ScrollbarSize = 10;
            this.scrlApproved.Size = new System.Drawing.Size(10, 640);
            this.scrlApproved.TabIndex = 20;
            // 
            // scrlWaitingforThesis
            // 
            this.scrlWaitingforThesis.BorderRadius = 5;
            this.scrlWaitingforThesis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.scrlWaitingforThesis.InUpdate = false;
            this.scrlWaitingforThesis.LargeChange = 20;
            this.scrlWaitingforThesis.Location = new System.Drawing.Point(998, 148);
            this.scrlWaitingforThesis.Name = "scrlWaitingforThesis";
            this.scrlWaitingforThesis.ScrollbarSize = 10;
            this.scrlWaitingforThesis.Size = new System.Drawing.Size(10, 640);
            this.scrlWaitingforThesis.TabIndex = 21;
            // 
            // scrlDefendingThesis
            // 
            this.scrlDefendingThesis.BorderRadius = 5;
            this.scrlDefendingThesis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.scrlDefendingThesis.InUpdate = false;
            this.scrlDefendingThesis.LargeChange = 20;
            this.scrlDefendingThesis.Location = new System.Drawing.Point(1336, 148);
            this.scrlDefendingThesis.Name = "scrlDefendingThesis";
            this.scrlDefendingThesis.ScrollbarSize = 10;
            this.scrlDefendingThesis.Size = new System.Drawing.Size(10, 640);
            this.scrlDefendingThesis.TabIndex = 22;
            // 
            // scrlDefendingCompleted
            // 
            this.scrlDefendingCompleted.BorderRadius = 5;
            this.scrlDefendingCompleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.scrlDefendingCompleted.InUpdate = false;
            this.scrlDefendingCompleted.LargeChange = 20;
            this.scrlDefendingCompleted.Location = new System.Drawing.Point(1690, 145);
            this.scrlDefendingCompleted.Name = "scrlDefendingCompleted";
            this.scrlDefendingCompleted.ScrollbarSize = 10;
            this.scrlDefendingCompleted.Size = new System.Drawing.Size(10, 640);
            this.scrlDefendingCompleted.TabIndex = 23;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "Export";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.Enabled = false;
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.IconLeft = global::GUI.Properties.Resources.icons8_cloud_download_501;
            this.guna2TextBox2.Location = new System.Drawing.Point(1587, 18);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.PlaceholderText = "Export";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(102, 36);
            this.guna2TextBox2.TabIndex = 6;
            this.guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2TextBox2.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(1148, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search something";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(431, 36);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderRadius = 5;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Approved",
            "Waiting for Thesis Defense",
            "Defending Thesis",
            "Defending Thesis Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(998, 18);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(140, 36);
            this.cmbStatus.StartIndex = 0;
            this.cmbStatus.TabIndex = 25;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // uc_Manage_Topic_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.scrlDefendingCompleted);
            this.Controls.Add(this.scrlDefendingThesis);
            this.Controls.Add(this.scrlWaitingforThesis);
            this.Controls.Add(this.scrlApproved);
            this.Controls.Add(this.scrlPending);
            this.Controls.Add(this.pnlDefendingThesisCompleted);
            this.Controls.Add(this.txtDefendingThesisCompleted);
            this.Controls.Add(this.pnlDefendingThesis);
            this.Controls.Add(this.txtDefendingThesis);
            this.Controls.Add(this.pnlWaitingforThesisDefense);
            this.Controls.Add(this.txtWaitingForThesisDefense);
            this.Controls.Add(this.txtApproved);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.txtPending);
            this.Controls.Add(this.pnlApproved);
            this.Controls.Add(this.pnlPending);
            this.Name = "uc_Manage_Topic_Details";
            this.Size = new System.Drawing.Size(1737, 919);
            this.Load += new System.EventHandler(this.uc_Manage_Topic_Details_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlApproved;
        private System.Windows.Forms.FlowLayoutPanel pnlPending;
        private Guna.UI2.WinForms.Guna2TextBox txtPending;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtApproved;
        private Guna.UI2.WinForms.Guna2TextBox txtWaitingForThesisDefense;
        private System.Windows.Forms.FlowLayoutPanel pnlWaitingforThesisDefense;
        private Guna.UI2.WinForms.Guna2TextBox txtDefendingThesis;
        private System.Windows.Forms.FlowLayoutPanel pnlDefendingThesis;
        private Guna.UI2.WinForms.Guna2TextBox txtDefendingThesisCompleted;
        private System.Windows.Forms.FlowLayoutPanel pnlDefendingThesisCompleted;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Guna.UI2.WinForms.Guna2VScrollBar scrlPending;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2VScrollBar scrlApproved;
        private Guna.UI2.WinForms.Guna2VScrollBar scrlWaitingforThesis;
        private Guna.UI2.WinForms.Guna2VScrollBar scrlDefendingThesis;
        private Guna.UI2.WinForms.Guna2VScrollBar scrlDefendingCompleted;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
    }
}
