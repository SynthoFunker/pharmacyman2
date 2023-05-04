namespace pharmacyp.TabContainer
{
    partial class Soldtab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.soldtable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.soldtable)).BeginInit();
            this.SuspendLayout();
            // 
            // soldtable
            // 
            this.soldtable.AllowUserToAddRows = false;
            this.soldtable.AllowUserToDeleteRows = false;
            this.soldtable.AllowUserToOrderColumns = true;
            this.soldtable.AllowUserToResizeColumns = false;
            this.soldtable.AllowUserToResizeRows = false;
            this.soldtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.soldtable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.soldtable.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.soldtable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.soldtable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rabar_004", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.soldtable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.soldtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.soldtable.DefaultCellStyle = dataGridViewCellStyle2;
            this.soldtable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.soldtable.EnableHeadersVisualStyles = false;
            this.soldtable.Location = new System.Drawing.Point(0, 185);
            this.soldtable.Name = "soldtable";
            this.soldtable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.soldtable.RowHeadersVisible = false;
            this.soldtable.RowHeadersWidth = 51;
            this.soldtable.RowTemplate.Height = 26;
            this.soldtable.Size = new System.Drawing.Size(1871, 851);
            this.soldtable.TabIndex = 7;
            // 
            // Soldtab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.soldtable);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Soldtab";
            this.Size = new System.Drawing.Size(1871, 1036);
            ((System.ComponentModel.ISupportInitialize)(this.soldtable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView soldtable;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saledateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
    }
}
