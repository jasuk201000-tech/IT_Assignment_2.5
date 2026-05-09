using AmanePOSHelpers;
using IT_Assignment_2.Helpers;

namespace IT_Assessment_2.Forms
{
    partial class PINControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(PINControl1));

            this.headerPnl = new System.Windows.Forms.Panel();
            this.PnlLabel1 = new System.Windows.Forms.Label();

            this.pictureBox1 = new System.Windows.Forms.PictureBox();

            this.label1 = new System.Windows.Forms.Label();
            this.PinLbl2 = new System.Windows.Forms.Label();

            this.pinInput = new System.Windows.Forms.MaskedTextBox();

            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();

            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();

            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();

            this.linkLabel2 = new System.Windows.Forms.LinkLabel();

            this.headerPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // 
            // PINControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AmaneStyling.CardPanel;
            this.Name = "PINControl1";
            this.Size = new System.Drawing.Size(648, 743);

            // 
            // headerPnl
            // 
            this.headerPnl.BackColor = AmaneStyling.NavBar;
            this.headerPnl.Controls.Add(this.PnlLabel1);
            this.headerPnl.Location = new System.Drawing.Point(0, 0);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(648, 80);
            this.headerPnl.TabIndex = 0;

            // 
            // PnlLabel1
            // 
            this.PnlLabel1.AutoSize = true;
            this.PnlLabel1.Font = new System.Drawing.Font("Cambria", 16F);
            this.PnlLabel1.ForeColor = AmaneStyling.TextOnURL;
            this.PnlLabel1.Location = new System.Drawing.Point(20, 20);
            this.PnlLabel1.Name = "PnlLabel1";
            this.PnlLabel1.Size = new System.Drawing.Size(273, 32);
            this.PnlLabel1.TabIndex = 0;
            this.PnlLabel1.Text = "amane staff portal";

            // 
            // pictureBox1
            // 
            this.pictureBox1.Image =
                ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F);
            this.label1.ForeColor = AmaneStyling.TextOnURL;
            this.label1.Location = new System.Drawing.Point(205, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "PIN Login Mode";

            // 
            // PinLbl2
            // 
            this.PinLbl2.AutoSize = true;
            this.PinLbl2.Font = new System.Drawing.Font("Cambria", 10F);
            this.PinLbl2.ForeColor = AmaneStyling.TextOnURL;
            this.PinLbl2.Location = new System.Drawing.Point(250, 255);
            this.PinLbl2.Name = "PinLbl2";
            this.PinLbl2.Size = new System.Drawing.Size(120, 20);
            this.PinLbl2.TabIndex = 3;
            this.PinLbl2.Text = "quick PIN entry";

            // 
            // pinInput
            // 
            this.pinInput.BackColor = AmaneStyling.InputBg;
            this.pinInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pinInput.Font = new System.Drawing.Font("Cambria", 20F,
                System.Drawing.FontStyle.Bold);
            this.pinInput.ForeColor = AmaneStyling.TextDark;
            this.pinInput.Location = new System.Drawing.Point(120, 305);
            this.pinInput.Name = "pinInput";
            this.pinInput.PasswordChar = '•';
            this.pinInput.ReadOnly = true;
            this.pinInput.Size = new System.Drawing.Size(400, 47);
            this.pinInput.TabIndex = 4;
            this.pinInput.Text = "****";
            this.pinInput.TextAlign =
                System.Windows.Forms.HorizontalAlignment.Center;

            // ==================================
            // BUTTON STYLE
            // ==================================

            // button2 = 1
            this.button2.BackColor = AmaneStyling.InputBg;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.FlatAppearance.BorderSize = 1;
            this.button2.Font = new System.Drawing.Font("Cambria", 18F,
                System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = AmaneStyling.TextDark;
            this.button2.Location = new System.Drawing.Point(170, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 70);
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = false;

            // button1 = 2
            this.button1.BackColor = AmaneStyling.InputBg;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.FlatAppearance.BorderSize = 1;
            this.button1.Font = new System.Drawing.Font("Cambria", 18F,
                System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = AmaneStyling.TextDark;
            this.button1.Location = new System.Drawing.Point(280, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 70);
            this.button1.Text = "2";
            this.button1.UseVisualStyleBackColor = false;

            // button3 = 3
            this.button3.BackColor = AmaneStyling.InputBg;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.FlatAppearance.BorderSize = 1;
            this.button3.Font = new System.Drawing.Font("Cambria", 18F,
                System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = AmaneStyling.TextDark;
            this.button3.Location = new System.Drawing.Point(390, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 70);
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;

            // button4 = 4
            this.button4.BackColor = AmaneStyling.InputBg;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.FlatAppearance.BorderSize = 1;
            this.button4.Font = new System.Drawing.Font("Cambria", 18F,
                System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = AmaneStyling.TextDark;
            this.button4.Location = new System.Drawing.Point(170, 480);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 70);
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;

            // button5 = 5
            this.button5.BackColor = AmaneStyling.InputBg;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.FlatAppearance.BorderSize = 1;
            this.button5.Font = new System.Drawing.Font("Cambria", 18F,
                System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = AmaneStyling.TextDark;
            this.button5.Location = new System.Drawing.Point(280, 480);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 70);
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;

            // button6 = 6
            this.button6.BackColor = AmaneStyling.InputBg;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.FlatAppearance.BorderSize = 1;
            this.button6.Font = new System.Drawing.Font("Cambria", 18F,
                System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = AmaneStyling.TextDark;
            this.button6.Location = new System.Drawing.Point(390, 480);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 70);
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;

            // button7 = 7
            this.button7.BackColor = AmaneStyling.InputBg;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.FlatAppearance.BorderSize = 1;
            this.button7.Font = new System.Drawing.Font("Cambria", 18F,
                System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = AmaneStyling.TextDark;
            this.button7.Location = new System.Drawing.Point(170, 570);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 70);
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;

            // button8 = 8
            this.button8.BackColor = AmaneStyling.InputBg;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.FlatAppearance.BorderSize = 1;
            this.button8.Font = new System.Drawing.Font("Cambria", 18F,
                System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = AmaneStyling.TextDark;
            this.button8.Location = new System.Drawing.Point(280, 570);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 70);
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;

            // button9 = 9
            this.button9.BackColor = AmaneStyling.InputBg;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.FlatAppearance.BorderSize = 1;
            this.button9.Font = new System.Drawing.Font("Cambria", 18F,
                System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = AmaneStyling.TextDark;
            this.button9.Location = new System.Drawing.Point(390, 570);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 70);
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;

            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Cambria", 11F,
                System.Drawing.FontStyle.Bold);
            this.linkLabel2.LinkColor = AmaneStyling.TextOnURL;
            this.linkLabel2.Location = new System.Drawing.Point(185, 680);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(263, 22);
            this.linkLabel2.TabIndex = 18;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "switch to password log in";

            // 
            // ADD CONTROLS
            // 
            this.Controls.Add(this.headerPnl);
            this.Controls.Add(this.pictureBox1);

            this.Controls.Add(this.label1);
            this.Controls.Add(this.PinLbl2);

            this.Controls.Add(this.pinInput);

            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);

            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);

            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);

            this.Controls.Add(this.linkLabel2);

            this.headerPnl.ResumeLayout(false);
            this.headerPnl.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.Label PnlLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PinLbl2;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.MaskedTextBox pinInput;
    }
}
