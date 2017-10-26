namespace StockBag
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_Cancel = new System.Windows.Forms.Button();
            this.m_OK = new System.Windows.Forms.Button();
            this.m_General = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_Index2Code = new System.Windows.Forms.TextBox();
            this.m_Index1Code = new System.Windows.Forms.TextBox();
            this.m_Index2Name = new System.Windows.Forms.TextBox();
            this.m_Index1Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_ListRefreshInterval = new System.Windows.Forms.TextBox();
            this.m_DataAccessInterval = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.m_General.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_Cancel);
            this.panel1.Controls.Add(this.m_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 40);
            this.panel1.TabIndex = 1;
            // 
            // m_Cancel
            // 
            this.m_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_Cancel.Location = new System.Drawing.Point(198, 12);
            this.m_Cancel.Name = "m_Cancel";
            this.m_Cancel.Size = new System.Drawing.Size(75, 23);
            this.m_Cancel.TabIndex = 1;
            this.m_Cancel.Text = "&Cancel";
            this.m_Cancel.UseVisualStyleBackColor = true;
            // 
            // m_OK
            // 
            this.m_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_OK.Location = new System.Drawing.Point(80, 12);
            this.m_OK.Name = "m_OK";
            this.m_OK.Size = new System.Drawing.Size(75, 23);
            this.m_OK.TabIndex = 0;
            this.m_OK.Text = "&OK";
            this.m_OK.UseVisualStyleBackColor = true;
            // 
            // m_General
            // 
            this.m_General.Controls.Add(this.label7);
            this.m_General.Controls.Add(this.label5);
            this.m_General.Controls.Add(this.label9);
            this.m_General.Controls.Add(this.label8);
            this.m_General.Controls.Add(this.label6);
            this.m_General.Controls.Add(this.m_Index2Code);
            this.m_General.Controls.Add(this.m_Index1Code);
            this.m_General.Controls.Add(this.m_Index2Name);
            this.m_General.Controls.Add(this.m_Index1Name);
            this.m_General.Controls.Add(this.label2);
            this.m_General.Controls.Add(this.label4);
            this.m_General.Controls.Add(this.label3);
            this.m_General.Controls.Add(this.label1);
            this.m_General.Controls.Add(this.m_ListRefreshInterval);
            this.m_General.Controls.Add(this.m_DataAccessInterval);
            this.m_General.Location = new System.Drawing.Point(4, 22);
            this.m_General.Name = "m_General";
            this.m_General.Padding = new System.Windows.Forms.Padding(3);
            this.m_General.Size = new System.Drawing.Size(348, 217);
            this.m_General.TabIndex = 1;
            this.m_General.Text = "General";
            this.m_General.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Note: Index values will be displayed on Title Bar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Index 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Index 1";
            // 
            // m_Index2Code
            // 
            this.m_Index2Code.Location = new System.Drawing.Point(194, 113);
            this.m_Index2Code.Name = "m_Index2Code";
            this.m_Index2Code.Size = new System.Drawing.Size(81, 20);
            this.m_Index2Code.TabIndex = 5;
            // 
            // m_Index1Code
            // 
            this.m_Index1Code.Location = new System.Drawing.Point(194, 87);
            this.m_Index1Code.Name = "m_Index1Code";
            this.m_Index1Code.Size = new System.Drawing.Size(81, 20);
            this.m_Index1Code.TabIndex = 3;
            // 
            // m_Index2Name
            // 
            this.m_Index2Name.Location = new System.Drawing.Point(100, 113);
            this.m_Index2Name.Name = "m_Index2Name";
            this.m_Index2Name.Size = new System.Drawing.Size(81, 20);
            this.m_Index2Name.TabIndex = 4;
            // 
            // m_Index1Name
            // 
            this.m_Index1Name.Location = new System.Drawing.Point(100, 87);
            this.m_Index1Name.Name = "m_Index1Name";
            this.m_Index1Name.Size = new System.Drawing.Size(81, 20);
            this.m_Index1Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "List Refresh Interval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Access Interval";
            // 
            // m_ListRefreshInterval
            // 
            this.m_ListRefreshInterval.Location = new System.Drawing.Point(132, 43);
            this.m_ListRefreshInterval.Name = "m_ListRefreshInterval";
            this.m_ListRefreshInterval.Size = new System.Drawing.Size(49, 20);
            this.m_ListRefreshInterval.TabIndex = 1;
            this.m_ListRefreshInterval.TextChanged += new System.EventHandler(this.m_ListRefreshInterval_TextChanged);
            // 
            // m_DataAccessInterval
            // 
            this.m_DataAccessInterval.Location = new System.Drawing.Point(132, 19);
            this.m_DataAccessInterval.Name = "m_DataAccessInterval";
            this.m_DataAccessInterval.Size = new System.Drawing.Size(49, 20);
            this.m_DataAccessInterval.TabIndex = 0;
            this.m_DataAccessInterval.TextChanged += new System.EventHandler(this.m_DataAccessInterval_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.m_General);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(356, 243);
            this.tabControl1.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.m_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_Cancel;
            this.ClientSize = new System.Drawing.Size(356, 243);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.m_General.ResumeLayout(false);
            this.m_General.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button m_Cancel;
        private System.Windows.Forms.Button m_OK;
        private System.Windows.Forms.TabPage m_General;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_ListRefreshInterval;
        private System.Windows.Forms.TextBox m_DataAccessInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_Index2Name;
        private System.Windows.Forms.TextBox m_Index1Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox m_Index2Code;
        private System.Windows.Forms.TextBox m_Index1Code;
    }
}