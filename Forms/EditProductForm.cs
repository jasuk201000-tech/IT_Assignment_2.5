using IT_Assessment_2.CSVs;
using IT_Assignment_2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IT_Assessment_2.Forms
{
    public partial class EditProductForm : Form
    {
        // null = adding a new product, otherwise = editing this one
        private CsvHelper.Product _editingProduct;
        private List<CsvHelper.Variant> _variants;
        private bool _isNewProduct;

        public EditProductForm(CsvHelper.Product productToEdit = null)
        {
            InitializeComponent();

            _isNewProduct = (productToEdit == null);

            if (_isNewProduct)
            {
                _editingProduct = new CsvHelper.Product
                {
                    ProductName = "",
                    CategoryID = 1,
                    Description = "",
                    BasePrice = 0m,
                    Brand = "Amane",
                    ImagePath = "",
                    Active = true,
                    DateAdded = DateTime.Today,
                };
                _variants = new List<CsvHelper.Variant>();
                this.Text = "Add Product";
                lblTitle.Text = "add new product";
            }
            else
            {
                _editingProduct = productToEdit;
                _variants = CsvHelper.LoadVariants(Paths.Variants)
                    .Where(v => v.ProductID == productToEdit.ProductID)
                    .ToList();
                this.Text = "Edit Product";
                lblTitle.Text = "edit product";
            }

            PopulateCategoryDropdown();
            LoadFieldsFromProduct();
            RefreshVariantsGrid();

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            btnAddVariant.Click += BtnAddVariant_Click;
            btnRemoveVariant.Click += BtnRemoveVariant_Click;
        }

        // =========================
        // CATEGORY DROPDOWN
        // =========================
        private void PopulateCategoryDropdown()
        {
            cboCategory.Items.Clear();
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Id";

            // load from categories.csv if you'd like, but hardcoded is fine for now
            cboCategory.Items.Add(new CategoryItem(1, "Dresses"));
            cboCategory.Items.Add(new CategoryItem(2, "Tops"));
            cboCategory.Items.Add(new CategoryItem(3, "Bottoms"));
            cboCategory.Items.Add(new CategoryItem(4, "Outerwear"));
            cboCategory.Items.Add(new CategoryItem(5, "Accessories"));
            cboCategory.Items.Add(new CategoryItem(6, "Footwear"));
        }

        private class CategoryItem
        {
            public int Id { get; }
            public string Name { get; }
            public CategoryItem(int id, string name) { Id = id; Name = name; }
            public override string ToString() => Name;
        }

        // =========================
        // LOAD / SAVE FIELDS
        // =========================
        private void LoadFieldsFromProduct()
        {
            txtName.Text = _editingProduct.ProductName;
            txtDescription.Text = _editingProduct.Description;
            txtBrand.Text = _editingProduct.Brand;
            txtPrice.Text = _editingProduct.BasePrice.ToString("F2");
            chkActive.Checked = _editingProduct.Active;

            // select matching category
            for (int i = 0; i < cboCategory.Items.Count; i++)
            {
                var cat = (CategoryItem)cboCategory.Items[i];
                if (cat.Id == _editingProduct.CategoryID)
                {
                    cboCategory.SelectedIndex = i;
                    break;
                }
            }
        }

        private bool SaveFieldsToProduct()
        {
            // validation
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Product name is required.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Price must be a positive number.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            if (cboCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _editingProduct.ProductName = txtName.Text.Trim();
            _editingProduct.Description = txtDescription.Text.Trim();
            _editingProduct.Brand = txtBrand.Text.Trim();
            _editingProduct.BasePrice = price;
            _editingProduct.CategoryID = ((CategoryItem)cboCategory.SelectedItem).Id;
            _editingProduct.Active = chkActive.Checked;

            return true;
        }

        // =========================
        // VARIANTS GRID
        // =========================
        private void RefreshVariantsGrid()
        {
            dgvVariants.DataSource = null;
            dgvVariants.DataSource = _variants.Select(v => new
            {
                v.VariantID,
                v.Size,
                v.SKU,
                v.StockLevel,
                v.ReorderLevel,
            }).ToList();

            if (dgvVariants.Columns.Count > 0)
            {
                dgvVariants.Columns["VariantID"].Visible = false;
                dgvVariants.Columns["StockLevel"].HeaderText = "Stock";
                dgvVariants.Columns["ReorderLevel"].HeaderText = "Reorder At";
            }
        }

        private void BtnAddVariant_Click(object sender, EventArgs e)
        {
            string size = txtNewSize.Text.Trim().ToUpperInvariant();
            if (string.IsNullOrWhiteSpace(size))
            {
                MessageBox.Show("Enter a size first.", "Add Variant",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_variants.Any(v => v.Size == size))
            {
                MessageBox.Show($"Size {size} already exists for this product.",
                                "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtNewStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Stock must be a non-negative number.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _variants.Add(new CsvHelper.Variant
            {
                VariantID = 0,   // assigned on save
                ProductID = _editingProduct.ProductID,
                Size = size,
                Color = "",
                SKU = $"AM-NEW-{size}",
                StockLevel = stock,
                ReorderLevel = 3,
            });

            txtNewSize.Clear();
            txtNewStock.Clear();
            RefreshVariantsGrid();
        }

        private void BtnRemoveVariant_Click(object sender, EventArgs e)
        {
            if (dgvVariants.SelectedRows.Count == 0) return;

            var row = dgvVariants.SelectedRows[0];
            int variantId = (int)row.Cells["VariantID"].Value;

            _variants.RemoveAll(v => v.VariantID == variantId);
            RefreshVariantsGrid();
        }

        // =========================
        // SAVE & CANCEL
        // =========================
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!SaveFieldsToProduct()) return;

            if (_variants.Count == 0)
            {
                MessageBox.Show("Add at least one variant (size) before saving.",
                                "No Variants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_isNewProduct)
                {
                    // append product, get new ID, then append variants
                    int newProductId = CsvHelper.AppendProduct(Paths.Products, _editingProduct);

                    foreach (var v in _variants)
                    {
                        v.ProductID = newProductId;
                        CsvHelper.AppendVariant(Paths.Variants, v);
                    }
                }
                else
                {
                    // update existing product
                    CsvHelper.UpdateProduct(Paths.Products, _editingProduct);

                    // replace this product's variants entirely:
                    // delete all old ones, append the current list
                    CsvHelper.DeleteVariantsForProduct(Paths.Variants, _editingProduct.ProductID);
                    foreach (var v in _variants)
                    {
                        v.VariantID = 0;   // re-assign on append
                        v.ProductID = _editingProduct.ProductID;
                        CsvHelper.AppendVariant(Paths.Variants, v);
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save product: " + ex.Message,
                                "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}