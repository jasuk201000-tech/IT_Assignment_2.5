using IT_Assessment_2.Forms;
using System;
using System.Windows.Forms;

public partial class LoginForm : Form
{
    private PasswordControl1 passwordScreen;
    private PINControl1 pinScreen;
    private DashboardForm1 dashboardScreen;

    public LoginForm()
    {
        InitializeComponent();

        // create screens
        passwordScreen = new PasswordControl1();
        pinScreen = new PINControl1();
        dashboardScreen = new DashboardForm1();   // <-- was missing

        // PASSWORD SCREEN EVENTS
        passwordScreen.LoginSuccess += LoginScreen_LoginSuccess;
        passwordScreen.SwitchToPIN += PasswordScreen_SwitchToPin;

        // PIN SCREEN EVENTS
        pinScreen.LoginSuccess += LoginScreen_LoginSuccess;             // reuse same handler
        pinScreen.SwitchToPassword += PinScreen_SwitchToPassword;

        // show default screen
        ShowScreen(passwordScreen);
    }

    // open dashboard (used by both password and PIN screens)
    private void LoginScreen_LoginSuccess(object sender, EventArgs e)
    {
        ShowScreen(dashboardScreen);
    }

    private void ShowScreen(DashboardForm1 dashboardScreen)
    {
        throw new NotImplementedException();
    }

    // open pin screen
    public void PasswordScreen_SwitchToPIN(object sender, EventArgs e)
    {
        ShowScreen(pinScreen);
    }

    // open password screen
    public void PinScreen_SwitchToPassword(object sender, EventArgs e)
    {
        ShowScreen(passwordScreen);
    }

    // screen switching
    private void ShowScreen(UserControl screen)
    {
        pnlLoginContainer.Controls.Clear();

        screen.Dock = DockStyle.Fill;

        pnlLoginContainer.Controls.Add(screen);
    }
}