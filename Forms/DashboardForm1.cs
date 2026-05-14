using IT_Assessment_2.CSVs;
using IT_Assessment_2.Models;
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
            PopulateLowStockGrid();
            ApplyRoleBasedAccess();

            // quick actions wire up
            button1.Click += (s, e) => new BuildOrderForm().Show();
            button2.Click += (s, e) => new EditProductForm().Show();
            button3.Click += (s, e) => new InventoryForm().Show();

            // to implement: inventory button and reports button

            // wire up navigation button actions
            button5.Click += (s, e) => new DashboardForm1().Show();
            button6.Click += (s, e) => new InventoryForm().Show();
            button7.Click += (s, e) => new BuildOrderForm().Show();
            button8.Click += (s, e) => new ViewOrderForm().Show();
        }

       


        // welcome
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

        // kpi tiles
        private void PopulateKPILabels()
        {
            try
            {
                var orders = CsvHelper.LoadOrders(Paths.Orders);
                var variants = CsvHelper.LoadVariants(Paths.Variants);

                decimal todaysSales = orders
                    .Where(o => o.Status == "Completed" && o.OrderDate.Date == DateTime.Today)
                    .Sum(o => o.Total);

                int todaysOrders = orders
                    .Count(o => o.Status == "Completed" && o.OrderDate.Date == DateTime.Today);

                int lowStockCount = variants.Count(v => v.IsLowStock || v.IsOutOfStock);
                int returnsCount = 0; // placeholder

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

        // low-stock grid
        private void PopulateLowStockGrid()
        {
            try
            {
                var products = CsvHelper.LoadProducts(Paths.Products);
                var variants = CsvHelper.LoadVariants(Paths.Variants);

                var lowStockRows = variants
                    .Where(v => v.IsLowStock || v.IsOutOfStock)
                    .Join(products,
                          v => v.ProductID,
                          p => p.ProductID,
                          (v, p) => new
                          {
                              Product = p.ProductName,
                              Brand = p.Brand,
                              Size = v.Size,
                              SKU = v.SKU,
                              Stock = v.StockLevel,
                              Reorder = v.ReorderLevel,
                              Status = v.IsOutOfStock ? "OUT OF STOCK" : "LOW",
                          })
                    .OrderBy(r => r.Stock)
                    .ThenBy(r => r.Product)
                    .ToList();

                dataGridView1.DataSource = lowStockRows;
                ConfigureGrid();
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

        private void ConfigureGrid()
        {
            if (dataGridView1.Columns.Count == 0) return;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        // role based access
        private void ApplyRoleBasedAccess()
        {
            if (SessionManager.CurrentUser == null) return;

            var role = SessionManager.CurrentUser.Role;
            bool isPrivileged = (role == UserRole.Admin || role == UserRole.Manager);

            intSalesLbl.Visible = isPrivileged;
            salesLbl.Visible = isPrivileged;
            lowstockintLbl.Visible = isPrivileged;
            lowstockLbl.Visible = isPrivileged;
            returnsintLbl.Visible = isPrivileged;
            returnsLbl.Visible = isPrivileged;

            if (role == UserRole.Cashier)
            {
                button8.Visible = false;   // transactions
                button9.Visible = false;   // reports
                button4.Visible = false;   // Reports quick action
            }
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            
            var orderForm = new BuildOrderForm();
            orderForm.Show();
            this.Hide();
        }

        private void AddProductButton_Click(Object sender, EventArgs e)
        {
            
            var editproductForm= new EditProductForm();
            editproductForm.Show();
            this.Hide();
        }

        private void ViewStockButton_Click(Object sender, EventArgs e)
        { 
            var inventoryForm = new InventoryForm();
            inventoryForm.Show();
            this.Hide();
        }

        private void ViewOrderForm_Click(Object sender, EventArgs e)
        { 
            var vieworderForm = new ViewOrderForm();
            vieworderForm.Show();
            this.Hide();
        }

        private void ViewInventoryForm_Click(Object sender, EventArgs e)
        {
            var viewinventoryForm = new InventoryForm();
            viewinventoryForm.Show();
            this.Hide();
        }

        private void ViewDashboardForm_Click(Object sender, EventArgs e)
        {
            var viewdashboardForm = new DashboardForm1();
            viewdashboardForm.Show();
            this.Hide();
        }
    }
}