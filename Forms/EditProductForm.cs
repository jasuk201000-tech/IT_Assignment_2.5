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
        private List<CsvHelper.Variant> _variants; // cached list of variants
        private bool _isNewProduct; // boolean for the the form modes: editing product vs new product

        public EditProductForm(CsvHelper.Product productToEdit = null)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized; // sizing winform 

            _isNewProduct = (productToEdit == null);

            // setting default properties for when there _isNewProduct is true
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
            // the else statement utilises the CSV information for that specific variant from the variant CSV path
            else
            {
                _editingProduct = productToEdit;
                _variants = CsvHelper.LoadVariants(Paths.Variants)
                    .Where(v => v.ProductID == productToEdit.ProductID)
                    .ToList();
                this.Text = "Edit Product";
                lblTitle.Text = "edit product";
            }

            // method constructors
            PopulateCategoryDropdown();
            LoadFieldsFromProduct();
            RefreshVariantsGrid();

            // event handlers
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            btnAddVariant.Click += BtnAddVariant_Click;
            btnRemoveVariant.Click += BtnRemoveVariant_Click;

            // winform sizing
            var screen = Screen.PrimaryScreen.WorkingArea;
            if (this.Width > screen.Width) this.Width = screen.Width;
            if (this.Height > screen.Height) this.Height = screen.Height;

        }

        

        // category drop down
        private void PopulateCategoryDropdown()
        {
            cboCategory.Items.Clear();
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Id"; // collecting category IDs from CSV

            // harcoded combo box clauses, can be taken directly from the CSV but for safety I hardcoded them
            cboCategory.Items.Add(new CategoryItem(1, "Dresses"));
            cboCategory.Items.Add(new CategoryItem(2, "Tops"));
            cboCategory.Items.Add(new CategoryItem(3, "Bottoms"));
            cboCategory.Items.Add(new CategoryItem(4, "Outerwear"));
            cboCategory.Items.Add(new CategoryItem(5, "Accessories"));
            cboCategory.Items.Add(new CategoryItem(6, "Footwear"));
        }


        // defining csv values 
        private class CategoryItem
        {
            public int Id { get; }
            public string Name { get; }
            public CategoryItem(int id, string name) { Id = id; Name = name; }
            public override string ToString() => Name;
        }

        // loading and saving fields from product to the panel
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

        
        // input validation check, whether there is a null or below zero input (
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

            // trimming and saving to the product object
            _editingProduct.ProductName = txtName.Text.Trim();
            _editingProduct.Description = txtDescription.Text.Trim();
            _editingProduct.Brand = txtBrand.Text.Trim();
            _editingProduct.BasePrice = price;
            _editingProduct.CategoryID = ((CategoryItem)cboCategory.SelectedItem).Id;
            _editingProduct.Active = chkActive.Checked;

            return true;
        }

        // adding variants grid
        private void RefreshVariantsGrid()
        {
            // rebind the grid to show current variants list/ variant CSV information
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

        // adding a variant
        private void BtnAddVariant_Click(object sender, EventArgs e)
        {
            // validation by checking for null/whitespace and negative stock levels, also checking for duplicate sizes for the same product
            string size = txtNewSize.Text.Trim().ToUpperInvariant();
            if (string.IsNullOrWhiteSpace(size))
            {
                MessageBox.Show("Enter a size first.", "Add Variant",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // check for duplicate size for this product within the current list of variants (ignoring case)/ CSV
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

            // saving to csv

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

        //removing variant
        private void BtnRemoveVariant_Click(object sender, EventArgs e)
        {
            if (dgvVariants.SelectedRows.Count == 0) return; // returning if no selection is amde

            var row = dgvVariants.SelectedRows[0]; // setting initial selected row value
            int variantId = (int)row.Cells["VariantID"].Value; // getting the variant ID from the hidden column in the grid

            _variants.RemoveAll(v => v.VariantID == variantId); // removing the variant from the list based on the ID
            RefreshVariantsGrid();
        }

        // saving and cancelling methods
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!SaveFieldsToProduct()) return;

            if (_variants.Count == 0) // require at least one variant before saving
            {
                // error mesage if there are no variants added to the product, as a product must have at least one variant (size)
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
                this.Close(); // closes message box if successful
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save product: " + ex.Message,
                                "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // closes the form without saving changes, setting DialogResult to Cancel so the caller can know that it was cancelled
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}