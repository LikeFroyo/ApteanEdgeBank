using System;
using ApteanEdgeBankDataLayer;
using System.Windows.Forms;

namespace ApteanEdgeBank
{
    public partial class ActivityLedger : Form
    {
        ActivityDL activityDL = new ActivityDL();
        public ActivityLedger()
        {
            this.Search.Text = "Search AccountID";
            InitializeComponent();
        }

        private void ActivityLedger_Load(object sender, EventArgs e)
        {
            this.activityGrid.DataSource = activityDL.GetAllTheActivity("");
        }

        private void Search_Click(object sender, System.EventArgs e)
        {
            this.Search.Text = "";
        }
    }
}
