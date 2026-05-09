using IT_Assessment_2.Helpers;
using IT_Assignment_2.Helpers;
using System;
using System.Windows.Forms;

namespace IT_Assessment_2.Forms
{
    public partial class PINControl1 : UserControl
    {
        // events LoginForm listens to
        public event EventHandler LoginSuccess;
        public event EventHandler SwitchToPassword;

        private const int PIN_LENGTH = 4;

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

        // =========================
        // DIGIT BUTTON CLICKED
        // =========================
        private void DigitButton_Click(object sender, EventArgs e)
        {
            // ignore extra clicks once 4 digits entered
            if (enteredPin.Length >= PIN_LENGTH) return;

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

        // =========================
        // PIN VALIDATION
        // =========================
        private void CheckPin()
        {
            try
            {
                var matched = CsvHelper.FindByPin(Paths.Staff, enteredPin);

                if (matched != null)
                {
                    SessionManager.CurrentUser = matched;
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
                MessageBox.Show("Could not verify PIN: " + ex.Message,
                                "Login Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                ResetPin();
            }
        }

        // =========================
        // CLEAR INPUT
        // =========================
        private void ResetPin()
        {
            enteredPin = "";
            pinInput.Text = "";
        }

        // =========================
        // SWITCH BACK TO PASSWORD
        // =========================
        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPin();
            SwitchToPassword?.Invoke(this, EventArgs.Empty);
        }
    }
}