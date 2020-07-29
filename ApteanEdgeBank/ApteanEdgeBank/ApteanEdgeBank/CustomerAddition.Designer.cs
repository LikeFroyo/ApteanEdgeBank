namespace ApteanEdgeBank
{
    partial class CustomerAddition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerAddition));
            this.customerName = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.selectBranch = new System.Windows.Forms.Label();
            this.dateOpenedPicker = new System.Windows.Forms.DateTimePicker();
            this.dateOpened = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.identityLabel = new System.Windows.Forms.Label();
            this.customerIdentityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.BackColor = System.Drawing.Color.Transparent;
            this.customerName.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.ForeColor = System.Drawing.SystemColors.Window;
            this.customerName.Location = new System.Drawing.Point(33, 443);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(240, 33);
            this.customerName.TabIndex = 0;
            this.customerName.Text = "Customer Name: ";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(300, 440);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(257, 40);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // branchComboBox
            // 
            this.branchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchComboBox.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchComboBox.FormattingEnabled = true;
            this.branchComboBox.Items.AddRange(new object[] {
            "Branch 1",
            "Branch 2",
            "Branch 3",
            "Branch 4"});
            this.branchComboBox.Location = new System.Drawing.Point(300, 574);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(257, 41);
            this.branchComboBox.TabIndex = 2;
            // 
            // selectBranch
            // 
            this.selectBranch.AutoSize = true;
            this.selectBranch.BackColor = System.Drawing.Color.Transparent;
            this.selectBranch.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBranch.ForeColor = System.Drawing.SystemColors.Window;
            this.selectBranch.Location = new System.Drawing.Point(33, 577);
            this.selectBranch.Name = "selectBranch";
            this.selectBranch.Size = new System.Drawing.Size(240, 33);
            this.selectBranch.TabIndex = 3;
            this.selectBranch.Text = "Select Branch: ";
            // 
            // dateOpenedPicker
            // 
            this.dateOpenedPicker.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOpenedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOpenedPicker.Location = new System.Drawing.Point(300, 504);
            this.dateOpenedPicker.Name = "dateOpenedPicker";
            this.dateOpenedPicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateOpenedPicker.Size = new System.Drawing.Size(257, 40);
            this.dateOpenedPicker.TabIndex = 4;
            // 
            // dateOpened
            // 
            this.dateOpened.AutoSize = true;
            this.dateOpened.BackColor = System.Drawing.Color.Transparent;
            this.dateOpened.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOpened.ForeColor = System.Drawing.SystemColors.Window;
            this.dateOpened.Location = new System.Drawing.Point(33, 510);
            this.dateOpened.Name = "dateOpened";
            this.dateOpened.Size = new System.Drawing.Size(240, 33);
            this.dateOpened.TabIndex = 5;
            this.dateOpened.Text = "Date  Opened : ";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(240, 643);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(136, 55);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // identityLabel
            // 
            this.identityLabel.AutoSize = true;
            this.identityLabel.BackColor = System.Drawing.Color.Transparent;
            this.identityLabel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identityLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.identityLabel.Location = new System.Drawing.Point(173, 378);
            this.identityLabel.Name = "identityLabel";
            this.identityLabel.Size = new System.Drawing.Size(270, 33);
            this.identityLabel.TabIndex = 7;
            this.identityLabel.Text = "Customer Identity";
            // 
            // customerIdentityLabel
            // 
            this.customerIdentityLabel.AutoSize = true;
            this.customerIdentityLabel.BackColor = System.Drawing.Color.Transparent;
            this.customerIdentityLabel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdentityLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.customerIdentityLabel.Location = new System.Drawing.Point(234, 345);
            this.customerIdentityLabel.Name = "customerIdentityLabel";
            this.customerIdentityLabel.Size = new System.Drawing.Size(150, 33);
            this.customerIdentityLabel.TabIndex = 8;
            this.customerIdentityLabel.Text = "100000001";
            // 
            // CustomerAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(618, 724);
            this.Controls.Add(this.customerIdentityLabel);
            this.Controls.Add(this.identityLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dateOpened);
            this.Controls.Add(this.dateOpenedPicker);
            this.Controls.Add(this.selectBranch);
            this.Controls.Add(this.branchComboBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerAddition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer Detail";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.ComboBox branchComboBox;
        private System.Windows.Forms.Label selectBranch;
        private System.Windows.Forms.DateTimePicker dateOpenedPicker;
        private System.Windows.Forms.Label dateOpened;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label identityLabel;
        private System.Windows.Forms.Label customerIdentityLabel;
    }
}