
using pharmacyp.Forms;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pharmacyp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private async void lgnbtn_Click(object sender, EventArgs e)
        {
            using (AsyncOleDbCrudHelper ol = new AsyncOleDbCrudHelper())
            {
                OleDbParameter[] parameters = new OleDbParameter[]
                {
            new OleDbParameter("@username", this.EorUBox.Text),
            new OleDbParameter("@password", this.passBox.Text),
                };

                OleDbDataReader reader = await ol.ExecuteReaderAsync("SELECT * FROM mUser WHERE (Uname = @username OR Uemail = @username) AND UPassword = @password;", parameters);
                await reader.ReadAsync();
                if ( reader != null && reader.HasRows)
                {
                    int userId = Convert.ToInt32(reader["UserID"]);

                    OleDbDataReader reader2 = await ol.ExecuteReaderAsync($"SELECT * FROM CompleteNames WHERE UserID = {userId}", null);
                    await reader2.ReadAsync();
                    if (reader2 != null && reader2.HasRows)
                    {
                        string name = $"{(string)reader2["fname"]} {(string)reader2["mname"]}";
                        string role = (string)reader["UserType"];
                        MainForm.UserID = userId;
                        MainForm.UName = name;
                        MainForm.Role = role;
                        MessageBox.Show($"بەخێربێیت {name} پلەکەت {role}");

                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }

                    reader.Close();
                    reader2.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

        private void visible_Click(object sender, EventArgs e)
        {
            if (this.passBox.PasswordChar == '*' || this.passBox.PasswordChar == '●')
            {
                this.passBox.UseSystemPasswordChar = false;
                this.passBox.PasswordChar = '\0';
                this.visible.Image = Properties.Resources.icons8_eye_25px_1;
            }
            else if (this.passBox.PasswordChar == '\0')
            {
                this.passBox.PasswordChar = '*';
                this.passBox.UseSystemPasswordChar = true;
                this.visible.Image = Properties.Resources.icons8_invisible_25px;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FpassForm m = new FpassForm();
            m.Show();
            this.Hide();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.Refresh();
            EorUBox.Focus();
        }
    }
}
