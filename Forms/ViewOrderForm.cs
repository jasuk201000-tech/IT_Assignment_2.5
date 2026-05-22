using IT_Assessment_2.CSVs;
using IT_Assignment_2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static IT_Assessment_2.Models.Staff;

namespace IT_Assessment_2.Forms
{
    public partial class ViewOrderForm : Form
    {
        private List<CsvHelper.Order> _orders;
        private List<CsvHelper.OrderItem> _orderItems;
        private List<CsvHelper.Staff> _staff;

        public ViewOrderForm()
        {
            InitializeComponent();
            ApplyRoleBasedAccess();

            

            LoadData();
            PopulateOrdersGrid();

            // wiring up events
            dgvOrders.SelectionChanged += DgvOrders_SelectionChanged;
            txtSearch.TextChanged += TxtSearch_TextChanged;

            // winform sizing
            this.WindowState = FormWindowState.Maximized;

            this.StartPosition = FormStartPosition.CenterScreen;



            // logo btn nav
            button1.Click += (s, e) => OpenChild(new DashboardForm1()); // logobtn nav to dashboard

            // wire up navigation button actions
            button5.Click += (s, e) => OpenChild(new DashboardForm1()); // dashboard 
            button6.Click += (s, e) => OpenChild(new InventoryForm());      // inventory
            button7.Click += (s, e) => OpenChild(new BuildOrderForm());     // orders / new order
            button8.Click += (s, e) => OpenChild(new ViewOrderForm());  // transactions / history
        }

        private void OpenChild(Form child)
        {
            this.Hide();
            child.StartPosition = FormStartPosition.CenterScreen;
            child.FormClosed += (s, e) => this.Show();
            child.Show();
        }

        private void ApplyRoleBasedAccess()
        {
            if (SessionManager.CurrentUser == null) return;

            var role = SessionManager.CurrentUser.Role;
            bool isPrivileged = (role == UserRole.Admin || role == UserRole.Manager);

            if (isPrivileged)
            {
                button8.Visible = true;
            }
            else
            {
                button8.Visible = false;
            }
        }

        // loading data to csv
        private void LoadData()
        {
            try
            {
                _orders = CsvHelper.LoadOrders(Paths.Orders);
                _orderItems = CsvHelper.LoadOrderItems(Paths.OrderItems);
                _staff = CsvHelper.LoadStaff(Paths.Staff);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load orders:\n" + ex.Message,
                                "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _orders = new List<CsvHelper.Order>();
                _orderItems = new List<CsvHelper.OrderItem>();
                _staff = new List<CsvHelper.Staff>();
            }
        }

        // ensuring that each cell value is set to string.Empty before values are added (so not null)
        private void PopulateOrdersGrid()
        {
            PopulateOrdersGrid("");
        }

        // populating the orders grid
        private void PopulateOrdersGrid(string filter)
        {
            var rows = _orders
                .Select(o => new
                {
                    Order = o,
                    StaffName = _staff.FirstOrDefault(s => s.StaffID == o.StaffID)?.FullName ?? "Unknown",
                })
                .Where(r =>
                    string.IsNullOrWhiteSpace(filter) ||
                    r.Order.OrderID.ToString().Contains(filter) ||
                    r.Order.CustomerName.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    r.StaffName.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderByDescending(r => r.Order.OrderDate)
                .Select(r => new
                {
                    OrderID = r.Order.OrderID,
                    Date = r.Order.OrderDate.ToString("yyyy-MM-dd HH:mm"),
                    Customer = r.Order.CustomerName,
                    Staff = r.StaffName,
                    Total = $"${r.Order.Total:F2}",
                    Payment = r.Order.PaymentMethod,
                    Status = r.Order.Status,
                })
                .ToList();

            dgvOrders.DataSource = rows;

            // adding each column for the data grid view
            if (dgvOrders.Columns.Count > 0)
            {
                dgvOrders.Columns["OrderID"].HeaderText = "Order #";
                dgvOrders.Columns["OrderID"].Width = 80;
                dgvOrders.Columns["Date"].Width = 140;
                dgvOrders.Columns["Customer"].Width = 180;
                dgvOrders.Columns["Staff"].Width = 150;
                dgvOrders.Columns["Total"].Width = 100;
                dgvOrders.Columns["Payment"].Width = 90;
                dgvOrders.Columns["Status"].Width = 100;
            }

            lblCount.Text = $"{rows.Count} order(s)";
        }

        // event for search bar change
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateOrdersGrid(txtSearch.Text);
        }

        // returning the selected change
        private void DgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                ClearLineItems();
                return;
            }

            var row = dgvOrders.SelectedRows[0];
            if (row.Cells["OrderID"].Value == null) return;

            int orderId = (int)row.Cells["OrderID"].Value;
            PopulateLineItems(orderId);
        }

        // populating the line items for the panel
        private void PopulateLineItems(int orderId)
        {
            var order = _orders.FirstOrDefault(o => o.OrderID == orderId);
            if (order == null)
            {
                ClearLineItems();
                return;
            }

            var items = _orderItems
                .Where(i => i.OrderID == orderId)
                .Select(i => new
                {
                    Product = i.ProductName,
                    Size = i.Size,
                    Qty = i.Quantity,
                    UnitPrice = $"${i.UnitPrice:F2}",
                    LineTotal = $"${i.LineTotal:F2}",
                })
                .ToList();

            dgvLineItems.DataSource = items;

            if (dgvLineItems.Columns.Count > 0)
            {
                dgvLineItems.Columns["Product"].Width = 180;
                dgvLineItems.Columns["Size"].Width = 60;
                dgvLineItems.Columns["Qty"].Width = 50;
                dgvLineItems.Columns["UnitPrice"].HeaderText = "Unit Price";
                dgvLineItems.Columns["UnitPrice"].Width = 90;
                dgvLineItems.Columns["LineTotal"].HeaderText = "Line Total";
                dgvLineItems.Columns["LineTotal"].Width = 90;
            }

            lblOrderHeader.Text = $"order #{order.OrderID}";
            lblOrderMeta.Text =
                $"{order.OrderDate:yyyy-MM-dd HH:mm}   {order.CustomerName}   {order.PaymentMethod}";

            lblSubtotal.Text = $"Subtotal: ${order.Subtotal:F2}";
            lblDiscount.Text = order.DiscountAmount > 0
                ? $"Discount ({order.DiscountCode}): -${order.DiscountAmount:F2}"
                : "Discount: -";
            lblTax.Text = $"Tax: ${order.TaxAmount:F2}";
            lblTotal.Text = $"TOTAL: ${order.Total:F2}";
        }

        // clearing line items
        private void ClearLineItems()
        {
            dgvLineItems.DataSource = null;
            lblOrderHeader.Text = "select an order";
            lblOrderMeta.Text = "";
            lblSubtotal.Text = "";
            lblDiscount.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";
        }
    }
}