namespace StockBag
{
    partial class AddEditStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditStockForm));
            this.m_OK = new System.Windows.Forms.Button();
            this.m_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_StockCode = new System.Windows.Forms.TextBox();
            this.m_StockName = new System.Windows.Forms.TextBox();
            this.m_Search = new System.Windows.Forms.Button();
            this.m_LabelQuantity = new System.Windows.Forms.Label();
            this.m_StockQuantity = new System.Windows.Forms.TextBox();
            this.m_LabelAveragePrice = new System.Windows.Forms.Label();
            this.m_StockAveragePrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m_OK
            // 
            this.m_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_OK.Location = new System.Drawing.Point(79, 148);
            this.m_OK.Name = "m_OK";
            this.m_OK.Size = new System.Drawing.Size(75, 23);
            this.m_OK.TabIndex = 5;
            this.m_OK.Text = "&OK";
            this.m_OK.UseVisualStyleBackColor = true;
            // 
            // m_Cancel
            // 
            this.m_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_Cancel.Location = new System.Drawing.Point(175, 148);
            this.m_Cancel.Name = "m_Cancel";
            this.m_Cancel.Size = new System.Drawing.Size(75, 23);
            this.m_Cancel.TabIndex = 6;
            this.m_Cancel.Text = "&Cancel";
            this.m_Cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock Name";
            // 
            // m_StockCode
            // 
            this.m_StockCode.Location = new System.Drawing.Point(116, 23);
            this.m_StockCode.Name = "m_StockCode";
            this.m_StockCode.Size = new System.Drawing.Size(104, 20);
            this.m_StockCode.TabIndex = 0;
            this.m_StockCode.Text = "stock code";
            this.m_StockCode.TextChanged += new System.EventHandler(this.m_StockCode_TextChanged);
            // 
            // m_StockName
            // 
            this.m_StockName.AcceptsReturn = true;
            this.m_StockName.Location = new System.Drawing.Point(116, 53);
            this.m_StockName.Name = "m_StockName";
            this.m_StockName.Size = new System.Drawing.Size(185, 20);
            this.m_StockName.TabIndex = 2;
            this.m_StockName.Text = "stock name";
            this.m_StockName.TextChanged += new System.EventHandler(this.m_StockName_TextChanged);
            // 
            // m_Search
            // 
            this.m_Search.Location = new System.Drawing.Point(226, 21);
            this.m_Search.Name = "m_Search";
            this.m_Search.Size = new System.Drawing.Size(75, 23);
            this.m_Search.TabIndex = 1;
            this.m_Search.Text = "&Search";
            this.m_Search.UseVisualStyleBackColor = true;
            this.m_Search.Click += new System.EventHandler(this.m_Search_Click);
            // 
            // m_LabelQuantity
            // 
            this.m_LabelQuantity.AutoSize = true;
            this.m_LabelQuantity.Location = new System.Drawing.Point(29, 111);
            this.m_LabelQuantity.Name = "m_LabelQuantity";
            this.m_LabelQuantity.Size = new System.Drawing.Size(46, 13);
            this.m_LabelQuantity.TabIndex = 3;
            this.m_LabelQuantity.Text = "Quantity";
            // 
            // m_StockQuantity
            // 
            this.m_StockQuantity.AcceptsReturn = true;
            this.m_StockQuantity.Location = new System.Drawing.Point(116, 111);
            this.m_StockQuantity.Name = "m_StockQuantity";
            this.m_StockQuantity.Size = new System.Drawing.Size(56, 20);
            this.m_StockQuantity.TabIndex = 4;
            this.m_StockQuantity.Text = "0";
            this.m_StockQuantity.TextChanged += new System.EventHandler(this.m_StockQuantity_TextChanged);
            // 
            // m_LabelAveragePrice
            // 
            this.m_LabelAveragePrice.AutoSize = true;
            this.m_LabelAveragePrice.Location = new System.Drawing.Point(29, 84);
            this.m_LabelAveragePrice.Name = "m_LabelAveragePrice";
            this.m_LabelAveragePrice.Size = new System.Drawing.Size(74, 13);
            this.m_LabelAveragePrice.TabIndex = 3;
            this.m_LabelAveragePrice.Text = "Average Price";
            // 
            // m_StockAveragePrice
            // 
            this.m_StockAveragePrice.AcceptsReturn = true;
            this.m_StockAveragePrice.Location = new System.Drawing.Point(116, 84);
            this.m_StockAveragePrice.Name = "m_StockAveragePrice";
            this.m_StockAveragePrice.Size = new System.Drawing.Size(79, 20);
            this.m_StockAveragePrice.TabIndex = 3;
            this.m_StockAveragePrice.Text = "0";
            this.m_StockAveragePrice.TextChanged += new System.EventHandler(this.m_StockAveragePrice_TextChanged);
            // 
            // AddEditStockForm
            // 
            this.AcceptButton = this.m_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_Cancel;
            this.ClientSize = new System.Drawing.Size(339, 178);
            this.Controls.Add(this.m_Search);
            this.Controls.Add(this.m_StockAveragePrice);
            this.Controls.Add(this.m_StockQuantity);
            this.Controls.Add(this.m_LabelAveragePrice);
            this.Controls.Add(this.m_StockName);
            this.Controls.Add(this.m_LabelQuantity);
            this.Controls.Add(this.m_StockCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_Cancel);
            this.Controls.Add(this.m_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditStockForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditStockForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_OK;
        private System.Windows.Forms.Button m_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_StockCode;
        private System.Windows.Forms.TextBox m_StockName;
        private System.Windows.Forms.Button m_Search;
        private System.Windows.Forms.Label m_LabelQuantity;
        private System.Windows.Forms.TextBox m_StockQuantity;
        private System.Windows.Forms.Label m_LabelAveragePrice;
        private System.Windows.Forms.TextBox m_StockAveragePrice;
    }
}