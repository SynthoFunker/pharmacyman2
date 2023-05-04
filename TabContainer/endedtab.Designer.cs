namespace pharmacyp.TabContainer
{
    partial class endedtab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.endedtable = new System.Windows.Forms.DataGridView();
            this.endedtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.endedtable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endedtableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // endedtable
            // 
            this.endedtable.AllowUserToAddRows = false;
            this.endedtable.AllowUserToDeleteRows = false;
            this.endedtable.AllowUserToOrderColumns = true;
            this.endedtable.AllowUserToResizeColumns = false;
            this.endedtable.AllowUserToResizeRows = false;
            this.endedtable.AutoGenerateColumns = false;
            this.endedtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.endedtable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.endedtable.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.endedtable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endedtable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rabar_004", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.endedtable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.endedtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.endedtable.DataSource = this.endedtableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.endedtable.DefaultCellStyle = dataGridViewCellStyle2;
            this.endedtable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.endedtable.EnableHeadersVisualStyles = false;
            this.endedtable.Location = new System.Drawing.Point(0, 185);
            this.endedtable.Name = "endedtable";
            this.endedtable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.endedtable.RowHeadersVisible = false;
            this.endedtable.RowHeadersWidth = 51;
            this.endedtable.RowTemplate.Height = 26;
            this.endedtable.Size = new System.Drawing.Size(1871, 851);
            this.endedtable.TabIndex = 7;
            // 
            // endedtab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endedtable);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "endedtab";
            this.Size = new System.Drawing.Size(1871, 1036);
            ((System.ComponentModel.ISupportInitialize)(this.endedtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endedtableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView endedtable;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource endedtableBindingSource;
    }
}
