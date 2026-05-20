using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
            this.WindowState = FormWindowState.Maximized;

            // sizing
            this.WindowState = FormWindowState.Maximized;

            // wire up navigation button actions
            button5.Click += (s, e) => OpenChild(new DashboardForm1()); // dashboard 
            button6.Click += (s, e) => OpenChild(new InventoryForm());      // inventory
            button7.Click += (s, e) => OpenChild(new BuildOrderForm());     // orders / new order
            button8.Click += (s, e) => OpenChild(new ViewOrderForm());  // transactions / history


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

        private void OpenChild(Form child)
        {
            this.Hide();
            child.StartPosition = FormStartPosition.CenterScreen;
            child.FormClosed += (s, e) => this.Show();
            child.Show();
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
            PopulateTopProductsChart(itemsInRange);
            PopulateStaffPerformance(ordersInRange);
            PopulateSalesOverTimeChart(ordersInRange, from.Date, dtpTo.Value.Date);

            lblRangeInfo.Text =
                $"showing {ordersInRange.Count} orders from " +
                $"{dtpFrom.Value:dd MMM yyyy} to {dtpTo.Value:dd MMM yyyy}";
        }

        // sales summary section
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

       // top products chart
        private void PopulateTopProductsChart(List<CsvHelper.OrderItem> items)
        {
            // top 10 products by units sold
            var topProducts = items
                .GroupBy(i => i.ProductName)
                .Select(g => new
                {
                    Product = g.Key,
                    UnitsSold = g.Sum(x => x.Quantity),
                })
                .OrderByDescending(r => r.UnitsSold)
                .Take(10)
                .ToList();

            chartTopProducts.Series.Clear();
            chartTopProducts.ChartAreas.Clear();
            chartTopProducts.Titles.Clear();

            // chart area styling
            var area = new ChartArea("MainArea");
            area.BackColor = System.Drawing.Color.FromArgb(250, 243, 240);
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(220, 200, 200);
            area.AxisX.LabelStyle.Font = new System.Drawing.Font("Cambria", 8F);
            area.AxisY.LabelStyle.Font = new System.Drawing.Font("Cambria", 9F);
            area.AxisX.LabelStyle.Angle = -30;   // angle labels for long names
            area.AxisX.Interval = 1;             // show every label
            area.AxisX.LineColor = System.Drawing.Color.FromArgb(180, 150, 150);
            area.AxisY.LineColor = System.Drawing.Color.FromArgb(180, 150, 150);
            chartTopProducts.ChartAreas.Add(area);

            // series
            var series = new Series("UnitsSold")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.FromArgb(198, 152, 152),   // amane accent
                BorderColor = System.Drawing.Color.FromArgb(158, 133, 133),
                BorderWidth = 1,
                IsValueShownAsLabel = true,
                LabelForeColor = System.Drawing.Color.FromArgb(70, 50, 50),
                Font = new System.Drawing.Font("Cambria", 8F),
            };

            foreach (var p in topProducts)
            {
                series.Points.AddXY(p.Product, p.UnitsSold);
            }

            chartTopProducts.Series.Add(series);
            chartTopProducts.BackColor = System.Drawing.Color.White;
        }

        // staff performance section
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

        // sales over time section
        private void PopulateSalesOverTimeChart(List<CsvHelper.Order> orders, DateTime from, DateTime to)
        {
            // build a daily revenue series across the range (zero-fill days with no sales)
            var dailySales = new List<(DateTime Date, decimal Revenue)>();

            for (DateTime d = from; d <= to; d = d.AddDays(1))
            {
                decimal dayRevenue = orders
                    .Where(o => o.OrderDate.Date == d.Date)
                    .Sum(o => o.Total);
                dailySales.Add((d, dayRevenue));
            }

            chartSalesOverTime.Series.Clear();
            chartSalesOverTime.ChartAreas.Clear();
            chartSalesOverTime.Titles.Clear();

            var area = new ChartArea("SalesArea");
            area.BackColor = System.Drawing.Color.FromArgb(250, 243, 240);
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(220, 200, 200);
            area.AxisX.LabelStyle.Font = new System.Drawing.Font("Cambria", 8F);
            area.AxisY.LabelStyle.Font = new System.Drawing.Font("Cambria", 9F);
            area.AxisX.LabelStyle.Angle = -30;
            area.AxisX.LineColor = System.Drawing.Color.FromArgb(180, 150, 150);
            area.AxisY.LineColor = System.Drawing.Color.FromArgb(180, 150, 150);
            area.AxisY.LabelStyle.Format = "${0:N0}";

            // choose interval based on range length so labels don't overlap
            int totalDays = (int)(to - from).TotalDays + 1;
            if (totalDays <= 14) area.AxisX.Interval = 1;
            else if (totalDays <= 60) area.AxisX.Interval = 7;
            else area.AxisX.Interval = 30;
            area.AxisX.IntervalType = DateTimeIntervalType.Days;

            chartSalesOverTime.ChartAreas.Add(area);

            var series = new Series("Revenue")
            {
                ChartType = SeriesChartType.Line,
                Color = System.Drawing.Color.FromArgb(198, 152, 152),
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6,
                MarkerColor = System.Drawing.Color.FromArgb(158, 133, 133),
                XValueType = ChartValueType.Date,
            };

            foreach (var d in dailySales)
            {
                series.Points.AddXY(d.Date, (double)d.Revenue);
            }

            chartSalesOverTime.Series.Add(series);
            chartSalesOverTime.BackColor = System.Drawing.Color.White;
        }
    }
}