using System;
using System.Windows.Forms;

namespace ApteanEdgeBank
{
    public partial class ApteanEdgeBankAccountExplorer : Form
    {
        public ApteanEdgeBankAccountExplorer()
        {
            InitializeComponent();
        }

        private void readAccount_Click(object sender, EventArgs e)
        {
            CustomerAccountList customerAccountList = new CustomerAccountList();
            customerAccountList.ShowDialog();
        }

        private void openAccount_Click(object sender, EventArgs e)
        {
            AccountAddition addAccount = new AccountAddition();
            addAccount.ShowDialog();
        }


        private void accountHandle_Click(object sender, EventArgs e)
        {
            AccountHandle accountHandle = new AccountHandle();
            accountHandle.ShowDialog();
        }

        private void accountManage_Click(object sender, EventArgs e)
        {
            AccountManage addAmount = new AccountManage();
            addAmount.ShowDialog();
        }

    }
}
