using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using IT_Assessment_2.CSVs;

namespace IT_Assessment_2.Forms
{
    public partial class ProductCardControl : UserControl
    {
        public event EventHandler<AddProductEventArgs> AddRequested;

        private CsvHelper.Product _product;
        private List<CsvHelper.Variant> _variantsForProduct;

        public ProductCardControl()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;
            cboSize.SelectedIndexChanged += CboSize_SelectedIndexChanged;
        }

        public void Bind(CsvHelper.Product product, List<CsvHelper.Variant> variants)
        {
            _product = product;
            _variantsForProduct = variants;

            lblName.Text = product.ProductName.ToLower();
            lblPrice.Text = $"${product.BasePrice:F2}";

            cboSize.Items.Clear();
            foreach (var v in variants)
            {
                cboSize.Items.Add(v.Size);
            }

            if (cboSize.Items.Count > 0)
            {
                cboSize.SelectedIndex = 0;
            }

            UpdateAddButtonState();
        }

        private void CboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }

        private void UpdateAddButtonState()
        {
            var selectedVariant = GetSelectedVariant();

            if (selectedVariant == null)
            {
                btnAdd.Enabled = false;
                btnAdd.Text = "+ add";
                return;
            }

            if (selectedVariant.IsOutOfStock)
            {
                btnAdd.Enabled = false;
                btnAdd.Text = "out of stock";
            }
            else
            {
                btnAdd.Enabled = true;
                btnAdd.Text = "+ add";
            }
        }

        private CsvHelper.Variant GetSelectedVariant()
        {
            if (cboSize.SelectedItem == null) return null;
            string size = cboSize.SelectedItem.ToString();
            return _variantsForProduct.FirstOrDefault(v => v.Size == size);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var variant = GetSelectedVariant();
            if (variant == null) return;

            AddRequested?.Invoke(this, new AddProductEventArgs
            {
                Product = _product,
                Variant = variant,
            });
        }
    }

    public class AddProductEventArgs : EventArgs
    {
        public CsvHelper.Product Product { get; set; }
        public CsvHelper.Variant Variant { get; set; }
    }
}