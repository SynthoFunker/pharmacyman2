using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacyp.Forms
{
    public partial class ReportGridview : Form
    {
        private StringBuilder buffer = new StringBuilder();

        public ReportGridview()
        {
            InitializeComponent();
        }

        private void ReportGridview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharDDataSet.FinancialRecord' table. You can move, or remove it, as needed.
            //this.financialRecordTableAdapter.Fill(this.pharDDataSet.FinancialRecord);

        }

        private void ReportGridview_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar.ToString();
            e.Handled = true;
        }
    }
}
