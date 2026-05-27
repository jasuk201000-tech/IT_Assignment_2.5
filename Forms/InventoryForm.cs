using IT_Assessment_2.CSVs;
using IT_Assignment_2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static IT_Assessment_2.Models.Staff;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace IT_Assessment_2.Forms
{
    public partial class InventoryForm : Form
    {
        private List<CsvHelper.Product> _products;
        private List<CsvHelper.Variant> _variants;

        public InventoryForm()
        {
            InitializeComponent();
            ApplyRoleBasedAccess();

            this.WindowState = FormWindowState.Maximized; // sizing winform

            // wiring up additional buttons
            btnAddProduct.Click += BtnAddProduct_Click;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

            // calling additional methods for product grid
            LoadCatalog();
            PopulateGrid();

            //
            button1.Click += (s, e) => OpenChild(new DashboardForm1()); // logo nav to dashboard

           
            this.StartPosition = FormStartPosition.CenterScreen;

            // wiring up nav bar
            button6.Click += (s, e) => OpenChild(new DashboardForm1()); // dashboard 
            button7.Click += (s, e) => OpenChild(new InventoryForm());      // inventory
            button8.Click += (s, e) => OpenChild(new BuildOrderForm());     // orders / new order
            button9.Click += (s, e) => OpenChild(new ViewOrderForm());  // transactions / history
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException(); // didn't end up implementing
        }

        private void ApplyRoleBasedAccess()
        {
            if (SessionManager.CurrentUser == null) return;

            var role = SessionManager.CurrentUser.Role;
            bool isPrivileged = (role == UserRole.Admin || role == UserRole.Manager);

            if (isPrivileged)
            {
                button9.Visible = true;
            }
            else
            {
                button9.Visible = false;
            }
        }

        // loading data
        private void LoadCatalog()
        {
            try
            {
                // load products and variants from CSV
                _products = CsvHelper.LoadProducts(Paths.Products);
                _variants = CsvHelper.LoadVariants(Paths.Variants);
            }
            catch (Exception ex)
            {
                // if there's an error loading the data, show a message and initialize empty lists to avoid null reference issues
                MessageBox.Show("Could not load inventory:\n" + ex.Message,
                                "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _products = new List<CsvHelper.Product>();
                _variants = new List<CsvHelper.Variant>();
            }
        }

        private void OpenChild(Form child)
        {
            this.Hide();
            child.StartPosition = FormStartPosition.CenterScreen;
            child.FormClosed += (s, e) => this.Show();
            child.Show();
        }

        // populating data grid with null 
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
            // the filter being whether or not there is null or white space
            var filtered = string.IsNullOrWhiteSpace(filter)
                ? _products
                : _products.Where(p =>
                    p.ProductName.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0 || // compares each product name string with input value
                    p.Brand.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0).ToList(); // compares each brand name string with input value

            // adding filters for the inventory ordering
            foreach (var product in filtered.OrderBy(p => p.ProductName))
            {
                var card = new ProductEditCardControl();
                var productVariants = _variants.Where(v => v.ProductID == product.ProductID).ToList(); // binds the variant and product CSV to This LINQ filter selects only those variants whose ProductID matches the ProductID of the current product 
                card.Bind(product, productVariants); // bind the product and product variants 
                card.EditRequested += Card_EditRequested; // event handler
                card.DeleteRequested += Card_DeleteRequested; // event handler
                flpProducts.Controls.Add(card); // adding controls/ card panels to the catalog
            }

            lblCount.Text = $"{filtered.Count} product(s)"; // counts the number of 
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateGrid(txtSearch.Text);
        }

        // edit existing
        private void Card_EditRequested(object sender, ProductActionEventArgs e)
        {
            using (var editForm = new EditProductForm(e.Product)) // within the event it calls the form and passes the product that was clicked on to the form so it can populate the fields with the existing data
            {
                if (editForm.ShowDialog(this) == DialogResult.OK)
                {
                    // refresh — products and variants may have changed
                    LoadCatalog();
                    PopulateGrid(txtSearch.Text);
                }
            }
        }

        // deleting card
        private void Card_DeleteRequested(object sender, ProductActionEventArgs e) // deleting card event handler, passes the product that was attempted to be deleted so it can confirm the name in the confirmation dialog
        {
            // confirmation dialog
            var result = MessageBox.Show(
                $"Delete \"{e.Product.ProductName}\"?\n\n" +
                "This will remove the product and all its sizes from inventory. " +
                "This cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // if the user clicks "No", the method returns early and no deletion occurs. If "Yes" is clicked, the code proceeds to delete the product and its variants.
            if (result != DialogResult.Yes) return;

            try
            {
                // delete variants first, then the product
                CsvHelper.DeleteVariantsForProduct(Paths.Variants, e.Product.ProductID);
                CsvHelper.DeleteProduct(Paths.Products, e.Product.ProductID);

                LoadCatalog();
                PopulateGrid(txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete product:\n" + ex.Message,
                                "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // adding new product
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            using (var editForm = new EditProductForm())   // it will open the edit product form but without passing a product to it, so the form will know to treat it as a new product rather than an edit of an existing product
            {
                if (editForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadCatalog();
                    PopulateGrid(txtSearch.Text);
                }
            }
        }
    }
}