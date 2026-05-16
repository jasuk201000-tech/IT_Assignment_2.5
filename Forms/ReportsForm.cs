using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using IT_Assessment_2.CSVs;
using IT_Assignment_2.Helpers;

namespace IT_Assessment_2.Forms
{
    public partial class ReportsForm : Form
    {
        private List<CsvHelper.Order> _allOrders;
        private List<CsvHelper.OrderItem> _allOrderItems;
        private List<CsvHelper.Staff> _allStaff;
        private List<CsvHelper.Product> _allProducts;

        public ReportsForm()
        {
            InitializeComponent();

            // sizing
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            LoadAllData();
            InitializeDateRange();

            // wire up filter controls
            btnApply.Click += (s, e) => RefreshAllReports();
            btnPresetToday.Click += (s, e) => SetPreset(0);
            btnPresetWeek.Click += (s, e) => SetPreset(7);
            btnPresetMonth.Click += (s, e) => SetPreset(30);
            btnPresetAll.Click += (s, e) => SetPresetAllTime();

            RefreshAllReports();
        }

        // loading all data
        private void LoadAllData()
        {
            try
            {
                _allOrders = CsvHelper.LoadOrders(Paths.Orders);
                _allOrderItems = CsvHelper.LoadOrderItems(Paths.OrderItems);
                _allStaff = CsvHelper.LoadStaff(Paths.Staff);
                _allProducts = CsvHelper.LoadProducts(Paths.Products);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load report data:\n" + ex.Message,
                                "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _allOrders = new List<CsvHelper.Order>();
                _allOrderItems = new List<CsvHelper.OrderItem>();
                _allStaff = new List<CsvHelper.Staff>();
                _allProducts = new List<CsvHelper.Product>();
            }
        }

        // add date range
        private void InitializeDateRange()
        {
            // default: last 30 days
            dtpTo.Value = DateTime.Today;
            dtpFrom.Value = DateTime.Today.AddDays(-30);
        }

        private void SetPreset(int daysBack)
        {
            dtpTo.Value = DateTime.Today;
            dtpFrom.Value = DateTime.Today.AddDays(-daysBack);
            RefreshAllReports();
        }

        private void SetPresetAllTime()
        {
            dtpTo.Value = DateTime.Today;

            if (_allOrders.Count > 0)
            {
                dtpFrom.Value = _allOrders.Min(o => o.OrderDate).Date;
            }
            else
            {
                dtpFrom.Value = DateTime.Today.AddYears(-1);
            }

            RefreshAllReports();
        }

        // refreshing each section based on input date
        private void RefreshAllReports()
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date.AddDays(1).AddTicks(-1);   // include the entire 'to' day

            if (from > to)
            {
                MessageBox.Show("'From' date must be before 'To' date.", "Invalid Range",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // filter orders for the range
            var ordersInRange = _allOrders
                .Where(o => o.Status == "Completed" && o.OrderDate >= from && o.OrderDate <= to)
                .ToList();

            // filter order items belonging to those orders
            var orderIds = ordersInRange.Select(o => o.OrderID).ToHashSet();
            var itemsInRange = _allOrderItems
                .Where(i => orderIds.Contains(i.OrderID))
                .ToList();

            PopulateSalesSummary(ordersInRange, itemsInRange);
            PopulateTopProducts(itemsInRange);
            PopulateStaffPerformance(ordersInRange);

            lblRangeInfo.Text =
                $"showing {ordersInRange.Count} orders from " +
                $"{dtpFrom.Value:dd MMM yyyy} to {dtpTo.Value:dd MMM yyyy}";
        }

        // =========================
        // SECTION 1: SALES SUMMARY
        // =========================
        private void PopulateSalesSummary(List<CsvHelper.Order> orders, List<CsvHelper.OrderItem> items)
        {
            decimal totalRevenue = orders.Sum(o => o.Total);
            int orderCount = orders.Count;
            decimal avgOrderValue = orderCount > 0 ? totalRevenue / orderCount : 0m;
            int unitsSold = items.Sum(i => i.Quantity);

            lblRevenueValue.Text = $"${totalRevenue:F2}";
            lblOrdersValue.Text = orderCount.ToString();
            lblAvgValue.Text = $"${avgOrderValue:F2}";
            lblUnitsValue.Text = unitsSold.ToString();
        }

        // =========================
        // SECTION 2: TOP PRODUCTS
        // =========================
        private void PopulateTopProducts(List<CsvHelper.OrderItem> items)
        {
            var topProducts = items
                .GroupBy(i => i.ProductName)
                .Select(g => new
                {
                    Product = g.Key,
                    UnitsSold = g.Sum(x => x.Quantity),
                    Revenue = $"${g.Sum(x => x.LineTotal):F2}",
                    AvgPrice = $"${(g.Sum(x => x.Quantity) > 0 ? g.Sum(x => x.LineTotal) / g.Sum(x => x.Quantity) : 0m):F2}",
                })
                .OrderByDescending(r => r.UnitsSold)
                .Take(15)
                .ToList();

            dgvTopProducts.DataSource = topProducts;

            if (dgvTopProducts.Columns.Count > 0)
            {
                dgvTopProducts.Columns["Product"].Width = 260;
                dgvTopProducts.Columns["UnitsSold"].HeaderText = "Units Sold";
                dgvTopProducts.Columns["UnitsSold"].Width = 100;
                dgvTopProducts.Columns["Revenue"].Width = 110;
                dgvTopProducts.Columns["AvgPrice"].HeaderText = "Avg Price";
                dgvTopProducts.Columns["AvgPrice"].Width = 100;
            }
        }

        // staf performance section
        private void PopulateStaffPerformance(List<CsvHelper.Order> orders)
        {
            var staffPerf = orders
                .GroupBy(o => o.StaffID)
                .Select(g => new
                {
                    StaffID = g.Key,
                    Name = _allStaff.FirstOrDefault(s => s.StaffID == g.Key)?.FullName ?? "Unknown",
                    Orders = g.Count(),
                    Revenue = $"${g.Sum(o => o.Total):F2}",
                    AvgOrder = $"${(g.Count() > 0 ? g.Sum(o => o.Total) / g.Count() : 0m):F2}",
                })
                .OrderByDescending(r => decimal.Parse(r.Revenue.Replace("$", "")))
                .ToList();

            dgvStaffPerformance.DataSource = staffPerf;

            if (dgvStaffPerformance.Columns.Count > 0)
            {
                dgvStaffPerformance.Columns["StaffID"].Visible = false;
                dgvStaffPerformance.Columns["Name"].Width = 220;
                dgvStaffPerformance.Columns["Orders"].Width = 90;
                dgvStaffPerformance.Columns["Revenue"].Width = 110;
                dgvStaffPerformance.Columns["AvgOrder"].HeaderText = "Avg Order";
                dgvStaffPerformance.Columns["AvgOrder"].Width = 100;
            }
        }
    }
}