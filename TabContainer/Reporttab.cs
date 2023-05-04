using Microsoft.Reporting.WinForms;
using pharmacyp.CrudHelper;
using pharmacyp.Tables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZXing.Common;
using ZXing.Rendering;
using ZXing;
using Dapper;

namespace pharmacyp.TabContainer
{
    public partial class Reporttab : UserControl
    {

        #region Variables

        public event EventHandler PurchaseRefunded;

        readonly ReportDataSource rs = new ReportDataSource();

        #endregion

        public Reporttab()
        {
            InitializeComponent();
           // guna2DataGridView1.DataSource = DataAccess.LoadRHistory();
         
            reportViewer1.Visible = false;
        }

        private void Loadreport(DataTable dt)
        {
            List<OReport> receipts = new List<OReport>();
            receipts.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                OReport re = new OReport
                {
                   // Username = dt.Rows[i]["Uname"].ToString(),
                    MName = dt.Rows[i]["MName"].ToString(),
                    olQuantity = Convert.ToInt32(dt.Rows[i]["olQuantity"]),
                    Sell = Convert.ToInt32(dt.Rows[i]["Sell"]),
                    BImage = bcodemaker(dt.Rows[i]["OBarcode"].ToString()),
                };
                receipts.Add(re);
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
        }

        private void guna2DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the OrderID value from the clicked cell
                int orderID = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);

                Loadreport(DataAccess.LoadRReceipt(orderID));

            }
        }

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

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && guna2DataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {

                int orderID = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);

                DataTable dt = DataAccess.LoadRReceipt(orderID);

                if (dt != null) { }

            }
        }
    }
}