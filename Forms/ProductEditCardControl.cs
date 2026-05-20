using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using IT_Assessment_2.CSVs;

namespace IT_Assessment_2.Forms
{
    public partial class ProductEditCardControl : UserControl
    {
        // events the parent listens to
        public event EventHandler<ProductActionEventArgs> EditRequested;
        public event EventHandler<ProductActionEventArgs> DeleteRequested;

        // remember which product this card represents
        public CsvHelper.Product Product { get; private set; }
        public List<CsvHelper.Variant> Variants { get; private set; }

        public ProductEditCardControl()
        {
            InitializeComponent();
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        
        public void Bind(CsvHelper.Product product, List<CsvHelper.Variant> variants)
        {
            Product = product;
            Variants = variants;

            lblName.Text = product.ProductName.ToLower();
            lblPrice.Text = $"${product.BasePrice:F2}";

            // show total stock across all variants
            int totalStock = variants.Sum(v => v.StockLevel);
            int variantCount = variants.Count;
            lblStock.Text = $"{totalStock} in stock ({variantCount} sizes)";

            // colour-code low/out-of-stock so admin can scan at a glance
            if (totalStock == 0)
            {
                lblStock.ForeColor = AmanePOSHelpers.AmaneStyling.Danger;
            }
            else if (variants.Any(v => v.IsLowStock))
            {
                lblStock.ForeColor = AmanePOSHelpers.AmaneStyling.Warning;
            }
            else
            {
                lblStock.ForeColor = AmanePOSHelpers.AmaneStyling.TextMuted;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditRequested?.Invoke(this, new ProductActionEventArgs { Product = Product });
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteRequested?.Invoke(this, new ProductActionEventArgs { Product = Product });
        }
    }

    public class ProductActionEventArgs : EventArgs
    {
        public CsvHelper.Product Product { get; set; }
    }
}