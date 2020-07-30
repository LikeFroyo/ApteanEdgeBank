using ApteanEdgeBankDataLayer;
using System;
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
    }
}
