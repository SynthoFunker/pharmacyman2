using Microsoft.ReportingServices.Diagnostics.Internal;
using pharmacyp.CrudHelper;
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pharmacyp.TabContainer
{
    public partial class Sellingtab : UserControl
    {
        public Sellingtab()
        {
            InitializeComponent();
            guna2DataGridView1.Columns["id"].ValueType = typeof(int);
            guna2DataGridView1.Columns["name"].ValueType = typeof(string);
            guna2DataGridView1.Columns["selling_price"].ValueType = typeof(int);
            guna2DataGridView1.Columns["quantity"].ValueType = typeof(int);
        }

        private void Sellingtab_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }

        private void Sellingtab_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn col in guna2DataGridView1.Columns)
            {
                if (col.DataPropertyName != null)
                {
                    col.DataPropertyName = col.Name;
                }
            }
            OleDbParameter p = new OleDbParameter("@barcode", barbox.Text);

            OleDbCrudHelper q = new OleDbCrudHelper();

            OleDbDataReader re = q.ExecuteReader2("SELECT name, selling_price,mbarcode FROM medicines where mbarcode = @barcode ORDER BY name", p);
            while (re.Read())
            {
                if (barbox.Text == re[0].ToString()) 
                {
                    foreach (DataGridViewColumn col in guna2DataGridView1.Columns)
                    {
                        if (col.ValueType != null)
                        {
                            dt.Columns.Add(col.Name, col.ValueType);
                        }
                        else if (col.CellType == typeof(DataGridViewButtonCell))
                        {

                        }
                    }

                    DataRow row = dt.NewRow();
                    row["name"] = re.GetString(0);
                    row["selling_price"] = re.GetInt32(1);
                    row["quantity"] = 1;
                    dt.Rows.Add(row);
                    guna2DataGridView1.DataSource = dt;
                }

            }
            re.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int medid = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["id"].Value);
            int quantity = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["quantity"].Value);
            int squantity = 0;
            OleDbParameter p = new OleDbParameter("@medid",squantity);
            OleDbDataReader re = StaticOleDbHelper.ExecuteReader("SELECT quantity FROM stock WHERE id= @medid",p);
            if (e.ColumnIndex == guna2DataGridView1.Columns["increment"].Index)
            {
                if (quantity > squantity)
                {
                    MessageBox.Show("too much.");
                }
                else
                {
                    guna2DataGridView1.Rows[e.RowIndex].Cells["quantity"].Value = quantity + 1;
                }
            }
            else if (e.ColumnIndex == guna2DataGridView1.Columns["decrement"].Index)
            {
                if (quantity > 0)
                {
                    guna2DataGridView1.Rows[e.RowIndex].Cells["quantity"].Value = quantity - 1;
                }
                else
                {
                    MessageBox.Show("no.");
                }
            }
            else if (e.ColumnIndex == guna2DataGridView1.Columns["delete"].Index)
            { 

                guna2DataGridView1.Rows.RemoveAt(e.RowIndex);


            }

        }

        private void Sellingtab_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn col in guna2DataGridView1.Columns)
            {
                if (col.DataPropertyName != null)
                {
                    col.DataPropertyName = col.Name;
                }
            }
            OleDbParameter p = new OleDbParameter("@barcode", barbox.Text);

            OleDbCrudHelper q = new OleDbCrudHelper();

            OleDbDataReader re = q.ExecuteReader2("SELECT id, name, selling_price,mbarcode FROM medicines where mbarcode = @barcode ORDER BY name", p);
            while (re.Read())
            {
                if (barbox.Text == re[2].ToString())
                {
                    foreach (DataGridViewColumn col in guna2DataGridView1.Columns)
                    {
                        if (col.ValueType != null)
                        {
                            dt.Columns.Add(col.Name, col.ValueType);
                        }
                        else if (col.CellType == typeof(DataGridViewButtonCell))
                        {

                        }
                    }

                    DataRow row = dt.NewRow();
                    row["id"] = re["id"];
                    row["name"] = re["name"];
                    row["selling_price"] = re["selling_price"];
                    row["quantity"] = 1;
                    dt.Rows.Add(row);
                    guna2DataGridView1.DataSource = dt;
                }


            }
            re.Close();
        }
    }
}
