using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace pharmacyp.Forms
{
    public partial class MainForm1 : Form
    {
        private readonly List<char> barcode = new List<char>(10);
        private DateTime lastKeystroke = new DateTime(0);

        public static int UserID;
        public static new string UName;
        public static string Role;
        public static string Barcode;

        public MainForm1()
        {
            InitializeComponent();
            hometab1.BringToFront();
            sellingtab1.PurchaseMade += UserControl1_PurchaseMade;

        }

        public MainForm1(int userID, string name, string role)
        {
            InitializeComponent();
            UserID = userID;
            UName = name;
            Role = role;
            lblname.Text = $"ناو : {name}";
            lblrole.Text = $"پلە : {role}";

            if (role == "کارمەند")
            {
                reportbtn.Visible = false;
                settingsbtn.Visible = false;
                homebtn.Visible = false;
                storagebtn.Visible = false;
            }
        }

        private async void UserControl1_PurchaseMade(object sender, EventArgs e)
        {
            storagetab1.LoadgridviewAsync();
            hometab1.Loadgraph();
        }

        private void void MainForm1_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ = DateTime.Now - this.lastKeystroke;
            this.barcode.Add(e.KeyChar);
            this.lastKeystroke = DateTime.Now;

            // process barcode
            if (e.KeyChar == 13)
            {
                string msg = new string(this.barcode.ToArray()).TrimEnd();
                sellingtab1.HandleBarcodeScannerInput(msg);

                barcode.Clear();
            }
        }

        private void Sidebar_MouseHover(object sender, EventArgs e)
        {
            _ = new Guna2GradientButton[] { homebtn, storagebtn, settingsbtn, reportbtn, settingsbtn, logoutbtn };
            Sidebar.Width = Sidebar.MaximumSize.Width;
            homebtn.Text = "سەرەکی";
            storagebtn.Text = "کۆگا";
            sellingbtn.Text = "فرۆشتن";
            reportbtn.Text = "ڕاپۆرت";
            settingsbtn.Text = "ڕێکخستنەکان";
            logoutbtn.Text = "چوونەدەرەوە";
        }

        private void Sidebar_MouseLeave(object sender, EventArgs e)
        {
            Guna2GradientButton[] button5 = new Guna2GradientButton[] { homebtn, storagebtn, sellingbtn, reportbtn, settingsbtn, logoutbtn };
            Point mpos = Sidebar.PointToClient(System.Windows.Forms.Control.MousePosition);
            if (!Sidebar.ClientRectangle.Contains(mpos))
            {
                Sidebar.Width = Sidebar.MinimumSize.Width;
                foreach (Guna2GradientButton button in button5)
                {
                    button.Text = string.Empty;
                }
            }
        }

        private void ProcessButtons(IEnumerable<Guna2GradientButton> buttons, Guna2GradientButton clickedButton)
        {
            foreach (Guna2GradientButton button in buttons)
            {
                if (button == clickedButton)
                {
                    button.FillColor = Color.FromArgb(125, 199, 178);
                    button.FillColor2 = Color.White;
                    button.CustomBorderColor = Color.FromArgb(92, 147, 132);
                    button.CustomBorderThickness = new Padding(0, 0, 5, 0);
                    button.BorderThickness = 1;
                    button.BorderColor = Color.FromArgb(125, 199, 178);
                    button.CustomizableEdges.BottomRight = false;
                    button.CustomizableEdges.TopRight = false;
                }
                else
                {
                    button.CustomBorderThickness = new Padding(0, 0, 0, 0);
                    button.BorderThickness = 0;
                    button.FillColor = Color.FromArgb(155, 205, 188);
                    button.FillColor2 = Color.White;
                    button.CustomizableEdges.BottomRight = true;
                    button.CustomizableEdges.TopRight = true;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Guna2GradientButton clickedButton = (Guna2GradientButton)sender;
            IEnumerable<Guna2GradientButton> buttons = new List<Guna2GradientButton> { homebtn, storagebtn, sellingbtn, reportbtn, settingsbtn, logoutbtn };
            this.ProcessButtons(buttons, clickedButton);

            switch (sender)
            {
                case Guna2GradientButton button1 when button1.Equals(homebtn):
                    hometab1.BringToFront();
                    hometab1.Refresh();
                    break;
                case Guna2GradientButton button1 when button1.Equals(storagebtn):
                    storagetab1.BringToFront();
                    break;
                case Guna2GradientButton button2 when button2.Equals(sellingbtn):
                    sellingtab1.BringToFront();
                    _ = sellingtab1.Focus();
                    break;
                case Guna2GradientButton button3 when button3.Equals(reportbtn):
                    reporttab1.BringToFront();
                    break;
                case Guna2GradientButton button3 when button3.Equals(settingsbtn):
                    settingstab1.BringToFront();
                    break;
                case Guna2GradientButton button3 when button3.Equals(logoutbtn):
                    login l = new login();
                    DialogResult ms = MessageBox.Show("ئایا تۆ دڵنیایت؟", "چوونەدەرەوە", MessageBoxButtons.YesNo);
                    if (ms == DialogResult.Yes)
                    {
                        l.Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                        // nothing
                    }

                    break;
                default:
                    break;
            }
        }

        private void MainForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
