using ApteanEdgeBankDataLayer;
using System;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
                    this.searchBox.Enabled = false;
                    this.mainPanel.Visible = true;
                    foreach (var item in customerAccounts)
                    {
                        if (item.AccountType == 1)
                            this.selectAccount.Items.Add("Chequing");
                        else if (item.AccountType == 2)
                            this.selectAccount.Items.Add("Saving");
                        else if (item.AccountType == 3)
                            this.selectAccount.Items.Add("Liability");
                    }
                    this.selectAccount.SelectedIndex = 0;
                }
            }
        }

        private void DataOfCustomer()
        {
            var customerAccounts = customerDL.GetCustomerAccount(Int64.Parse(searchBox.Text));
            if (this.selectAccount.SelectedItem.ToString() == "Chequing")
                this.accountType = 1;
            else if (this.selectAccount.SelectedItem.ToString() == "Saving")
                this.accountType = 2;
            else if (this.selectAccount.SelectedItem.ToString() == "Liability")
                this.accountType = 3;


            var search = (from account in customerAccounts where this.accountType == account.AccountType select account).First();
            this.accountIdtextBox.Text = search.AccountId.ToString();
            this.accountBalanceLabel.Text = search.TotalBalance.ToString();
            this.accountStatusLabel.Text = ((search.StatusAccount == true) ? "Opened" : "Closed");
        }

        private void selectAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataOfCustomer();
        }
    }
}
