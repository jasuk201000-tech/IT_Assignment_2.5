namespace IT_Assessment_2.Forms
{
    partial class DashboardForm1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.LogoBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.salesPnl = new System.Windows.Forms.Panel();
            this.intSalesLbl = new System.Windows.Forms.Label();
            this.salesLbl = new System.Windows.Forms.Label();
            this.ordersPnl = new System.Windows.Forms.Panel();
            this.intOrdersLbl = new System.Windows.Forms.Label();
            this.ordersLbl = new System.Windows.Forms.Label();
            this.lowstockPnl = new System.Windows.Forms.Panel();
            this.lowstockintLbl = new System.Windows.Forms.Label();
            this.lowstockLbl = new System.Windows.Forms.Label();
            this.returnsPnl = new System.Windows.Forms.Panel();
            this.returnsintLbl = new System.Windows.Forms.Label();
            this.returnsLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.salesPnl.SuspendLayout();
            this.ordersPnl.SuspendLayout();
            this.lowstockPnl.SuspendLayout();
            this.returnsPnl.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2126, 93);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-6, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2132, 120);
            this.panel2.TabIndex = 6;
            // 
            // panel3 (top nav bar — mauve)
            // 
            this.panel3.BackColor = AmanePOSHelpers.AmaneStyling.NavBar;
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.LogoBtn);
            this.panel3.Location = new System.Drawing.Point(-10, -7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2142, 97);
            this.panel3.TabIndex = 6;
            // 
            // button9 (reports)
            // 
            this.button9.BackColor = AmanePOSHelpers.AmaneStyling.NavBar;
            this.button9.ForeColor = AmanePOSHelpers.AmaneStyling.TextOnNav;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = AmanePOSHelpers.AmaneStyling.FontNavItem;
            this.button9.Location = new System.Drawing.Point(1749, 45);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(185, 41);
            this.button9.TabIndex = 11;
            this.button9.Text = "reports";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8 (transactions)
            // 
            this.button8.BackColor = AmanePOSHelpers.AmaneStyling.NavBar;
            this.button8.ForeColor = AmanePOSHelpers.AmaneStyling.TextOnNav;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = AmanePOSHelpers.AmaneStyling.FontNavItem;
            this.button8.Location = new System.Drawing.Point(1547, 45);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(185, 41);
            this.button8.TabIndex = 10;
            this.button8.Text = "transactions";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7 (orders)
            // 
            this.button7.BackColor = AmanePOSHelpers.AmaneStyling.NavBar;
            this.button7.ForeColor = AmanePOSHelpers.AmaneStyling.TextOnNav;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = AmanePOSHelpers.AmaneStyling.FontNavItem;
            this.button7.Location = new System.Drawing.Point(1345, 45);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(185, 41);
            this.button7.TabIndex = 9;
            this.button7.Text = "orders";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6 (inventory)
            // 
            this.button6.BackColor = AmanePOSHelpers.AmaneStyling.NavBar;
            this.button6.ForeColor = AmanePOSHelpers.AmaneStyling.TextOnNav;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = AmanePOSHelpers.AmaneStyling.FontNavItem;
            this.button6.Location = new System.Drawing.Point(1142, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(185, 41);
            this.button6.TabIndex = 8;
            this.button6.Text = "inventory";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5 (dashboard)
            // 
            this.button5.BackColor = AmanePOSHelpers.AmaneStyling.NavBar;
            this.button5.ForeColor = AmanePOSHelpers.AmaneStyling.TextOnNav;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = AmanePOSHelpers.AmaneStyling.FontNavItem;
            this.button5.Location = new System.Drawing.Point(937, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 41);
            this.button5.TabIndex = 7;
            this.button5.Text = "dashboard";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // LogoBtn
            // 
            this.LogoBtn.BackColor = AmanePOSHelpers.AmaneStyling.NavBar;
            this.LogoBtn.ForeColor = AmanePOSHelpers.AmaneStyling.TextOnNav;
            this.LogoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LogoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoBtn.FlatAppearance.BorderSize = 0;
            this.LogoBtn.Location = new System.Drawing.Point(39, 20);
            this.LogoBtn.Name = "LogoBtn";
            this.LogoBtn.Size = new System.Drawing.Size(217, 74);
            this.LogoBtn.TabIndex = 6;
            this.LogoBtn.Text = "𝖆𝖒𝖆𝖓𝖊";
            this.LogoBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-29, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2131, 351);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(708, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2131, 351);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1443, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(2131, 351);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(982, 105);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(147, 50);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = AmanePOSHelpers.AmaneStyling.FontTitle;
            this.welcomeLbl.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.welcomeLbl.Location = new System.Drawing.Point(817, 175);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(496, 47);
            this.welcomeLbl.TabIndex = 8;
            this.welcomeLbl.Text = "welcome *insert username*";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = AmanePOSHelpers.AmaneStyling.FontLabel;
            this.dateLbl.ForeColor = AmanePOSHelpers.AmaneStyling.TextMuted;
            this.dateLbl.Location = new System.Drawing.Point(975, 234);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(166, 37);
            this.dateLbl.TabIndex = 9;
            this.dateLbl.Text = "insert date";
            // 
            // salesPnl
            // 
            this.salesPnl.BackColor = AmanePOSHelpers.AmaneStyling.CardBg;
            this.salesPnl.Padding = new System.Windows.Forms.Padding(12);
            this.salesPnl.Controls.Add(this.intSalesLbl);
            this.salesPnl.Controls.Add(this.salesLbl);
            this.salesPnl.Location = new System.Drawing.Point(146, 366);
            this.salesPnl.Name = "salesPnl";
            this.salesPnl.Size = new System.Drawing.Size(321, 187);
            this.salesPnl.TabIndex = 10;
            // 
            // intSalesLbl
            // 
            this.intSalesLbl.AutoSize = true;
            this.intSalesLbl.Font = AmanePOSHelpers.AmaneStyling.FontTitle;
            this.intSalesLbl.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.intSalesLbl.Location = new System.Drawing.Point(46, 89);
            this.intSalesLbl.Name = "intSalesLbl";
            this.intSalesLbl.Size = new System.Drawing.Size(80, 32);
            this.intSalesLbl.TabIndex = 16;
            this.intSalesLbl.Text = "$////";
            // 
            // salesLbl
            // 
            this.salesLbl.AutoSize = true;
            this.salesLbl.Font = AmanePOSHelpers.AmaneStyling.FontLabel;
            this.salesLbl.ForeColor = AmanePOSHelpers.AmaneStyling.TextMuted;
            this.salesLbl.Location = new System.Drawing.Point(36, 28);
            this.salesLbl.Name = "salesLbl";
            this.salesLbl.Size = new System.Drawing.Size(187, 36);
            this.salesLbl.TabIndex = 14;
            this.salesLbl.Text = "Todays Sales:";
            // 
            // ordersPnl
            // 
            this.ordersPnl.BackColor = AmanePOSHelpers.AmaneStyling.CardBg;
            this.ordersPnl.Padding = new System.Windows.Forms.Padding(12);
            this.ordersPnl.Controls.Add(this.intOrdersLbl);
            this.ordersPnl.Controls.Add(this.ordersLbl);
            this.ordersPnl.Location = new System.Drawing.Point(613, 366);
            this.ordersPnl.Name = "ordersPnl";
            this.ordersPnl.Size = new System.Drawing.Size(321, 187);
            this.ordersPnl.TabIndex = 11;
            // 
            // intOrdersLbl
            // 
            this.intOrdersLbl.AutoSize = true;
            this.intOrdersLbl.Font = AmanePOSHelpers.AmaneStyling.FontTitle;
            this.intOrdersLbl.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.intOrdersLbl.Location = new System.Drawing.Point(35, 79);
            this.intOrdersLbl.Name = "intOrdersLbl";
            this.intOrdersLbl.Size = new System.Drawing.Size(66, 32);
            this.intOrdersLbl.TabIndex = 17;
            this.intOrdersLbl.Text = "////";
            // 
            // ordersLbl
            // 
            this.ordersLbl.AutoSize = true;
            this.ordersLbl.Font = AmanePOSHelpers.AmaneStyling.FontLabel;
            this.ordersLbl.ForeColor = AmanePOSHelpers.AmaneStyling.TextMuted;
            this.ordersLbl.Location = new System.Drawing.Point(24, 28);
            this.ordersLbl.Name = "ordersLbl";
            this.ordersLbl.Size = new System.Drawing.Size(112, 36);
            this.ordersLbl.TabIndex = 15;
            this.ordersLbl.Text = "Orders:";
            // 
            // lowstockPnl
            // 
            this.lowstockPnl.BackColor = AmanePOSHelpers.AmaneStyling.CardBg;
            this.lowstockPnl.Padding = new System.Windows.Forms.Padding(12);
            this.lowstockPnl.Controls.Add(this.lowstockintLbl);
            this.lowstockPnl.Controls.Add(this.lowstockLbl);
            this.lowstockPnl.Location = new System.Drawing.Point(1195, 366);
            this.lowstockPnl.Name = "lowstockPnl";
            this.lowstockPnl.Size = new System.Drawing.Size(321, 187);
            this.lowstockPnl.TabIndex = 12;
            // 
            // lowstockintLbl
            // 
            this.lowstockintLbl.AutoSize = true;
            this.lowstockintLbl.Font = AmanePOSHelpers.AmaneStyling.FontTitle;
            this.lowstockintLbl.ForeColor = AmanePOSHelpers.AmaneStyling.Warning;
            this.lowstockintLbl.Location = new System.Drawing.Point(40, 89);
            this.lowstockintLbl.Name = "lowstockintLbl";
            this.lowstockintLbl.Size = new System.Drawing.Size(66, 32);
            this.lowstockintLbl.TabIndex = 18;
            this.lowstockintLbl.Text = "////";
            // 
            // lowstockLbl
            // 
            this.lowstockLbl.AutoSize = true;
            this.lowstockLbl.Font = AmanePOSHelpers.AmaneStyling.FontLabel;
            this.lowstockLbl.ForeColor = AmanePOSHelpers.AmaneStyling.TextMuted;
            this.lowstockLbl.Location = new System.Drawing.Point(29, 28);
            this.lowstockLbl.Name = "lowstockLbl";
            this.lowstockLbl.Size = new System.Drawing.Size(153, 36);
            this.lowstockLbl.TabIndex = 16;
            this.lowstockLbl.Text = "Low stock:";
            // 
            // returnsPnl
            // 
            this.returnsPnl.BackColor = AmanePOSHelpers.AmaneStyling.CardBg;
            this.returnsPnl.Padding = new System.Windows.Forms.Padding(12);
            this.returnsPnl.Controls.Add(this.returnsintLbl);
            this.returnsPnl.Controls.Add(this.returnsLbl);
            this.returnsPnl.Location = new System.Drawing.Point(1689, 366);
            this.returnsPnl.Name = "returnsPnl";
            this.returnsPnl.Size = new System.Drawing.Size(321, 187);
            this.returnsPnl.TabIndex = 13;
            // 
            // returnsintLbl
            // 
            this.returnsintLbl.AutoSize = true;
            this.returnsintLbl.Font = AmanePOSHelpers.AmaneStyling.FontTitle;
            this.returnsintLbl.ForeColor = AmanePOSHelpers.AmaneStyling.Danger;
            this.returnsintLbl.Location = new System.Drawing.Point(40, 89);
            this.returnsintLbl.Name = "returnsintLbl";
            this.returnsintLbl.Size = new System.Drawing.Size(66, 32);
            this.returnsintLbl.TabIndex = 19;
            this.returnsintLbl.Text = "////";
            // 
            // returnsLbl
            // 
            this.returnsLbl.AutoSize = true;
            this.returnsLbl.Font = AmanePOSHelpers.AmaneStyling.FontLabel;
            this.returnsLbl.ForeColor = AmanePOSHelpers.AmaneStyling.TextMuted;
            this.returnsLbl.Location = new System.Drawing.Point(28, 28);
            this.returnsLbl.Name = "returnsLbl";
            this.returnsLbl.Size = new System.Drawing.Size(117, 36);
            this.returnsLbl.TabIndex = 17;
            this.returnsLbl.Text = "Returns";
            // 
            // panel4 (Quick Nav container)
            // 
            this.panel4.BackColor = AmanePOSHelpers.AmaneStyling.CardBg;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(1466, 614);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 425);
            this.panel4.TabIndex = 14;
            // 
            // button4 (Reports — secondary)
            // 
            this.button4.BackColor = AmanePOSHelpers.AmaneStyling.ButtonSecondary;
            this.button4.ForeColor = AmanePOSHelpers.AmaneStyling.ButtonText;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = AmanePOSHelpers.AmaneStyling.FontButton;
            this.button4.Location = new System.Drawing.Point(40, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(312, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Reports";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3 (View stock — secondary)
            // 
            this.button3.BackColor = AmanePOSHelpers.AmaneStyling.ButtonSecondary;
            this.button3.ForeColor = AmanePOSHelpers.AmaneStyling.ButtonText;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = AmanePOSHelpers.AmaneStyling.FontButton;
            this.button3.Location = new System.Drawing.Point(40, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "View stock";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2 (Add product — secondary)
            // 
            this.button2.BackColor = AmanePOSHelpers.AmaneStyling.ButtonSecondary;
            this.button2.ForeColor = AmanePOSHelpers.AmaneStyling.ButtonText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = AmanePOSHelpers.AmaneStyling.FontButton;
            this.button2.Location = new System.Drawing.Point(40, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add product";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1 (Build Order — primary)
            // 
            this.button1.BackColor = AmanePOSHelpers.AmaneStyling.ButtonPrimary;
            this.button1.ForeColor = AmanePOSHelpers.AmaneStyling.ButtonText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = AmanePOSHelpers.AmaneStyling.FontButton;
            this.button1.Location = new System.Drawing.Point(40, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Build Order";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1 (Quick Nav title strip)
            // 
            this.flowLayoutPanel1.BackColor = AmanePOSHelpers.AmaneStyling.CardBg;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1466, 614);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(600, 78);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // label1 (Quick Navigation title)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = AmanePOSHelpers.AmaneStyling.FontTitle;
            this.label1.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quick Navigation";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = AmanePOSHelpers.AmaneStyling.CardBg;
            this.dataGridView1.GridColor = AmanePOSHelpers.AmaneStyling.Divider;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = AmanePOSHelpers.AmaneStyling.NavBar;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = AmanePOSHelpers.AmaneStyling.TextOnNav;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = AmanePOSHelpers.AmaneStyling.FontNav;
            this.dataGridView1.DefaultCellStyle.BackColor = AmanePOSHelpers.AmaneStyling.CardBg;
            this.dataGridView1.DefaultCellStyle.ForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.dataGridView1.DefaultCellStyle.Font = AmanePOSHelpers.AmaneStyling.FontBody;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = AmanePOSHelpers.AmaneStyling.AccentLight;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = AmanePOSHelpers.AmaneStyling.TextDark;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = AmanePOSHelpers.AmaneStyling.PageBg;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 614);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(995, 425);
            this.dataGridView1.TabIndex = 16;
            // 
            // DashboardForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AmanePOSHelpers.AmaneStyling.PageBg;
            this.ClientSize = new System.Drawing.Size(2129, 1176);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.returnsPnl);
            this.Controls.Add(this.lowstockPnl);
            this.Controls.Add(this.ordersPnl);
            this.Controls.Add(this.salesPnl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "DashboardForm1";
            this.Text = "DashboardForm1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.salesPnl.ResumeLayout(false);
            this.salesPnl.PerformLayout();
            this.ordersPnl.ResumeLayout(false);
            this.ordersPnl.PerformLayout();
            this.lowstockPnl.ResumeLayout(false);
            this.lowstockPnl.PerformLayout();
            this.returnsPnl.ResumeLayout(false);
            this.returnsPnl.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // ... (control field declarations unchanged below)
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button LogoBtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Panel salesPnl;
        private System.Windows.Forms.Label salesLbl;
        private System.Windows.Forms.Panel ordersPnl;
        private System.Windows.Forms.Label ordersLbl;
        private System.Windows.Forms.Panel lowstockPnl;
        private System.Windows.Forms.Label lowstockLbl;
        private System.Windows.Forms.Panel returnsPnl;
        private System.Windows.Forms.Label returnsLbl;
        private System.Windows.Forms.Label intSalesLbl;
        private System.Windows.Forms.Label intOrdersLbl;
        private System.Windows.Forms.Label lowstockintLbl;
        private System.Windows.Forms.Label returnsintLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}