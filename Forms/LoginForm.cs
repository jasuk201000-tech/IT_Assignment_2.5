using System;
using System.Windows.Forms;
using IT_Assessment_2.Forms;
using AmanePOSHelpers;
using IT_Assessment_2.CSVs;

namespace IT_Assessment_2.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // PASSWORD SCREEN EVENTS
            PasswordControl1.LoginSuccess += LoginScreen_LoginSuccess;
            Button2.Click += PasswordScreen_SwitchToPin;

            // PIN SCREEN EVENTS
            PINControl1.LoginSuccess += LoginScreen_LoginSuccess;
            PINControl1.SwitchToPassword += PinScreen_SwitchToPassword;

            // show default screen
            ShowScreen(passwordControl1);
        }

        private void DefaultScreen()
        { 
            ShowScreen(screen: PasswordControl1 as PasswordControl1);
        }

        // login success — open dashboard, hide this form
        private void LoginScreen_LoginSuccess(object sender, EventArgs e)
        {
            var dashboard = new DashboardForm1();
            dashboard.FormClosed += (s, args) => Application.Exit();
            dashboard.Show();
            this.Hide();
        }

        // switch to pin
        private void PasswordScreen_SwitchToPin(object sender, EventArgs e)
        {
            ShowScreen(PINControl1);
        }

        // switch to password
        private void PinScreen_SwitchToPassword(object sender, EventArgs e)
        {
            ShowScreen(passwordControl1);
        }

        // screen switching between user controls
        private void ShowScreen(UserControl screen)
        {
            pnlLoginContainer.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            pnlLoginContainer.Controls.Add(screen);
        }
    }
}
