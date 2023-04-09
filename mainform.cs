using pharmacyp.TabContainer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace pharmacyp
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            Hometab h = new Hometab();
            LoadUserControl(h);
        }

        public void LoadUserControl(UserControl userControl)
        {
            if (tabcon.Controls.Count > 0 && tabcon.Controls[0].GetType() == userControl.GetType())
            {
                return;
            }
            else
            {
                userControl.Dock = DockStyle.Fill;
                tabcon.Controls.Clear();
                tabcon.Controls.Add(userControl);
                userControl.BringToFront();
            }
        }

        private void Sidebar_MouseHover(object sender, EventArgs e)
        {
            side_animation.Start();
        }

        private void Sidebar_MouseLeave(object sender, EventArgs e)
        {
            Point mpos = sidebar.PointToClient(Control.MousePosition);
            if (!sidebar.ClientRectangle.Contains(mpos))
            {
                sidebar.Width = sidebar.MinimumSize.Width;
            }
        }

        private void side_animation_Tick(object sender, EventArgs e)
        {
            sidebar.Width += 20;

            if (sidebar.Width == sidebar.MaximumSize.Width)
            {

                side_animation.Stop();
            }
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Hometab h = new Hometab();
            LoadUserControl(h);
        }

        private void strbtn_Click(object sender, EventArgs e)
        {
            Storagetab h = new Storagetab();
            LoadUserControl(h);
        }

        private void selbtn_Click(object sender, EventArgs e)
        {
            Sellingtab h = new Sellingtab();
            LoadUserControl(h);
        }

        private void solbtn_Click(object sender, EventArgs e)
        {
            Soldtab h = new Soldtab();
            LoadUserControl(h);
        }

        private void repbtn_Click(object sender, EventArgs e)
        {
            Reporttab h = new Reporttab();
            LoadUserControl(h);
        }

        private void expbtn_Click(object sender, EventArgs e)
        {
            expirytab h = new expirytab();
            LoadUserControl(h);
        }

        private void finbtn_Click(object sender, EventArgs e)
        {
            endedtab h = new endedtab();
            LoadUserControl(h);
        }

        private void usbtn_Click(object sender, EventArgs e)
        {
            Userstab h = new Userstab();
            LoadUserControl(h);
        }

        private void bcbtn_Click(object sender, EventArgs e)
        {
            Backuptab h = new Backuptab();
            LoadUserControl(h);
        }
    }
}
