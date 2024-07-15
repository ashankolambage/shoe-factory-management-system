
namespace ShoeFactory.Interfaces.Home
{
    partial class frmHome
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnProduction = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlHome);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnSales);
            this.panel1.Controls.Add(this.btnProduction);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnHR);
            this.panel1.Controls.Add(this.btnAccounts);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 686);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1237, 71);
            this.panel3.TabIndex = 12;
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlHome.Location = new System.Drawing.Point(124, 80);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1111, 598);
            this.pnlHome.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(11, 560);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(11, 514);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(107, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(11, 374);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(107, 40);
            this.btnSales.TabIndex = 5;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnProduction
            // 
            this.btnProduction.Location = new System.Drawing.Point(11, 314);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(107, 40);
            this.btnProduction.TabIndex = 6;
            this.btnProduction.Text = "Production";
            this.btnProduction.UseVisualStyleBackColor = true;
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(11, 248);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(107, 40);
            this.btnCustomers.TabIndex = 8;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnHR
            // 
            this.btnHR.Location = new System.Drawing.Point(11, 187);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(107, 40);
            this.btnHR.TabIndex = 9;
            this.btnHR.Text = "HR";
            this.btnHR.UseVisualStyleBackColor = true;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Location = new System.Drawing.Point(11, 132);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(107, 40);
            this.btnAccounts.TabIndex = 10;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 687);
            this.Controls.Add(this.panel1);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Button btnAccounts;
    }
}