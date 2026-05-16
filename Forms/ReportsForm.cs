using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Assessment_2.Forms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // sizing winform

            // implement nav bar later 
            
            // winform sizing
            var screen = Screen.PrimaryScreen.WorkingArea;
            if (this.Width > screen.Width) this.Width = screen.Width;
            if (this.Height > screen.Height) this.Height = screen.Height;

            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void OpenChild(Form child)
        {
            this.Hide();
            child.StartPosition = FormStartPosition.CenterScreen;
            child.FormClosed += (s, e) => this.Show();
            child.Show();
        }
    }
}
