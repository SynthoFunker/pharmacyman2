
using System.Linq;
using System.Windows.Forms;
using System;

namespace pharmacyp.TabContainer
{
    partial class Storagetab
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
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medicationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataSource = typeof(pharmacyp.Tables.Storage);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicationIDDataGridViewTextBoxColumn,
            this.mNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dosageDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.sellDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn,
            this.sQuantityDataGridViewTextBoxColumn,
            this.mQuantityDataGridViewTextBoxColumn,
            this.totalQDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.storageBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 298);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 312);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.VirtualMode = true;
            // 
            // medicationIDDataGridViewTextBoxColumn
            // 
            this.medicationIDDataGridViewTextBoxColumn.DataPropertyName = "MedicationID";
            this.medicationIDDataGridViewTextBoxColumn.HeaderText = "MedicationID";
            this.medicationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicationIDDataGridViewTextBoxColumn.Name = "medicationIDDataGridViewTextBoxColumn";
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "MName";
            this.mNameDataGridViewTextBoxColumn.HeaderText = "MName";
            this.mNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // dosageDataGridViewTextBoxColumn
            // 
            this.dosageDataGridViewTextBoxColumn.DataPropertyName = "Dosage";
            this.dosageDataGridViewTextBoxColumn.HeaderText = "Dosage";
            this.dosageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dosageDataGridViewTextBoxColumn.Name = "dosageDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // sellDataGridViewTextBoxColumn
            // 
            this.sellDataGridViewTextBoxColumn.DataPropertyName = "Sell";
            this.sellDataGridViewTextBoxColumn.HeaderText = "Sell";
            this.sellDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellDataGridViewTextBoxColumn.Name = "sellDataGridViewTextBoxColumn";
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            // 
            // sQuantityDataGridViewTextBoxColumn
            // 
            this.sQuantityDataGridViewTextBoxColumn.DataPropertyName = "SQuantity";
            this.sQuantityDataGridViewTextBoxColumn.HeaderText = "SQuantity";
            this.sQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sQuantityDataGridViewTextBoxColumn.Name = "sQuantityDataGridViewTextBoxColumn";
            // 
            // mQuantityDataGridViewTextBoxColumn
            // 
            this.mQuantityDataGridViewTextBoxColumn.DataPropertyName = "MQuantity";
            this.mQuantityDataGridViewTextBoxColumn.HeaderText = "MQuantity";
            this.mQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mQuantityDataGridViewTextBoxColumn.Name = "mQuantityDataGridViewTextBoxColumn";
            // 
            // totalQDataGridViewTextBoxColumn
            // 
            this.totalQDataGridViewTextBoxColumn.DataPropertyName = "TotalQ";
            this.totalQDataGridViewTextBoxColumn.HeaderText = "TotalQ";
            this.totalQDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalQDataGridViewTextBoxColumn.Name = "totalQDataGridViewTextBoxColumn";
            // 
            // Storagetab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Storagetab";
            this.Size = new System.Drawing.Size(1047, 610);
            this.Load += new System.EventHandler(this.Storagetab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton insbtn;
        private BindingSource storageBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn medicationIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dosageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sellDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalQDataGridViewTextBoxColumn;
    }
}
