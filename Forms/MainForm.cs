using BarcodeStandard;
using Dapper;
using Guna.UI2.WinForms;
using LiveCharts.Charts;
using Microsoft.Reporting.WinForms;
using pharmacyp.CrudHelper;
using pharmacyp.TabContainer;
using pharmacyp.Tables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;
using Image = System.Drawing.Image;

namespace pharmacyp.Forms
{

    public partial class MainForm : Form
    {
        #region Variables

        AsyncOleDbCrudHelper m = new AsyncOleDbCrudHelper();
 
        private List<Storage> st()
        {
            List<Storage> s = DataAccess.Conn("PharDCS").Query<Storage>("SELECT MM.MedicationID, MM.MName, MM.Description, MM.Dosage, MM.Cost, MM.Sell," +
     " MM.Company, MM.Barcode, MM.ExpiryDate, MS.SQuantity, MS.MQuantity, MS.TotalQ FROM Medication AS MM INNER JOIN Medicine_Stock AS MS " +
     "ON MM.MedicationID = MS.MedicationID;").ToList();
            return s;
        }
        #region MainFormVariables
        public static int UserID = 1;
        public static new string UName = "hem";
        public static string Role;
        #endregion

        #region HomeTabVariables
        #endregion

        #region StorageTabVariables
        #endregion

        #region SellingTabVariables
        StringBuilder medbarcode = new StringBuilder();
        private DateTime lastKeystroke = new DateTime(0);
        private string repbarcode;
        readonly ReportDataSource rs = new ReportDataSource();

        public event EventHandler PurchaseMade;
        #endregion

        #region ReportTabVariables
        #endregion

        #region SettingsTabVariables
        #endregion

        #endregion

        #region Ctors

        public MainForm()
        {
            InitializeComponent();
            if (Role == "کارمەند")
            {
                CContainer.TabPages.Remove(CContainer.TabPages[0]);
                CContainer.TabPages.Remove(CContainer.TabPages[0]);
                CContainer.TabPages.Remove(CContainer.TabPages[1]);
                CContainer.TabPages.Remove(CContainer.TabPages[1]);
            }
            SellingRView.Visible = false;
            ReportGrid.DataSource = DataAccess.LoadRHistory();
            PurchaseMade += UserControl1_PurchaseMade;
            Loadgraph(st());
            QuantityChart.Invalidate();
        }

        public MainForm(int userID, string name, string role)
        {
            InitializeComponent();
            Loadgraph(st());
            LoadCbox(st());
            UserID = userID;
            UName = name;
            Role = role;
            Uinfo.Text = $"بەخێربێیت {name} پلەکەت:{role}";
            SellingRView.Visible = false;
            if (Role == "کارمەند")
            {
                CContainer.TabPages.Remove(CContainer.TabPages[0]);
                CContainer.TabPages.Remove(CContainer.TabPages[0]);
                CContainer.TabPages.Remove(CContainer.TabPages[1]);
                CContainer.TabPages.Remove(CContainer.TabPages[1]);
            }
            else if (Role == "جێگری بەڕێوەبەر")
            {
                CContainer.TabPages.Remove(CContainer.TabPages[4]);
            }
            PurchaseMade += UserControl1_PurchaseMade;
            Loadgraph(st());
            QuantityChart.Invalidate();
        }

        #endregion

        #region MainFormEvents
        private async void UserControl1_PurchaseMade(object sender, EventArgs e)
        {
            Loadgraph(st());
            LoadCbox(st());
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)

        {
            _ = DateTime.Now - this.lastKeystroke;
            this.medbarcode.Append(e.KeyChar);
            this.lastKeystroke = DateTime.Now;

            // process barcode
            if (e.KeyChar == 13)
            {
                string msg = medbarcode.ToString();
                if (CContainer.SelectedTab == saletab)
                {
                    SellingGridViewFill(st(), msg.TrimEnd());
                    medbarcode.Clear();
                }
                else if (CContainer.SelectedTab == reporttab)
                {
                    ReportGrid.DataSource = DataAccess.LoadRHistory(msg);
                    medbarcode.Clear();
                }
                else
                {
                    medbarcode.Clear();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReportGrid.DataSource = DataAccess.LoadRHistory();
            this.SellingRView.RefreshReport();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lobtn_Click(object sender, EventArgs e)
        {
            login l = new login();
            DialogResult ms = MessageBox.Show("ئایا تۆ دڵنیایت؟", "چوونەدەرەوە", MessageBoxButtons.YesNo);
            if (ms == DialogResult.Yes)
            {
                l.Show();
                this.Hide();
            }
        }

        private void CContainer_MouseLeave(object sender, EventArgs e)
        {
            CContainer.ItemSize = new Size(43, CContainer.ItemSize.Height);
            STbar.ColumnStyles[1].Width = CContainer.ItemSize.Width;
        }

        private void CContainer_MouseEnter(object sender, EventArgs e)
        {
            CContainer.ItemSize = new Size(135, CContainer.ItemSize.Height);
            STbar.ColumnStyles[1].Width = CContainer.ItemSize.Width;
        }
        #endregion

        #region HomeTabEvents

        private void Loadgraph(List<Storage> s)
        {
            QuantityChart.DataSource = s;
            QuantityChart.Invalidate();
            foreach (DataPoint point in QuantityChart.Series["Quantity"].Points)
            {
                int mmQuantity = (int)point.YValues[0];
                Color color = Color.Green;
                if (mmQuantity <= 3)
                {
                    color = Color.Red;
                }
                else if (mmQuantity <= 5)
                {
                    color = Color.Orange;
                }
                else if (mmQuantity <= 10)
                {
                    color = Color.Yellow;
                }

                point.Color = color;
            }

        }

        private void LoadCbox(List<Storage> names)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (var name in names)
            {
                string hold = name.MName;
                collection.Add(hold);
            }

            Mnbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Mnbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Mnbox.AutoCompleteCustomSource = collection;
        }

        #endregion

        #region StorageTabEvents

        #endregion

        #region SellingTabEvents

        private void SellingGridViewFill(List<Storage> storageList, string input)
        {
            var rows = storageList.Where(s => s.Barcode == input);
            if (rows.Count() == 0)
            {
                return;
            }

            var row = rows.First();

            bool rowExists = false;
            int dquantity = row.SQuantity;
            if (dquantity == 0)
            {
                MessageBox.Show("ئەم دەرمانە تەواو بووە.", "ئاگاداری", MessageBoxButtons.OK);
                return;
            }
            foreach (DataGridViewRow dgvRow in SellingGrid.Rows)
            {
                if (dgvRow.Cells["DID"].Value.ToString() == row.MedicationID.ToString())
                {
                    int quantity = Convert.ToInt32(dgvRow.Cells["Quantity"].Value);
                    if ((int)dgvRow.Cells["Quantity"].Value >= (int)row.SQuantity)
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
                DataGridViewRow dgvRow = new DataGridViewRow();
                dgvRow.CreateCells(SellingGrid);

                dgvRow.Cells[0].Value = row.MedicationID.ToString();
                dgvRow.Cells[1].Value = row.MName;
                dgvRow.Cells[2].Value = row.Sell.ToString();
                dgvRow.Cells[3].Value = Properties.Resources.icons8_minus_25px;
                dgvRow.Cells[4].Value = 1;
                dgvRow.Cells[5].Value = Properties.Resources.icons8_Plus_25px;
                dgvRow.Cells[6].Value = Properties.Resources.icons8_delete_25px;
                _ = SellingGrid.Rows.Add(dgvRow);

                Loadreport();
            }
        }

        private void Loadreport()
        {
            List<OReport> receipts = new List<OReport>();

            receipts.Clear();

            BocodeG();
            for (int i = 0; i < SellingGrid.Rows.Count; i++)
            {
                OReport re = new OReport
                {
                    Uname = MainForm.UName,
                    MName = SellingGrid.Rows[i].Cells[1].Value.ToString(),
                    olQuantity = Convert.ToInt32(SellingGrid.Rows[i].Cells[4].Value),
                    Sell = Convert.ToInt32(SellingGrid.Rows[i].Cells[2].Value),
                    BImage = Bcodemaker(),
                };
                receipts.Add(re);
            }

            rs.Name = "DataSet1";
            rs.Value = receipts;
            SellingRView.LocalReport.DataSources.Clear();
            SellingRView.LocalReport.DataSources.Add(rs);
            SellingRView.LocalReport.ReportEmbeddedResource = "pharmacyp.Sellingreport.rdlc";
            if (SellingRView.Visible == false)
            {
                SellingRView.Visible = true;
            }

            SellingRView.RefreshReport();
        }

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
                    TextFont = new Font("Gadugi", 7f, FontStyle.Bold),
                },
            };

            var img = writer.Write(repbarcode);

            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private void BocodeG()
        {
                Random random = new Random();
                var digits = Enumerable.Range(0, 12).Select(x => random.Next(10));
                string inputString = string.Join("", digits);
                repbarcode = inputString;
        }

        private void IncreaseQuantity(int rowIndex, int quantity, int squantity)
        {
            if (quantity >= squantity)
            {
                _ = MessageBox.Show("لەم برە زیاتر نییە");
            }
            else
            {
                SellingGrid.Rows[rowIndex].Cells["Quantity"].Value = quantity + 1;
            }
        }

        private void DecreaseQuantity(int rowIndex, int quantity)
        {
            if (quantity > 1)
            {
                SellingGrid.Rows[rowIndex].Cells["Quantity"].Value = quantity - 1;
                Loadreport();
            }
            else if (quantity == 1)
            {
                SellingGrid.Rows.RemoveAt(rowIndex);
                Loadreport();
                if (SellingGrid.Rows.Count == 0)
                {
                    ClearSellingReport();
                }
            }
            else
            {
                _ = MessageBox.Show("لەم برە کەم تر نابێت");
            }
        }

        private void RemoveRow(int rowIndex)
        {
            SellingGrid.Rows.RemoveAt(rowIndex);
            Loadreport();
            if (SellingGrid.Rows.Count == 0)
            {
                ClearSellingReport();
            }
        }

        private void ClearSellingReport()
        {
            SellingRView.LocalReport.DataSources.Clear();
            SellingRView.RefreshReport();
            SellingRView.Visible = false;
        }

        private void SellingGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                int id = Convert.ToInt32(SellingGrid.Rows[e.RowIndex].Cells[0].Value);
                int quantity = Convert.ToInt32(SellingGrid.Rows[e.RowIndex].Cells["Quantity"].Value);
                int squantity = GetInventoryQuantity(st(), id);

                if (e.ColumnIndex == 5)
                {
                    IncreaseQuantity(e.RowIndex, quantity, squantity);
                    Loadreport();
                }
                else if (e.ColumnIndex == 3)
                {
                    DecreaseQuantity(e.RowIndex, quantity);
                }
                else if (e.ColumnIndex == 6)
                {
                    RemoveRow(e.RowIndex);
                    SellingRView.RefreshReport();
                }
            }
        }

        private int GetInventoryQuantity(List<Storage> storageList, int id)
        {
            int quantity = 0;
            Storage storage = storageList.FirstOrDefault(s => s.MedicationID == id);
            if (storage != null)
            {
                quantity = storage.SQuantity;
            }
            return quantity;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            Guna2Button b = (Guna2Button)sender;
            if (b.Text == "C")
            {
                calcbox.Clear();
            }
            else
            {
                calcbox.Text += b.Text;
            }
        }

        #region SellingProcess

        private void Sellbtn_Click(object sender, EventArgs e)
        {
            if (SellingGrid.RowCount > 0)
            {

                foreach (DataGridViewRow row in SellingGrid.Rows)
                {
                    int id = Convert.ToInt32(row.Cells["DID"].Value);
                    int quantity = Convert.ToInt32(row.Cells["quantity"].Value);

                    AddOrder(repbarcode, id, quantity);
                }

                if (sender == sellbtn)
                {
                    DialogResult result = printDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                        printDocument1.Print();
                    }
                }

                _ = MessageBox.Show("Sold");

                ClearSellingReport();
                SellingGrid.Rows.Clear();
                SellingGrid.Refresh();
                lbltotal.Text = "کۆی گشتی";
                SellingGrid.Focus();
                PurchaseMade?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                _ = MessageBox.Show("تکایە دەرمانێک دیاری بکە");
                SellingGrid.Focus();
            }
        }

        private async Task AddOrder(string bcode, int medicationID, int quantity)
        {
            OleDbParameter[] p =
            {
                new OleDbParameter("@id", UserID), new OleDbParameter("@sdate", DateTime.Now.Date), new OleDbParameter("@Obarcode", bcode), new OleDbParameter("@mid", medicationID), new OleDbParameter( "amount", quantity)
            };
            _ = await this.m.AsyncExecuteNonQueryWithTransaction("INSERT INTO mOrder (UserID,OrderDate,Obarcode,MedicationID,olQuantity) VALUES (@id,@sdate,@Obarcode,@mid,@amount)", p);

            OleDbParameter[] p2 = { new OleDbParameter("@quan", quantity),new OleDbParameter("@id", medicationID) };

            await this.m.AsyncExecuteNonQueryWithTransaction("UPDATE Medicine_Stock SET SQuantity = SQuantity - @quan where MedicationID = @id", p2);
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            byte[] Eimg = SellingRView.LocalReport.Render("Image");

            using (MemoryStream ms = new MemoryStream(Eimg))
            {
                Image img = Image.FromStream(ms);
                e.Graphics.DrawImage(img, e.MarginBounds);
            }

        }

        #endregion

        #endregion

        #region ReportTabEvents

        private byte[] bcodemaker(string Bcode)
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
                    TextFont = new Font("Gadugi", 7f, FontStyle.Bold),
                },
            };

            var img = writer.Write(Bcode);

            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private void Loadreport(DataTable dt)
        {
            List<OReport> receipts = new List<OReport>();
            receipts.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                OReport re = new OReport
                {
                    Uname = dt.Rows[i]["Uname"].ToString(),
                    MName = dt.Rows[i]["MName"].ToString(),
                    olQuantity = Convert.ToInt32(dt.Rows[i]["olQuantity"]),
                    Sell = Convert.ToInt32(dt.Rows[i]["Sell"]),
                    BImage = bcodemaker(dt.Rows[i]["OBarcode"].ToString()),
                };
                receipts.Add(re);
            }

            rs.Name = "DataSet1";
            rs.Value = receipts;
            ReportRview.LocalReport.DataSources.Clear();
            ReportRview.LocalReport.DataSources.Add(rs);
            ReportRview.LocalReport.ReportEmbeddedResource = "pharmacyp.Sellingreport.rdlc";
            if (ReportRview.Visible == false)
            {
                ReportRview.Visible = true;
            }

            ReportRview.RefreshReport();
        }

        private void RepBcodebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ReportGrid.DataSource = DataAccess.LoadRHistory(RepBcodebox.Text);
            }
        }

        private void ReportGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                int orderID = Convert.ToInt32(ReportGrid.Rows[e.RowIndex].Cells["OrderID"].Value);
                if (ReportGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {

                    Refund(DataAccess.LoadRReceipt(orderID));
                }

                else if (e.RowIndex >= 0)
                {

                    Loadreport(DataAccess.LoadRReceipt(orderID));
                }
            }
        }

        private void Refund(DataTable dt)
        {
            if (true)
            {

            }
            //DataAccess.Conn("PharDCS").Execute($"Update Medicine_Stock SET {column} = {column} + @QQ where MedicineID = @id", new {QQ = , id = });
            //DataAccess.Conn("PharDCS").Execute("Delete from mOrder where OrderID = @id", new { id = });

        }
        #endregion

        #region SettingsTabEvents

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            Loadgraph(st());
            timer1.Stop();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowSalesData(DataAccess.GetSalesData());
        }

        private void ShowSalesData(List<OReport> salesDataList1)
        {
            List<OReport> salesDataList = DataAccess.GetSalesData();

            chart1.Titles.Add("Total Sales by User");

            // Set the chart area
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Order Date";
            chartArea.AxisY.Title = "Total Sales";
            chart1.ChartAreas.Add(chartArea);

            foreach (string username in salesDataList.Select(s => s.Uname).Distinct())
            {
                Series series = new Series(username);
                series.ChartType = SeriesChartType.Line;

                // Add the data points for the user
                foreach (OReport salesData in salesDataList.Where(s => s.Uname == username))
                {
                    DataPoint dataPoint = new DataPoint();
                    dataPoint.XValue = salesData.OrderDate.ToOADate();
                    dataPoint.YValues = new double[] { salesData.TotalSales };
                    series.Points.Add(dataPoint);
                }
                chart1.Series.Add(series);
            }
        }

    }

}
