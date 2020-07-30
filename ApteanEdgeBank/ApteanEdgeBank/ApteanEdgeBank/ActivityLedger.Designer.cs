namespace ApteanEdgeBank
{
    partial class ActivityLedger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityLedger));
            this.activityListLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.activityGrid = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // activityListLabel
            // 
            this.activityListLabel.AutoSize = true;
            this.activityListLabel.BackColor = System.Drawing.Color.Transparent;
            this.activityListLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.activityListLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.activityListLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityListLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.activityListLabel.Location = new System.Drawing.Point(916, 9);
            this.activityListLabel.Name = "activityListLabel";
            this.activityListLabel.Size = new System.Drawing.Size(416, 58);
            this.activityListLabel.TabIndex = 2;
            this.activityListLabel.Text = "Activity Ledger";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.activityGrid);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(910, 712);
            this.mainPanel.TabIndex = 3;
            // 
            // activityGrid
            // 
            this.activityGrid.AllowUserToAddRows = false;
            this.activityGrid.AllowUserToDeleteRows = false;
            this.activityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityGrid.Location = new System.Drawing.Point(0, 0);
            this.activityGrid.Name = "activityGrid";
            this.activityGrid.ReadOnly = true;
            this.activityGrid.RowHeadersWidth = 62;
            this.activityGrid.RowTemplate.Height = 28;
            this.activityGrid.Size = new System.Drawing.Size(910, 712);
            this.activityGrid.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(966, 91);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(322, 45);
            this.Search.TabIndex = 4;
            // 
            // ActivityLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.activityListLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActivityLedger";
            this.Text = "ActivityLedger";
            this.Load += new System.EventHandler(this.ActivityLedger_Load);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activityGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label activityListLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView activityGrid;
        private System.Windows.Forms.TextBox Search;
    }
}