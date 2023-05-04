namespace pharmacyp.Forms
{
    partial class FpassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FpassForm));
            this.lblheader = new System.Windows.Forms.Label();
            this.lblv = new System.Windows.Forms.Label();
            this.lble = new System.Windows.Forms.Label();
            this.sendbtn = new Guna.UI2.WinForms.Guna2Button();
            this.VBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblncode = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // lblheader
            // 
            this.lblheader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblheader.AutoSize = true;
            this.lblheader.BackColor = System.Drawing.Color.Transparent;
            this.lblheader.Font = new System.Drawing.Font("UniQAIDAR_Blawkrawe 007", 20F);
            this.lblheader.Location = new System.Drawing.Point(30, 42);
            this.lblheader.Name = "lblheader";
            this.lblheader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblheader.Size = new System.Drawing.Size(256, 49);
            this.lblheader.TabIndex = 12;
            this.lblheader.Text = "گۆرینی تێپەڕە وشە";
            this.lblheader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblv
            // 
            this.lblv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblv.AutoSize = true;
            this.lblv.BackColor = System.Drawing.Color.Transparent;
            this.lblv.Font = new System.Drawing.Font("UniQAIDAR_Blawkrawe 007", 11F);
            this.lblv.ForeColor = System.Drawing.Color.Black;
            this.lblv.Location = new System.Drawing.Point(137, 192);
            this.lblv.Name = "lblv";
            this.lblv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblv.Size = new System.Drawing.Size(140, 27);
            this.lblv.TabIndex = 11;
            this.lblv.Text = "کۆدی دڵنیاکردنەوە";
            this.lblv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lble
            // 
            this.lble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lble.AutoSize = true;
            this.lble.BackColor = System.Drawing.Color.Transparent;
            this.lble.Font = new System.Drawing.Font("UniQAIDAR_Blawkrawe 007", 11F);
            this.lble.ForeColor = System.Drawing.Color.Black;
            this.lble.Location = new System.Drawing.Point(215, 102);
            this.lble.Name = "lble";
            this.lble.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lble.Size = new System.Drawing.Size(62, 27);
            this.lble.TabIndex = 10;
            this.lble.Text = "ئیمەیڵ";
            this.lble.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sendbtn
            // 
            this.sendbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sendbtn.Animated = true;
            this.sendbtn.AnimatedGIF = true;
            this.sendbtn.AutoRoundedCorners = true;
            this.sendbtn.BackColor = System.Drawing.Color.Transparent;
            this.sendbtn.BorderRadius = 21;
            this.sendbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendbtn.FillColor = System.Drawing.Color.SeaGreen;
            this.sendbtn.Font = new System.Drawing.Font("UniQAIDAR_Blawkrawe 007", 11F);
            this.sendbtn.ForeColor = System.Drawing.Color.Black;
            this.sendbtn.Location = new System.Drawing.Point(75, 315);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(180, 45);
            this.sendbtn.TabIndex = 9;
            this.sendbtn.Text = "ناردنی کۆد";
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // VBox
            // 
            this.VBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VBox.Animated = true;
            this.VBox.AutoRoundedCorners = true;
            this.VBox.BackColor = System.Drawing.Color.Transparent;
            this.VBox.BorderColor = System.Drawing.Color.White;
            this.VBox.BorderRadius = 23;
            this.VBox.BorderThickness = 2;
            this.VBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VBox.DefaultText = "";
            this.VBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.VBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.VBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.VBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VBox.Location = new System.Drawing.Point(48, 223);
            this.VBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VBox.Name = "VBox";
            this.VBox.PasswordChar = '\0';
            this.VBox.PlaceholderText = "";
            this.VBox.SelectedText = "";
            this.VBox.Size = new System.Drawing.Size(229, 48);
            this.VBox.TabIndex = 8;
            // 
            // EBox
            // 
            this.EBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EBox.Animated = true;
            this.EBox.AutoRoundedCorners = true;
            this.EBox.BackColor = System.Drawing.Color.Transparent;
            this.EBox.BorderColor = System.Drawing.Color.White;
            this.EBox.BorderRadius = 23;
            this.EBox.BorderThickness = 2;
            this.EBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EBox.DefaultText = "";
            this.EBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.EBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EBox.Location = new System.Drawing.Point(48, 134);
            this.EBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EBox.Name = "EBox";
            this.EBox.PasswordChar = '\0';
            this.EBox.PlaceholderText = "";
            this.EBox.SelectedText = "";
            this.EBox.Size = new System.Drawing.Size(229, 48);
            this.EBox.TabIndex = 7;
            // 
            // lblncode
            // 
            this.lblncode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblncode.AutoSize = true;
            this.lblncode.BackColor = System.Drawing.Color.Transparent;
            this.lblncode.Enabled = false;
            this.lblncode.Font = new System.Drawing.Font("UniQAIDAR_Blawkrawe 007", 11F);
            this.lblncode.ForeColor = System.Drawing.Color.DarkGray;
            this.lblncode.Location = new System.Drawing.Point(110, 278);
            this.lblncode.Name = "lblncode";
            this.lblncode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblncode.Size = new System.Drawing.Size(119, 27);
            this.lblncode.TabIndex = 14;
            this.lblncode.Text = "کۆدەکە نەهات؟";
            this.lblncode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblncode.Visible = false;
            this.lblncode.Click += new System.EventHandler(this.lblncode_ClickAsync);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(161)))), ((int)(((byte)(153)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(281, -2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(44, 41);
            this.guna2ControlBox1.TabIndex = 15;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // FpassForm
            // 
            this.AcceptButton = this.sendbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(324, 386);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblncode);
            this.Controls.Add(this.lblheader);
            this.Controls.Add(this.lblv);
            this.Controls.Add(this.lble);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.VBox);
            this.Controls.Add(this.EBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FpassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fpass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label lblv;
        private System.Windows.Forms.Label lble;
        private Guna.UI2.WinForms.Guna2Button sendbtn;
        private Guna.UI2.WinForms.Guna2TextBox VBox;
        private Guna.UI2.WinForms.Guna2TextBox EBox;
        private System.Windows.Forms.Label lblncode;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}