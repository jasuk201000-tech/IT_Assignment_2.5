using IT_Assessment_2.Helpers;
using IT_Assignment_2.Helpers;
using System;
using System.Windows.Forms;

namespace IT_Assessment_2.Forms
{
    public partial class PasswordControl1 : UserControl
    {
        // events LoginForm listens to
        public event EventHandler LoginSuccess;
        public event EventHandler SwitchToPin;

        private int attempts = 3;

        public PasswordControl1()
        {
            InitializeComponent();

            // wire up controls
            button1.Click += Button1_Click;
        }

        // =========================
        // PASSWORD LOGIN
        // =========================
        private void Button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            try
            {
                var matched = CsvHelper.FindByLogin(Paths.Staff, username, password);

                if (matched != null)
                {
                    SessionManager.CurrentUser = matched;
                    LoginSuccess?.Invoke(this, EventArgs.Empty);
                    return;
                }

                // failed login
                attempts--;

                MessageBox.Show(
                    $"Wrong username or password.\nAttempts left: {attempts}",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Clear();
                txtPassword.Focus();

                // lock out after 3 failed attempts
                if (attempts <= 0)
                {
                    MessageBox.Show(
                        "Too many failed attempts. Login disabled.",
                        "Locked",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    button1.Enabled = false;
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not verify login: " + ex.Message,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // SWITCH TO PIN SCREEN
        // =========================
        private void SwitchToPinLink_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchToPin?.Invoke(this, EventArgs.Empty);
        }
    }
}