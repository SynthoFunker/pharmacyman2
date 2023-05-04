namespace pharmacyp.TabContainer
{
    partial class expirytab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.expirytable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expirytable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rabar_004", 11F);
            this.label1.Location = new System.Drawing.Point(1466, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "‌حەوت ڕۆژ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pharmacyp.Properties.Resources.b2p6bu5n;
            this.pictureBox1.Location = new System.Drawing.Point(1552, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rabar_004", 11F);
            this.label2.Location = new System.Drawing.Point(1479, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "‌سێ ڕۆژ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rabar_004", 11F);
            this.label3.Location = new System.Drawing.Point(1464, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "بەسەرچوو";
            // 
            // expirytable
            // 
            this.expirytable.AllowUserToAddRows = false;
            this.expirytable.AllowUserToDeleteRows = false;
            this.expirytable.AllowUserToOrderColumns = true;
            this.expirytable.AllowUserToResizeColumns = false;
            this.expirytable.AllowUserToResizeRows = false;
            this.expirytable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expirytable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.expirytable.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.expirytable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expirytable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.expirytable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rabar_004", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expirytable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.expirytable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expirytable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.expirytable.EnableHeadersVisualStyles = false;
            this.expirytable.Location = new System.Drawing.Point(0, 185);
            this.expirytable.Name = "expirytable";
            this.expirytable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.expirytable.RowHeadersVisible = false;
            this.expirytable.RowHeadersWidth = 51;
            this.expirytable.RowTemplate.Height = 26;
            this.expirytable.Size = new System.Drawing.Size(1654, 851);
            this.expirytable.TabIndex = 5;
            this.expirytable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.expirytable_CellFormatting);
            // 
            // expirytab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.expirytable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "expirytab";
            this.Size = new System.Drawing.Size(1654, 1036);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expirytable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView expirytable;
    }
}
