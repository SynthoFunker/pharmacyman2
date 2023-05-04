using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacyp.TabContainer
{
    public partial class Backuptab : UserControl
    {
        public Backuptab()
        {
            InitializeComponent();
        }

        private void backupbtn_Click(object sender, EventArgs e)
        {
            string sourcePath = @"C:\Users\Han\source\repos\pharmacyp\Resources\Database8.accdb";
            string backupPath = @"D:\Program Files\Backup\Database8.accdb";

            File.Copy(sourcePath, backupPath, true);
        }

        private void resbtn_Click(object sender, EventArgs e)
        {
            string restorePath = @"C:\Users\Han\source\repos\pharmacyp\Resources\Database8.accdb";
            string backupPath = @"D:\Program Files\Backup\Database8.accdb";
            File.Copy(backupPath, restorePath, true);
        }
    }
}
