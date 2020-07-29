using ApteanEdgeBankDataLayer;
using System;
using System.Windows.Forms;

namespace ApteanEdgeBank
{
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
        }

        CustomerDL customerDL = new CustomerDL();
        private void CustomerList_Load(object sender, EventArgs e)
        {
            this.Search.Text = "Search Name";
            this.CustomerListView.DataSource = customerDL.GetAllCustomer("");
        }
        private void Search_TextChanged(object sender, EventArgs e)
        {
            this.CustomerListView.DataSource = customerDL.GetAllCustomer(this.Search.Text.Trim());
        }
        private void Search_Click(object sender, System.EventArgs e)
        {
            this.Search.Text = "";
        }
    }
}
