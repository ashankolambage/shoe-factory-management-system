using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeFactory.Interfaces.Login
{
    public partial class frmCreateAccount : Form
    {
        int i = 0;
        Thread th;
        Classes.Database.dbCon DB = new Classes.Database.dbCon();
        public frmCreateAccount()
        {
            InitializeComponent();

            txtUserType.Text = "Administrator";
            txtEmployeeID.Text = DB.NextID("employeeDetail", "employeeID", "emp");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int em = 0;
                string message = "";

                if (txtEmployeeName.Text.Equals(string.Empty))
                {
                    em++;
                    message += "Employee Name" + '\n';
                }

                if (txtPass.Text.Equals(string.Empty))
                {
                    em++;
                    message += "Password" + '\n';
                }

                if (em != 0)
                {
                    MessageBox.Show("This Fields Can't be Empty" + '\n' + '\n' + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmployeeName.Focus();
                    em = 0;
                }
                else
                {
                    string employeeName = txtEmployeeName.Text;
                    string pass = txtPass.Text;
                    string checkPass = txtCheckPass.Text;

                    if (pass.Equals(checkPass))
                    {
                        int i = 1;
                        string shortDate = DateTime.Now.ToString("dd-MM-yyyy");
                        i = i * DB.WriteDB("insert into employeeDetail values('" + txtEmployeeID.Text + "', null, null, '" + "Admin" + "', '" + shortDate + "', '" + txtEmployeeName.Text + "', '" + "Admin" + "', '" + "Admin" + "', '" + "Admin" + "', '" + 000 + "')");
                        i = i * DB.WriteDB("insert into userAccount values('" + txtEmployeeID.Text + "', '" + txtPass.Text + "', '" + txtUserType.Text + "')");
                        if (i == 1)
                        {
                            MessageBox.Show("Success" + '\n' + "Redirecting to User Login", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            i = 1;
                            closeOpenNew();
                        }
                        else
                        {
                            clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCheckPass.Clear();
                        txtCheckPass.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + '\n' + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                i = 1;
                closeOpenNew();
            }
            else
            {
                txtEmployeeName.Focus();
            }
        }

        private void btnShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            txtCheckPass.UseSystemPasswordChar = false;
        }

        private void btnShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            txtCheckPass.UseSystemPasswordChar = true;
        }

        private void frmCreateAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (i == 0)
            {
                e.Cancel = true;
                DialogResult rs = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    closeOpenNew();
                }
                else
                {
                    txtEmployeeName.Focus();
                }
            }
        }

        private void clear()
        {
            txtEmployeeName.Clear();
            txtPass.Clear();
            txtCheckPass.Clear();
            txtEmployeeName.Focus();
        }

        private void openUserLogin(object ob)
        {
            Application.Run(new frmUserLogin());
        }

        private void closeOpenNew()
        {
            i = 1;
            this.Close();
            th = new Thread(openUserLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
