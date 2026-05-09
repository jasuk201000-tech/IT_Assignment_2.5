using IT_Assessment_2.Helpers;
using IT_Assignment_2.Helpers;
using System;
using System.IO;
using System.Windows.Forms;
using IT_Assessment_2.Helpers;

namespace IT_Assessment_2.Forms
{
    public partial class PasswordControl1 : UserControl
    {
        public event EventHandler LoginSuccess;
        public event EventHandler SwitchToPin;

        private int attempts = 3;

        public PasswordControl1()
        {
            InitializeComponent();


            button1.Click += Button1_Click;
            button2.Click += button2_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // confirm staff.csv exists before reading it
            if (!File.Exists(Paths.Staff))
            {
                MessageBox.Show(
                    "Staff data file not found:\n" + Paths.Staff,
                    "Missing Data File",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            SwitchToPin?.Invoke(this, EventArgs.Empty);
        }

    }
}