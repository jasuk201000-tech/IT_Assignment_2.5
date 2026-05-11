using IT_Assessment_2.CSVs;
using IT_Assignment_2.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;
using static IT_Assessment_2.Models.Staff;

namespace IT_Assessment_2.Forms
{
    public partial class DashboardForm1 : Form
    {
        public DashboardForm1()
        {
            InitializeComponent();

            SetUpUserInfo();
            PopulateKPILabels();
            ApplyRoleBasedAccess();
        }

        // setting up user info
        private void SetUpUserInfo()
        {
            if (SessionManager.CurrentUser != null)
            {
                welcomeLbl.Text = $"welcome {SessionManager.CurrentUser.FirstName.ToLower()}";
            }
            else
            {
                welcomeLbl.Text = "welcome";
            }

            dateLbl.Text = DateTime.Now.ToString("dddd, d MMMM yyyy");
        }

        // kpi tiles from CSV file
        private void PopulateKPILabels()
        {
            try
            {
                var orders = CsvHelper.LoadOrders(Paths.Orders);
                var variants = CsvHelper.LoadVariants(Paths.Variants);

                // today's sales: sum of Total for any completed order placed today
                decimal todaysSales = orders
                    .Where(o => o.Status == "Completed" && o.OrderDate.Date == DateTime.Today)
                    .Sum(o => o.Total);

                // today's order count
                int todaysOrders = orders
                    .Count(o => o.Status == "Completed" && o.OrderDate.Date == DateTime.Today);

                // low stock count: any variant at or below its reorder level
                int lowStockCount = variants.Count(v => v.IsLowStock);

                // returns: not tracked yet — placeholder
                int returnsCount = 0;

                intSalesLbl.Text = $"${todaysSales:F2}";
                intOrdersLbl.Text = todaysOrders.ToString();
                lowstockintLbl.Text = lowStockCount.ToString();
                returnsintLbl.Text = returnsCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load dashboard data: " + ex.Message,
                    "Data Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                intSalesLbl.Text = "$0.00";
                intOrdersLbl.Text = "0";
                lowstockintLbl.Text = "0";
                returnsintLbl.Text = "0";
            }
        }

        // applying role based access
        private void ApplyRoleBasedAccess()
        {
            if (SessionManager.CurrentUser == null) return;

            var role = SessionManager.CurrentUser.Role;

            // Admin and Manager see all KPIs; Cashier only sees today's count
            bool isPrivileged = (role == UserRole.Admin || role == UserRole.Manager);

            // hide sensitive KPI numbers from cashiers
            intSalesLbl.Visible = isPrivileged;
            salesLbl.Visible = isPrivileged;
            lowstockintLbl.Visible = isPrivileged;
            lowstockLbl.Visible = isPrivileged;
            returnsintLbl.Visible = isPrivileged;
            returnsLbl.Visible = isPrivileged;

            // cashiers always see today's order count (their KPI)
            intOrdersLbl.Visible = true;
            ordersLbl.Visible = true;

            // hide nav items the cashier shouldn't see
            // (your design doc: Cashier sees Home, Inventory, Orders only)
            if (role == UserRole.Cashier)
            {
                button8.Visible = false;   // transactions
                button9.Visible = false;   // reports
                button4.Visible = false;   // Reports quick action
            }
        }
    }
}