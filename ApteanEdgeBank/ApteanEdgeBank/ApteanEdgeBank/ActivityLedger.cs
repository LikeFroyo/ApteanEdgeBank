using ApteanEdgeBankDataLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ApteanEdgeBank
{
    public partial class ActivityLedger : Form
    {
        ActivityDL activityDL = new ActivityDL();
        public ActivityLedger()
        {
            InitializeComponent();
        }

        private void ActivityLedger_Load(object sender, EventArgs e)
        {
            this.Search.Text = "Search AccountID";
            this.activityGrid.DataSource = activityDL.GetAllTheActivity("");
        }

        private void Search_Click(object sender, System.EventArgs e)
        {
            this.Search.Text = "";
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            this.activityGrid.DataSource = activityDL.GetAllTheActivity(this.Search.Text.Trim());
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            var accountID = Int64.Parse(this.Search.Text.Trim());
            if (activityGrid.DataSource != null)
            {
                this.calculateView.Items.Clear();
                string transac = "";
                foreach(var item in activityDL.GetAllTheActivity(this.Search.Text.Trim()))
                {
                    transac = item.ActivityCode ? "Credit : +" : "Debit: -";
                    transac += item.Amount.ToString();
                    this.calculateView.Items.Add(new ListViewItem(transac));
                }
                progressBar.Value = 100;
                this.balance.Text = activityDL.Calculate(accountID).ToString();
            }
        }
    }
}
