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
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblStaffSection = new System.Windows.Forms.Label();
            this.dgvStaffPerformance = new System.Windows.Forms.DataGridView();
            this.lblSalesOverTimeSection = new System.Windows.Forms.Label();
            this.chartSalesOverTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlRevenue.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlAvg.SuspendLayout();
            this.pnlUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffPerformance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesOverTime)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Cambria", 9F);
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblFrom.Location = new System.Drawing.Point(435, 145);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(62, 28);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "from";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarFont = new System.Drawing.Font("Cambria", 9F);
            this.dtpFrom.CustomFormat = "dd MMM yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Cambria", 10F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(430, 176);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(226, 39);
            this.dtpFrom.TabIndex = 3;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Cambria", 9F);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblTo.Location = new System.Drawing.Point(691, 144);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(33, 28);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "to";
            // 
            // dtpTo
            // 
            this.dtpTo.CalendarFont = new System.Drawing.Font("Cambria", 9F);
            this.dtpTo.CustomFormat = "dd MMM yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Cambria", 10F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(680, 175);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(180, 39);
            this.dtpTo.TabIndex = 5;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Cambria", 8F);
            this.btnApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnApply.Location = new System.Drawing.Point(884, 175);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(152, 35);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "apply";
            this.btnApply.UseVisualStyleBackColor = false;
            // 
            // btnPresetToday
            // 
            this.btnPresetToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(198)))));
            this.btnPresetToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresetToday.FlatAppearance.BorderSize = 0;
            this.btnPresetToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresetToday.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnPresetToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPresetToday.Location = new System.Drawing.Point(1083, 174);
            this.btnPresetToday.Name = "btnPresetToday";
            this.btnPresetToday.Size = new System.Drawing.Size(139, 35);
            this.btnPresetToday.TabIndex = 7;
            this.btnPresetToday.Text = "today";
            this.btnPresetToday.UseVisualStyleBackColor = false;
            // 
            // btnPresetWeek
            // 
            this.btnPresetWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(198)))));
            this.btnPresetWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresetWeek.FlatAppearance.BorderSize = 0;
            this.btnPresetWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresetWeek.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnPresetWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPresetWeek.Location = new System.Drawing.Point(1242, 175);
            this.btnPresetWeek.Name = "btnPresetWeek";
            this.btnPresetWeek.Size = new System.Drawing.Size(143, 35);
            this.btnPresetWeek.TabIndex = 8;
            this.btnPresetWeek.Text = "7 days";
            this.btnPresetWeek.UseVisualStyleBackColor = false;
            // 
            // btnPresetMonth
            // 
            this.btnPresetMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(198)))));
            this.btnPresetMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresetMonth.FlatAppearance.BorderSize = 0;
            this.btnPresetMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresetMonth.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnPresetMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPresetMonth.Location = new System.Drawing.Point(1395, 175);
            this.btnPresetMonth.Name = "btnPresetMonth";
            this.btnPresetMonth.Size = new System.Drawing.Size(147, 35);
            this.btnPresetMonth.TabIndex = 9;
            this.btnPresetMonth.Text = "30 days";
            this.btnPresetMonth.UseVisualStyleBackColor = false;
            // 
            // btnPresetAll
            // 
            this.btnPresetAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(207)))), ((int)(((byte)(198)))));
            this.btnPresetAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresetAll.FlatAppearance.BorderSize = 0;
            this.btnPresetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresetAll.Font = new System.Drawing.Font("Cambria", 9F);
            this.btnPresetAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPresetAll.Location = new System.Drawing.Point(1560, 174);
            this.btnPresetAll.Name = "btnPresetAll";
            this.btnPresetAll.Size = new System.Drawing.Size(168, 35);
            this.btnPresetAll.TabIndex = 10;
            this.btnPresetAll.Text = "all time";
            this.btnPresetAll.UseVisualStyleBackColor = false;
            // 
            // lblRangeInfo
            // 
            this.lblRangeInfo.AutoSize = true;
            this.lblRangeInfo.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic);
            this.lblRangeInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblRangeInfo.Location = new System.Drawing.Point(40, 230);
            this.lblRangeInfo.Name = "lblRangeInfo";
            this.lblRangeInfo.Size = new System.Drawing.Size(0, 28);
            this.lblRangeInfo.TabIndex = 11;
            // 
            // lblSalesSection
            // 
            this.lblSalesSection.Font = new System.Drawing.Font("Cambria", 13F);
            this.lblSalesSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblSalesSection.Location = new System.Drawing.Point(888, 265);
            this.lblSalesSection.Name = "lblSalesSection";
            this.lblSalesSection.Size = new System.Drawing.Size(300, 35);
            this.lblSalesSection.TabIndex = 12;
            this.lblSalesSection.Text = "sales summary";
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.pnlRevenue.Controls.Add(this.lblRevenueCaption);
            this.pnlRevenue.Controls.Add(this.lblRevenueValue);
            this.pnlRevenue.Location = new System.Drawing.Point(199, 325);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(280, 130);
            this.pnlRevenue.TabIndex = 13;
            // 
            // lblRevenueCaption
            // 
            this.lblRevenueCaption.AutoSize = true;
            this.lblRevenueCaption.Font = new System.Drawing.Font("Cambria", 11F);
            this.lblRevenueCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblRevenueCaption.Location = new System.Drawing.Point(20, 18);
            this.lblRevenueCaption.Name = "lblRevenueCaption";
            this.lblRevenueCaption.Size = new System.Drawing.Size(186, 36);
            this.lblRevenueCaption.TabIndex = 0;
            this.lblRevenueCaption.Text = "total revenue";
            // 
            // lblRevenueValue
            // 
            this.lblRevenueValue.Font = new System.Drawing.Font("Cambria", 22F);
            this.lblRevenueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblRevenueValue.Location = new System.Drawing.Point(20, 55);
            this.lblRevenueValue.Name = "lblRevenueValue";
            this.lblRevenueValue.Size = new System.Drawing.Size(240, 55);
            this.lblRevenueValue.TabIndex = 1;
            this.lblRevenueValue.Text = "$0.00";
            // 
            // pnlOrders
            // 
            this.pnlOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.pnlOrders.Controls.Add(this.lblOrdersCaption);
            this.pnlOrders.Controls.Add(this.lblOrdersValue);
            this.pnlOrders.Location = new System.Drawing.Point(670, 325);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(280, 130);
            this.pnlOrders.TabIndex = 14;
            // 
            // lblOrdersCaption
            // 
            this.lblOrdersCaption.AutoSize = true;
            this.lblOrdersCaption.Font = new System.Drawing.Font("Cambria", 11F);
            this.lblOrdersCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblOrdersCaption.Location = new System.Drawing.Point(20, 18);
            this.lblOrdersCaption.Name = "lblOrdersCaption";
            this.lblOrdersCaption.Size = new System.Drawing.Size(100, 36);
            this.lblOrdersCaption.TabIndex = 0;
            this.lblOrdersCaption.Text = "orders";
            // 
            // lblOrdersValue
            // 
            this.lblOrdersValue.Font = new System.Drawing.Font("Cambria", 22F);
            this.lblOrdersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblOrdersValue.Location = new System.Drawing.Point(20, 55);
            this.lblOrdersValue.Name = "lblOrdersValue";
            this.lblOrdersValue.Size = new System.Drawing.Size(240, 55);
            this.lblOrdersValue.TabIndex = 1;
            this.lblOrdersValue.Text = "0";
            // 
            // pnlAvg
            // 
            this.pnlAvg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.pnlAvg.Controls.Add(this.lblAvgCaption);
            this.pnlAvg.Controls.Add(this.lblAvgValue);
            this.pnlAvg.Location = new System.Drawing.Point(1140, 325);
            this.pnlAvg.Name = "pnlAvg";
            this.pnlAvg.Size = new System.Drawing.Size(280, 130);
            this.pnlAvg.TabIndex = 15;
            // 
            // lblAvgCaption
            // 
            this.lblAvgCaption.AutoSize = true;
            this.lblAvgCaption.Font = new System.Drawing.Font("Cambria", 11F);
            this.lblAvgCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblAvgCaption.Location = new System.Drawing.Point(20, 18);
            this.lblAvgCaption.Name = "lblAvgCaption";
            this.lblAvgCaption.Size = new System.Drawing.Size(213, 36);
            this.lblAvgCaption.TabIndex = 0;
            this.lblAvgCaption.Text = "avg order value";
            // 
            // lblAvgValue
            // 
            this.lblAvgValue.Font = new System.Drawing.Font("Cambria", 22F);
            this.lblAvgValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblAvgValue.Location = new System.Drawing.Point(20, 55);
            this.lblAvgValue.Name = "lblAvgValue";
            this.lblAvgValue.Size = new System.Drawing.Size(240, 55);
            this.lblAvgValue.TabIndex = 1;
            this.lblAvgValue.Text = "$0.00";
            // 
            // pnlUnits
            // 
            this.pnlUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.pnlUnits.Controls.Add(this.lblUnitsCaption);
            this.pnlUnits.Controls.Add(this.lblUnitsValue);
            this.pnlUnits.Location = new System.Drawing.Point(1601, 325);
            this.pnlUnits.Name = "pnlUnits";
            this.pnlUnits.Size = new System.Drawing.Size(280, 130);
            this.pnlUnits.TabIndex = 16;
            // 
            // lblUnitsCaption
            // 
            this.lblUnitsCaption.AutoSize = true;
            this.lblUnitsCaption.Font = new System.Drawing.Font("Cambria", 11F);
            this.lblUnitsCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblUnitsCaption.Location = new System.Drawing.Point(20, 18);
            this.lblUnitsCaption.Name = "lblUnitsCaption";
            this.lblUnitsCaption.Size = new System.Drawing.Size(141, 36);
            this.lblUnitsCaption.TabIndex = 0;
            this.lblUnitsCaption.Text = "units sold";
            // 
            // lblUnitsValue
            // 
            this.lblUnitsValue.Font = new System.Drawing.Font("Cambria", 22F);
            this.lblUnitsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblUnitsValue.Location = new System.Drawing.Point(14, 54);
            this.lblUnitsValue.Name = "lblUnitsValue";
            this.lblUnitsValue.Size = new System.Drawing.Size(240, 55);
            this.lblUnitsValue.TabIndex = 1;
            this.lblUnitsValue.Text = "0";
            // 
            // lblProductsSection
            // 
            this.lblProductsSection.Font = new System.Drawing.Font("Cambria", 8F);
            this.lblProductsSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblProductsSection.Location = new System.Drawing.Point(40, 480);
            this.lblProductsSection.Name = "lblProductsSection";
            this.lblProductsSection.Size = new System.Drawing.Size(400, 35);
            this.lblProductsSection.TabIndex = 17;
            this.lblProductsSection.Text = "top products (by units sold)";
            // 
            // chartTopProducts
            // 
            this.chartTopProducts.Location = new System.Drawing.Point(40, 525);
            this.chartTopProducts.Name = "chartTopProducts";
            this.chartTopProducts.Size = new System.Drawing.Size(667, 323);
            this.chartTopProducts.TabIndex = 18;
            // 
            // lblStaffSection
            // 
            this.lblStaffSection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStaffSection.Font = new System.Drawing.Font("Cambria", 8F);
            this.lblStaffSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblStaffSection.Location = new System.Drawing.Point(1453, 480);
            this.lblStaffSection.Name = "lblStaffSection";
            this.lblStaffSection.Size = new System.Drawing.Size(400, 35);
            this.lblStaffSection.TabIndex = 19;
            this.lblStaffSection.Text = "staff performance (by revenue)";
            // 
            // dgvStaffPerformance
            // 
            this.dgvStaffPerformance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.dgvStaffPerformance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaffPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffPerformance.Location = new System.Drawing.Point(1458, 525);
            this.dgvStaffPerformance.Name = "dgvStaffPerformance";
            this.dgvStaffPerformance.ReadOnly = true;
            this.dgvStaffPerformance.RowHeadersVisible = false;
            this.dgvStaffPerformance.RowHeadersWidth = 82;
            this.dgvStaffPerformance.Size = new System.Drawing.Size(540, 323);
            this.dgvStaffPerformance.TabIndex = 20;
            // 
            // lblSalesOverTimeSection
            // 
            this.lblSalesOverTimeSection.Font = new System.Drawing.Font("Cambria", 8F);
            this.lblSalesOverTimeSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblSalesOverTimeSection.Location = new System.Drawing.Point(737, 480);
            this.lblSalesOverTimeSection.Name = "lblSalesOverTimeSection";
            this.lblSalesOverTimeSection.Size = new System.Drawing.Size(400, 35);
            this.lblSalesOverTimeSection.TabIndex = 21;
            this.lblSalesOverTimeSection.Text = "sales over time";
            // 
            // chartSalesOverTime
            // 
            this.chartSalesOverTime.Location = new System.Drawing.Point(734, 525);
            this.chartSalesOverTime.Name = "chartSalesOverTime";
            this.chartSalesOverTime.Size = new System.Drawing.Size(677, 323);
            this.chartSalesOverTime.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2185, 110);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
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
            this.panel3.Location = new System.Drawing.Point(-28, -6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2220, 115);
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
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(2108, 1077);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartSalesOverTime);
            this.Controls.Add(this.lblSalesOverTimeSection);
            this.Controls.Add(this.dgvStaffPerformance);
            this.Controls.Add(this.lblStaffSection);
            this.Controls.Add(this.chartTopProducts);
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
            this.Name = "ReportsForm";
            this.Text = "Amane - Reports";
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlAvg.ResumeLayout(false);
            this.pnlAvg.PerformLayout();
            this.pnlUnits.ResumeLayout(false);
            this.pnlUnits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffPerformance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesOverTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private System.Windows.Forms.Label lblStaffSection;
        private System.Windows.Forms.DataGridView dgvStaffPerformance;
        private System.Windows.Forms.Label lblSalesOverTimeSection;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalesOverTime;
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