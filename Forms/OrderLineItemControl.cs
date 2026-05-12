using System;
using System.Windows.Forms;
using IT_Assessment_2.CSVs;

namespace IT_Assessment_2.Forms
{
    public partial class OrderLineItemControl : UserControl
    {
        public event EventHandler<RemoveLineItemEventArgs> RemoveRequested;

        public CsvHelper.Product Product { get; private set; }
        public CsvHelper.Variant Variant { get; private set; }
        public decimal LineTotal => Product?.BasePrice ?? 0m;

        public OrderLineItemControl()
        {
            InitializeComponent();
            btnRemove.Click += BtnRemove_Click;
        }

        public void Bind(CsvHelper.Product product, CsvHelper.Variant variant)
        {
            Product = product;
            Variant = variant;

            lblName.Text = product.ProductName;
            lblSize.Text = $"size: {variant.Size.ToLower()}";
            lblPrice.Text = $"${product.BasePrice:F2}";
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            RemoveRequested?.Invoke(this, new RemoveLineItemEventArgs
            {
                LineItem = this
            });
        }
    }

    public class RemoveLineItemEventArgs : EventArgs
    {
        public OrderLineItemControl LineItem { get; set; }
    }
}