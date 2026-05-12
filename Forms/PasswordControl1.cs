using IT_Assessment_2.CSVs;
using IT_Assignment_2.Helpers;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace IT_Assessment_2.Forms
{
    public partial class PasswordControl1 : UserControl
    {
        public event EventHandler LoginSuccess;
        public event EventHandler SwitchToPin;

        // load the staff list once when the control is constructed
        private List<CsvHelper.Staff> _allStaff;
        private string _csvPath => Paths.Staff;

        private int attempts = 3;

        public PasswordControl1()
        {
            InitializeComponent();

            LoadStaffData();

            button1.Click += Button1_Click;
            button2.Click += button2_Click;
        }

        // load all staff once into memory
        private void LoadStaffData()
        {
            if (!File.Exists(_csvPath))
            {
                MessageBox.Show(
                    "Staff data file not found:\n" + _csvPath,
                    "Missing Data File",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                _allStaff = new List<CsvHelper.Staff>();   // empty so lookup just fails cleanly
                return;
            }

            _allStaff = CsvHelper.LoadStaff(_csvPath);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // search the in-memory list (instead of re-reading the CSV)
            var matched = _allStaff.FirstOrDefault(s =>
                s.Active &&
                s.Username == username &&
                s.Password == password);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
