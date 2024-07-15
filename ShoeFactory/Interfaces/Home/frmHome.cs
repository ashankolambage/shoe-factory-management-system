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

namespace ShoeFactory.Interfaces.Home
{
    public partial class frmHome : Form
    {
        int i = 0;
        Thread th;
        string employeeID = "";
        string loginTime = "";
        Classes.Database.dbCon DB = new Classes.Database.dbCon();
        public frmHome()
        {
            InitializeComponent();
        }

        public frmHome(string empID, string logTime)
        {
            InitializeComponent();
            employeeID = empID;
            loginTime = logTime;
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            Login.frmAccountsHome AccountsHome = new Login.frmAccountsHome();
            AccountsHome.TopLevel = false;
            pnlHome.Controls.Add(AccountsHome);
            AccountsHome.Show();
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            HR.frmHRHome HRHome = new HR.frmHRHome();
            HRHome.TopLevel = false;
            pnlHome.Controls.Add(HRHome);
            HRHome.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            Sales.frmCustomerDetails CustomerHome = new Sales.frmCustomerDetails();
            CustomerHome.TopLevel = false;
            pnlHome.Controls.Add(CustomerHome);
            CustomerHome.Show();
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            Production.frmProductionHome ProductionHome = new Production.frmProductionHome();
            ProductionHome.TopLevel = false;
            pnlHome.Controls.Add(ProductionHome);
            ProductionHome.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            Sales.frmSalesHome SalesHome = new Sales.frmSalesHome();
            SalesHome.TopLevel = false;
            pnlHome.Controls.Add(SalesHome);
            SalesHome.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                i = 1;
                logoutRecord();
                this.Close();
                th = new Thread(openUserLogin);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                i = 1;
                logoutRecord();
                Application.Exit();
            }
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (i == 0)
            {
                DialogResult rs = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (rs == DialogResult.OK)
                {
                    logoutRecord();
                }
            }
        }

        private void openUserLogin(object ob)
        {
            Application.Run(new Interfaces.Login.frmUserLogin());
        }

        private void logoutRecord()
        {
            string dateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            System.Diagnostics.Debug.WriteLine(employeeID + "   " + loginTime + "   " + dateTime);
            DB.WriteDB("update loginRecord set logoutTime = '" + dateTime + "' where employeeID ='" + employeeID + "' and loginTime = '" + loginTime + "'");
        }

        private void setHomeData()
        {

        }
    }
}
