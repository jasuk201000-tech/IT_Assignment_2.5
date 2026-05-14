using IT_Assessment_2.CSVs;
using IT_Assessment_2.Models;
using IT_Assignment_2.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IT_Assessment_2.CSVs.CsvHelper;

namespace IT_Assessment_2.Forms
{
    public partial class ViewOrderForm : Form
    {
        public ViewOrderForm()
        {
            InitializeComponent();
            PopulateOrderGrid();
        }

        private void PopulateOrderGrid()
        {
            try
            {
                var orders = CsvHelper.LoadOrders(Paths.Orders);
                var orderitems = CsvHelper.LoadOrderItems(Paths.OrderItems);

                //OrderItemID,OrderID,VariantID,ProductName,Size,Quantity,UnitPrice,LineTotal
                //OrderID,OrderDate,StaffID,CustomerName,Subtotal,DiscountCode,DiscountAmount,TaxAmount,Total,PaymentMethod,Status
                var orderRows = orderitems
                    .Join(orders,
                          v => v.OrderID,
                          p => p.OrderID,
                          (v, p) => new
                          {
                              OrderID = p.OrderID,
                              OrderDate = p.OrderDate,
                              Total = p.Total,
                              PaymentMethod = p.PaymentMethod,
                              Status = p.Status,
                              
                          })
                    .OrderBy(r => r.OrderDate)
                    .ThenBy(r => r.Status)
                    .ToList();

                dataGridView1.DataSource = orders;
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
    }
}
