namespace pharmacyp.Forms
{
    partial class MainForm1
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Sidebar = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.logoutbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.settingsbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.reportbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.sellingbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.storagebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.homebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblrole = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.hometab1 = new pharmacyp.TabContainer.Hometab();
            this.settingstab1 = new pharmacyp.TabContainer.Settingstab();
            this.reporttab1 = new pharmacyp.TabContainer.Reporttab();
            this.sellingtab1 = new pharmacyp.TabContainer.Sellingtab();
            this.storagetab1 = new pharmacyp.TabContainer.Storagetab();
            this.Sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.guna2BorderlessForm1.BorderRadius = 35;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.IndianRed;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.White;
            this.Sidebar.Controls.Add(this.logoutbtn);
            this.Sidebar.Controls.Add(this.settingsbtn);
            this.Sidebar.Controls.Add(this.reportbtn);
            this.Sidebar.Controls.Add(this.sellingbtn);
            this.Sidebar.Controls.Add(this.storagebtn);
            this.Sidebar.Controls.Add(this.homebtn);
            this.Sidebar.Controls.Add(this.panel1);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Sidebar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(199)))), ((int)(((byte)(178)))));
            this.Sidebar.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(199)))), ((int)(((byte)(178)))));
            this.Sidebar.Location = new System.Drawing.Point(1849, 0);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.Sidebar.MaximumSize = new System.Drawing.Size(250, 0);
            this.Sidebar.MinimumSize = new System.Drawing.Size(71, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(71, 1080);
            this.Sidebar.TabIndex = 0;
            this.Sidebar.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.Sidebar.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutbtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutbtn.BorderColor = System.Drawing.Color.Transparent;
            this.logoutbtn.BorderRadius = 8;
            this.logoutbtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.logoutbtn.CustomizableEdges.BottomRight = false;
            this.logoutbtn.CustomizableEdges.TopRight = false;
            this.logoutbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(205)))), ((int)(((byte)(188)))));
            this.logoutbtn.FillColor2 = System.Drawing.Color.White;
            this.logoutbtn.Font = new System.Drawing.Font("UniQAIDAR_A7MED", 14F);
            this.logoutbtn.ForeColor = System.Drawing.Color.Black;
            this.logoutbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(175)))), ((int)(((byte)(150)))));
            this.logoutbtn.HoverState.FillColor2 = System.Drawing.Color.White;
            this.logoutbtn.Image = global::pharmacyp.Properties.Resources.Exit;
            this.logoutbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.logoutbtn.Location = new System.Drawing.Point(15, 509);
            this.logoutbtn.MaximumSize = new System.Drawing.Size(250, 62);
            this.logoutbtn.MinimumSize = new System.Drawing.Size(50, 62);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.PressedColor = System.Drawing.Color.PaleTurquoise;
            this.logoutbtn.PressedDepth = 45;
            this.logoutbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logoutbtn.Size = new System.Drawing.Size(50, 62);
            this.logoutbtn.TabIndex = 6;
            this.logoutbtn.Text = "چوونەدەرەوە";
            this.logoutbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutbtn.Click += new System.EventHandler(this.Button_Click);
            this.logoutbtn.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.logoutbtn.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // settingsbtn
            // 
            this.settingsbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsbtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsbtn.BorderColor = System.Drawing.Color.Transparent;
            this.settingsbtn.BorderRadius = 8;
            this.settingsbtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.settingsbtn.CustomizableEdges.BottomRight = false;
            this.settingsbtn.CustomizableEdges.TopRight = false;
            this.settingsbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingsbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingsbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingsbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(205)))), ((int)(((byte)(188)))));
            this.settingsbtn.FillColor2 = System.Drawing.Color.White;
            this.settingsbtn.Font = new System.Drawing.Font("UniQAIDAR_A7MED", 14F);
            this.settingsbtn.ForeColor = System.Drawing.Color.Black;
            this.settingsbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(175)))), ((int)(((byte)(150)))));
            this.settingsbtn.HoverState.FillColor2 = System.Drawing.Color.White;
            this.settingsbtn.Image = global::pharmacyp.Properties.Resources.Settingss;
            this.settingsbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.settingsbtn.Location = new System.Drawing.Point(15, 439);
            this.settingsbtn.MaximumSize = new System.Drawing.Size(250, 62);
            this.settingsbtn.MinimumSize = new System.Drawing.Size(50, 62);
            this.settingsbtn.Name = "settingsbtn";
            this.settingsbtn.PressedColor = System.Drawing.Color.PaleTurquoise;
            this.settingsbtn.PressedDepth = 45;
            this.settingsbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.settingsbtn.Size = new System.Drawing.Size(50, 62);
            this.settingsbtn.TabIndex = 5;
            this.settingsbtn.Text = "ڕێکخستنەکان";
            this.settingsbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsbtn.Click += new System.EventHandler(this.Button_Click);
            this.settingsbtn.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.settingsbtn.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // reportbtn
            // 
            this.reportbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportbtn.BackColor = System.Drawing.Color.Transparent;
            this.reportbtn.BorderColor = System.Drawing.Color.Transparent;
            this.reportbtn.BorderRadius = 8;
            this.reportbtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.reportbtn.CustomizableEdges.BottomRight = false;
            this.reportbtn.CustomizableEdges.TopRight = false;
            this.reportbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reportbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reportbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reportbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reportbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reportbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(205)))), ((int)(((byte)(188)))));
            this.reportbtn.FillColor2 = System.Drawing.Color.White;
            this.reportbtn.Font = new System.Drawing.Font("UniQAIDAR_A7MED", 14F);
            this.reportbtn.ForeColor = System.Drawing.Color.Black;
            this.reportbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(175)))), ((int)(((byte)(150)))));
            this.reportbtn.HoverState.FillColor2 = System.Drawing.Color.White;
            this.reportbtn.Image = global::pharmacyp.Properties.Resources.Report;
            this.reportbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reportbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.reportbtn.Location = new System.Drawing.Point(15, 369);
            this.reportbtn.MaximumSize = new System.Drawing.Size(250, 62);
            this.reportbtn.MinimumSize = new System.Drawing.Size(50, 62);
            this.reportbtn.Name = "reportbtn";
            this.reportbtn.PressedColor = System.Drawing.Color.PaleTurquoise;
            this.reportbtn.PressedDepth = 45;
            this.reportbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reportbtn.Size = new System.Drawing.Size(50, 62);
            this.reportbtn.TabIndex = 4;
            this.reportbtn.Text = "ڕاپۆرت";
            this.reportbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reportbtn.Click += new System.EventHandler(this.Button_Click);
            this.reportbtn.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.reportbtn.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // sellingbtn
            // 
            this.sellingbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellingbtn.BackColor = System.Drawing.Color.Transparent;
            this.sellingbtn.BorderColor = System.Drawing.Color.Transparent;
            this.sellingbtn.BorderRadius = 8;
            this.sellingbtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.sellingbtn.CustomizableEdges.BottomRight = false;
            this.sellingbtn.CustomizableEdges.TopRight = false;
            this.sellingbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sellingbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sellingbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sellingbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sellingbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sellingbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(205)))), ((int)(((byte)(188)))));
            this.sellingbtn.FillColor2 = System.Drawing.Color.White;
            this.sellingbtn.Font = new System.Drawing.Font("UniQAIDAR_A7MED", 14F);
            this.sellingbtn.ForeColor = System.Drawing.Color.Black;
            this.sellingbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(175)))), ((int)(((byte)(150)))));
            this.sellingbtn.HoverState.FillColor2 = System.Drawing.Color.White;
            this.sellingbtn.Image = global::pharmacyp.Properties.Resources.selling;
            this.sellingbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sellingbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.sellingbtn.Location = new System.Drawing.Point(15, 299);
            this.sellingbtn.MaximumSize = new System.Drawing.Size(250, 62);
            this.sellingbtn.MinimumSize = new System.Drawing.Size(50, 62);
            this.sellingbtn.Name = "sellingbtn";
            this.sellingbtn.PressedColor = System.Drawing.Color.PaleTurquoise;
            this.sellingbtn.PressedDepth = 45;
            this.sellingbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sellingbtn.Size = new System.Drawing.Size(50, 62);
            this.sellingbtn.TabIndex = 3;
            this.sellingbtn.Text = "فرۆشتن";
            this.sellingbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sellingbtn.Click += new System.EventHandler(this.Button_Click);
            this.sellingbtn.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.sellingbtn.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // storagebtn
            // 
            this.storagebtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storagebtn.BackColor = System.Drawing.Color.Transparent;
            this.storagebtn.BorderColor = System.Drawing.Color.Transparent;
            this.storagebtn.BorderRadius = 8;
            this.storagebtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.storagebtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(54)))), ((int)(((byte)(40)))));
            this.storagebtn.CustomizableEdges.BottomRight = false;
            this.storagebtn.CustomizableEdges.TopRight = false;
            this.storagebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.storagebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.storagebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.storagebtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.storagebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.storagebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(205)))), ((int)(((byte)(188)))));
            this.storagebtn.FillColor2 = System.Drawing.Color.White;
            this.storagebtn.Font = new System.Drawing.Font("UniQAIDAR_A7MED", 14F);
            this.storagebtn.ForeColor = System.Drawing.Color.Black;
            this.storagebtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(175)))), ((int)(((byte)(150)))));
            this.storagebtn.HoverState.FillColor2 = System.Drawing.Color.White;
            this.storagebtn.Image = global::pharmacyp.Properties.Resources.Storagepng;
            this.storagebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.storagebtn.ImageSize = new System.Drawing.Size(30, 30);
            this.storagebtn.Location = new System.Drawing.Point(15, 229);
            this.storagebtn.MaximumSize = new System.Drawing.Size(250, 62);
            this.storagebtn.MinimumSize = new System.Drawing.Size(50, 62);
            this.storagebtn.Name = "storagebtn";
            this.storagebtn.PressedColor = System.Drawing.Color.PaleTurquoise;
            this.storagebtn.PressedDepth = 45;
            this.storagebtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.storagebtn.Size = new System.Drawing.Size(50, 62);
            this.storagebtn.TabIndex = 2;
            this.storagebtn.Text = "کۆگا";
            this.storagebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.storagebtn.Click += new System.EventHandler(this.Button_Click);
            this.storagebtn.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.storagebtn.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // homebtn
            // 
            this.homebtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homebtn.BackColor = System.Drawing.Color.Transparent;
            this.homebtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(147)))), ((int)(((byte)(132)))));
            this.homebtn.BorderRadius = 8;
            this.homebtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.homebtn.BorderThickness = 1;
            this.homebtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(147)))), ((int)(((byte)(132)))));
            this.homebtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.homebtn.CustomizableEdges.BottomRight = false;
            this.homebtn.CustomizableEdges.TopRight = false;
            this.homebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homebtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(199)))), ((int)(((byte)(178)))));
            this.homebtn.FillColor2 = System.Drawing.Color.White;
            this.homebtn.Font = new System.Drawing.Font("UniQAIDAR_A7MED", 14F);
            this.homebtn.ForeColor = System.Drawing.Color.Black;
            this.homebtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(175)))), ((int)(((byte)(150)))));
            this.homebtn.HoverState.FillColor2 = System.Drawing.Color.White;
            this.homebtn.Image = global::pharmacyp.Properties.Resources.home_ic;
            this.homebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homebtn.ImageSize = new System.Drawing.Size(30, 30);
            this.homebtn.Location = new System.Drawing.Point(15, 159);
            this.homebtn.MaximumSize = new System.Drawing.Size(250, 62);
            this.homebtn.MinimumSize = new System.Drawing.Size(50, 62);
            this.homebtn.Name = "homebtn";
            this.homebtn.PressedColor = System.Drawing.Color.PaleTurquoise;
            this.homebtn.PressedDepth = 45;
            this.homebtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.homebtn.Size = new System.Drawing.Size(50, 62);
            this.homebtn.TabIndex = 1;
            this.homebtn.Text = "سەرەکی";
            this.homebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homebtn.Click += new System.EventHandler(this.Button_Click);
            this.homebtn.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.homebtn.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblrole);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 135);
            this.panel1.TabIndex = 0;
            // 
            // lblrole
            // 
            this.lblrole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblrole.AutoSize = true;
            this.lblrole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblrole.Font = new System.Drawing.Font("UniQAIDAR_A7MED", 14F);
            this.lblrole.ForeColor = System.Drawing.Color.Black;
            this.lblrole.Location = new System.Drawing.Point(18, 67);
            this.lblrole.Margin = new System.Windows.Forms.Padding(0);
            this.lblrole.Name = "lblrole";
            this.lblrole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblrole.Size = new System.Drawing.Size(42, 35);
            this.lblrole.TabIndex = 1;
            this.lblrole.Text = "پلە:";
            // 
            // lblname
            // 
            this.lblname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("UniQAIDAR_A7MED", 14F);
            this.lblname.ForeColor = System.Drawing.Color.Black;
            this.lblname.Location = new System.Drawing.Point(18, 23);
            this.lblname.Margin = new System.Windows.Forms.Padding(0);
            this.lblname.Name = "lblname";
            this.lblname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblname.Size = new System.Drawing.Size(39, 35);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "ناو:";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hometab1
            // 
            this.hometab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hometab1.Location = new System.Drawing.Point(0, 0);
            this.hometab1.Margin = new System.Windows.Forms.Padding(0);
            this.hometab1.Name = "hometab1";
            this.hometab1.Size = new System.Drawing.Size(1849, 1080);
            this.hometab1.TabIndex = 1;
            // 
            // settingstab1
            // 
            this.settingstab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingstab1.Location = new System.Drawing.Point(0, 0);
            this.settingstab1.Name = "settingstab1";
            this.settingstab1.Size = new System.Drawing.Size(1920, 1080);
            this.settingstab1.TabIndex = 5;
            this.settingstab1.TabStop = false;
            // 
            // reporttab1
            // 
            this.reporttab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporttab1.Location = new System.Drawing.Point(0, 0);
            this.reporttab1.Margin = new System.Windows.Forms.Padding(0);
            this.reporttab1.Name = "reporttab1";
            this.reporttab1.Size = new System.Drawing.Size(1920, 1080);
            this.reporttab1.TabIndex = 4;
            this.reporttab1.TabStop = false;
            // 
            // sellingtab1
            // 
            this.sellingtab1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sellingtab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellingtab1.Location = new System.Drawing.Point(0, 0);
            this.sellingtab1.Margin = new System.Windows.Forms.Padding(0);
            this.sellingtab1.Name = "sellingtab1";
            this.sellingtab1.Size = new System.Drawing.Size(1920, 1080);
            this.sellingtab1.TabIndex = 3;
            this.sellingtab1.TabStop = false;
            this.sellingtab1.UserID = 1;
            // 
            // storagetab1
            // 
            this.storagetab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storagetab1.Location = new System.Drawing.Point(0, 0);
            this.storagetab1.Margin = new System.Windows.Forms.Padding(0);
            this.storagetab1.Name = "storagetab1";
            this.storagetab1.Size = new System.Drawing.Size(1920, 1080);
            this.storagetab1.TabIndex = 2;
            this.storagetab1.TabStop = false;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.hometab1);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.settingstab1);
            this.Controls.Add(this.reporttab1);
            this.Controls.Add(this.storagetab1);
            this.Controls.Add(this.sellingtab1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(620, 341);
            this.Name = "MainForm1";
            this.RightToLeftLayout = true;
            this.Text = "MainForm1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm1_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm1_KeyPress);
            this.Sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Sidebar;
        private Guna.UI2.WinForms.Guna2GradientButton settingsbtn;
        private Guna.UI2.WinForms.Guna2GradientButton reportbtn;
        private Guna.UI2.WinForms.Guna2GradientButton sellingbtn;
        private Guna.UI2.WinForms.Guna2GradientButton homebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.Label lblname;
        private Guna.UI2.WinForms.Guna2GradientButton logoutbtn;
        private TabContainer.Storagetab storagetab1;
        private TabContainer.Hometab hometab1;
        private TabContainer.Reporttab reporttab1;
        private TabContainer.Sellingtab sellingtab1;
        private TabContainer.Settingstab settingstab1;
        private Guna.UI2.WinForms.Guna2GradientButton storagebtn;
    }
}