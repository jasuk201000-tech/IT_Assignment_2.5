using System;
using System.Windows.Forms;
using IT_Assessment_2.Forms;
using AmanePOSHelpers;

namespace IT_Assessment_2.Forms
{
    public partial class LoginForm : Form
    {
        private PasswordControl1 passwordScreen;
        private PINControl1 pinScreen;

        public LoginForm()
        {
            InitializeComponent();

            // create login screens (UserControls only — dashboard is separate)
            passwordScreen = new PasswordControl1();
            pinScreen = new PINControl1();

            // PASSWORD SCREEN EVENTS
            passwordScreen.LoginSuccess += LoginScreen_LoginSuccess;
            passwordScreen.SwitchToPin += PasswordScreen_SwitchToPin;

            // PIN SCREEN EVENTS
            pinScreen.LoginSuccess += LoginScreen_LoginSuccess;
            pinScreen.SwitchToPassword += PinScreen_SwitchToPassword;

            // show default screen
            ShowScreen(passwordScreen);
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
            ShowScreen(pinScreen);
        }

        // switch to password
        private void PinScreen_SwitchToPassword(object sender, EventArgs e)
        {
            ShowScreen(passwordScreen);
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