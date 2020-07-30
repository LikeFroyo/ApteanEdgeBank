using ApteanEdgeBankDataLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ApteanEdgeBank
{
    public partial class AccountHandle : Form
    {
        public AccountHandle()
        {
            InitializeComponent();
        }
        AccountDL accountDL = new AccountDL();

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
                if (accountSearch == null)
                {
                    MessageBox.Show("Account Not Found");
                }
                else if (accountSearch.AccountType == 3)
                {
                    MessageBox.Show("Warning!!! Liability Account Can't Be Closed/Reopened");
                }
                else
                {
                    this.mainPanel.Visible = true;
                    this.AccountSearch.Enabled = false;
                    this.Search.Enabled = false;

                    accountBalance.Text = accountSearch.TotalBalance.ToString();
                    if (accountSearch.StatusAccount == true)
                        this.statusComboBox.SelectedIndex = 0;
                    else
                        this.statusComboBox.SelectedIndex = 1;
                }
            }

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            if (statusComboBox.SelectedIndex == 1)
            {
                accountDL.AccountHandle(Int64.Parse(AccountSearch.Text), true);
                MessageBox.Show("Account Opened Successfully!!!");
                this.Close();
            }

            else
            {
                if (double.Parse(accountBalance.Text) > 0)
                {
                    MessageBox.Show("Your Balance isn't Zero, No operation performed");
                    this.Close();
                }
                else
                {
                    accountDL.AccountHandle(Int64.Parse(AccountSearch.Text), false);
                    MessageBox.Show("Account Closed Successfully!!!");
                    this.Close();
                }
            }
        }

        private void AccountHandle_Load(object sender, EventArgs e)
        {
            this.mainPanel.Visible = false;
            this.statusComboBox.Enabled = false;
        }
    }
}
