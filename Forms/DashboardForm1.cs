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
            ConfigureLowStockGrid();
            PopulateLowStockGrid();

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

        private void PopulateLowStockGrid()
        {
            try
            {
                var products = CsvHelper.LoadProducts(Paths.Products);
                var variants = CsvHelper.LoadVariants(Paths.Variants);

                // join variants -> products so we can show readable names
                var lowStockRows = variants
                    .Where(v => v.IsLowStock || v.IsOutOfStock)
                    .Join(products,
                          v => v.ProductID,
                          p => p.ProductID,
                          (v, p) => new
                          {
                              Product = p.ProductName,
                              Size = v.Size,
                              SKU = v.SKU,
                              Stock = v.StockLevel,
                              Reorder = v.ReorderLevel,
                              Status = v.IsOutOfStock ? "OUT OF STOCK" : "LOW",
                          })
                    .OrderBy(r => r.Stock)        // most urgent first (0s on top)
                    .ThenBy(r => r.Product)
                    .ToList();

                dataGridView1.DataSource = lowStockRows;

                // pretty up the grid after binding
                ConfigureLowStockGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load low-stock data: " + ex.Message,
                    "Data Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigureLowStockGrid()
        {
            // safety check — if binding failed, no columns exist
            if (dataGridView1.Columns.Count == 0) return;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // column header text (nicer than the property names)
            dataGridView1.Columns["Product"].HeaderText = "Product";
            dataGridView1.Columns["Size"].HeaderText = "Size";
            dataGridView1.Columns["SKU"].HeaderText = "SKU";
            dataGridView1.Columns["Stock"].HeaderText = "Stock";
            dataGridView1.Columns["Reorder"].HeaderText = "Reorder At";
            dataGridView1.Columns["Status"].HeaderText = "Status";

            // colour the OUT OF STOCK rows red for instant visual scan
            dataGridView1.CellFormatting += (s, e) =>
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

                var statusCell = dataGridView1.Rows[e.RowIndex].Cells["Status"];
                if (statusCell?.Value?.ToString() == "OUT OF STOCK")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = AmanePOSHelpers.AmaneStyling.Danger;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = AmanePOSHelpers.AmaneStyling.Warning;
                }
            };
        }
    }
}