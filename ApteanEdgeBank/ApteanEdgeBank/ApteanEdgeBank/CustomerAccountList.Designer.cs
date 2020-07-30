namespace ApteanEdgeBank
{
    partial class CustomerAccountList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerAccountList));
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchAccount = new System.Windows.Forms.Button();
            this.selectAccount = new System.Windows.Forms.ComboBox();
            this.customerID = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.accountStatusLabel = new System.Windows.Forms.Label();
            this.accountBalanceLabel = new System.Windows.Forms.Label();
            this.accountIdtextBox = new System.Windows.Forms.TextBox();
            this.accountStatus = new System.Windows.Forms.Label();
            this.accountAmnt = new System.Windows.Forms.Label();
            this.accountID = new System.Windows.Forms.Label();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(300, 363);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(281, 40);
            this.searchBox.TabIndex = 0;
            // 
            // searchAccount
            // 
            this.searchAccount.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAccount.Location = new System.Drawing.Point(235, 423);
            this.searchAccount.Name = "searchAccount";
            this.searchAccount.Size = new System.Drawing.Size(164, 46);
            this.searchAccount.TabIndex = 1;
            this.searchAccount.Text = "Search";
            this.searchAccount.UseVisualStyleBackColor = true;
            this.searchAccount.Click += new System.EventHandler(this.searchAccount_Click);
            // 
            // selectAccount
            // 
            this.selectAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectAccount.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAccount.FormattingEnabled = true;
            this.selectAccount.Location = new System.Drawing.Point(325, 22);
            this.selectAccount.Name = "selectAccount";
            this.selectAccount.Size = new System.Drawing.Size(256, 41);
            this.selectAccount.TabIndex = 5;
            this.selectAccount.SelectedIndexChanged += new System.EventHandler(this.selectAccount_SelectedIndexChanged);
            // 
            // customerID
            // 
            this.customerID.AutoSize = true;
            this.customerID.BackColor = System.Drawing.Color.Transparent;
            this.customerID.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerID.ForeColor = System.Drawing.SystemColors.Window;
            this.customerID.Location = new System.Drawing.Point(84, 366);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(210, 33);
            this.customerID.TabIndex = 6;
            this.customerID.Text = "Customer ID: ";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.warning);
            this.mainPanel.Controls.Add(this.accountStatusLabel);
            this.mainPanel.Controls.Add(this.accountBalanceLabel);
            this.mainPanel.Controls.Add(this.accountIdtextBox);
            this.mainPanel.Controls.Add(this.accountStatus);
            this.mainPanel.Controls.Add(this.accountAmnt);
            this.mainPanel.Controls.Add(this.accountID);
            this.mainPanel.Controls.Add(this.accountTypeLabel);
            this.mainPanel.Controls.Add(this.selectAccount);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 490);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(618, 354);
            this.mainPanel.TabIndex = 7;
            this.mainPanel.Visible = false;
            // 
            // accountStatusLabel
            // 
            this.accountStatusLabel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountStatusLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.accountStatusLabel.Location = new System.Drawing.Point(319, 264);
            this.accountStatusLabel.Name = "accountStatusLabel";
            this.accountStatusLabel.Size = new System.Drawing.Size(262, 33);
            this.accountStatusLabel.TabIndex = 13;
            this.accountStatusLabel.Text = "Account Status";
            // 
            // accountBalanceLabel
            // 
            this.accountBalanceLabel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.accountBalanceLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.accountBalanceLabel.Location = new System.Drawing.Point(319, 188);
            this.accountBalanceLabel.Name = "accountBalanceLabel";
            this.accountBalanceLabel.Size = new System.Drawing.Size(262, 33);
            this.accountBalanceLabel.TabIndex = 11;
            this.accountBalanceLabel.Text = "Account Balance";
            // 
            // accountIdtextBox
            // 
            this.accountIdtextBox.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountIdtextBox.Location = new System.Drawing.Point(325, 105);
            this.accountIdtextBox.Name = "accountIdtextBox";
            this.accountIdtextBox.ReadOnly = true;
            this.accountIdtextBox.Size = new System.Drawing.Size(256, 40);
            this.accountIdtextBox.TabIndex = 10;
            // 
            // accountStatus
            // 
            this.accountStatus.AutoSize = true;
            this.accountStatus.BackColor = System.Drawing.SystemColors.Highlight;
            this.accountStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountStatus.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.accountStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.accountStatus.Location = new System.Drawing.Point(68, 266);
            this.accountStatus.Name = "accountStatus";
            this.accountStatus.Size = new System.Drawing.Size(226, 33);
            this.accountStatus.TabIndex = 9;
            this.accountStatus.Text = "Account Status:";
            // 
            // accountAmnt
            // 
            this.accountAmnt.AutoSize = true;
            this.accountAmnt.BackColor = System.Drawing.SystemColors.Highlight;
            this.accountAmnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountAmnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountAmnt.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountAmnt.ForeColor = System.Drawing.SystemColors.Window;
            this.accountAmnt.Location = new System.Drawing.Point(82, 186);
            this.accountAmnt.Name = "accountAmnt";
            this.accountAmnt.Size = new System.Drawing.Size(212, 35);
            this.accountAmnt.TabIndex = 8;
            this.accountAmnt.Text = "Account Amnt:";
            // 
            // accountID
            // 
            this.accountID.AutoSize = true;
            this.accountID.BackColor = System.Drawing.SystemColors.Highlight;
            this.accountID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountID.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountID.ForeColor = System.Drawing.SystemColors.Window;
            this.accountID.Location = new System.Drawing.Point(82, 105);
            this.accountID.Name = "accountID";
            this.accountID.Size = new System.Drawing.Size(212, 35);
            this.accountID.TabIndex = 7;
            this.accountID.Text = "Account ID  :";
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.accountTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountTypeLabel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.accountTypeLabel.Location = new System.Drawing.Point(82, 22);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(212, 35);
            this.accountTypeLabel.TabIndex = 6;
            this.accountTypeLabel.Text = "Account Type:";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.SystemColors.Window;
            this.warning.Location = new System.Drawing.Point(208, 334);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(191, 20);
            this.warning.TabIndex = 14;
            this.warning.Text = "Select n Copy Account ID";
            // 
            // CustomerAccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(618, 844);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.searchAccount);
            this.Controls.Add(this.searchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerAccountList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerAccountList";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchAccount;
        private System.Windows.Forms.ComboBox selectAccount;
        private int accountType;
        private System.Windows.Forms.Label customerID;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.Label accountStatus;
        private System.Windows.Forms.Label accountAmnt;
        private System.Windows.Forms.Label accountID;
        private System.Windows.Forms.TextBox accountIdtextBox;
        private System.Windows.Forms.Label accountStatusLabel;
        private System.Windows.Forms.Label accountBalanceLabel;
        private System.Windows.Forms.Label warning;
    }
}