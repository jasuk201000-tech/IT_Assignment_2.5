namespace IT_Assessment_2.Forms
{
    partial class EditProductForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lblVariants = new System.Windows.Forms.Label();
            this.dgvVariants = new System.Windows.Forms.DataGridView();
            this.lblAddSize = new System.Windows.Forms.Label();
            this.txtNewSize = new System.Windows.Forms.TextBox();
            this.lblAddStock = new System.Windows.Forms.Label();
            this.txtNewStock = new System.Windows.Forms.TextBox();
            this.btnAddVariant = new System.Windows.Forms.Button();
            this.btnRemoveVariant = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariants)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 15F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "edit product";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblName.Location = new System.Drawing.Point(30, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(174, 32);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "product name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtName.Location = new System.Drawing.Point(30, 115);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(440, 39);
            this.txtName.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblPrice.Location = new System.Drawing.Point(30, 165);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(113, 32);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "price ($)";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPrice.Location = new System.Drawing.Point(30, 200);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 39);
            this.txtPrice.TabIndex = 4;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblBrand.Location = new System.Drawing.Point(270, 165);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(83, 32);
            this.lblBrand.TabIndex = 5;
            this.lblBrand.Text = "brand";
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.Color.White;
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrand.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBrand.Location = new System.Drawing.Point(270, 200);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(200, 39);
            this.txtBrand.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblCategory.Location = new System.Drawing.Point(30, 250);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(113, 32);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "category";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Cambria", 10F);
            this.cboCategory.Location = new System.Drawing.Point(30, 285);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(200, 40);
            this.cboCategory.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblDescription.Location = new System.Drawing.Point(30, 335);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(146, 32);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtDescription.Location = new System.Drawing.Point(30, 370);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(440, 70);
            this.txtDescription.TabIndex = 11;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Font = new System.Drawing.Font("Cambria", 10F);
            this.chkActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.chkActive.Location = new System.Drawing.Point(270, 287);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(113, 36);
            this.chkActive.TabIndex = 9;
            this.chkActive.Text = "active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // lblVariants
            // 
            this.lblVariants.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblVariants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblVariants.Location = new System.Drawing.Point(30, 460);
            this.lblVariants.Name = "lblVariants";
            this.lblVariants.Size = new System.Drawing.Size(200, 35);
            this.lblVariants.TabIndex = 12;
            this.lblVariants.Text = "sizes and stock";
            // 
            // dgvVariants
            // 
            this.dgvVariants.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.dgvVariants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVariants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariants.Location = new System.Drawing.Point(30, 505);
            this.dgvVariants.Name = "dgvVariants";
            this.dgvVariants.RowHeadersWidth = 50;
            this.dgvVariants.Size = new System.Drawing.Size(440, 180);
            this.dgvVariants.TabIndex = 13;
            // 
            // lblAddSize
            // 
            this.lblAddSize.AutoSize = true;
            this.lblAddSize.Font = new System.Drawing.Font("Cambria", 9F);
            this.lblAddSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblAddSize.Location = new System.Drawing.Point(30, 700);
            this.lblAddSize.Name = "lblAddSize";
            this.lblAddSize.Size = new System.Drawing.Size(52, 28);
            this.lblAddSize.TabIndex = 14;
            this.lblAddSize.Text = "size";
            // 
            // txtNewSize
            // 
            this.txtNewSize.BackColor = System.Drawing.Color.White;
            this.txtNewSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewSize.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtNewSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtNewSize.Location = new System.Drawing.Point(30, 730);
            this.txtNewSize.Name = "txtNewSize";
            this.txtNewSize.Size = new System.Drawing.Size(80, 39);
            this.txtNewSize.TabIndex = 15;
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Font = new System.Drawing.Font("Cambria", 9F);
            this.lblAddStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblAddStock.Location = new System.Drawing.Point(125, 700);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(67, 28);
            this.lblAddStock.TabIndex = 16;
            this.lblAddStock.Text = "stock";
            // 
            // txtNewStock
            // 
            this.txtNewStock.BackColor = System.Drawing.Color.White;
            this.txtNewStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewStock.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtNewStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtNewStock.Location = new System.Drawing.Point(125, 730);
            this.txtNewStock.Name = "txtNewStock";
            this.txtNewStock.Size = new System.Drawing.Size(80, 39);
            this.txtNewStock.TabIndex = 17;
            // 
            // btnAddVariant
            // 
            this.btnAddVariant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(198)))));
            this.btnAddVariant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddVariant.FlatAppearance.BorderSize = 0;
            this.btnAddVariant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVariant.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnAddVariant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAddVariant.Location = new System.Drawing.Point(220, 730);
            this.btnAddVariant.Name = "btnAddVariant";
            this.btnAddVariant.Size = new System.Drawing.Size(115, 34);
            this.btnAddVariant.TabIndex = 18;
            this.btnAddVariant.Text = "+ add size";
            this.btnAddVariant.UseVisualStyleBackColor = false;
            // 
            // btnRemoveVariant
            // 
            this.btnRemoveVariant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnRemoveVariant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveVariant.FlatAppearance.BorderSize = 0;
            this.btnRemoveVariant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveVariant.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnRemoveVariant.ForeColor = System.Drawing.Color.White;
            this.btnRemoveVariant.Location = new System.Drawing.Point(345, 730);
            this.btnRemoveVariant.Name = "btnRemoveVariant";
            this.btnRemoveVariant.Size = new System.Drawing.Size(125, 34);
            this.btnRemoveVariant.TabIndex = 19;
            this.btnRemoveVariant.Text = "remove selected";
            this.btnRemoveVariant.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 11F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.Location = new System.Drawing.Point(76, 801);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 42);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(198)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 11F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancel.Location = new System.Drawing.Point(253, 801);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 42);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(510, 855);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemoveVariant);
            this.Controls.Add(this.btnAddVariant);
            this.Controls.Add(this.txtNewStock);
            this.Controls.Add(this.lblAddStock);
            this.Controls.Add(this.txtNewSize);
            this.Controls.Add(this.lblAddSize);
            this.Controls.Add(this.dgvVariants);
            this.Controls.Add(this.lblVariants);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label lblVariants;
        private System.Windows.Forms.DataGridView dgvVariants;
        private System.Windows.Forms.Label lblAddSize;
        private System.Windows.Forms.TextBox txtNewSize;
        private System.Windows.Forms.Label lblAddStock;
        private System.Windows.Forms.TextBox txtNewStock;
        private System.Windows.Forms.Button btnAddVariant;
        private System.Windows.Forms.Button btnRemoveVariant;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}