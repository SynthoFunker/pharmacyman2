using pharmacyp.TabContainer;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pharmacyp.Forms
{
    public partial class InsertForm : Form
    {
        public event EventHandler DataUpdated;

        public InsertForm()
        {
            InitializeComponent();
          
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            OleDbCrudHelper m = new OleDbCrudHelper();
            string barcode = barcodebox.Text;
            string name = namebox.Text;
            int quantity = Convert.ToInt32(Qbox.Text);
            int buyprice = Convert.ToInt32(buypricebox.Text);
            int sellprice = Convert.ToInt32(sellpricebox.Text);
            DateTime buydate = buyydate.Value;
            DateTime expdate = exppdate.Value;
            // m.Insert($"insert into medicines (name, mbarcode, purchased_price, selling_price, purchased_date, expiry_date) values ('{name}','{barcode}',{buyprice},{sellprice},'{buydate.ToShortDateString()}','{expdate.Date.ToShortDateString()}')", null);
            // m.Insert($"insert into stock (amount) values ({quantity})", null);
            m.Insert($"insert into medicines (mbarcode,name,amount, purchased_price, selling_price, purchased_date, expiry_date) values ('{barcode}','{name}',{quantity},{buyprice},{sellprice},'{buydate.ToShortDateString()}','{expdate.Date.ToShortDateString()}');", null);

            MessageBox.Show("Data Inserted Successfully");
            this.Close();

        }

        private void InsertForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
