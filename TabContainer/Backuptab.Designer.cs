namespace pharmacyp.TabContainer
{
    partial class Backuptab
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
            this.backupbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.resbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // backupbtn
            // 
            this.backupbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backupbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backupbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backupbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backupbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backupbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backupbtn.ForeColor = System.Drawing.Color.White;
            this.backupbtn.Location = new System.Drawing.Point(464, 276);
            this.backupbtn.Name = "backupbtn";
            this.backupbtn.Size = new System.Drawing.Size(112, 41);
            this.backupbtn.TabIndex = 0;
            this.backupbtn.Text = "Backup";
            this.backupbtn.Click += new System.EventHandler(this.backupbtn_Click);
            // 
            // resbtn
            // 
            this.resbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resbtn.ForeColor = System.Drawing.Color.White;
            this.resbtn.Location = new System.Drawing.Point(464, 349);
            this.resbtn.Name = "resbtn";
            this.resbtn.Size = new System.Drawing.Size(112, 41);
            this.resbtn.TabIndex = 1;
            this.resbtn.Text = "Restore";
            this.resbtn.Click += new System.EventHandler(this.resbtn_Click);
            // 
            // Backuptab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resbtn);
            this.Controls.Add(this.backupbtn);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Backuptab";
            this.Size = new System.Drawing.Size(1654, 1036);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton backupbtn;
        private Guna.UI2.WinForms.Guna2GradientButton resbtn;
    }
}
