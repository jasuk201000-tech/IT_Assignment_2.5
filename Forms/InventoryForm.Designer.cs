namespace IT_Assessment_2.Forms
{
    partial class InventoryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlNav = new System.Windows.Forms.Panel();
            this.LogoBtn = new System.Windows.Forms.Button();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlNav
            //
            this.pnlNav.BackColor = AmanePOSHelpers.AmaneStyling.NavBar;
            this.pnlNav.Controls.Add(this.LogoBtn);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(1400, 80);
            this.pnlNav.TabIndex = 0;
            //
            // LogoBtn
            //
            this.LogoBtn.BackColor = AmanePOSHelpers.AmaneStyling.NavBar;
            this.LogoBtn.FlatAppearance.BorderSize = 0;
            this.LogoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoBtn.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Italic);
            this.LogoBtn.ForeColor = AmanePOSHelpers.AmaneStyling.TextOnNav;
            this.LogoBtn.Location = new System.Drawing.Point(30, 18);
            this.LogoBtn.Name = "LogoBtn";
            this.LogoBtn.Size = new System.Drawing.Size(160, 50);
            this.LogoBtn.TabIndex = 0;
            this.LogoBtn.Text = "amane";
            this.LogoBtn.UseVisualStyleBackColor = false;
            //
            // lblPageTitle
            //
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Italic);
            this.lblPageTitle.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.lblPageTitle.Location = new System.Drawing.Point(40, 95);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(300, 40);
            this.lblPageTitle.TabIndex = 1;
            this.lblPageTitle.Text = "inventory";
            //
            // btnAddProduct
            //
            this.btnAddProduct.BackColor = AmanePOSHelpers.AmaneStyling.Accent;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Cambria", 11F);
            this.btnAddProduct.ForeColor = AmanePOSHelpers.AmaneStyling.ButtonText;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Location = new System.Drawing.Point(1200, 95);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(180, 45);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "+ add new product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            //
            // txtSearch
            //
            this.txtSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtSearch.ForeColor = AmanePOSHelpers.AmaneStyling.TextMuted;
            this.txtSearch.Location = new System.Drawing.Point(40, 160);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(600, 34);
            this.txtSearch.TabIndex = 3;
            //
            // lblCount
            //
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic);
            this.lblCount.ForeColor = AmanePOSHelpers.AmaneStyling.TextMuted;
            this.lblCount.Location = new System.Drawing.Point(665, 165);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(140, 28);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0 product(s)";
            //
            // flpProducts
            //
            this.flpProducts.AutoScroll = true;
            this.flpProducts.BackColor = System.Drawing.Color.White;
            this.flpProducts.Location = new System.Drawing.Point(40, 210);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(1340, 680);
            this.flpProducts.TabIndex = 5;
            //
            // InventoryForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AmanePOSHelpers.AmaneStyling.PageBg;
            this.ClientSize = new System.Drawing.Size(1400, 920);
            this.Controls.Add(this.flpProducts);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.pnlNav);
            this.Name = "InventoryForm";
            this.Text = "Amane - Inventory";
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button LogoBtn;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
    }
}