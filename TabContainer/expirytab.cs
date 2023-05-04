using pharmacyp.CrudHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacyp.TabContainer
{
    public partial class expirytab : UserControl
    {
        public expirytab()
        {
            InitializeComponent();
          
        }   

        private void expirytable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in expirytable.Rows)
            {
                DateTime expd = Convert.ToDateTime(row.Cells["expiry_date"].Value);
                if (expd <= DateTime.Today) { row.DefaultCellStyle.BackColor = Color.Red; }
                else if (expd <= DateTime.Today.AddDays(3)) { row.DefaultCellStyle.BackColor = Color.Orange; }
                else if (expd <= DateTime.Today.AddDays(10)) { row.DefaultCellStyle.BackColor = Color.Yellow; }
                else { row.DefaultCellStyle.BackColor = Color.Green; }
            }

        }

        private void expirytab_Load(object sender, EventArgs e)
        {
            //OleDbCrudHelper m = new OleDbCrudHelper();
            //DataTable dt = m.Select("SELECT name, mbarcode, purchased_date, expiry_date, amount FROM medicines WHERE (((expiry_date) >= Date() - 365 And (expiry_date) <= Date() + 10)) ORDER BY expiry_date ASC", null);

            //expirytable.DataSource = dt;
            //expirytable.Refresh();            
        }
    }
}
