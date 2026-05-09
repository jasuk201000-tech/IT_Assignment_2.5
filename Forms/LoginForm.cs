using System;
using System.Windows.Forms;

namespace IT_Assessment_2.Forms
{
    public partial class LoginForm : Form
    {
        // Reusable user controls
        private PasswordControl1 passwordScreen;
        private PINControl1 pinScreen;

        public LoginForm()
        {
            InitializeComponent();

            // Create screens
            passwordScreen = new PasswordControl1();
            pinScreen = new PINControl1();

            // Show default screen
            ShowScreen(passwordScreen);
        }

        // switches between user controls
        private void ShowScreen(UserControl newScreen)
        {
            // Remove existing control
            if (pnlLoginContainer.Controls.Count > 0)
            {
                pnlLoginContainer.Controls.Clear();
            }

            // Configure new control
            newScreen.Dock = DockStyle.Fill;
            newScreen.Margin = Padding.Empty;

            // Add to panel
            pnlLoginContainer.Controls.Add(newScreen);
            newScreen.BringToFront();
        }
    }
}