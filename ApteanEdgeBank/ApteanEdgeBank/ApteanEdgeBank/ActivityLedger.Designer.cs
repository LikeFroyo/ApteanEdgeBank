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
            this.calculateView = new System.Windows.Forms.ListView();
            this.calculate = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
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
            this.activityListLabel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityListLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.activityListLabel.Location = new System.Drawing.Point(985, 19);
            this.activityListLabel.Name = "activityListLabel";
            this.activityListLabel.Size = new System.Drawing.Size(352, 49);
            this.activityListLabel.TabIndex = 2;
            this.activityListLabel.Text = "Activity Ledger";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.activityGrid);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(979, 712);
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
            this.activityGrid.RowHeadersWidth = 65;
            this.activityGrid.RowTemplate.Height = 28;
            this.activityGrid.Size = new System.Drawing.Size(979, 712);
            this.activityGrid.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(985, 81);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(352, 45);
            this.Search.TabIndex = 4;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // calculateView
            // 
            this.calculateView.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateView.HideSelection = false;
            this.calculateView.Location = new System.Drawing.Point(985, 146);
            this.calculateView.Name = "calculateView";
            this.calculateView.Size = new System.Drawing.Size(350, 390);
            this.calculateView.TabIndex = 5;
            this.calculateView.UseCompatibleStateImageBehavior = false;
            this.calculateView.View = System.Windows.Forms.View.Tile;
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(985, 586);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(350, 35);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.balance.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(1087, 645);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(158, 42);
            this.balance.TabIndex = 7;
            this.balance.Text = "balance";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(985, 555);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(350, 25);
            this.progressBar.TabIndex = 8;
            // 
            // ActivityLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.calculateView);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.activityListLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActivityLedger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ListView calculateView;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}