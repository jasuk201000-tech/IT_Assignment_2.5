using System;
using AmanePOSHelpers;
using IT_Assignment_2.Helpers;

namespace IT_Assessment_2.Forms
{
    partial class PasswordControl1
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

        /// <summary> 
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordControl1));
            this.headerPnl = new System.Windows.Forms.Panel();
            this.PnlLabel1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PromptLbl1 = new System.Windows.Forms.Label();
            this.PromptLbl2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.forgotPasswordLbl = new System.Windows.Forms.LinkLabel();
            this.newstaffLbl = new System.Windows.Forms.LinkLabel();
            this.headerPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPnl
            // 
            this.headerPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.headerPnl.Controls.Add(this.PnlLabel1);
            this.headerPnl.Location = new System.Drawing.Point(0, 0);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(648, 80);
            this.headerPnl.TabIndex = 0;
            // 
            // PnlLabel1
            // 
            this.PnlLabel1.AutoSize = true;
            this.PnlLabel1.Font = new System.Drawing.Font("Cambria", 15F);
            this.PnlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PnlLabel1.Location = new System.Drawing.Point(152, 16);
            this.PnlLabel1.Name = "PnlLabel1";
            this.PnlLabel1.Size = new System.Drawing.Size(333, 47);
            this.PnlLabel1.TabIndex = 0;
            this.PnlLabel1.Text = "amane staff portal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PromptLbl1
            // 
            this.PromptLbl1.AutoSize = true;
            this.PromptLbl1.Font = new System.Drawing.Font("Cambria", 10F);
            this.PromptLbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.PromptLbl1.Location = new System.Drawing.Point(47, 215);
            this.PromptLbl1.Name = "PromptLbl1";
            this.PromptLbl1.Size = new System.Drawing.Size(350, 32);
            this.PromptLbl1.TabIndex = 2;
            this.PromptLbl1.Text = "please enter email/username";
            // 
            // PromptLbl2
            // 
            this.PromptLbl2.AutoSize = true;
            this.PromptLbl2.Font = new System.Drawing.Font("Cambria", 10F);
            this.PromptLbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.PromptLbl2.Location = new System.Drawing.Point(47, 335);
            this.PromptLbl2.Name = "PromptLbl2";
            this.PromptLbl2.Size = new System.Drawing.Size(273, 32);
            this.PromptLbl2.TabIndex = 3;
            this.PromptLbl2.Text = "please enter password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Cambria", 14F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPassword.Location = new System.Drawing.Point(47, 370);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(541, 51);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtUsername.Location = new System.Drawing.Point(47, 250);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(541, 39);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "staff@amane.com";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 10F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(53, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 66);
            this.button1.TabIndex = 7;
            this.button1.Text = "log in";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 10F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(371, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 66);
            this.button2.TabIndex = 8;
            this.button2.Text = "PIN Log in";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // forgotPasswordLbl
            // 
            this.forgotPasswordLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.forgotPasswordLbl.AutoSize = true;
            this.forgotPasswordLbl.Font = new System.Drawing.Font("Cambria", 10F);
            this.forgotPasswordLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.forgotPasswordLbl.Location = new System.Drawing.Point(41, 436);
            this.forgotPasswordLbl.Name = "forgotPasswordLbl";
            this.forgotPasswordLbl.Size = new System.Drawing.Size(250, 32);
            this.forgotPasswordLbl.TabIndex = 6;
            this.forgotPasswordLbl.TabStop = true;
            this.forgotPasswordLbl.Text = "forgotten password?";
            // 
            // newstaffLbl
            // 
            this.newstaffLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.newstaffLbl.AutoSize = true;
            this.newstaffLbl.Font = new System.Drawing.Font("Cambria", 11F);
            this.newstaffLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.newstaffLbl.Location = new System.Drawing.Point(147, 657);
            this.newstaffLbl.Name = "newstaffLbl";
            this.newstaffLbl.Size = new System.Drawing.Size(338, 36);
            this.newstaffLbl.TabIndex = 9;
            this.newstaffLbl.TabStop = true;
            this.newstaffLbl.Text = "new staff? contact admin";
            // 
            // PasswordControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.headerPnl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PromptLbl1);
            this.Controls.Add(this.PromptLbl2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.forgotPasswordLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.newstaffLbl);
            this.Name = "PasswordControl1";
            this.Size = new System.Drawing.Size(648, 743);
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
        private System.Windows.Forms.Label PromptLbl1;
        private System.Windows.Forms.Label PromptLbl2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.MaskedTextBox txtUsername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel forgotPasswordLbl;
        private System.Windows.Forms.LinkLabel newstaffLbl;
    }
}