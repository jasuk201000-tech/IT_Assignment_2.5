using System;
using System.ComponentModel;
using System.Windows.Forms;

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
            this.pnlLoginContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-62, -21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2190, 129);
            this.panel1.TabIndex = 0;
            // 
            // pnlLoginContainer
            // 
            this.pnlLoginContainer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlLoginContainer.Location = new System.Drawing.Point(732, 218);
            this.pnlLoginContainer.Name = "pnlLoginContainer";
            this.pnlLoginContainer.Size = new System.Drawing.Size(648, 743);
            this.pnlLoginContainer.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2129, 1176);
            this.Controls.Add(this.pnlLoginContainer);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Log";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel pnlLoginContainer;
    }
}