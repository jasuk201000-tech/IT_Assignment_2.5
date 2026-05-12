using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IT_Assessment_2.CSVs;
using IT_Assessment_2.Models;
using IT_Assignment_2.Helpers;

namespace IT_Assessment_2.Forms
{
    public partial class BuildOrderForm : Form
    {
        private List<CsvHelper.Product> _products;
        private List<CsvHelper.Variant> _variants;
        private List<OrderLineItemControl> _lineItems = new List<OrderLineItemControl>();

        private const decimal TAX_RATE = 0.10m;
        private decimal _discountRate = 0m;
        private string _discountCode = "";

        public class AddProductEventArgs : EventArgs
        {
            public CsvHelper.Product Product { get; set; }
            public CsvHelper.Variant Variant { get; set; }
        }

        public BuildOrderForm()
        {
            InitializeComponent();

            LoadCatalog();
            PopulateProductGrid();
            RefreshTotals();

            txtSearch.TextChanged += TxtSearch_TextChanged;
            btnComplete.Click += BtnComplete_Click;
            btnClear.Click += BtnClear_Click;
            btnApplyDiscount.Click += BtnApplyDiscount_Click;

            lblOrderNumber.Text = $"order #{GetNextOrderNumber()}";
        }

        // load data
        private void LoadCatalog()
        {
            try
            {
                _products = CsvHelper.LoadProducts(Paths.Products).Where(p => p.Active).ToList();
                _variants = CsvHelper.LoadVariants(Paths.Variants);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load product catalog:\n" + ex.Message,
                                "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _products = new List<CsvHelper.Product>();
                _variants = new List<CsvHelper.Variant>();
            }
        }

        private int GetNextOrderNumber()
        {
            try
            {
                var orders = CsvHelper.LoadOrders(Paths.Orders);
                return orders.Any() ? orders.Max(o => o.OrderID) + 1 : 1001;
            }
            catch
            {
                return 1001;
            }
        }

        // product grid
        private void PopulateProductGrid()
        {
            PopulateProductGrid("");
        }

        private void PopulateProductGrid(string filter)
        {
            flpProducts.Controls.Clear();

            var filtered = string.IsNullOrWhiteSpace(filter)
                ? _products
                : _products.Where(p =>
                    p.ProductName.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            foreach (var product in filtered)
            {
                var card = new ProductCardControl();
                var variants = _variants.Where(v => v.ProductID == product.ProductID).ToList();
                card.Bind(product, variants);
                card_AddRequested+= Card_AddRequested;
                flpProducts.Controls.Add(card);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateProductGrid(txtSearch.Text);
        }

        // addding and removing items
        private void Card_AddRequested(object sender, AddProductEventArgs e)
        {
            var line = new OrderLineItemControl();
            line.Bind(e.Product, e.Variant);
            line.RemoveRequested += Line_RemoveRequested;

            _lineItems.Add(line);
            flpOrderItems.Controls.Add(line);

            RefreshTotals();
        }

        private void Line_RemoveRequested(object sender, RemoveLineItemEventArgs e)
        {
            _lineItems.Remove(e.LineItem);
            flpOrderItems.Controls.Remove(e.LineItem);
            e.LineItem.Dispose();

            RefreshTotals();
        }

        // totals
        private void RefreshTotals()
        {
            decimal subtotal = _lineItems.Sum(li => li.LineTotal);
            decimal discount = subtotal * _discountRate;
            decimal taxable = subtotal - discount;
            decimal tax = taxable * TAX_RATE;
            decimal total = taxable;   // GST inclusive

            lblSubtotal.Text = $"${subtotal:F2}";
            lblDiscount.Text = $"-${discount:F2}";
            lblTax.Text = $"${tax:F2}";
            lblTotal.Text = $"${total:F2}";
        }

       // discount
        private void BtnApplyDiscount_Click(object sender, EventArgs e)
        {
            string code = txtDiscount.Text.Trim().ToUpperInvariant();

            switch (code)
            {
                case "WELCOME10":
                    _discountRate = 0.10m;
                    _discountCode = code;
                    break;
                case "VIP15":
                    _discountRate = 0.15m;
                    _discountCode = code;
                    break;
                case "STAFF20":
                    _discountRate = 0.20m;
                    _discountCode = code;
                    break;
                case "":
                    _discountRate = 0m;
                    _discountCode = "";
                    break;
                default:
                    MessageBox.Show("Invalid discount code.", "Discount",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            RefreshTotals();
        }

        // completing order
        private void BtnComplete_Click(object sender, EventArgs e)
        {
            if (_lineItems.Count == 0)
            {
                MessageBox.Show("Add at least one item before completing the order.",
                                "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SessionManager.CurrentUser == null)
            {
                MessageBox.Show("No staff member logged in.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string customerName = string.IsNullOrWhiteSpace(txtCustomerName.Text)
                ? "Walk-in"
                : txtCustomerName.Text.Trim();

            decimal subtotal = _lineItems.Sum(li => li.LineTotal);
            decimal discount = subtotal * _discountRate;
            decimal taxable = subtotal - discount;
            decimal tax = taxable * TAX_RATE;
            decimal total = taxable;

            var order = new CsvHelper.Order
            {
                OrderDate = DateTime.Now,
                StaffID = SessionManager.CurrentUser.StaffID,
                CustomerName = customerName,
                Subtotal = subtotal,
                DiscountCode = _discountCode,
                DiscountAmount = discount,
                TaxAmount = tax,
                Total = total,
                PaymentMethod = "Card",
                Status = "Completed",
            };

            try
            {
                int orderId = CsvHelper.AppendOrder(Paths.Orders, order);

                var orderItems = _lineItems.Select(li => new CsvHelper.OrderItem
                {
                    OrderID = orderId,
                    VariantID = li.Variant.VariantID,
                    ProductName = li.Product.ProductName,
                    Size = li.Variant.Size,
                    Quantity = 1,
                    UnitPrice = li.Product.BasePrice,
                    LineTotal = li.Product.BasePrice,
                }).ToList();

                CsvHelper.AppendOrderItems(Paths.OrderItems, orderItems);
                CsvHelper.IncrementCustomersServed(Paths.Staff, SessionManager.CurrentUser.StaffID);

                GenerateReceiptPdf(order, orderitems);

                MessageBox.Show($"Order #{orderId} completed. Receipt saved.",
                                "Order Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearOrder();
                lblOrderNumber.Text = $"order #{GetNextOrderNumber()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save order:\n" + ex.Message,
                                "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateReceiptPdf(CsvHelper.Order order, List<OrderItem> items)
        {
            // placeholder for PDF
            string receiptsDir = Path.Combine(Application.StartupPath, "Receipts");
            Directory.CreateDirectory(receiptsDir);

            string filename = $"order_{order.OrderID}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string path = Path.Combine(receiptsDir, filename);

            var lines = new List<string>
            {
                "=================================",
                "         AMANE BOUTIQUE          ",
                "=================================",
                $"Order #{order.OrderID}",
                $"Date: {order.OrderDate:yyyy-MM-dd HH:mm}",
                $"Customer: {order.CustomerName}",
                $"Staff: {SessionManager.CurrentUser.FullName}",
                "---------------------------------",
            };

            foreach (var item in items)
            {
                lines.Add($"{item.ProductName} ({item.Size})");
                lines.Add($"   ${item.LineTotal:F2}");
            }

            lines.Add("---------------------------------");
            lines.Add($"Subtotal:  ${order.Subtotal:F2}");
            if (order.DiscountAmount > 0)
            {
                lines.Add($"Discount:  -${order.DiscountAmount:F2}  ({order.DiscountCode})");
            }
            lines.Add($"Tax (10%): ${order.TaxAmount:F2}");
            lines.Add($"TOTAL:     ${order.Total:F2}");
            lines.Add("=================================");
            lines.Add("       Thank you for shopping    ");
            lines.Add("=================================");

            File.WriteAllLines(path, lines);
        }

        // clearing the page
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (_lineItems.Count == 0) return;

            var result = MessageBox.Show("Clear all items from this order?",
                                          "Clear Order",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ClearOrder();
            }
        }

        private void ClearOrder()
        {
            foreach (var line in _lineItems)
            {
                line.Dispose();
            }
            _lineItems.Clear();
            flpOrderItems.Controls.Clear();

            txtCustomerName.Clear();
            txtDiscount.Clear();
            _discountRate = 0m;
            _discountCode = "";

            RefreshTotals();
        }
    }
}