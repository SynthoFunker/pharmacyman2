namespace pharmacyp
{
    partial class mainform
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
            this.side_animation = new System.Windows.Forms.Timer(this.components);
            this.expbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.homebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tabcon = new System.Windows.Forms.Panel();
            this.closebtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.bcbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.usbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.finbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.repbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.solbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.selbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.profilepic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Cbar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.strbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.sidebar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).BeginInit();
            this.Cbar.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // side_animation
            // 
            this.side_animation.Interval = 35;
            this.side_animation.Tick += new System.EventHandler(this.side_animation_Tick);
            // 
            // expbtn
            // 
            this.expbtn.Animated = true;
            this.expbtn.BackColor = System.Drawing.Color.Transparent;
            this.expbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.expbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.expbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.expbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.expbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.expbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.expbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.expbtn.Font = new System.Drawing.Font("RudawRegular", 13F);
            this.expbtn.ForeColor = System.Drawing.Color.White;
            this.expbtn.Image = global::pharmacyp.Properties.Resources.miscellaneous;
            this.expbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.expbtn.ImageSize = new System.Drawing.Size(35, 35);
            this.expbtn.Location = new System.Drawing.Point(0, 572);
            this.expbtn.Margin = new System.Windows.Forms.Padding(0);
            this.expbtn.Name = "expbtn";
            this.expbtn.Size = new System.Drawing.Size(266, 76);
            this.expbtn.TabIndex = 6;
            this.expbtn.Text = "بـــەســەرجــوون";
            this.expbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.expbtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.expbtn.Click += new System.EventHandler(this.expbtn_Click);
            this.expbtn.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.expbtn.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // homebtn
            // 
            this.homebtn.Animated = true;
            this.homebtn.BackColor = System.Drawing.Color.Transparent;
            this.homebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homebtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.homebtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.homebtn.Font = new System.Drawing.Font("RudawRegular", 14F);
            this.homebtn.ForeColor = System.Drawing.Color.White;
            this.homebtn.Image = global::pharmacyp.Properties.Resources.home__1_;
            this.homebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.homebtn.ImageSize = new System.Drawing.Size(35, 35);
            this.homebtn.Location = new System.Drawing.Point(0, 192);
            this.homebtn.Margin = new System.Windows.Forms.Padding(0);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(266, 76);
            this.homebtn.TabIndex = 1;
            this.homebtn.Text = "ســەرەکی";
            this.homebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.homebtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            this.homebtn.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.homebtn.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // tabcon
            // 
            this.tabcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcon.Location = new System.Drawing.Point(0, 44);
            this.tabcon.Margin = new System.Windows.Forms.Padding(0);
            this.tabcon.Name = "tabcon";
            this.tabcon.Size = new System.Drawing.Size(1654, 1036);
            this.tabcon.TabIndex = 5;
            // 
            // closebtn
            // 
            this.closebtn.Animated = true;
            this.closebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.closebtn.BorderColor = System.Drawing.Color.Transparent;
            this.closebtn.CustomIconSize = 1F;
            this.closebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.closebtn.IconColor = System.Drawing.Color.Black;
            this.closebtn.Location = new System.Drawing.Point(1871, 0);
            this.closebtn.Margin = new System.Windows.Forms.Padding(0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(49, 44);
            this.closebtn.TabIndex = 0;
            // 
            // bcbtn
            // 
            this.bcbtn.Animated = true;
            this.bcbtn.BackColor = System.Drawing.Color.Transparent;
            this.bcbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bcbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bcbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bcbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bcbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bcbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.bcbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.bcbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.bcbtn.Font = new System.Drawing.Font("RudawRegular", 13F);
            this.bcbtn.ForeColor = System.Drawing.Color.White;
            this.bcbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bcbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bcbtn.ImageSize = new System.Drawing.Size(35, 35);
            this.bcbtn.Location = new System.Drawing.Point(0, 800);
            this.bcbtn.Margin = new System.Windows.Forms.Padding(0);
            this.bcbtn.Name = "bcbtn";
            this.bcbtn.Size = new System.Drawing.Size(266, 76);
            this.bcbtn.TabIndex = 9;
            this.bcbtn.Text = "پــاراستنی سـیـستەم";
            this.bcbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bcbtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.bcbtn.Click += new System.EventHandler(this.bcbtn_Click);
            this.bcbtn.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.bcbtn.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // usbtn
            // 
            this.usbtn.Animated = true;
            this.usbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.usbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.usbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.usbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.usbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.usbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.usbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.usbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.usbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.usbtn.Font = new System.Drawing.Font("RudawRegular", 13F);
            this.usbtn.ForeColor = System.Drawing.Color.White;
            this.usbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.usbtn.ImageSize = new System.Drawing.Size(35, 35);
            this.usbtn.Location = new System.Drawing.Point(0, 724);
            this.usbtn.Margin = new System.Windows.Forms.Padding(0);
            this.usbtn.Name = "usbtn";
            this.usbtn.Size = new System.Drawing.Size(266, 76);
            this.usbtn.TabIndex = 8;
            this.usbtn.Text = "بـەکـارهـێـنەران";
            this.usbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.usbtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.usbtn.Click += new System.EventHandler(this.usbtn_Click);
            this.usbtn.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.usbtn.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // finbtn
            // 
            this.finbtn.Animated = true;
            this.finbtn.BackColor = System.Drawing.Color.Transparent;
            this.finbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.finbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.finbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.finbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.finbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.finbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.finbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.finbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.finbtn.Font = new System.Drawing.Font("RudawRegular", 13F);
            this.finbtn.ForeColor = System.Drawing.Color.White;
            this.finbtn.Image = global::pharmacyp.Properties.Resources.remove_from_cart1;
            this.finbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.finbtn.ImageSize = new System.Drawing.Size(35, 35);
            this.finbtn.Location = new System.Drawing.Point(0, 648);
            this.finbtn.Margin = new System.Windows.Forms.Padding(0);
            this.finbtn.Name = "finbtn";
            this.finbtn.Size = new System.Drawing.Size(266, 76);
            this.finbtn.TabIndex = 7;
            this.finbtn.Text = "تــەواوبـــوون";
            this.finbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.finbtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.finbtn.Click += new System.EventHandler(this.finbtn_Click);
            this.finbtn.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.finbtn.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // repbtn
            // 
            this.repbtn.Animated = true;
            this.repbtn.BackColor = System.Drawing.Color.Transparent;
            this.repbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.repbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.repbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.repbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.repbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.repbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.repbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.repbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.repbtn.Font = new System.Drawing.Font("RudawRegular", 13F);
            this.repbtn.ForeColor = System.Drawing.Color.White;
            this.repbtn.Image = global::pharmacyp.Properties.Resources.seo_report;
            this.repbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.repbtn.ImageSize = new System.Drawing.Size(35, 35);
            this.repbtn.Location = new System.Drawing.Point(0, 496);
            this.repbtn.Margin = new System.Windows.Forms.Padding(0);
            this.repbtn.Name = "repbtn";
            this.repbtn.Size = new System.Drawing.Size(266, 76);
            this.repbtn.TabIndex = 5;
            this.repbtn.Text = "ڕاپــــۆرت";
            this.repbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.repbtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.repbtn.Click += new System.EventHandler(this.repbtn_Click);
            this.repbtn.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.repbtn.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // solbtn
            // 
            this.solbtn.Animated = true;
            this.solbtn.BackColor = System.Drawing.Color.Transparent;
            this.solbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.solbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.solbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.solbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.solbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.solbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.solbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.solbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.solbtn.Font = new System.Drawing.Font("RudawRegular", 13F);
            this.solbtn.ForeColor = System.Drawing.Color.White;
            this.solbtn.Image = global::pharmacyp.Properties.Resources.remove_from_cart;
            this.solbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.solbtn.ImageSize = new System.Drawing.Size(35, 35);
            this.solbtn.Location = new System.Drawing.Point(0, 420);
            this.solbtn.Margin = new System.Windows.Forms.Padding(0);
            this.solbtn.Name = "solbtn";
            this.solbtn.Size = new System.Drawing.Size(266, 76);
            this.solbtn.TabIndex = 4;
            this.solbtn.Text = "فــرۆشــراوەکــان";
            this.solbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.solbtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.solbtn.Click += new System.EventHandler(this.solbtn_Click);
            this.solbtn.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.solbtn.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // selbtn
            // 
            this.selbtn.Animated = true;
            this.selbtn.BackColor = System.Drawing.Color.Transparent;
            this.selbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.selbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.selbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.selbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.selbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.selbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.selbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.selbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.selbtn.Font = new System.Drawing.Font("RudawRegular", 13F);
            this.selbtn.ForeColor = System.Drawing.Color.White;
            this.selbtn.Image = global::pharmacyp.Properties.Resources.trade;
            this.selbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.selbtn.ImageSize = new System.Drawing.Size(35, 35);
            this.selbtn.Location = new System.Drawing.Point(0, 344);
            this.selbtn.Margin = new System.Windows.Forms.Padding(0);
            this.selbtn.Name = "selbtn";
            this.selbtn.Size = new System.Drawing.Size(266, 76);
            this.selbtn.TabIndex = 3;
            this.selbtn.Text = "فــرۆشــتــن";
            this.selbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.selbtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.selbtn.Click += new System.EventHandler(this.selbtn_Click);
            this.selbtn.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.selbtn.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel2.Controls.Add(this.label1);
            this.guna2GradientPanel2.Controls.Add(this.profilepic);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(266, 192);
            this.guna2GradientPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("RudawRegular", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ناو";
            // 
            // profilepic
            // 
            this.profilepic.ImageRotate = 0F;
            this.profilepic.Location = new System.Drawing.Point(71, 13);
            this.profilepic.Name = "profilepic";
            this.profilepic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilepic.Size = new System.Drawing.Size(124, 123);
            this.profilepic.TabIndex = 0;
            this.profilepic.TabStop = false;
            // 
            // Cbar
            // 
            this.Cbar.Controls.Add(this.closebtn);
            this.Cbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.Cbar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.Cbar.Location = new System.Drawing.Point(0, 0);
            this.Cbar.Margin = new System.Windows.Forms.Padding(0);
            this.Cbar.Name = "Cbar";
            this.Cbar.Size = new System.Drawing.Size(1920, 44);
            this.Cbar.TabIndex = 4;
            // 
            // strbtn
            // 
            this.strbtn.Animated = true;
            this.strbtn.BackColor = System.Drawing.Color.Transparent;
            this.strbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.strbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.strbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.strbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.strbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.strbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.strbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.strbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.strbtn.Font = new System.Drawing.Font("RudawRegular", 13F);
            this.strbtn.ForeColor = System.Drawing.Color.White;
            this.strbtn.Image = global::pharmacyp.Properties.Resources.add_cart;
            this.strbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.strbtn.ImageSize = new System.Drawing.Size(35, 35);
            this.strbtn.Location = new System.Drawing.Point(0, 268);
            this.strbtn.Margin = new System.Windows.Forms.Padding(0);
            this.strbtn.Name = "strbtn";
            this.strbtn.Size = new System.Drawing.Size(266, 76);
            this.strbtn.TabIndex = 2;
            this.strbtn.Text = "کـــۆگــــا";
            this.strbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.strbtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.strbtn.Click += new System.EventHandler(this.strbtn_Click);
            this.strbtn.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.strbtn.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // sidebar
            // 
            this.sidebar.AutoRoundedCorners = true;
            this.sidebar.BorderRadius = 132;
            this.sidebar.Controls.Add(this.bcbtn);
            this.sidebar.Controls.Add(this.usbtn);
            this.sidebar.Controls.Add(this.finbtn);
            this.sidebar.Controls.Add(this.expbtn);
            this.sidebar.Controls.Add(this.repbtn);
            this.sidebar.Controls.Add(this.solbtn);
            this.sidebar.Controls.Add(this.selbtn);
            this.sidebar.Controls.Add(this.strbtn);
            this.sidebar.Controls.Add(this.homebtn);
            this.sidebar.Controls.Add(this.guna2GradientPanel2);
            this.sidebar.CustomBorderColor = System.Drawing.Color.Yellow;
            this.sidebar.CustomizableEdges.BottomRight = false;
            this.sidebar.CustomizableEdges.TopLeft = false;
            this.sidebar.CustomizableEdges.TopRight = false;
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.sidebar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(171)))), ((int)(((byte)(186)))));
            this.sidebar.Location = new System.Drawing.Point(1654, 44);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.MaximumSize = new System.Drawing.Size(266, 0);
            this.sidebar.MinimumSize = new System.Drawing.Size(49, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(266, 1036);
            this.sidebar.TabIndex = 3;
            this.sidebar.MouseLeave += new System.EventHandler(this.Sidebar_MouseLeave);
            this.sidebar.MouseHover += new System.EventHandler(this.Sidebar_MouseHover);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tabcon);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.Cbar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainform";
            this.Text = "mainform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).EndInit();
            this.Cbar.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Timer side_animation;
        private System.Windows.Forms.Panel tabcon;
        private Guna.UI2.WinForms.Guna2GradientPanel Cbar;
        private Guna.UI2.WinForms.Guna2ControlBox closebtn;
        private Guna.UI2.WinForms.Guna2GradientPanel sidebar;
        private Guna.UI2.WinForms.Guna2GradientButton bcbtn;
        private Guna.UI2.WinForms.Guna2GradientButton usbtn;
        private Guna.UI2.WinForms.Guna2GradientButton finbtn;
        private Guna.UI2.WinForms.Guna2GradientButton expbtn;
        private Guna.UI2.WinForms.Guna2GradientButton repbtn;
        private Guna.UI2.WinForms.Guna2GradientButton solbtn;
        private Guna.UI2.WinForms.Guna2GradientButton selbtn;
        private Guna.UI2.WinForms.Guna2GradientButton strbtn;
        private Guna.UI2.WinForms.Guna2GradientButton homebtn;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilepic;
    }
}