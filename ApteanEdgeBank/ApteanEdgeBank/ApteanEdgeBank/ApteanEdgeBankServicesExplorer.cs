using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
