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
    public partial class frmUserLogin : Form
    {
        int i = 0;
        Thread th;
        string dateTime = "";
        string employeeID = "";
        Classes.Database.dbCon DB = new Classes.Database.dbCon();

        public frmUserLogin()
        {
            InitializeComponent();
            btnCreate.Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            int em = 0;
            string message = "";

            if (txtEmployeeID.Text.Equals(string.Empty))
            {
                em++;
                message += "User Name" + '\n';
            }

            if (txtPassword.Text.Equals(string.Empty))
            {
                em++;
                message += "Password" + '\n';
            }

            if (em != 0)
            {
                MessageBox.Show("This Fields Can't be Empty" + '\n' + '\n' + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                em = 0;
            }
            else
            {
                try
                {
                    string userName = txtEmployeeID.Text;
                    string pass = txtPassword.Text;
                    DataTable dt = DB.ReadDB("select * from userAccount where employeeID ='" + userName + "'");

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Incorrect User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmployeeID.Clear();
                        txtEmployeeID.Focus();
                    }
                    else
                    {
                        if (pass.Equals(dt.Rows[0][1].ToString()))
                        {
                            MessageBox.Show("Login Success");

                            int ii = 1;
                            dateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                            employeeID = txtEmployeeID.Text;
                            ii = ii * DB.WriteDB("insert into loginRecord values('" + txtEmployeeID.Text + "', '" + dateTime + "', null)");

                            if (ii == 1)
                            {
                                i = 1;
                                this.Close();
                                th = new Thread(openHome);
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Clear();
                            txtPassword.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + '\n' + ex.Message);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                i = 1;
                Application.Exit();
            }
            else
            {
                txtEmployeeID.Focus();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            i = 1;
            this.Close();
            th = new Thread(openCreateAccount);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void frmUserLogin_Load(object sender, EventArgs e)
        {
            DataTable dt = DB.ReadDB("select * from userAccount");
            if (dt.Rows.Count == 0)
            {
                btnSignIn.Visible = false;
                btnCreate.Visible = true;
            }
        }

        private void frmUserLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (i == 0)
            {
                DialogResult rs = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    txtEmployeeID.Focus();
                }
            }
        }

        private void openCreateAccount(object ob)
        {
            Application.Run(new frmCreateAccount());
            i = 0;
        }

        private void openHome(object ob)
        {
            Application.Run(new Home.frmHome(employeeID, dateTime));
            i = 0;
        }
    }
}
