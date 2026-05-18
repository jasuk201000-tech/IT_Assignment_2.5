using System;
using System.ComponentModel;
using System.Windows.Forms;
using AmanePOSHelpers;
using IT_Assignment_2.Helpers;
using IT_Assessment_2.CSVs;

namespace IT_Assessment_2.Forms
{
    partial class LoginForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoBtn = new System.Windows.Forms.Button();
            this.pnlLoginContainer = new System.Windows.Forms.Panel();
            this.pINControl1 = new IT_Assessment_2.Forms.PINControl1();
            this.passwordControl1 = new IT_Assessment_2.Forms.PasswordControl1();
            this.panel1.SuspendLayout();
            this.pnlLoginContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.LogoBtn);
            this.panel1.Location = new System.Drawing.Point(-62, -21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2190, 129);
            this.panel1.TabIndex = 0;
            // 
            // LogoBtn
            // 
            this.LogoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.LogoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LogoBtn.Location = new System.Drawing.Point(97, 43);
            this.LogoBtn.Name = "LogoBtn";
            this.LogoBtn.Size = new System.Drawing.Size(217, 74);
            this.LogoBtn.TabIndex = 0;
            this.LogoBtn.Text = "𝖆𝖒𝖆𝖓𝖊";
            this.LogoBtn.UseVisualStyleBackColor = false;
            // 
            // pnlLoginContainer
            // 
            this.pnlLoginContainer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlLoginContainer.Controls.Add(this.pINControl1);
            this.pnlLoginContainer.Controls.Add(this.passwordControl1);
            this.pnlLoginContainer.Location = new System.Drawing.Point(732, 218);
            this.pnlLoginContainer.Name = "pnlLoginContainer";
            this.pnlLoginContainer.Size = new System.Drawing.Size(648, 743);
            this.pnlLoginContainer.TabIndex = 1;
            // 
            // pINControl1
            // 
            this.pINControl1.BackColor = System.Drawing.Color.White;
            this.pINControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pINControl1.Location = new System.Drawing.Point(0, 0);
            this.pINControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pINControl1.Name = "pINControl1";
            this.pINControl1.Size = new System.Drawing.Size(648, 743);
            this.pINControl1.TabIndex = 1;
            this.pINControl1.Visible = false;
            // 
            // passwordControl1
            // 
            this.passwordControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordControl1.Location = new System.Drawing.Point(0, 0);
            this.passwordControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordControl1.Name = "passwordControl1";
            this.passwordControl1.Size = new System.Drawing.Size(648, 743);
            this.passwordControl1.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2108, 1077);
            this.Controls.Add(this.pnlLoginContainer);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.RightToLeftLayout = true;
            this.Text = "Log";
            this.panel1.ResumeLayout(false);
            this.pnlLoginContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel pnlLoginContainer;
        private Button LogoBtn;
        private PasswordControl1 passwordControl1;
        private PINControl1 pINControl1;
    }
}