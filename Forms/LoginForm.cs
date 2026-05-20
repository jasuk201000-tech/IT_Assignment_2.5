using System;
using System.Windows.Forms;

namespace IT_Assessment_2.Forms
{
    public partial class LoginForm : Form
    {
        private PasswordControl1 passwordScreen;
        private PINControl1 pinScreen;

        public LoginForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;



            passwordScreen = new PasswordControl1();
            pinScreen = new PINControl1();

            // password screen events
            passwordScreen.LoginSuccess += LoginScreen_LoginSuccess;
            passwordScreen.SwitchToPin += PasswordScreen_SwitchToPin;

            // PIN screen events
            pinScreen.LoginSuccess += LoginScreen_LoginSuccess;
            pinScreen.SwitchToPassword += PinScreen_SwitchToPassword;

            ShowScreen(passwordScreen);

            
        }

        private void LoginScreen_LoginSuccess(object sender, EventArgs e)
        {
            var dashboard = new DashboardForm1();
            dashboard.FormClosed += (s, args) => Application.Exit();
            dashboard.Show();
            this.Hide();
        }

        private void PasswordScreen_SwitchToPin(object sender, EventArgs e)
        {
            ShowScreen(pinScreen);
        }

        private void PinScreen_SwitchToPassword(object sender, EventArgs e)
        {
            ShowScreen(passwordScreen);
        }

        private void ShowScreen(UserControl screen)
        {
            pnlLoginContainer.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            pnlLoginContainer.Controls.Add(screen);
        }
    }
}