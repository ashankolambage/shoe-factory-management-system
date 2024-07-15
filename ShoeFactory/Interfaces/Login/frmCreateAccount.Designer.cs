
namespace ShoeFactory.Interfaces.Login
{
    partial class frmCreateAccount
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
            this.btnShowPass = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.txtCheckPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowPass
            // 
            this.btnShowPass.Location = new System.Drawing.Point(383, 181);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(23, 31);
            this.btnShowPass.TabIndex = 23;
            this.btnShowPass.Text = "#";
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPass_MouseDown);
            this.btnShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPass_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(57, 286);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 37);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(196, 286);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 37);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(338, 286);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(123, 37);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "User Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter Password Again :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pasword :";
            // 
            // txtUserType
            // 
            this.txtUserType.Enabled = false;
            this.txtUserType.Location = new System.Drawing.Point(161, 237);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(204, 20);
            this.txtUserType.TabIndex = 16;
            // 
            // txtCheckPass
            // 
            this.txtCheckPass.Location = new System.Drawing.Point(161, 187);
            this.txtCheckPass.Name = "txtCheckPass";
            this.txtCheckPass.Size = new System.Drawing.Size(204, 20);
            this.txtCheckPass.TabIndex = 15;
            this.txtCheckPass.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(161, 139);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(204, 20);
            this.txtPass.TabIndex = 13;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(161, 88);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(204, 20);
            this.txtEmployeeName.TabIndex = 11;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.Location = new System.Drawing.Point(161, 26);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(204, 20);
            this.txtEmployeeID.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(33, 91);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 13);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Employee Name :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(33, 29);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(73, 13);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "Employee ID :";
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.txtCheckPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Name = "frmCreateAccount";
            this.Text = "frmCreateAccount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCreateAccount_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserType;
        private System.Windows.Forms.TextBox txtCheckPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
    }
}