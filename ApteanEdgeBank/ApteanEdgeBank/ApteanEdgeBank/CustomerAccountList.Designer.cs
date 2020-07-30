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
            this.Submit = new System.Windows.Forms.Button();
            this.selectAccount = new System.Windows.Forms.ComboBox();
            this.customerID = new System.Windows.Forms.Label();
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
            this.searchAccount.Location = new System.Drawing.Point(225, 438);
            this.searchAccount.Name = "searchAccount";
            this.searchAccount.Size = new System.Drawing.Size(164, 46);
            this.searchAccount.TabIndex = 1;
            this.searchAccount.Text = "Search";
            this.searchAccount.UseVisualStyleBackColor = true;
            this.searchAccount.Click += new System.EventHandler(this.searchAccount_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.Highlight;
            this.Submit.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.Window;
            this.Submit.Location = new System.Drawing.Point(317, 518);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(180, 45);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // selectAccount
            // 
            this.selectAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectAccount.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAccount.FormattingEnabled = true;
            this.selectAccount.Location = new System.Drawing.Point(57, 518);
            this.selectAccount.Name = "selectAccount";
            this.selectAccount.Size = new System.Drawing.Size(220, 45);
            this.selectAccount.TabIndex = 5;
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
            // CustomerAccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(618, 724);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.selectAccount);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.searchAccount);
            this.Controls.Add(this.searchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerAccountList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerAccountList";
            this.Load += new System.EventHandler(this.CustomerAccountList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchAccount;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ComboBox selectAccount;
        private int accountType;
        private System.Windows.Forms.Label customerID;
    }
}