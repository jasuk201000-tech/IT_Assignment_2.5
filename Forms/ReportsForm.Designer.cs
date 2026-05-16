namespace IT_Assessment_2.Forms
{
    partial class ReportsForm
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnPresetToday = new System.Windows.Forms.Button();
            this.btnPresetWeek = new System.Windows.Forms.Button();
            this.btnPresetMonth = new System.Windows.Forms.Button();
            this.btnPresetAll = new System.Windows.Forms.Button();
            this.lblRangeInfo = new System.Windows.Forms.Label();
            this.lblSalesSection = new System.Windows.Forms.Label();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueCaption = new System.Windows.Forms.Label();
            this.lblRevenueValue = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblOrdersCaption = new System.Windows.Forms.Label();
            this.lblOrdersValue = new System.Windows.Forms.Label();
            this.pnlAvg = new System.Windows.Forms.Panel();
            this.lblAvgCaption = new System.Windows.Forms.Label();
            this.lblAvgValue = new System.Windows.Forms.Label();
            this.pnlUnits = new System.Windows.Forms.Panel();
            this.lblUnitsCaption = new System.Windows.Forms.Label();
            this.lblUnitsValue = new System.Windows.Forms.Label();
            this.lblProductsSection = new System.Windows.Forms.Label();
            this.dgvTopProducts = new System.Windows.Forms.DataGridView();
            this.lblStaffSection = new System.Windows.Forms.Label();
            this.dgvStaffPerformance = new System.Windows.Forms.DataGridView();
            this.pnlNav.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlAvg.SuspendLayout();
            this.pnlUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffPerformance)).BeginInit();
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
            this.lblPageTitle.Size = new System.Drawing.Size(150, 40);
            this.lblPageTitle.TabIndex = 1;
            this.lblPageTitle.Text = "reports";
            //
            // lblFrom
            //
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Cambria", 9F);
            this.lblFrom.ForeColor = AmanePOSHelpers.AmaneStyling.TextMuted;
            this.lblFrom.Location = new System.Drawing.Point(40, 155);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(50, 28);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "from";
            //
            // dtpFrom
            //
            this.dtpFrom.CalendarFont = new System.Drawing.Font("Cambria", 9F);
            this.dtpFrom.Font = new System.Drawing.Font("Cambria", 10F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.CustomFormat = "dd MMM yyyy";
            this.dtpFrom.Location = new System.Drawing.Point(40, 185);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(180, 33);
            this.dtpFrom.TabIndex = 3;
            //
            // lblTo
            //
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Cambria", 9F);
            this.lblTo.ForeColor = AmanePOSHelpers.AmaneStyling.TextMuted;
            this.lblTo.Location = new System.Drawing.Point(240, 155);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(30, 28);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "to";
            //
            // dtpTo
            //
            this.dtpTo.CalendarFont = new System.Drawing.Font("Cambria", 9F);
            this.dtpTo.Font = new System.Drawing.Font("Cambria", 10F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.CustomFormat = "dd MMM yyyy";
            this.dtpTo.Location = new System.Drawing.Point(240, 185);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(180, 33);
            this.dtpTo.TabIndex = 5;
            //
            // btnApply
            //
            this.btnApply.BackColor = AmanePOSHelpers.AmaneStyling.Accent;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnApply.ForeColor = AmanePOSHelpers.AmaneStyling.ButtonText;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Location = new System.Drawing.Point(440, 184);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 35);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "apply";
            this.btnApply.UseVisualStyleBackColor = false;
            //
            // btnPresetToday
            //
            this.btnPresetToday.BackColor = AmanePOSHelpers.AmaneStyling.AccentLight;
            this.btnPresetToday.FlatAppearance.BorderSize = 0;
            this.btnPresetToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresetToday.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnPresetToday.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.btnPresetToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresetToday.Location = new System.Drawing.Point(580, 184);
            this.btnPresetToday.Name = "btnPresetToday";
            this.btnPresetToday.Size = new System.Drawing.Size(85, 35);
            this.btnPresetToday.TabIndex = 7;
            this.btnPresetToday.Text = "today";
            this.btnPresetToday.UseVisualStyleBackColor = false;
            //
            // btnPresetWeek
            //
            this.btnPresetWeek.BackColor = AmanePOSHelpers.AmaneStyling.AccentLight;
            this.btnPresetWeek.FlatAppearance.BorderSize = 0;
            this.btnPresetWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresetWeek.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnPresetWeek.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.btnPresetWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresetWeek.Location = new System.Drawing.Point(675, 184);
            this.btnPresetWeek.Name = "btnPresetWeek";
            this.btnPresetWeek.Size = new System.Drawing.Size(85, 35);
            this.btnPresetWeek.TabIndex = 8;
            this.btnPresetWeek.Text = "7 days";
            this.btnPresetWeek.UseVisualStyleBackColor = false;
            //
            // btnPresetMonth
            //
            this.btnPresetMonth.BackColor = AmanePOSHelpers.AmaneStyling.AccentLight;
            this.btnPresetMonth.FlatAppearance.BorderSize = 0;
            this.btnPresetMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresetMonth.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnPresetMonth.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.btnPresetMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresetMonth.Location = new System.Drawing.Point(770, 184);
            this.btnPresetMonth.Name = "btnPresetMonth";
            this.btnPresetMonth.Size = new System.Drawing.Size(85, 35);
            this.btnPresetMonth.TabIndex = 9;
            this.btnPresetMonth.Text = "30 days";
            this.btnPresetMonth.UseVisualStyleBackColor = false;
            //
            // btnPresetAll
            //
            this.btnPresetAll.BackColor = AmanePOSHelpers.AmaneStyling.AccentLight;
            this.btnPresetAll.FlatAppearance.BorderSize = 0;
            this.btnPresetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresetAll.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnPresetAll.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.btnPresetAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresetAll.Location = new System.Drawing.Point(865, 184);
            this.btnPresetAll.Name = "btnPresetAll";
            this.btnPresetAll.Size = new System.Drawing.Size(85, 35);
            this.btnPresetAll.TabIndex = 10;
            this.btnPresetAll.Text = "all time";
            this.btnPresetAll.UseVisualStyleBackColor = false;
            //
            // lblRangeInfo
            //
            this.lblRangeInfo.AutoSize = true;
            this.lblRangeInfo.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic);
            this.lblRangeInfo.ForeColor = AmanePOSHelpers.AmaneStyling.TextMuted;
            this.lblRangeInfo.Location = new System.Drawing.Point(40, 230);
            this.lblRangeInfo.Name = "lblRangeInfo";
            this.lblRangeInfo.Size = new System.Drawing.Size(400, 28);
            this.lblRangeInfo.TabIndex = 11;
            this.lblRangeInfo.Text = "";
            //
            // lblSalesSection
            //
            this.lblSalesSection.Font = new System.Drawing.Font("Cambria", 13F);
            this.lblSalesSection.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.lblSalesSection.Location = new System.Drawing.Point(40, 280);
            this.lblSalesSection.Name = "lblSalesSection";
            this.lblSalesSection.Size = new System.Drawing.Size(300, 35);
            this.lblSalesSection.TabIndex = 12;
            this.lblSalesSection.Text = "sales summary";
            //
            // pnlRevenue
            //
            this.pnlRevenue.BackColor = AmanePOSHelpers.AmaneStyling.CardBg;
            this.pnlRevenue.Controls.Add(this.lblRevenueCaption);
            this.pnlRevenue.Controls.Add(this.lblRevenueValue);
            this.pnlRevenue.Location = new System.Drawing.Point(40, 325);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(280, 130);
            this.pnlRevenue.TabIndex = 13;
            //
            // lblRevenueCaption
            //
            this.lblRevenueCaption.AutoSize = true;
            this.lblRevenueCaption.Font = new System.Drawing.Font("Cambria", 11F);
            this.lblRevenueCaption.ForeColor = AmanePOSHelpers.AmaneStyling.TextMuted;
            this.lblRevenueCaption.Location = new System.Drawing.Point(20, 18);
            this.lblRevenueCaption.Name = "lblRevenueCaption";
            this.lblRevenueCaption.Size = new System.Drawing.Size(150, 30);
            this.lblRevenueCaption.TabIndex = 0;
            this.lblRevenueCaption.Text = "total revenue";
            //
            // lblRevenueValue
            //
            this.lblRevenueValue.Font = new System.Drawing.Font("Cambria", 22F);
            this.lblRevenueValue.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.lblRevenueValue.Location = new System.Drawing.Point(20, 55);
            this.lblRevenueValue.Name = "lblRevenueValue";
            this.lblRevenueValue.Size = new System.Drawing.Size(240, 55);
            this.lblRevenueValue.TabIndex = 1;
            this.lblRevenueValue.Text = "$0.00";
            //
            // pnlOrders
            //
            this.pnlOrders.BackColor = AmanePOSHelpers.AmaneStyling.CardBg;
            this.pnlOrders.Controls.Add(this.lblOrdersCaption);
            this.pnlOrders.Controls.Add(this.lblOrdersValue);
            this.pnlOrders.Location = new System.Drawing.Point(340, 325);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(280, 130);
            this.pnlOrders.TabIndex = 14;
            //
            // lblOrdersCaption
            //
            this.lblOrdersCaption.AutoSize = true;
            this.lblOrdersCaption.Font = new System.Drawing.Font("Cambria", 11F);
            this.lblOrdersCaption.ForeColor = AmanePOSHelpers.AmaneStyling.TextMuted;
            this.lblOrdersCaption.Location = new System.Drawing.Point(20, 18);
            this.lblOrdersCaption.Name = "lblOrdersCaption";
            this.lblOrdersCaption.Size = new System.Drawing.Size(80, 30);
            this.lblOrdersCaption.TabIndex = 0;
            this.lblOrdersCaption.Text = "orders";
            //
            // lblOrdersValue
            //
            this.lblOrdersValue.Font = new System.Drawing.Font("Cambria", 22F);
            this.lblOrdersValue.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.lblOrdersValue.Location = new System.Drawing.Point(20, 55);
            this.lblOrdersValue.Name = "lblOrdersValue";
            this.lblOrdersValue.Size = new System.Drawing.Size(240, 55);
            this.lblOrdersValue.TabIndex = 1;
            this.lblOrdersValue.Text = "0";
            //
            // pnlAvg
            //
            this.pnlAvg.BackColor = AmanePOSHelpers.AmaneStyling.CardBg;
            this.pnlAvg.Controls.Add(this.lblAvgCaption);
            this.pnlAvg.Controls.Add(this.lblAvgValue);
            this.pnlAvg.Location = new System.Drawing.Point(640, 325);
            this.pnlAvg.Name = "pnlAvg";
            this.pnlAvg.Size = new System.Drawing.Size(280, 130);
            this.pnlAvg.TabIndex = 15;
            //
            // lblAvgCaption
            //
            this.lblAvgCaption.AutoSize = true;
            this.lblAvgCaption.Font = new System.Drawing.Font("Cambria", 11F);
            this.lblAvgCaption.ForeColor = AmanePOSHelpers.AmaneStyling.TextMuted;
            this.lblAvgCaption.Location = new System.Drawing.Point(20, 18);
            this.lblAvgCaption.Name = "lblAvgCaption";
            this.lblAvgCaption.Size = new System.Drawing.Size(160, 30);
            this.lblAvgCaption.TabIndex = 0;
            this.lblAvgCaption.Text = "avg order value";
            //
            // lblAvgValue
            //
            this.lblAvgValue.Font = new System.Drawing.Font("Cambria", 22F);
            this.lblAvgValue.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.lblAvgValue.Location = new System.Drawing.Point(20, 55);
            this.lblAvgValue.Name = "lblAvgValue";
            this.lblAvgValue.Size = new System.Drawing.Size(240, 55);
            this.lblAvgValue.TabIndex = 1;
            this.lblAvgValue.Text = "$0.00";
            //
            // pnlUnits
            //
            this.pnlUnits.BackColor = AmanePOSHelpers.AmaneStyling.CardBg;
            this.pnlUnits.Controls.Add(this.lblUnitsCaption);
            this.pnlUnits.Controls.Add(this.lblUnitsValue);
            this.pnlUnits.Location = new System.Drawing.Point(940, 325);
            this.pnlUnits.Name = "pnlUnits";
            this.pnlUnits.Size = new System.Drawing.Size(280, 130);
            this.pnlUnits.TabIndex = 16;
            //
            // lblUnitsCaption
            //
            this.lblUnitsCaption.AutoSize = true;
            this.lblUnitsCaption.Font = new System.Drawing.Font("Cambria", 11F);
            this.lblUnitsCaption.ForeColor = AmanePOSHelpers.AmaneStyling.TextMuted;
            this.lblUnitsCaption.Location = new System.Drawing.Point(20, 18);
            this.lblUnitsCaption.Name = "lblUnitsCaption";
            this.lblUnitsCaption.Size = new System.Drawing.Size(120, 30);
            this.lblUnitsCaption.TabIndex = 0;
            this.lblUnitsCaption.Text = "units sold";
            //
            // lblUnitsValue
            //
            this.lblUnitsValue.Font = new System.Drawing.Font("Cambria", 22F);
            this.lblUnitsValue.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.lblUnitsValue.Location = new System.Drawing.Point(20, 55);
            this.lblUnitsValue.Name = "lblUnitsValue";
            this.lblUnitsValue.Size = new System.Drawing.Size(240, 55);
            this.lblUnitsValue.TabIndex = 1;
            this.lblUnitsValue.Text = "0";
            //
            // lblProductsSection
            //
            this.lblProductsSection.Font = new System.Drawing.Font("Cambria", 13F);
            this.lblProductsSection.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.lblProductsSection.Location = new System.Drawing.Point(40, 480);
            this.lblProductsSection.Name = "lblProductsSection";
            this.lblProductsSection.Size = new System.Drawing.Size(400, 35);
            this.lblProductsSection.TabIndex = 17;
            this.lblProductsSection.Text = "top products (by units sold)";
            //
            // dgvTopProducts
            //
            this.dgvTopProducts.BackgroundColor = AmanePOSHelpers.AmaneStyling.CardBg;
            this.dgvTopProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTopProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopProducts.ReadOnly = true;
            this.dgvTopProducts.RowHeadersVisible = false;
            this.dgvTopProducts.Location = new System.Drawing.Point(40, 525);
            this.dgvTopProducts.Name = "dgvTopProducts";
            this.dgvTopProducts.Size = new System.Drawing.Size(620, 340);
            this.dgvTopProducts.TabIndex = 18;
            //
            // lblStaffSection
            //
            this.lblStaffSection.Font = new System.Drawing.Font("Cambria", 13F);
            this.lblStaffSection.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.lblStaffSection.Location = new System.Drawing.Point(680, 480);
            this.lblStaffSection.Name = "lblStaffSection";
            this.lblStaffSection.Size = new System.Drawing.Size(400, 35);
            this.lblStaffSection.TabIndex = 19;
            this.lblStaffSection.Text = "staff performance (by revenue)";
            //
            // dgvStaffPerformance
            //
            this.dgvStaffPerformance.BackgroundColor = AmanePOSHelpers.AmaneStyling.CardBg;
            this.dgvStaffPerformance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaffPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffPerformance.ReadOnly = true;
            this.dgvStaffPerformance.RowHeadersVisible = false;
            this.dgvStaffPerformance.Location = new System.Drawing.Point(680, 525);
            this.dgvStaffPerformance.Name = "dgvStaffPerformance";
            this.dgvStaffPerformance.Size = new System.Drawing.Size(540, 340);
            this.dgvStaffPerformance.TabIndex = 20;
            //
            // ReportsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AmanePOSHelpers.AmaneStyling.PageBg;
            this.ClientSize = new System.Drawing.Size(1400, 920);
            this.Controls.Add(this.dgvStaffPerformance);
            this.Controls.Add(this.lblStaffSection);
            this.Controls.Add(this.dgvTopProducts);
            this.Controls.Add(this.lblProductsSection);
            this.Controls.Add(this.pnlUnits);
            this.Controls.Add(this.pnlAvg);
            this.Controls.Add(this.pnlOrders);
            this.Controls.Add(this.pnlRevenue);
            this.Controls.Add(this.lblSalesSection);
            this.Controls.Add(this.lblRangeInfo);
            this.Controls.Add(this.btnPresetAll);
            this.Controls.Add(this.btnPresetMonth);
            this.Controls.Add(this.btnPresetWeek);
            this.Controls.Add(this.btnPresetToday);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.pnlNav);
            this.Name = "ReportsForm";
            this.Text = "Amane - Reports";
            this.pnlNav.ResumeLayout(false);
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlAvg.ResumeLayout(false);
            this.pnlAvg.PerformLayout();
            this.pnlUnits.ResumeLayout(false);
            this.pnlUnits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffPerformance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button LogoBtn;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnPresetToday;
        private System.Windows.Forms.Button btnPresetWeek;
        private System.Windows.Forms.Button btnPresetMonth;
        private System.Windows.Forms.Button btnPresetAll;
        private System.Windows.Forms.Label lblRangeInfo;
        private System.Windows.Forms.Label lblSalesSection;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Label lblRevenueCaption;
        private System.Windows.Forms.Label lblRevenueValue;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Label lblOrdersCaption;
        private System.Windows.Forms.Label lblOrdersValue;
        private System.Windows.Forms.Panel pnlAvg;
        private System.Windows.Forms.Label lblAvgCaption;
        private System.Windows.Forms.Label lblAvgValue;
        private System.Windows.Forms.Panel pnlUnits;
        private System.Windows.Forms.Label lblUnitsCaption;
        private System.Windows.Forms.Label lblUnitsValue;
        private System.Windows.Forms.Label lblProductsSection;
        private System.Windows.Forms.DataGridView dgvTopProducts;
        private System.Windows.Forms.Label lblStaffSection;
        private System.Windows.Forms.DataGridView dgvStaffPerformance;
    }
}