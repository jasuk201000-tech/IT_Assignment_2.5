namespace IT_Assessment_2.Forms
{
    partial class BuildOrderForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOrderSummary = new System.Windows.Forms.Panel();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblOrderItems = new System.Windows.Forms.Label();
            this.flpOrderItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSubtotalCaption = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscountCaption = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTaxCaption = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDiscountCode = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnApplyDiscount = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlOrderSummary.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Cambria", 7.85F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtSearch.Location = new System.Drawing.Point(40, 150);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(600, 32);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "search products to add...";
            // 
            // flpProducts
            // 
            this.flpProducts.AutoScroll = true;
            this.flpProducts.BackColor = System.Drawing.Color.White;
            this.flpProducts.Location = new System.Drawing.Point(40, 200);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(1307, 910);
            this.flpProducts.TabIndex = 3;
            // 
            // pnlOrderSummary
            // 
            this.pnlOrderSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.pnlOrderSummary.Controls.Add(this.lblOrderNumber);
            this.pnlOrderSummary.Controls.Add(this.lblCustomerName);
            this.pnlOrderSummary.Controls.Add(this.txtCustomerName);
            this.pnlOrderSummary.Controls.Add(this.lblOrderItems);
            this.pnlOrderSummary.Controls.Add(this.flpOrderItems);
            this.pnlOrderSummary.Controls.Add(this.lblSubtotalCaption);
            this.pnlOrderSummary.Controls.Add(this.lblSubtotal);
            this.pnlOrderSummary.Controls.Add(this.lblDiscountCaption);
            this.pnlOrderSummary.Controls.Add(this.lblDiscount);
            this.pnlOrderSummary.Controls.Add(this.lblTaxCaption);
            this.pnlOrderSummary.Controls.Add(this.lblTax);
            this.pnlOrderSummary.Controls.Add(this.lblTotalCaption);
            this.pnlOrderSummary.Controls.Add(this.lblTotal);
            this.pnlOrderSummary.Controls.Add(this.btnComplete);
            this.pnlOrderSummary.Controls.Add(this.btnClear);
            this.pnlOrderSummary.Controls.Add(this.lblDiscountCode);
            this.pnlOrderSummary.Controls.Add(this.txtDiscount);
            this.pnlOrderSummary.Controls.Add(this.btnApplyDiscount);
            this.pnlOrderSummary.Location = new System.Drawing.Point(1448, 150);
            this.pnlOrderSummary.Name = "pnlOrderSummary";
            this.pnlOrderSummary.Size = new System.Drawing.Size(656, 998);
            this.pnlOrderSummary.TabIndex = 4;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Cambria", 14F);
            this.lblOrderNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblOrderNumber.Location = new System.Drawing.Point(109, 26);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(226, 44);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "order #1001";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Cambria", 7F);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCustomerName.Location = new System.Drawing.Point(113, 88);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(135, 22);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "customer name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.White;
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCustomerName.Location = new System.Drawing.Point(117, 133);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(380, 39);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lblOrderItems
            // 
            this.lblOrderItems.AutoSize = true;
            this.lblOrderItems.Font = new System.Drawing.Font("Cambria", 9F);
            this.lblOrderItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblOrderItems.Location = new System.Drawing.Point(126, 188);
            this.lblOrderItems.Name = "lblOrderItems";
            this.lblOrderItems.Size = new System.Drawing.Size(122, 28);
            this.lblOrderItems.TabIndex = 3;
            this.lblOrderItems.Text = "order item";
            // 
            // flpOrderItems
            // 
            this.flpOrderItems.AutoScroll = true;
            this.flpOrderItems.BackColor = System.Drawing.Color.Transparent;
            this.flpOrderItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOrderItems.Location = new System.Drawing.Point(126, 218);
            this.flpOrderItems.Name = "flpOrderItems";
            this.flpOrderItems.Size = new System.Drawing.Size(380, 250);
            this.flpOrderItems.TabIndex = 4;
            this.flpOrderItems.WrapContents = false;
            // 
            // lblSubtotalCaption
            // 
            this.lblSubtotalCaption.AutoSize = true;
            this.lblSubtotalCaption.Font = new System.Drawing.Font("Cambria", 8.5F);
            this.lblSubtotalCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSubtotalCaption.Location = new System.Drawing.Point(126, 488);
            this.lblSubtotalCaption.Name = "lblSubtotalCaption";
            this.lblSubtotalCaption.Size = new System.Drawing.Size(93, 27);
            this.lblSubtotalCaption.TabIndex = 5;
            this.lblSubtotalCaption.Text = "subtotal";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSubtotal.Location = new System.Drawing.Point(386, 488);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(120, 30);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "$0.00";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountCaption
            // 
            this.lblDiscountCaption.AutoSize = true;
            this.lblDiscountCaption.Font = new System.Drawing.Font("Cambria", 8.5F);
            this.lblDiscountCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDiscountCaption.Location = new System.Drawing.Point(126, 523);
            this.lblDiscountCaption.Name = "lblDiscountCaption";
            this.lblDiscountCaption.Size = new System.Drawing.Size(97, 27);
            this.lblDiscountCaption.TabIndex = 7;
            this.lblDiscountCaption.Text = "discount";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDiscount.Location = new System.Drawing.Point(386, 523);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(120, 30);
            this.lblDiscount.TabIndex = 8;
            this.lblDiscount.Text = "-$0.00";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxCaption
            // 
            this.lblTaxCaption.AutoSize = true;
            this.lblTaxCaption.Font = new System.Drawing.Font("Cambria", 8.5F);
            this.lblTaxCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTaxCaption.Location = new System.Drawing.Point(126, 558);
            this.lblTaxCaption.Name = "lblTaxCaption";
            this.lblTaxCaption.Size = new System.Drawing.Size(111, 27);
            this.lblTaxCaption.TabIndex = 9;
            this.lblTaxCaption.Text = "tax (10%)";
            // 
            // lblTax
            // 
            this.lblTax.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTax.Location = new System.Drawing.Point(386, 558);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(120, 30);
            this.lblTax.TabIndex = 10;
            this.lblTax.Text = "$0.00";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblTotalCaption.Location = new System.Drawing.Point(126, 598);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(108, 44);
            this.lblTotalCaption.TabIndex = 11;
            this.lblTotalCaption.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblTotal.Location = new System.Drawing.Point(326, 598);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(180, 35);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnComplete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnComplete.Location = new System.Drawing.Point(126, 675);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(380, 45);
            this.btnComplete.TabIndex = 13;
            this.btnComplete.Text = "complete order";
            this.btnComplete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(198)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.Location = new System.Drawing.Point(126, 740);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(380, 45);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "clear order";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // lblDiscountCode
            // 
            this.lblDiscountCode.AutoSize = true;
            this.lblDiscountCode.Font = new System.Drawing.Font("Cambria", 9F);
            this.lblDiscountCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDiscountCode.Location = new System.Drawing.Point(129, 813);
            this.lblDiscountCode.Name = "lblDiscountCode";
            this.lblDiscountCode.Size = new System.Drawing.Size(154, 28);
            this.lblDiscountCode.TabIndex = 15;
            this.lblDiscountCode.Text = "discount code";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.White;
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtDiscount.Location = new System.Drawing.Point(126, 853);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(260, 39);
            this.txtDiscount.TabIndex = 16;
            // 
            // btnApplyDiscount
            // 
            this.btnApplyDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnApplyDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyDiscount.FlatAppearance.BorderSize = 0;
            this.btnApplyDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyDiscount.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnApplyDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnApplyDiscount.Location = new System.Drawing.Point(406, 853);
            this.btnApplyDiscount.Name = "btnApplyDiscount";
            this.btnApplyDiscount.Size = new System.Drawing.Size(140, 39);
            this.btnApplyDiscount.TabIndex = 17;
            this.btnApplyDiscount.Text = "apply";
            this.btnApplyDiscount.UseVisualStyleBackColor = false;
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
            this.panel3.Location = new System.Drawing.Point(2, -16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2142, 122);
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
            // BuildOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2129, 1176);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlOrderSummary);
            this.Controls.Add(this.flpProducts);
            this.Controls.Add(this.txtSearch);
            this.Name = "BuildOrderForm";
            this.Text = "Amane - Build Order";
            this.pnlOrderSummary.ResumeLayout(false);
            this.pnlOrderSummary.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.Panel pnlOrderSummary;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblOrderItems;
        private System.Windows.Forms.FlowLayoutPanel flpOrderItems;
        private System.Windows.Forms.Label lblSubtotalCaption;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscountCaption;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTaxCaption;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDiscountCode;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnApplyDiscount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}