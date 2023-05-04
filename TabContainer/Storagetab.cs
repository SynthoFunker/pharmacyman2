using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using pharmacyp.CrudHelper;
using pharmacyp.Forms;

namespace pharmacyp.TabContainer
{
    public partial class Storagetab : UserControl
    {
        private readonly AsyncOleDbCrudHelper m;

        public Storagetab()
        {
            InitializeComponent();
            m = new AsyncOleDbCrudHelper();
        }

        private void insbtn_Click(object sender, EventArgs e)
        {
            bool opened = false;
            if (opened)
            {
                _ = MessageBox.Show("Test");
            }
            else
            {
                InsertForm m = new InsertForm();
                m.Show();
                opened = true;
            }
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                //e
            }
            //else if (e.ColumnIndex == dataGridView1.Columns["deletee"].Index)
            //{
            //    int IDD = (int)dataGridView1.Rows[e.RowIndex].Cells["MedicationID"].Value;

            //    _ = await m.Connection.ExecuteAsync("Delete from Inventory where MedicationID = @ID", new { ID = IDD });
            //    _ = MessageBox.Show("ڕەشکرایەوە");
            //    await LoadgridviewAsync();
            //}
        }

        private async void Storagetab_Load(object sender, EventArgs e)
        {
            await LoadgridviewAsync();
        }

        public async Task LoadgridviewAsync()
        {
            using (m.Connection = new OleDbConnection(m.ConnectionString))
            {
                IDataReader re = DataAccess.Conn("PharDCS").ExecuteReader("SELECT Medication.MedicationID, Medication.MName, Medication.Description, Medication.Dosage, Medication.Cost, Medication.Sell, Medication.Company, Inventory.Barcode, Inventory.ExpiryDate, Medicine_Stock.SQuantity, Medicine_Stock.MQuantity, Medicine_Stock.TotalQ FROM Medicine_Stock INNER JOIN (Inventory INNER JOIN Medication ON Inventory.MedicationID = Medication.MedicationID) ON Medicine_Stock.MedicationID = Medication.MedicationID Order By Medication.MName;", null);
                DataTable dt = new DataTable();
                dt.Load(re);
                this.dataGridView1.DataSource = dt;
                this.dataGridView1.Refresh();
            }
        }

        private async void Storagetable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            object newValue = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            object primaryKeyValue = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            string columnName = this.dataGridView1.Columns[e.ColumnIndex].DataPropertyName;
            using (m.Connection = new OleDbConnection(m.ConnectionString))
            {
                var parameters = new { val = newValue, key = primaryKeyValue };
                await m.Connection.ExecuteAsync($"UPDATE Inventory INNER JOIN (Medicine_Stock INNER JOIN Medication ON Medicine_Stock.MedicationID = Medication.MedicationID) ON Inventory.MedicationID = Medication.MedicationID SET {columnName} = @val WHERE Medication.MedicationID = @key", parameters);
                m.Connection.Close();
            }
        }

        public void SubscribeToPurchaseMadeEvent(Sellingtab purchaseControl)
        {
            purchaseControl.PurchaseMade += async (sender, e) =>
            {
                await LoadgridviewAsync();
            };
        }
    }
}
