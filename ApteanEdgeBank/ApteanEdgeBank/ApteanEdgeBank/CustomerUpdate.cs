using System;
using System.Linq;
using System.Windows.Forms;
using ApteanEdgeBankDataLayer;

namespace ApteanEdgeBank
{
    public partial class CustomerUpdate : Form
    {
        public CustomerUpdate()
        {
            InitializeComponent();
        }
        CustomerDL customerDL = new CustomerDL();

        private void Search_Click(object sender, EventArgs e)
        {
            customerSearchTextBox.Text = customerSearchTextBox.Text.Trim();
            if (customerSearchTextBox.Text.Any(ch => !char.IsDigit(ch)))
            {
                MessageBox.Show("Invalid Arguments!!!");
            }
            else 
            {
                var customerReturned = customerDL.GetCustomerDetail(Int64.Parse(customerSearchTextBox.Text));
                if (customerReturned == null)
                {
                    MessageBox.Show("No user Found !!!");
                }
                else
                {
                    this.search.Enabled = false;
                    this.customerSearchTextBox.Enabled = false;

                    this.customerNameTextBox.Text = customerReturned.CustomerName;
                    this.DateJoinedPicker.Value = customerReturned.DateOpened;
                    this.BranchComboBox.SelectedIndex = customerReturned.customerBranchId - 1;
                }
            }   
        }

        public void Update_mode(bool status)
        {
            this.update.Visible = status;
            this.customerNameTextBox.Enabled = status;
            this.DateJoinedPicker.Enabled = status;
            this.BranchComboBox.Enabled = status;
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            string customerName = customerNameTextBox.Text.Trim();
            if (customerName == "" || customerName.Any(ch => !(Char.IsLetter(ch) || char.IsWhiteSpace(ch))))
            {
                MessageBox.Show("Invalid Arguments!!!");
            }
            else if (customerDL.UpdateCustomer(Int64.Parse(customerSearchTextBox.Text), customerName, DateJoinedPicker.Value, BranchComboBox.SelectedIndex + 1))
            {
                MessageBox.Show("SUCCESSFULLY Updated!!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("DataBase Connection Issue");
                this.Close();
            }
        }

        private void CustomerUpdate_Load_1(object sender, EventArgs e)
        {
            this.Update_mode(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Update_mode(true);
            this.checkUpdate.Visible = false;
        }
    }
}
