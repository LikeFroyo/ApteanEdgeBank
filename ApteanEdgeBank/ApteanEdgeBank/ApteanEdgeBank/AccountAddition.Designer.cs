namespace ApteanEdgeBank
{
    partial class AccountAddition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountAddition));
            this.customerID = new System.Windows.Forms.Label();
            this.customerIdSearch = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.accountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.accountIdGenerated = new System.Windows.Forms.Label();
            this.AccountID = new System.Windows.Forms.Label();
            this.branchID = new System.Windows.Forms.Label();
            this.dateOpened = new System.Windows.Forms.Label();
            this.dateOpenedPicker = new System.Windows.Forms.DateTimePicker();
            this.accountType = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.branchIDcomboBox = new System.Windows.Forms.ComboBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerID
            // 
            this.customerID.AutoSize = true;
            this.customerID.BackColor = System.Drawing.Color.Transparent;
            this.customerID.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerID.ForeColor = System.Drawing.SystemColors.Window;
            this.customerID.Location = new System.Drawing.Point(111, 345);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(210, 33);
            this.customerID.TabIndex = 0;
            this.customerID.Text = "Customer ID: ";
            // 
            // customerIdSearch
            // 
            this.customerIdSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdSearch.Location = new System.Drawing.Point(339, 346);
            this.customerIdSearch.Name = "customerIdSearch";
            this.customerIdSearch.Size = new System.Drawing.Size(237, 36);
            this.customerIdSearch.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(246, 397);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(125, 40);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // accountTypeComboBox
            // 
            this.accountTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountTypeComboBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Items.AddRange(new object[] {
            "Chequing Account",
            "Saving Account",
            "Liability Account"});
            this.accountTypeComboBox.Location = new System.Drawing.Point(339, 106);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(237, 36);
            this.accountTypeComboBox.TabIndex = 3;
            // 
            // accountIdGenerated
            // 
            this.accountIdGenerated.AutoSize = true;
            this.accountIdGenerated.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountIdGenerated.Location = new System.Drawing.Point(334, 43);
            this.accountIdGenerated.Name = "accountIdGenerated";
            this.accountIdGenerated.Size = new System.Drawing.Size(246, 28);
            this.accountIdGenerated.TabIndex = 4;
            this.accountIdGenerated.Text = "accountIdGenerated";
            // 
            // AccountID
            // 
            this.AccountID.AutoSize = true;
            this.AccountID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountID.Location = new System.Drawing.Point(112, 43);
            this.AccountID.Name = "AccountID";
            this.AccountID.Size = new System.Drawing.Size(155, 28);
            this.AccountID.TabIndex = 5;
            this.AccountID.Text = "Account ID:";
            // 
            // branchID
            // 
            this.branchID.AutoSize = true;
            this.branchID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchID.Location = new System.Drawing.Point(112, 173);
            this.branchID.Name = "branchID";
            this.branchID.Size = new System.Drawing.Size(142, 28);
            this.branchID.TabIndex = 6;
            this.branchID.Text = "BranchID: ";
            // 
            // dateOpened
            // 
            this.dateOpened.AutoSize = true;
            this.dateOpened.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOpened.Location = new System.Drawing.Point(112, 250);
            this.dateOpened.Name = "dateOpened";
            this.dateOpened.Size = new System.Drawing.Size(168, 28);
            this.dateOpened.TabIndex = 7;
            this.dateOpened.Text = "Date Opened:";
            // 
            // dateOpenedPicker
            // 
            this.dateOpenedPicker.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOpenedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOpenedPicker.Location = new System.Drawing.Point(339, 244);
            this.dateOpenedPicker.Name = "dateOpenedPicker";
            this.dateOpenedPicker.Size = new System.Drawing.Size(237, 36);
            this.dateOpenedPicker.TabIndex = 8;
            // 
            // accountType
            // 
            this.accountType.AutoSize = true;
            this.accountType.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountType.Location = new System.Drawing.Point(112, 109);
            this.accountType.Name = "accountType";
            this.accountType.Size = new System.Drawing.Size(181, 28);
            this.accountType.TabIndex = 9;
            this.accountType.Text = "Account Type:";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.submit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(217, 309);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(200, 50);
            this.submit.TabIndex = 11;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // branchIDcomboBox
            // 
            this.branchIDcomboBox.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchIDcomboBox.FormattingEnabled = true;
            this.branchIDcomboBox.Items.AddRange(new object[] {
            "Branch 1",
            "Branch 2",
            "Branch 3",
            "Branch 4"});
            this.branchIDcomboBox.Location = new System.Drawing.Point(339, 170);
            this.branchIDcomboBox.Name = "branchIDcomboBox";
            this.branchIDcomboBox.Size = new System.Drawing.Size(237, 36);
            this.branchIDcomboBox.TabIndex = 12;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.submit);
            this.MainPanel.Controls.Add(this.branchIDcomboBox);
            this.MainPanel.Controls.Add(this.dateOpenedPicker);
            this.MainPanel.Controls.Add(this.accountType);
            this.MainPanel.Controls.Add(this.dateOpened);
            this.MainPanel.Controls.Add(this.accountIdGenerated);
            this.MainPanel.Controls.Add(this.AccountID);
            this.MainPanel.Controls.Add(this.branchID);
            this.MainPanel.Controls.Add(this.accountTypeComboBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 454);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(618, 390);
            this.MainPanel.TabIndex = 17;
            // 
            // AccountAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(618, 844);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.customerIdSearch);
            this.Controls.Add(this.customerID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountAddition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAccount";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerID;
        private System.Windows.Forms.TextBox customerIdSearch;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
        private System.Windows.Forms.Label accountIdGenerated;
        private System.Windows.Forms.Label AccountID;
        private System.Windows.Forms.Label branchID;
        private System.Windows.Forms.Label dateOpened;
        private System.Windows.Forms.DateTimePicker dateOpenedPicker;
        private System.Windows.Forms.Label accountType;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox branchIDcomboBox;
        private System.Windows.Forms.Panel MainPanel;
    }
}