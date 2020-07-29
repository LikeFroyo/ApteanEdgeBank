namespace ApteanEdgeBank
{
    partial class AccountManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManage));
            this.accountID = new System.Windows.Forms.Label();
            this.AccountSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.transactionTypeBox = new System.Windows.Forms.ComboBox();
            this.accountType = new System.Windows.Forms.Label();
            this.SelectOption = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.balanceType = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountID
            // 
            this.accountID.AutoSize = true;
            this.accountID.BackColor = System.Drawing.Color.Transparent;
            this.accountID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountID.ForeColor = System.Drawing.SystemColors.Window;
            this.accountID.Location = new System.Drawing.Point(233, 340);
            this.accountID.Name = "accountID";
            this.accountID.Size = new System.Drawing.Size(142, 28);
            this.accountID.TabIndex = 0;
            this.accountID.Text = "Account ID";
            // 
            // AccountSearch
            // 
            this.AccountSearch.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountSearch.Location = new System.Drawing.Point(39, 386);
            this.AccountSearch.Name = "AccountSearch";
            this.AccountSearch.Size = new System.Drawing.Size(248, 31);
            this.AccountSearch.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(329, 386);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(248, 35);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search ";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(181, 167);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(284, 26);
            this.balance.TabIndex = 3;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.totalAmount);
            this.mainPanel.Controls.Add(this.balanceType);
            this.mainPanel.Controls.Add(this.transactionTypeBox);
            this.mainPanel.Controls.Add(this.accountType);
            this.mainPanel.Controls.Add(this.SelectOption);
            this.mainPanel.Controls.Add(this.submit);
            this.mainPanel.Controls.Add(this.balance);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 456);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(618, 268);
            this.mainPanel.TabIndex = 4;
            // 
            // transactionTypeBox
            // 
            this.transactionTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transactionTypeBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionTypeBox.FormattingEnabled = true;
            this.transactionTypeBox.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw"});
            this.transactionTypeBox.Location = new System.Drawing.Point(316, 117);
            this.transactionTypeBox.Name = "transactionTypeBox";
            this.transactionTypeBox.Size = new System.Drawing.Size(248, 31);
            this.transactionTypeBox.TabIndex = 7;
            // 
            // accountType
            // 
            this.accountType.AutoSize = true;
            this.accountType.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountType.Location = new System.Drawing.Point(244, 18);
            this.accountType.Name = "accountType";
            this.accountType.Size = new System.Drawing.Size(131, 23);
            this.accountType.TabIndex = 6;
            this.accountType.Text = "accountType";
            // 
            // SelectOption
            // 
            this.SelectOption.AutoSize = true;
            this.SelectOption.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectOption.Location = new System.Drawing.Point(93, 116);
            this.SelectOption.Name = "SelectOption";
            this.SelectOption.Size = new System.Drawing.Size(194, 28);
            this.SelectOption.TabIndex = 5;
            this.SelectOption.Text = "Select Option:";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(181, 215);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(284, 34);
            this.submit.TabIndex = 4;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // balanceType
            // 
            this.balanceType.AutoSize = true;
            this.balanceType.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceType.Location = new System.Drawing.Point(189, 68);
            this.balanceType.Name = "balanceType";
            this.balanceType.Size = new System.Drawing.Size(98, 23);
            this.balanceType.TabIndex = 8;
            this.balanceType.Text = "Balance:";
            // 
            // totalAmount
            // 
            this.totalAmount.AutoSize = true;
            this.totalAmount.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.Location = new System.Drawing.Point(312, 68);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(131, 23);
            this.totalAmount.TabIndex = 9;
            this.totalAmount.Text = "totalAmount";
            // 
            // AccountManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(618, 724);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.AccountSearch);
            this.Controls.Add(this.accountID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit / Loan Repay";
            this.Load += new System.EventHandler(this.AccountManage_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountID;
        private System.Windows.Forms.TextBox AccountSearch;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label SelectOption;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label accountType;
        private System.Windows.Forms.ComboBox transactionTypeBox;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.Label balanceType;
    }
}