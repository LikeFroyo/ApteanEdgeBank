using ApteanEdgeBankDataLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ApteanEdgeBank
{
    public partial class AccountAddition : Form
    {
        public AccountAddition()
        {
            InitializeComponent();
        }

        AccountDL accountDL = new AccountDL();
        CustomerDL customerDL = new CustomerDL();


        private void AddAccount_Load(object sender, EventArgs e)
        {
            this.MainPanel.Visible = false;
            this.branchIDcomboBox.Enabled = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            customerIdSearch.Text = customerIdSearch.Text.Trim();
            if (customerIdSearch.Text.Any(ch => !char.IsDigit(ch)))
            {
                MessageBox.Show("Invalid Arguments!!!");
            }
            else
            {
                var customerReturned = customerDL.GetCustomerDetail(Int64.Parse(customerIdSearch.Text));
                if (customerReturned == null)
                {
                    MessageBox.Show("No user Found !!!");
                }
                else
                {
                    this.MainPanel.Visible = true;
                    accountIdGenerated.Text = accountDL.GetNewAccountId().ToString();
                    var customerAccounts = customerDL.GetCustomerAccount(Int64.Parse(customerIdSearch.Text));
                    if (customerAccounts.Count() == 3)
                    {
                        MessageBox.Show("You Cannot Open More Accounts");
                        this.Close();
                    }
                    else
                    {
                        this.branchIDcomboBox.SelectedIndex = customerReturned.customerBranchId - 1;
                        this.searchButton.Enabled = false;
                        this.customerIdSearch.Enabled = false;

                        foreach (var item in customerAccounts)
                        {
                            if (item.AccountType == 1)
                                this.accountTypeComboBox.Items.Remove("Chequing Account");
                            if (item.AccountType == 2)
                                this.accountTypeComboBox.Items.Remove("Saving Account");
                            if (item.AccountType == 3)
                                this.accountTypeComboBox.Items.Remove("Liability Account");
                        }
                        this.accountTypeComboBox.SelectedIndex = 0;
                    }
                }
            }

        }



        private void submit_Click(object sender, EventArgs e)
        {
            int accountType = 0;

            if (this.accountTypeComboBox.SelectedItem.ToString() == "Chequing Account")
                accountType = 1;
            else if (this.accountTypeComboBox.SelectedItem.ToString() == "Saving Account")
                accountType = 2;
            else if (this.accountTypeComboBox.SelectedItem.ToString() == "Liability Account")
                accountType = 3;

            if (accountDL.AddAccount(Int64.Parse(this.customerIdSearch.Text), this.dateOpenedPicker.Value, this.branchIDcomboBox.SelectedIndex + 1, accountType))
            {
                MessageBox.Show("Account Opened Successfully!!!");
            }
            else
            {
                MessageBox.Show("Database Connection Issue");
            }
            this.Close();
        }
    }
}
