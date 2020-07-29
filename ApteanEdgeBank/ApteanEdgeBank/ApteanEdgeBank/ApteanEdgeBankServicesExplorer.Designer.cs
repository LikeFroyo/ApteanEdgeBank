namespace ApteanEdgeBank
{
    partial class ApteanEdgeBankServicesExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApteanEdgeBankServicesExplorer));
            this.bankBanner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customerServicesButton = new System.Windows.Forms.Button();
            this.accountServicesButton = new System.Windows.Forms.Button();
            this.actitivityButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bankBanner
            // 
            this.bankBanner.AutoSize = true;
            this.bankBanner.BackColor = System.Drawing.SystemColors.Window;
            this.bankBanner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bankBanner.Font = new System.Drawing.Font("Consolas", 32F, System.Drawing.FontStyle.Bold);
            this.bankBanner.Location = new System.Drawing.Point(150, 40);
            this.bankBanner.Name = "bankBanner";
            this.bankBanner.Size = new System.Drawing.Size(977, 75);
            this.bankBanner.TabIndex = 0;
            this.bankBanner.Text = "WELCOME TO APTEAN EDGE BANK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(713, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(528, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 75);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // customerServicesButton
            // 
            this.customerServicesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customerServicesButton.BackgroundImage")));
            this.customerServicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customerServicesButton.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerServicesButton.Location = new System.Drawing.Point(163, 324);
            this.customerServicesButton.Name = "customerServicesButton";
            this.customerServicesButton.Size = new System.Drawing.Size(200, 200);
            this.customerServicesButton.TabIndex = 3;
            this.customerServicesButton.Text = "Customer";
            this.customerServicesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customerServicesButton.UseVisualStyleBackColor = true;
            this.customerServicesButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // accountServicesButton
            // 
            this.accountServicesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accountServicesButton.BackgroundImage")));
            this.accountServicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountServicesButton.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountServicesButton.Location = new System.Drawing.Point(549, 324);
            this.accountServicesButton.Name = "accountServicesButton";
            this.accountServicesButton.Size = new System.Drawing.Size(200, 200);
            this.accountServicesButton.TabIndex = 4;
            this.accountServicesButton.Text = "Account";
            this.accountServicesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accountServicesButton.UseVisualStyleBackColor = true;
            this.accountServicesButton.Click += new System.EventHandler(this.bankButton_Click);
            // 
            // actitivityButton
            // 
            this.actitivityButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("actitivityButton.BackgroundImage")));
            this.actitivityButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.actitivityButton.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actitivityButton.Location = new System.Drawing.Point(927, 324);
            this.actitivityButton.Name = "actitivityButton";
            this.actitivityButton.Size = new System.Drawing.Size(200, 200);
            this.actitivityButton.TabIndex = 5;
            this.actitivityButton.Text = "Activity Ledger";
            this.actitivityButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.actitivityButton.UseVisualStyleBackColor = true;
            // 
            // ApteanEdgeBankServicesExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.actitivityButton);
            this.Controls.Add(this.accountServicesButton);
            this.Controls.Add(this.customerServicesButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bankBanner);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApteanEdgeBankServicesExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aptean Edge Bank";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bankBanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button customerServicesButton;
        private System.Windows.Forms.Button accountServicesButton;
        private System.Windows.Forms.Button actitivityButton;
    }
}