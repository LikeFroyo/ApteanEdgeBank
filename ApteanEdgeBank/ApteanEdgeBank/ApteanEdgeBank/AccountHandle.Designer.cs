namespace ApteanEdgeBank
{
    partial class AccountHandle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountHandle));
            this.Search = new System.Windows.Forms.Label();
            this.AccountSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectOption = new System.Windows.Forms.Label();
            this.accountBalance = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.accountId = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(254, 423);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(125, 37);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // AccountSearch
            // 
            this.AccountSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountSearch.Location = new System.Drawing.Point(304, 357);
            this.AccountSearch.Name = "AccountSearch";
            this.AccountSearch.Size = new System.Drawing.Size(245, 36);
            this.AccountSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Balance: ";
            // 
            // selectOption
            // 
            this.selectOption.AutoSize = true;
            this.selectOption.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectOption.Location = new System.Drawing.Point(76, 68);
            this.selectOption.Name = "selectOption";
            this.selectOption.Size = new System.Drawing.Size(207, 28);
            this.selectOption.TabIndex = 3;
            this.selectOption.Text = "Select Option: ";
            // 
            // accountBalance
            // 
            this.accountBalance.AutoSize = true;
            this.accountBalance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountBalance.Location = new System.Drawing.Point(346, 24);
            this.accountBalance.Name = "accountBalance";
            this.accountBalance.Size = new System.Drawing.Size(194, 28);
            this.accountBalance.TabIndex = 4;
            this.accountBalance.Text = "AccountBalance";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(243, 150);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(150, 50);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.statusComboBox);
            this.mainPanel.Controls.Add(this.submitButton);
            this.mainPanel.Controls.Add(this.selectOption);
            this.mainPanel.Controls.Add(this.accountBalance);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 500);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(618, 224);
            this.mainPanel.TabIndex = 7;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Close Account",
            "Open Account"});
            this.statusComboBox.Location = new System.Drawing.Point(351, 71);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(198, 31);
            this.statusComboBox.TabIndex = 7;
            // 
            // accountId
            // 
            this.accountId.AutoSize = true;
            this.accountId.BackColor = System.Drawing.Color.Transparent;
            this.accountId.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountId.ForeColor = System.Drawing.SystemColors.Window;
            this.accountId.Location = new System.Drawing.Point(133, 356);
            this.accountId.Name = "accountId";
            this.accountId.Size = new System.Drawing.Size(150, 33);
            this.accountId.TabIndex = 8;
            this.accountId.Text = "AcountID:";
            // 
            // AccountHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(618, 724);
            this.Controls.Add(this.accountId);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.AccountSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountHandle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Handle";
            this.Load += new System.EventHandler(this.AccountHandle_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox AccountSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label selectOption;
        private System.Windows.Forms.Label accountBalance;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label accountId;
    }
}