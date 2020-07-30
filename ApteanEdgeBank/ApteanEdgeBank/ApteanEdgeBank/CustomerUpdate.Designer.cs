namespace ApteanEdgeBank
{
    partial class CustomerUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerUpdate));
            this.customerSearchTextBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.customerName = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.dateJoined = new System.Windows.Forms.Label();
            this.selectBranch = new System.Windows.Forms.Label();
            this.DateJoinedPicker = new System.Windows.Forms.DateTimePicker();
            this.BranchComboBox = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.customerID = new System.Windows.Forms.Label();
            this.checkUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerSearchTextBox
            // 
            this.customerSearchTextBox.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSearchTextBox.Location = new System.Drawing.Point(45, 354);
            this.customerSearchTextBox.Name = "customerSearchTextBox";
            this.customerSearchTextBox.Size = new System.Drawing.Size(292, 40);
            this.customerSearchTextBox.TabIndex = 0;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.search.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(353, 349);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(224, 49);
            this.search.TabIndex = 1;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.BackColor = System.Drawing.Color.Transparent;
            this.customerName.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.ForeColor = System.Drawing.SystemColors.Window;
            this.customerName.Location = new System.Drawing.Point(43, 465);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(240, 33);
            this.customerName.TabIndex = 2;
            this.customerName.Text = "Customer Name: ";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(348, 462);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(229, 40);
            this.customerNameTextBox.TabIndex = 3;
            // 
            // dateJoined
            // 
            this.dateJoined.AutoSize = true;
            this.dateJoined.BackColor = System.Drawing.Color.Transparent;
            this.dateJoined.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateJoined.ForeColor = System.Drawing.SystemColors.Window;
            this.dateJoined.Location = new System.Drawing.Point(49, 529);
            this.dateJoined.Name = "dateJoined";
            this.dateJoined.Size = new System.Drawing.Size(225, 33);
            this.dateJoined.TabIndex = 4;
            this.dateJoined.Text = "Date  Joined :";
            // 
            // selectBranch
            // 
            this.selectBranch.AutoSize = true;
            this.selectBranch.BackColor = System.Drawing.Color.Transparent;
            this.selectBranch.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBranch.ForeColor = System.Drawing.SystemColors.Window;
            this.selectBranch.Location = new System.Drawing.Point(49, 592);
            this.selectBranch.Name = "selectBranch";
            this.selectBranch.Size = new System.Drawing.Size(240, 33);
            this.selectBranch.TabIndex = 5;
            this.selectBranch.Text = "Select Branch: ";
            // 
            // DateJoinedPicker
            // 
            this.DateJoinedPicker.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateJoinedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateJoinedPicker.Location = new System.Drawing.Point(348, 529);
            this.DateJoinedPicker.Name = "DateJoinedPicker";
            this.DateJoinedPicker.Size = new System.Drawing.Size(229, 36);
            this.DateJoinedPicker.TabIndex = 6;
            // 
            // BranchComboBox
            // 
            this.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchComboBox.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchComboBox.FormattingEnabled = true;
            this.BranchComboBox.Items.AddRange(new object[] {
            "Branch 1",
            "Branch 2",
            "Branch 3",
            "Branch 4"});
            this.BranchComboBox.Location = new System.Drawing.Point(348, 589);
            this.BranchComboBox.Name = "BranchComboBox";
            this.BranchComboBox.Size = new System.Drawing.Size(229, 41);
            this.BranchComboBox.TabIndex = 7;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.Highlight;
            this.update.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(227, 655);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(156, 57);
            this.update.TabIndex = 8;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.Submit_Click);
            // 
            // customerID
            // 
            this.customerID.AutoSize = true;
            this.customerID.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerID.Location = new System.Drawing.Point(45, 332);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(99, 19);
            this.customerID.TabIndex = 9;
            this.customerID.Text = "customerID";
            // 
            // checkUpdate
            // 
            this.checkUpdate.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUpdate.Location = new System.Drawing.Point(45, 400);
            this.checkUpdate.Name = "checkUpdate";
            this.checkUpdate.Size = new System.Drawing.Size(135, 30);
            this.checkUpdate.TabIndex = 10;
            this.checkUpdate.Text = "Update Detail";
            this.checkUpdate.UseVisualStyleBackColor = true;
            this.checkUpdate.Click += new System.EventHandler(this.UpdateIntiate_Click);
            // 
            // CustomerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(618, 724);
            this.Controls.Add(this.checkUpdate);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.update);
            this.Controls.Add(this.BranchComboBox);
            this.Controls.Add(this.DateJoinedPicker);
            this.Controls.Add(this.selectBranch);
            this.Controls.Add(this.dateJoined);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.search);
            this.Controls.Add(this.customerSearchTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read/Update Customer Detail";
            this.Load += new System.EventHandler(this.CustomerUpdate_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerSearchTextBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label dateJoined;
        private System.Windows.Forms.Label selectBranch;
        private System.Windows.Forms.DateTimePicker DateJoinedPicker;
        private System.Windows.Forms.ComboBox BranchComboBox;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label customerID;
        private System.Windows.Forms.Button checkUpdate;
    }
}