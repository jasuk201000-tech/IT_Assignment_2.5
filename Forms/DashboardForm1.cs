using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmanePOSHelpers;
using IT_Assignment_2.Helpers;

namespace IT_Assessment_2.Forms
{
    public partial class DashboardForm1 : Form
    {
        public DashboardForm1()
        {
            InitializeComponent();
            SetUpUserInfo();
        }

        public void SetUpUserInfo();
        {
            if (SessionManager.CurrentUser! = null)
            {
                welcomeLbl.Text = $"welcome" {SessionManager.CurrentUser.FirstName.ToLower() }
                dateLbl.Text = DateTime.Now().ToString("dddd, d MMMM yyyy");
            }
        }

        public void PopulateKPILabels();
        {
    if (SessionManager.CurrentUser == null)
    {
        {
            intSalesLbl.Text = string.Empty; //placeholder for actual text

        }
    }
}
