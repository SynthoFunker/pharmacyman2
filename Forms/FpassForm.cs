using pharmacyp.Miscellaneous;
using System;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacyp.Forms
{
    public partial class FpassForm : Form
    {
        private string _otpCode;
        private static string _userEmail;
        private string firstName;
        private string lastName;
        private static int _userId;
        private static OleDbCrudHelper _dbHelper;

        private const int EMaxAttempts = 3;
        private const int VMaxAttempts = 6;
        private const int LockoutDurationHours = 24;

        public FpassForm()
        {
            InitializeComponent();
            VBox.Enabled = false;
            _dbHelper = new OleDbCrudHelper();
        }

        private async void sendbtn_Click(object sender, EventArgs e)
        {
            if (lblheader.Text == "گۆڕینی وشەی نهێنی")
            {
                if (EBox.Text == VBox.Text)
                {
                    _ = _dbHelper.Update($"Update Users set [Password]='{VBox.Text}' where [email] = '{_userEmail}'", null);
                    _ = MessageBox.Show("گۆڕینی وشەی نهێنی سەرکوتووبوو");
                    login l = new login();
                    l.Show();
                    Hide();
                }
                else
                {
                    _ = MessageBox.Show("وشە نهێنییەکان وەکو یەک نین/جیاوازن");
                }
            }
            else if (sendbtn.Text == "دڵنیاکردنەوە" || EBox.Enabled == false)
            {
                await VerifyButton_ClickAsync();
                return;
            }
            else if (EBox.Text == string.Empty)
            {
                _ = MessageBox.Show("Test");
            }
            else
            {
                _ = await Send();
            }
        }

        private async Task<Task> Send()
        {
            OleDbParameter p = new OleDbParameter("@email", EBox.Text.Trim());
            OleDbDataReader re = _dbHelper.SExecuteReader("SELECT * FROM Users WHERE email = @email", p);

            if (re == null)
            {
                _ = MessageBox.Show("ئەم ئیمێڵە تۆمار نەکراوە.");
                return Task.CompletedTask;
            }
            else if (!re.HasRows)
            {
                _ = MessageBox.Show("تکایە ئیمێڵێکی گونجاو بنووسە.");
                return Task.CompletedTask;
            }
            else if (re.HasRows)
            {
                if (await IsUserLockedOutAsync(Convert.ToInt32(re["id"])))
                {
                    _ = MessageBox.Show($"هەوڵی دڵنیابوونەوەت بەسەرچووە. تکایە {LockoutDurationHours} کاتژمێر دوایین هەوڵ بدە.");
                    EBox.Clear();
                    VBox.Clear();
                    VBox.Enabled = false;
                    EBox.Enabled = false;
                    return Task.CompletedTask;
                }
                if (IsValidEmail(EBox.Text))
                {

                    firstName = re["fname"].ToString();
                    _userEmail = re["email"].ToString();
                    lastName = re["lname"].ToString();
                    _userId = Convert.ToInt32(re["id"]);
                    try
                    {
                        using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
                        {
                            smtpClient.UseDefaultCredentials = false;
                            smtpClient.Credentials = new NetworkCredential("pharmanager01@gmail.com", "zevdpeczmvzyzwzo");
                            smtpClient.EnableSsl = true;
                            smtpClient.Port = 587;

                            string otpCode = GenerateOtpCode();
                            _otpCode = otpCode;
                            string subject = "گۆڕینی وشەی نهێنی";
                            string body = $"سڵاو {firstName} {lastName} کۆدی داواکراو برییتیە لە {_otpCode}";

                            await smtpClient.SendMailAsync("pharmanager01@gmail.com", _userEmail, subject, body);

                            _ = MessageBox.Show("کۆدی دڵنیابوونەوەت بۆ نێردرا");
                            int failedAttempts = IncrementFailedAttempts(_userId);
                            if (failedAttempts >= EMaxAttempts)
                            {
                                SetLockoutEndTime(_userId, DateTime.Now.AddHours(LockoutDurationHours));
                                _ = MessageBox.Show($"هەوڵی دڵنیابوونەوەت بەسەرچوونە. تکایە {LockoutDurationHours} کاتژمێر دوایین هەوڵ بدە.");
                                VBox.Clear();
                                EBox.Clear();
                                VBox.Enabled = false;
                            }
                            sendbtn.Text = "دڵنیاکردنەوە";
                            EBox.Enabled = false;
                            VBox.Enabled = true;
                            timer.Start();
                        }
                    }
                    catch (Exception ex)
                    {
                        _ = MessageBox.Show($"ناردنەکە سەرکەوتوو نەبوو.\n\nError: {ex.Message}");
                        return Task.CompletedTask;
                    }
                }
                else
                {
                    _ = MessageBox.Show("تکایە ئیمێڵێکی گونجاو بنووسە.");
                    return Task.CompletedTask;
                }
            }
            return Task.CompletedTask;
        }

        private Task VerifyButton_ClickAsync()
        {
            _ = int.TryParse(VBox.Text.Trim(), out int enteredOtpCode);
            if (VBox.Text == string.Empty)
            {
                _ = MessageBox.Show("تکایە تەنها کۆدەکە بنووسە");
                return Task.CompletedTask;
            }
            else if (enteredOtpCode.ToString() != _otpCode)
            {
                int failedAttempts = IncrementFailedAttempts(_userId);
                if (failedAttempts >= VMaxAttempts)
                {
                    SetLockoutEndTime(_userId, DateTime.Now.AddHours(LockoutDurationHours));
                    _ = MessageBox.Show($"هەوڵی دڵنیابوونەوەت بەسەرچوونە. تکایە {LockoutDurationHours} کاتژمێر دوایین هەوڵ بدە.");
                    VBox.Clear();
                    EBox.Clear();
                    VBox.Enabled = false;
                }
                else
                {
                    _ = MessageBox.Show("ئەو کۆدەی داخڵت کردووە هەڵەیە");
                }
            }
            else if (enteredOtpCode.ToString() == _otpCode)
            {
                ResetFailedAttempts(_userId);
                _ = MessageBox.Show("کۆدەکە دڵنیاکرایەوە");
                lblheader.Text = "گۆڕینی وشەی نهێنی";
                lble.Text = "وشەی نهێنی نوێ";
                lblv.Text = "دووبارە وشەی نهێنی نوێ بنووسە";
                EBox.Enabled = true;
                VBox.Enabled = true;
                return Task.CompletedTask;
            }

            return Task.CompletedTask;
        }

        private string GenerateOtpCode()
        {
            RNGCryptoServiceProvider random = new RNGCryptoServiceProvider();
            byte[] bytes = new byte[4];
            random.GetBytes(bytes);
            uint code = BitConverter.ToUInt32(bytes, 0) % 100000;
            return code.ToString("D5");
        }

        private static bool IsValidEmail(string email)
        {
            return isValidEmail(email, out _userId);
        }
        private static bool isValidEmail(string email, out int _userId)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                OleDbDataReader re = _dbHelper.ExecuteReader($"Select id from users where email = '{email}'", null);

                _userId = Convert.ToInt32(re["id"]);
                return mailAddress.Address == email;
            }
            catch
            {
                _userId = 0;
                return false;
            }

        }

        private int IncrementFailedAttempts(int userId)
        {
            OleDbParameter paramUserId = new OleDbParameter("@userId", userId);
            int updatedRows = _dbHelper.SUpdate("UPDATE ResetPasswordAttempts SET failed_attempts = failed_attempts + 1 WHERE user_id = @userId", paramUserId);

            if (updatedRows == 0)
            {
                OleDbParameter paramNewUserId = new OleDbParameter("@userId", userId);
                _ = _dbHelper.SInsert("INSERT INTO ResetPasswordAttempts (user_id, failed_attempts) VALUES (@userId, 1)", paramNewUserId);
                return 1;
            }
            OleDbParameter paramRetrieveAttempts = new OleDbParameter("@userId", userId);
            OleDbDataReader attemptsReader = _dbHelper.SExecuteReader("SELECT failed_attempts FROM ResetPasswordAttempts WHERE user_id = @userId", paramRetrieveAttempts);
            return Convert.ToInt32(attemptsReader["failed_attempts"]);
        }

        private void ResetFailedAttempts(int userId)
        {
            OleDbParameter paramUserId = new OleDbParameter("@userId", 1);
            _ = _dbHelper.SUpdate("UPDATE ResetPasswordAttempts SET failed_attempts = 0 WHERE user_id = @userId", paramUserId);
            VBox.Enabled = true;
        }

        private void SetLockoutEndTime(int userId, DateTime lockoutEndTime)
        {
            OleDbParameter[] d = { new OleDbParameter("@userId", userId) };
            _ = _dbHelper.Update($"UPDATE ResetPasswordAttempts SET lockout_end_time = '{lockoutEndTime}' WHERE user_id = @userId", d);
        }

        private async Task<bool> IsUserLockedOutAsync(int userId)
        {
            OleDbParameter paramUserId = new OleDbParameter("@userId", userId);
            OleDbDataReader lockoutReader = _dbHelper.SExecuteReader("SELECT lockout_end_time FROM ResetPasswordAttempts WHERE user_id = @userId", paramUserId);
            object lockoutEndTime = lockoutReader["lockout_end_time"];
            if (lockoutEndTime != DBNull.Value)
            {
                DateTime endTime = Convert.ToDateTime(lockoutEndTime);
                DateTime networkTime = await NTPClient.NetworkTime.GetNetworkTimeAsync();
                if (networkTime >= endTime)
                {
                    ResetFailedAttempts(userId);
                    return false;
                }
                else
                {
                    return DateTime.UtcNow > endTime || DateTime.UtcNow < endTime;
                }
            }
            return false;
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            login b = new login();
            b.Show();
            Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timer.Interval == 5000)
            {
                lblncode.Visible = true;
            }
        }

        private void lblncode_ClickAsync(object sender, EventArgs e)
        {
            _ = Send();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Dispose();
        }
    }

}