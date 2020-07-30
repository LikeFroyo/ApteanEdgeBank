using ApteanEdgeBankDataLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ApteanEdgeBank
{
    public partial class AccountManage : Form
    {
        public AccountManage()
        {
            InitializeComponent();
        }

        private void AccountManage_Load(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
        }
        AccountDL accountDL = new AccountDL();
        BranchDL branchDL = new BranchDL();

        private void Search_Click(object sender, EventArgs e)
        {
            AccountSearch.Text = AccountSearch.Text.Trim();
            if (AccountSearch.Text.Any(ch => !char.IsDigit(ch)))
            {
                MessageBox.Show("Invalid Arguments!!!");
            }
            else
            {
                var accountSearch = accountDL.GetAccountDetail(Int64.Parse(AccountSearch.Text));
                if (accountSearch == null || accountSearch.StatusAccount == false)
                {
                    MessageBox.Show("Account Is Either Closed/Not Found");
                }
                else
                {
                    this.totalAmount.Text = accountSearch.TotalBalance.ToString();
                    this.mainPanel.Visible = true;
                    this.AccountSearch.Enabled = false;
                    this.Search.Enabled = false;

                    if (accountSearch.AccountType == 1)
                        accountType.Text = "Chequing Account";
                    else if (accountSearch.AccountType == 2)
                        accountType.Text = "Saving Account";
                    else if (accountSearch.AccountType == 3)
                    {
                        accountType.Text = "Liability Account";
                        this.balanceType.Text = "In Debt:";
                        transactionTypeBox.Items.Clear();
                        transactionTypeBox.Items.AddRange(new object[] { "Repay Loan", "Issue Loan" });
                    }
                    this.transactionTypeBox.SelectedIndex = 0;
                }
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            double amount;
            var account = accountDL.GetAccountDetail(Int64.Parse(AccountSearch.Text));
            if (!double.TryParse(balance.Text, out amount))
            {
                MessageBox.Show("Invalid Arguements");
            }

            if (transactionTypeBox.SelectedIndex == 0)
            {
                if (account.AccountType == 1)
                {
                    accountDL.AccountCreditOrWithdraw(account.AccountId, amount);
                    MessageBox.Show("Account Credited Successfully");
                }
                else if (account.AccountType == 2)
                {
                    if (account.TotalBalance + amount > 5000)
                        MessageBox.Show("Exceeding Bank Limit");
                    else
                    {
                        accountDL.AccountCreditOrWithdraw(account.AccountId, amount);
                        MessageBox.Show("Account Credited Successfully");
                    }
                }
                else
                {
                    double interest = amount * 0.1;
                    if (account.TotalBalance - (amount - interest) >= 0)
                    {
                        accountDL.Repay(account.AccountId, amount);
                        MessageBox.Show("Loan Repayed!!");
                    }
                    else
                        MessageBox.Show("Exceeding Bank Limit");
                }
            }

            else if (branchDL.GetBranchTotalBalance(account.BranchId) - amount >= 0)
            {
                if (account.AccountType == 3)
                {
                    accountDL.Issue(account.AccountId, amount);
                    MessageBox.Show("Loan Issued!!!");
                }
                else if (account.TotalBalance - amount >= 0)
                {
                    accountDL.AccountCreditOrWithdraw(account.AccountId, -amount);
                    MessageBox.Show("Withdrawn Complete!!!");

                }
                else
                {
                    MessageBox.Show("Insufficient Balance In Account!!!");
                }
            }
            else
            {
                MessageBox.Show("Insufficient Balance In Branch!!!");
            }

            account = accountDL.GetAccountDetail(Int64.Parse(AccountSearch.Text));
            this.totalAmount.Text = account.TotalBalance.ToString();
        }
    }
}
