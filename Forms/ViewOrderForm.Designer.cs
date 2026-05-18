namespace IT_Assessment_2.Forms
{
    partial class ViewOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrderForm));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblOrderHeader = new System.Windows.Forms.Label();
            this.lblOrderMeta = new System.Windows.Forms.Label();
            this.lblLineItems = new System.Windows.Forms.Label();
            this.dgvLineItems = new System.Windows.Forms.DataGridView();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtSearch.Location = new System.Drawing.Point(40, 137);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(500, 39);
            this.txtSearch.TabIndex = 2;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Cambria", 9F);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblCount.Location = new System.Drawing.Point(568, 148);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(116, 28);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0 order(s)";
            // 
            // dgvOrders
            // 
            this.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(40, 200);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowHeadersWidth = 82;
            this.dgvOrders.RowTemplate.Height = 33;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(1363, 782);
            this.dgvOrders.TabIndex = 4;
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.pnlDetail.Controls.Add(this.lblOrderHeader);
            this.pnlDetail.Controls.Add(this.lblOrderMeta);
            this.pnlDetail.Controls.Add(this.lblLineItems);
            this.pnlDetail.Controls.Add(this.dgvLineItems);
            this.pnlDetail.Controls.Add(this.lblSubtotal);
            this.pnlDetail.Controls.Add(this.lblDiscount);
            this.pnlDetail.Controls.Add(this.lblTax);
            this.pnlDetail.Controls.Add(this.lblTotal);
            this.pnlDetail.Location = new System.Drawing.Point(1484, 137);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(568, 845);
            this.pnlDetail.TabIndex = 5;
            // 
            // lblOrderHeader
            // 
            this.lblOrderHeader.Font = new System.Drawing.Font("Cambria", 14F);
            this.lblOrderHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblOrderHeader.Location = new System.Drawing.Point(20, 25);
            this.lblOrderHeader.Name = "lblOrderHeader";
            this.lblOrderHeader.Size = new System.Drawing.Size(380, 40);
            this.lblOrderHeader.TabIndex = 0;
            this.lblOrderHeader.Text = "select an order";
            // 
            // lblOrderMeta
            // 
            this.lblOrderMeta.Font = new System.Drawing.Font("Cambria", 9F);
            this.lblOrderMeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblOrderMeta.Location = new System.Drawing.Point(20, 65);
            this.lblOrderMeta.Name = "lblOrderMeta";
            this.lblOrderMeta.Size = new System.Drawing.Size(380, 28);
            this.lblOrderMeta.TabIndex = 1;
            // 
            // lblLineItems
            // 
            this.lblLineItems.AutoSize = true;
            this.lblLineItems.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblLineItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblLineItems.Location = new System.Drawing.Point(20, 105);
            this.lblLineItems.Name = "lblLineItems";
            this.lblLineItems.Size = new System.Drawing.Size(78, 32);
            this.lblLineItems.TabIndex = 2;
            this.lblLineItems.Text = "items";
            // 
            // dgvLineItems
            // 
            this.dgvLineItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.dgvLineItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLineItems.Location = new System.Drawing.Point(20, 140);
            this.dgvLineItems.Name = "dgvLineItems";
            this.dgvLineItems.ReadOnly = true;
            this.dgvLineItems.RowHeadersVisible = false;
            this.dgvLineItems.RowHeadersWidth = 82;
            this.dgvLineItems.Size = new System.Drawing.Size(519, 480);
            this.dgvLineItems.TabIndex = 3;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSubtotal.Location = new System.Drawing.Point(20, 555);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(380, 30);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDiscount.Location = new System.Drawing.Point(20, 590);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(380, 30);
            this.lblDiscount.TabIndex = 5;
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTax.Location = new System.Drawing.Point(20, 625);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(380, 30);
            this.lblTax.TabIndex = 6;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblTotal.Location = new System.Drawing.Point(20, 670);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(380, 40);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1000, 105);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(269, 71);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-42, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2170, 110);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-6, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2132, 120);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(-10, -7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2186, 97);
            this.panel3.TabIndex = 6;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Cambria", 10F);
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button9.Location = new System.Drawing.Point(1749, 45);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(185, 41);
            this.button9.TabIndex = 11;
            this.button9.Text = "reports";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Cambria", 10F);
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button8.Location = new System.Drawing.Point(1547, 45);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(185, 41);
            this.button8.TabIndex = 10;
            this.button8.Text = "transactions";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Cambria", 10F);
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button7.Location = new System.Drawing.Point(1345, 45);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(185, 41);
            this.button7.TabIndex = 9;
            this.button7.Text = "orders";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Cambria", 10F);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button6.Location = new System.Drawing.Point(1142, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(185, 41);
            this.button6.TabIndex = 8;
            this.button6.Text = "inventory";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Cambria", 10F);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button5.Location = new System.Drawing.Point(937, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 41);
            this.button5.TabIndex = 7;
            this.button5.Text = "dashboard";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.Location = new System.Drawing.Point(39, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 74);
            this.button1.TabIndex = 6;
            this.button1.Text = "𝖆𝖒𝖆𝖓𝖊";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ViewOrderForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2108, 1077);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtSearch);
            this.Name = "ViewOrderForm";
            this.Text = "Amane - Orders History";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblOrderHeader;
        private System.Windows.Forms.Label lblOrderMeta;
        private System.Windows.Forms.Label lblLineItems;
        private System.Windows.Forms.DataGridView dgvLineItems;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}