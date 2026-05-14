using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using IT_Assessment_2.CSVs;
using IT_Assignment_2.Helpers;

namespace IT_Assessment_2.Forms
{
    public partial class InventoryForm : Form
    {
        private List<CsvHelper.Product> _products;
        private List<CsvHelper.Variant> _variants;

        public InventoryForm()
        {
            InitializeComponent();

            btnAddProduct.Click += BtnAddProduct_Click;
            txtSearch.TextChanged += TxtSearch_TextChanged;

            LoadData();
            PopulateGrid();
        }

        // =========================
        // LOAD DATA
        // =========================
        private void LoadData()
        {
            try
            {
                _products = CsvHelper.LoadProducts(Paths.Products);
                _variants = CsvHelper.LoadVariants(Paths.Variants);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load inventory:\n" + ex.Message,
                                "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _products = new List<CsvHelper.Product>();
                _variants = new List<CsvHelper.Variant>();
            }
        }

        // =========================
        // POPULATE THE GRID
        // =========================
        private void PopulateGrid()
        {
            PopulateGrid("");
        }

        private void PopulateGrid(string filter)
        {
            // dispose any existing cards before clearing
            foreach (Control c in flpProducts.Controls)
            {
                c.Dispose();
            }
            flpProducts.Controls.Clear();

            var filtered = string.IsNullOrWhiteSpace(filter)
                ? _products
                : _products.Where(p =>
                    p.ProductName.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.Brand.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            foreach (var product in filtered.OrderBy(p => p.ProductName))
            {
                var card = new ProductEditCardControl();
                var productVariants = _variants.Where(v => v.ProductID == product.ProductID).ToList();
                card.Bind(product, productVariants);
                card.EditRequested += Card_EditRequested;
                card.DeleteRequested += Card_DeleteRequested;
                flpProducts.Controls.Add(card);
            }

            lblCount.Text = $"{filtered.Count} product(s)";
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateGrid(txtSearch.Text);
        }

        // =========================
        // EDIT EXISTING
        // =========================
        private void Card_EditRequested(object sender, ProductActionEventArgs e)
        {
            using (var editForm = new EditProductForm(e.Product))
            {
                if (editForm.ShowDialog(this) == DialogResult.OK)
                {
                    // refresh — products and variants may have changed
                    LoadData();
                    PopulateGrid(txtSearch.Text);
                }
            }
        }

        // =========================
        // DELETE
        // =========================
        private void Card_DeleteRequested(object sender, ProductActionEventArgs e)
        {
            var result = MessageBox.Show(
                $"Delete \"{e.Product.ProductName}\"?\n\n" +
                "This will remove the product and all its sizes from inventory. " +
                "This cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            try
            {
                // delete variants first, then the product
                CsvHelper.DeleteVariantsForProduct(Paths.Variants, e.Product.ProductID);
                CsvHelper.DeleteProduct(Paths.Products, e.Product.ProductID);

                LoadData();
                PopulateGrid(txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete product:\n" + ex.Message,
                                "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================
        // ADD NEW
        // =========================
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            using (var editForm = new EditProductForm())   // null = new product
            {
                if (editForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                    PopulateGrid(txtSearch.Text);
                }
            }
        }
    }
}