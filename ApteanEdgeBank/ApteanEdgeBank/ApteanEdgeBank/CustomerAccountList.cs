using ApteanEdgeBankDataLayer;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ApteanEdgeBank
{
    public partial class CustomerAccountList : Form
    {
        public CustomerAccountList()
        {
            InitializeComponent();
        }
        CustomerDL customerDL = new CustomerDL();

        private void CustomerAccountList_Load(object sender, EventArgs e)
        {
            this.selectAccount.Visible = false;
            this.Submit.Visible = false;
        }
        
        private void searchAccount_Click(object sender, EventArgs e)
        {
            searchBox.Text = searchBox.Text.Trim();
            if (searchBox.Text.Any(ch => !(Char.IsDigit(ch))))
            {
                MessageBox.Show("Invalid Arguments!!!");
            }
            else
            {
                var customerAccounts = customerDL.GetCustomerAccount(Int64.Parse(searchBox.Text));
                if (customerAccounts.Count() == 0)
                {
                    MessageBox.Show("No Active Customer Accounts Found !!!");
                }
                else
                {
                    this.searchAccount.Enabled = false;
                    this.selectAccount.Visible = true;
                    this.Submit.Visible = true;
                    foreach (var item in customerAccounts)
                    {
                        if (item.AccountType == 1)
                            this.selectAccount.Items.Add("Chequing");
                        else if (item.AccountType == 2)
                            this.selectAccount.Items.Add("Saving");
                        else if (item.AccountType == 3)
                            this.selectAccount.Items.Add("Liability");
                    }
                }
            }
        }

        private string DataOfCustomer()
        {
            var customerAccounts = customerDL.GetCustomerAccount(Int64.Parse(searchBox.Text));
            if (this.selectAccount.SelectedItem.ToString() == "Chequing")
                this.accountType = 1;
            else if (this.selectAccount.SelectedItem.ToString() == "Saving")
                this.accountType = 2;
            else if (this.selectAccount.SelectedItem.ToString() == "Liability")
                this.accountType = 3;

            var search = (from account in customerAccounts where this.accountType == account.AccountType select account).First();
            string dataCustomer = "Account ID      : " + search.AccountId + "\n" +
                                   "Customer ID    : " + search.CustomerId + "\n" +
                                   "Branch ID        : " + search.BranchId + "\n" +
                                   "Account Opened : " + search.AccountOpenedDate + "\n";
            if (search.AccountType == 3)
                dataCustomer += "Load Issued   :" + search.TotalBalance;
            else
                dataCustomer += "Total Balance   :" + search.TotalBalance;
            return dataCustomer;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.DataOfCustomer());
        }

    }
}
