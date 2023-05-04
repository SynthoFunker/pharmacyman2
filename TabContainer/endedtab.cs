using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacyp.TabContainer
{
    public partial class endedtab : UserControl
    {
        OleDbCrudHelper m = new OleDbCrudHelper();
        public endedtab()
        {
            InitializeComponent();
            DataTable dt = m.Select("SELECT name, mbarcode, amount FROM medicines WHERE (((amount)=0));",null);
            endedtable.DataSource = dt;
            endedtable.Update();
            endedtable.Refresh();
        }
    }
}
