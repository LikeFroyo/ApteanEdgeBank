using ApteanEdgeBankDataLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ApteanEdgeBank
{
    public partial class CustomerAddition : Form
    {
        public CustomerAddition()
        {
            InitializeComponent();
        }

        CustomerDL customerDL = new CustomerDL();
        private void submitButton_Click(object sender, EventArgs e)
        {
            customerNameTextBox.Text = customerNameTextBox.Text.Trim();
            if (customerNameTextBox.Text == "" || customerNameTextBox.Text.Any(ch => !(Char.IsLetter(ch) || char.IsWhiteSpace(ch))))
            {
                MessageBox.Show("Invalid Arguments!!!");
            }
            else if (customerDL.AddCustomer(customerNameTextBox.Text, dateOpenedPicker.Value, branchComboBox.SelectedIndex + 1))
            {
                MessageBox.Show("SUCCESSFULLY ADDED!!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("DataBase Connection Issue"); 
                this.Close();
            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            customerIdentityLabel.Text = customerDL.GetNewCustomerId().ToString();
            branchComboBox.SelectedIndex = 0;
        }
    }
}
