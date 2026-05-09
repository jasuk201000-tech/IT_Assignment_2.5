using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IT_Assessment_2.Forms
{
    public partial class PasswordControl1 : UserControl
    {
        

        // implement CSV connection

        private int attempts = 3;

        

        public event EventHandler LoginSuccess;

        // constructor
        public PasswordControl1()
        {
            InitializeComponent();

            // connect button click
            button1.Click += button1_Click;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // check if username exists
            if (users.ContainsKey(username))
            {
                // check password
                if (users[username] == password)
                {
                    MessageBox.Show(
                        "Login successful!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // open next screen
                    LoginSuccess?.Invoke(this, EventArgs.Empty);

                    return;
                }
            }

            // failed login
            attempts--;

            MessageBox.Show(
                $"Wrong login.\nAttempts left: {attempts}",
                "Login Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            // lock out
            if (attempts <= 0)
            {
                MessageBox.Show(
                    "Too many failed attempts.",
                    "Locked",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowScreen()
        }
    }
}