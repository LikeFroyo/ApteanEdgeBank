using System;
using System.Windows.Forms;

namespace ApteanEdgeBank
{
    public partial class ApteanEdgeBankServicesExplorer : Form
    {
        public ApteanEdgeBankServicesExplorer()
        {
            InitializeComponent();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            ApteanEdgeBankCustomerExplorer customerPage = new ApteanEdgeBankCustomerExplorer();
            customerPage.Show();
        }

        private void bankButton_Click(object sender, EventArgs e)
        {
            ApteanEdgeBankAccountExplorer apteanEdgeBankAccountExplorer = new ApteanEdgeBankAccountExplorer();
            apteanEdgeBankAccountExplorer.Show();
        }
    }
}
