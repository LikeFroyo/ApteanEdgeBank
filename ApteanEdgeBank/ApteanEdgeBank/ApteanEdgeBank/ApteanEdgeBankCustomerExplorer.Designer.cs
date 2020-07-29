namespace ApteanEdgeBank
{
    partial class ApteanEdgeBankCustomerExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApteanEdgeBankCustomerExplorer));
            this.addCustomer = new System.Windows.Forms.Button();
            this.customerList = new System.Windows.Forms.Button();
            this.accountList = new System.Windows.Forms.Button();
            this.updateCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCustomer
            // 
            this.addCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCustomer.BackgroundImage")));
            this.addCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addCustomer.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.Location = new System.Drawing.Point(352, 184);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(200, 200);
            this.addCustomer.TabIndex = 1;
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // customerList
            // 
            this.customerList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customerList.BackgroundImage")));
            this.customerList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.customerList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customerList.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerList.Location = new System.Drawing.Point(986, 184);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(200, 200);
            this.customerList.TabIndex = 2;
            this.customerList.Text = "Customer List";
            this.customerList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customerList.UseVisualStyleBackColor = true;
            this.customerList.Click += new System.EventHandler(this.CustomerList_Click);
            // 
            // accountList
            // 
            this.accountList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accountList.BackgroundImage")));
            this.accountList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.accountList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountList.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountList.Location = new System.Drawing.Point(76, 184);
            this.accountList.Name = "accountList";
            this.accountList.Size = new System.Drawing.Size(200, 200);
            this.accountList.TabIndex = 3;
            this.accountList.Text = "Account List";
            this.accountList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accountList.UseVisualStyleBackColor = true;
            this.accountList.Click += new System.EventHandler(this.AccountList_Click);
            // 
            // updateCustomer
            // 
            this.updateCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateCustomer.BackgroundImage")));
            this.updateCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.updateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateCustomer.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomer.Location = new System.Drawing.Point(668, 184);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(210, 200);
            this.updateCustomer.TabIndex = 4;
            this.updateCustomer.Text = "Read /Update Customer";
            this.updateCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
            // 
            // ApteanEdgeBankCustomerExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.updateCustomer);
            this.Controls.Add(this.accountList);
            this.Controls.Add(this.customerList);
            this.Controls.Add(this.addCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApteanEdgeBankCustomerExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aptean Edge Bank";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button customerList;
        private System.Windows.Forms.Button accountList;
        private System.Windows.Forms.Button updateCustomer;
    }
}