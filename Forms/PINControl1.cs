using System;
using System.Windows.Forms;

namespace IT_Assessment_2.Forms
{
    public partial class PINControl1 : UserControl
    {
        // events MainForm listens to
        public event EventHandler LoginSuccess;
        public event EventHandler SwitchToPassword;

        private const int PIN_LENGTH = 4;
        private readonly object pnlLoginContainer;

        // stores what the user has typed so far
        private string enteredPin = "";

        public PINControl1()
        {
            InitializeComponent();

            // start with empty display
            pinInput.Text = "";

            // wire up all 9 digit buttons to ONE handler
            button2.Click += DigitButton_Click; // "1"
            button1.Click += DigitButton_Click; // "2"
            button3.Click += DigitButton_Click; // "3"
            button4.Click += DigitButton_Click; // "4"
            button5.Click += DigitButton_Click; // "5"
            button6.Click += DigitButton_Click; // "6"
            button7.Click += DigitButton_Click; // "7"
            button8.Click += DigitButton_Click; // "8"
            button9.Click += DigitButton_Click; // "9"

            // switch to password screen link
            linkLabel2.LinkClicked += LinkLabel2_LinkClicked;
        }

        \
        private void DigitButton_Click(object sender, EventArgs e)
        {
            // ignore extra clicks once 4 digits entered
            if (enteredPin.Length >= PIN_LENGTH) return;

            // get the number off the button that was clicked
            Button clicked = (Button)sender;
            enteredPin += clicked.Text;

            // show dots for what's been typed
            pinInput.Text = new string('•', enteredPin.Length);

            // auto-submit once 4 digits entered
            if (enteredPin.Length == PIN_LENGTH)
            {
                CheckPin();
            }
        }

        // try catch for later implementation
        private void CheckPin()
        {
            try
            {
                // TODO: replace this block with CSV lookup later.
                // for now there is no source of truth, so throw
                // and let the catch handle the "wrong PIN" path.
                bool isValid = false;

                throw new NotImplementedException("PIN source not connected yet (CSV pending).");

                // when CSV is added it will look something like:
                // isValid = PinHelper.CheckPin(enteredPin);

                if (isValid)
                {
                    LoginSuccess?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Incorrect PIN. Try again.",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    ResetPin();
                }
            }
            catch (Exception ex)
            {
                // safety net so the app doesn't crash while CSV is missing
                MessageBox.Show("Could not verify PIN: " + ex.Message,
                                "Login Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                ResetPin();
            }
        }

        // setting the pin to empty string
        private void ResetPin()
        {
            enteredPin = "";
            pinInput.Text = "";
        }

        // switching back to password mode
        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPin(); // clean slate when leaving
            SwitchToPassword?.Invoke(this, EventArgs.Empty);
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowScreen(PasswordControl1);
        }

        private void ShowScreen(UserControl screen)
        {
            pnlLoginContainer.Controls.Clear();

            screen.Dock = DockStyle.Fill;

            pnlLoginContainer.Controls.Add(screen);
        }
    }
}