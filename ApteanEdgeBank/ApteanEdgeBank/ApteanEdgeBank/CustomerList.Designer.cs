namespace ApteanEdgeBank
{
    partial class CustomerList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerList));
            this.CustomerListView = new System.Windows.Forms.DataGridView();
            this.customerListLabel = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerListView
            // 
            this.CustomerListView.AllowUserToAddRows = false;
            this.CustomerListView.AllowUserToDeleteRows = false;
            this.CustomerListView.AllowUserToResizeColumns = false;
            this.CustomerListView.AllowUserToResizeRows = false;
            this.CustomerListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerListView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.CustomerListView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomerListView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerListView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerListView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CustomerListView.GridColor = System.Drawing.SystemColors.Desktop;
            this.CustomerListView.Location = new System.Drawing.Point(0, 154);
            this.CustomerListView.MultiSelect = false;
            this.CustomerListView.Name = "CustomerListView";
            this.CustomerListView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerListView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerListView.RowHeadersWidth = 15;
            this.CustomerListView.RowTemplate.Height = 30;
            this.CustomerListView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CustomerListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CustomerListView.Size = new System.Drawing.Size(1344, 510);
            this.CustomerListView.TabIndex = 0;
            // 
            // customerListLabel
            // 
            this.customerListLabel.AutoSize = true;
            this.customerListLabel.BackColor = System.Drawing.Color.Transparent;
            this.customerListLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerListLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customerListLabel.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerListLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.customerListLabel.Location = new System.Drawing.Point(456, 47);
            this.customerListLabel.Name = "customerListLabel";
            this.customerListLabel.Size = new System.Drawing.Size(406, 63);
            this.customerListLabel.TabIndex = 1;
            this.customerListLabel.Text = "Customer List";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(1035, 95);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(297, 40);
            this.Search.TabIndex = 2;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1344, 664);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.customerListLabel);
            this.Controls.Add(this.CustomerListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerList";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerListView;
        private System.Windows.Forms.Label customerListLabel;
        private System.Windows.Forms.TextBox Search;
    }
}