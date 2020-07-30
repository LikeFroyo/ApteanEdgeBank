using System;
using System.Windows.Forms;

namespace ApteanEdgeBank
{
    public partial class ApteanEdgeBankCustomerExplorer : Form
    {
        public ApteanEdgeBankCustomerExplorer()
        {
            InitializeComponent();
        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            CustomerList customerList = new CustomerList();
            customerList.ShowDialog();
        }

        private void AccountList_Click(object sender, EventArgs e)
        {
            CustomerAccountList customerAccountList = new CustomerAccountList();
            customerAccountList.ShowDialog();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            CustomerAddition addCustomer = new CustomerAddition();
            addCustomer.ShowDialog();
        }

        private void ReadCustomer_Click(object sender, EventArgs e)
        {
            CustomerUpdate updateCustomer = new CustomerUpdate();
            updateCustomer.ShowDialog();
        }

        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            CustomerUpdate updateCustomer = new CustomerUpdate();
            updateCustomer.ShowDialog();
        }
    }
}
