using Microsoft.Reporting.WinForms;
using pharmacyp.Forms;
using pharmacyp.Tables;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.Common;
using ZXing;
using ZXing.Rendering;

namespace pharmacyp.TabContainer
{
    public partial class Sellingtab : UserControl
    {
        #region Variables
        //public int UserID { get; set; } = MainForm.UserID;

        private readonly AsyncOleDbCrudHelper m;

        private readonly OleDbCrudHelper m2;
        readonly ReportDataSource rs = new ReportDataSource();

        public event EventHandler PurchaseMade;
        #endregion

        public Sellingtab()
        {
            this.m = new AsyncOleDbCrudHelper();
            this.m2 = new OleDbCrudHelper();
            InitializeComponent();
        }

        #region GridViewHandler

        private async void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);
            int squantity = await GetInventoryQuantityAsync(id);

            if (e.ColumnIndex == 5)
            {
                IncreaseQuantity(e.RowIndex, quantity, squantity);
                await Loadreport();
            }
            else if (e.ColumnIndex == dataGridView1.Columns[3].Index)
            {
                DecreaseQuantity(e.RowIndex, quantity);
            }
            else if (e.ColumnIndex == 6)
            {
                RemoveRow(e.RowIndex);
                reportViewer1.RefreshReport();
            }
        }

        private async Task<int> GetInventoryQuantityAsync(int id)
        {
            OleDbParameter p = new OleDbParameter("@medid", id);
            _ = new OleDbCrudHelper();
            OleDbDataReader re = await this.m.SExecuteReaderAsync("SELECT Medicine_Stock.SQuantity FROM Medicine_Stock WHERE (((Medicine_Stock.MedicationID)=[@medid]));", p);
            int quantity = 0;
            if (re.Read())
            {
                quantity = (int)re["SQuantity"];
            }
            re.Close();
            return quantity;
        }

        private void IncreaseQuantity(int rowIndex, int quantity, int squantity)
        {
            if (quantity >= squantity)
            {
                _ = MessageBox.Show("لەم برە زیاتر نییە");
            }
            else
            {
                dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = quantity + 1;
            }
        }

        private void DecreaseQuantity(int rowIndex, int quantity)
        {
            if (quantity > 1)
            {
                dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = quantity - 1;
                 Loadreport();
            }
            else if (quantity == 1)
            {
                dataGridView1.Rows.RemoveAt(rowIndex);
                 Loadreport();
                if (dataGridView1.Rows.Count == 0)
                {
                    ClearReport();
                }
            }
            else
            {
                _ = MessageBox.Show("لەم برە کەم تر نابێت");
            }
        }

        private void RemoveRow(int rowIndex)
        {
            dataGridView1.Rows.RemoveAt(rowIndex);
            if (dataGridView1.Rows.Count == 0)
            {
                ClearReport();
            }
        }

        private void Datagridviewfill(string input)
        {
            OleDbParameter b = new OleDbParameter("@barcode", input);
            label1.Text = input;
            OleDbDataReader re = this.m.SExecuteReader("SELECT Medication.MedicationID, Medication.MName, Medication.Sell, Medication.Company, Inventory.Barcode, Inventory.ExpiryDate, Medicine_Stock.SQuantity, Medicine_Stock.MQuantity, Medicine_Stock.TotalQ FROM Inventory INNER JOIN (Medicine_Stock INNER JOIN Medication ON Medicine_Stock.MedicationID = Medication.MedicationID) ON Inventory.MedicationID = Medication.MedicationID WHERE (((Inventory.Barcode)=[@barcode])) ORDER BY Medication.MName;", b);
            while (re.Read())
            {
                if (input == re["Barcode"].ToString())
                {
                    bool rowExists = false;
                    foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
                    {
                        if (dgvRow.Cells["DID"].Value.ToString() == re["MedicationID"].ToString())
                        {
                            int quantity = Convert.ToInt32(dgvRow.Cells["Quantity"].Value);
                            if ((int)dgvRow.Cells["Quantity"].Value >= (int)re["SQuantity"])
                            {
                                MessageBox.Show("لەم برە زیاتر نییە");
                                rowExists = true;
                                break;
                            }
                            else
                            {
                                dgvRow.Cells["Quantity"].Value = quantity + 1;
                                Loadreport();
                                rowExists = true;
                                break;
                            }
                        }
                        else
                        {
                            rowExists = false;
                        }
                    }

                    if (!rowExists)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView1);

                        row.Cells[0].Value = re["MedicationID"].ToString();
                        row.Cells[1].Value = re["MName"].ToString();
                        row.Cells[2].Value = re["Sell"].ToString();
                        row.Cells[3].Value = Properties.Resources.icons8_minus_25px;
                        row.Cells[4].Value = 1;
                        row.Cells[5].Value = Properties.Resources.icons8_Plus_25px;
                        row.Cells[6].Value = Properties.Resources.icons8_delete_25px;
                        _ = dataGridView1.Rows.Add(row);

                        Loadreport();
                    }
                }
            }
        }

        #endregion

        #region ReportHandler

        private void ClearReport()
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.RefreshReport();
            reportViewer1.Visible = false;
        }

        private async Task<Task> Loadreport()
        {
            List<OReport> receipts = new List<OReport>();
            receipts.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                 await Task.Run(() =>
                {
                    OReport re = new OReport
                    {
                       // Username = MainForm.UName,
                        MName = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                        olQuantity = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value),
                        Sell = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value),
                        BImage = Bcodemaker(),
                    };
                    receipts.Add(re);
                });
            }

            rs.Name = "DataSet1";
            rs.Value = receipts;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rs);
            reportViewer1.LocalReport.ReportEmbeddedResource = "pharmacyp.Sellingreport.rdlc";
            if (reportViewer1.Visible == false)
            {
                reportViewer1.Visible = true;
            }

            reportViewer1.RefreshReport();

            return Task.CompletedTask;
        }

        #endregion

        #region SellingProcess

        private void Sellbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
               
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int id = Convert.ToInt32(row.Cells["DID"].Value);
                        int sellingPrice = Convert.ToInt32(row.Cells["Price"].Value);
                        int quantity = Convert.ToInt32(row.Cells["quantity"].Value);

                         AddOrder();
                         AddOrderLine(id, quantity);
                         UpdateInventory(id, quantity);
                    }
             
                _ = MessageBox.Show("Sold");

                ClearReport();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                lbltotal.Text = "کۆی گشتی";
                dataGridView1.Focus();
                PurchaseMade?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                _ = MessageBox.Show("تکایە دەرمانێک دیاری بکە");
                dataGridView1.Focus();
            }
        }

        private async Task AddOrder()
        {
            OleDbParameter[] p =
            {
              //  new OleDbParameter("@id", this.UserID), new OleDbParameter("@sdate", DateTime.Now.Date), new OleDbParameter("@Obarcode", BocodeG()),
            };
            _ = await this.m.AsyncExecuteNonQueryWithTransaction("INSERT INTO mOrder (UserID,OrderDate,Obarcode) VALUES (@id,@sdate,@Obarcode)", p);
        }

        private async Task AddOrderLine(int medicationID, int quantity)
        {
            OleDbParameter[] p =
            {
                new OleDbParameter("@mid", medicationID), new OleDbParameter("@amount", quantity),
            };
            _ = await this.m.AsyncExecuteNonQueryWithTransaction("Insert INTO OrderLine (MedicationID,olQuantity) Values (@mid,@amount)", p);
        }

        private async Task UpdateInventory(int medicationID, int quantity)
        {
            OleDbParameter[] p =
            {
                new OleDbParameter("@iQuantity", quantity), new OleDbParameter("@id", medicationID)
            };
            _ = await this.m.AsyncExecuteNonQueryWithTransaction("UPDATE Inventory SET iQuantity = iQuantity - @iQuantity where MedicationID = @id", p);
        }

        #endregion

        #region Medicine Barcode Handler

        public void HandleBarcodeScannerInput(string input)
        {
             this.Datagridviewfill(input);
        }

        private void Barbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string msg = textBox1.Text;
                this.HandleBarcodeScannerInput(msg);

                textBox1.Clear();
            }
        }

        #endregion

        #region Receipt Barcode Handler

        private byte[] Bcodemaker()
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.EAN_13,
                Options = new EncodingOptions
                {
                    Height = 75,
                    Width = 150,
                    Margin = 1,
                },

                Renderer = new BitmapRenderer
                {
                    TextFont = new Font("Gadugi", 7f,FontStyle.Bold),
                },
            };

            var img = writer.Write(BocodeG());

            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private string BocodeG()
        {
            Random random = new Random();
            var digits = Enumerable.Range(0, 12).Select(x => random.Next(10));
            string inputString = string.Join("", digits);
            return inputString;
        }

        private void medbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
        #endregion
}