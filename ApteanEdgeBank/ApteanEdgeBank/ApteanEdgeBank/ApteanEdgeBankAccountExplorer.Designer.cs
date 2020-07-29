namespace ApteanEdgeBank
{
    partial class ApteanEdgeBankAccountExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApteanEdgeBankAccountExplorer));
            this.readAccount = new System.Windows.Forms.Button();
            this.AccountHandle = new System.Windows.Forms.Button();
            this.openAccount = new System.Windows.Forms.Button();
            this.accountManage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readAccount
            // 
            this.readAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("readAccount.BackgroundImage")));
            this.readAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.readAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.readAccount.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readAccount.Location = new System.Drawing.Point(44, 208);
            this.readAccount.Name = "readAccount";
            this.readAccount.Size = new System.Drawing.Size(200, 200);
            this.readAccount.TabIndex = 0;
            this.readAccount.Text = "Read Account";
            this.readAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.readAccount.UseVisualStyleBackColor = true;
            this.readAccount.Click += new System.EventHandler(this.readAccount_Click);
            // 
            // AccountHandle
            // 
            this.AccountHandle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AccountHandle.BackgroundImage")));
            this.AccountHandle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AccountHandle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AccountHandle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountHandle.Location = new System.Drawing.Point(683, 208);
            this.AccountHandle.Name = "AccountHandle";
            this.AccountHandle.Size = new System.Drawing.Size(200, 200);
            this.AccountHandle.TabIndex = 2;
            this.AccountHandle.Text = "Close/Reopen Account";
            this.AccountHandle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AccountHandle.UseVisualStyleBackColor = true;
            this.AccountHandle.Click += new System.EventHandler(this.accountHandle_Click);
            // 
            // openAccount
            // 
            this.openAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openAccount.BackgroundImage")));
            this.openAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openAccount.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAccount.Location = new System.Drawing.Point(351, 208);
            this.openAccount.Name = "openAccount";
            this.openAccount.Size = new System.Drawing.Size(200, 200);
            this.openAccount.TabIndex = 3;
            this.openAccount.Text = "Open New Account";
            this.openAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openAccount.UseVisualStyleBackColor = true;
            this.openAccount.Click += new System.EventHandler(this.openAccount_Click);
            // 
            // accountManage
            // 
            this.accountManage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accountManage.BackgroundImage")));
            this.accountManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.accountManage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountManage.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountManage.Location = new System.Drawing.Point(969, 208);
            this.accountManage.Name = "accountManage";
            this.accountManage.Size = new System.Drawing.Size(225, 200);
            this.accountManage.TabIndex = 5;
            this.accountManage.Text = "Deposit / Withdraw Issue / Loan Repay";
            this.accountManage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accountManage.UseVisualStyleBackColor = true;
            this.accountManage.Click += new System.EventHandler(this.accountManage_Click);
            // 
            // AccountsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.accountManage);
            this.Controls.Add(this.openAccount);
            this.Controls.Add(this.AccountHandle);
            this.Controls.Add(this.readAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readAccount;
        private System.Windows.Forms.Button AccountHandle;
        private System.Windows.Forms.Button openAccount;
        private System.Windows.Forms.Button accountManage;
    }
}