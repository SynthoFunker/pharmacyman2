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
    public partial class Userstab : UserControl
    {       
        public Userstab()
        {
            InitializeComponent();
            //OleDbCrudHelper m = new OleDbCrudHelper();
            //DataTable dt = m.Select("SELECT username,password,email,roles,fname,lname,mname from users", null);
            //userstable.DataSource = dt;
            //userstable.Update();
            ////userstable.Refresh();
            
        }
    }
}
