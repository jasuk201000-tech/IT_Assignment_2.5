using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IT_Assessment_2.CSVs;
using IT_Assignment_2.Helpers;

namespace IT_Assessment_2.Forms
{
    public partial class PINControl1 : UserControl
    {
        public event EventHandler LoginSuccess;
        public event EventHandler SwitchToPassword;

        private const int PIN_LENGTH = 4;
        private string enteredPin = "";

        // load the staff list once when the control is constructed
        private List<CsvHelper.Staff> _allStaff;
        private string _csvPath => Paths.Staff;

        public PINControl1()
        {
            InitializeComponent();

            LoadStaffData();

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

            // switch to password screen
            button11.Click += Button11_Click;
        }

        private void LoadStaffData()
        {
            // safety check — show clear message if file isn't where expected
            if (!File.Exists(_csvPath))
            {
                MessageBox.Show(
                    "Staff data file not found:\n" + _csvPath,
                    "Missing Data File",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                _allStaff = new List<CsvHelper.Staff>();   // empty so .FirstOrDefault() doesn't crash
                return;
            }

            // actually load the staff list — this is what was missing
            _allStaff = CsvHelper.LoadStaff(_csvPath);
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            if (enteredPin.Length >= PIN_LENGTH) return;

            Button clicked = (Button)sender;
            enteredPin += clicked.Text;
            pinInput.Text = new string('•', enteredPin.Length);

            if (enteredPin.Length == PIN_LENGTH)
            {
                CheckPin();
            }
        }

        private void CheckPin()
        {
            // search the in-memory list
            var matched = _allStaff.FirstOrDefault(s => s.Active && s.PIN == enteredPin);

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

        private void ResetPin()
        {
            enteredPin = "";
            pinInput.Text = "";
        }

        // switch to password screen
        private void Button11_Click(object sender, EventArgs e)
        {
            ResetPin();
            SwitchToPassword?.Invoke(this, EventArgs.Empty);
        }
    }
}