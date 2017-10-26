namespace StockBag
{
    partial class StockBagMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockBagMainForm));
            this.m_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_StartStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_StockSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.m_RefreshtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.m_AddStockToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.m_DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.m_StartStopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.m_StatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.m_StockTree = new System.Windows.Forms.TreeView();
            this.m_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.m_AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_DetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_StockInfoList = new System.Windows.Forms.ListView();
            this.m_StockName = new System.Windows.Forms.ColumnHeader();
            this.m_LastQuote = new System.Windows.Forms.ColumnHeader();
            this.m_PercentChange = new System.Windows.Forms.ColumnHeader();
            this.m_PreviousQuote = new System.Windows.Forms.ColumnHeader();
            this.m_Change = new System.Windows.Forms.ColumnHeader();
            this.m_BuyPrice = new System.Windows.Forms.ColumnHeader();
            this.m_BuyQuantity = new System.Windows.Forms.ColumnHeader();
            this.m_NetPercentChange = new System.Windows.Forms.ColumnHeader();
            this.m_Investment = new System.Windows.Forms.ColumnHeader();
            this.m_NetChange = new System.Windows.Forms.ColumnHeader();
            this.m_CurrentValue = new System.Windows.Forms.ColumnHeader();
            this.m_RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.m_DataRequestTimer = new System.Windows.Forms.Timer(this.components);
            this.m_ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_MenuStrip.SuspendLayout();
            this.m_ToolStrip.SuspendLayout();
            this.m_StatusStrip.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.m_ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_MenuStrip
            // 
            this.m_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.m_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.m_MenuStrip.Name = "m_MenuStrip";
            this.m_MenuStrip.Size = new System.Drawing.Size(500, 24);
            this.m_MenuStrip.TabIndex = 0;
            this.m_MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // m_ExitToolStripMenuItem
            // 
            this.m_ExitToolStripMenuItem.Name = "m_ExitToolStripMenuItem";
            this.m_ExitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.m_ExitToolStripMenuItem.Text = "&Exit";
            this.m_ExitToolStripMenuItem.Click += new System.EventHandler(this.m_ExitToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_SettingsToolStripMenuItem,
            this.m_RefreshToolStripMenuItem,
            this.m_StartStopToolStripMenuItem,
            this.m_StockSearchToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.optionToolStripMenuItem.Text = "&Tools";
            // 
            // m_SettingsToolStripMenuItem
            // 
            this.m_SettingsToolStripMenuItem.Name = "m_SettingsToolStripMenuItem";
            this.m_SettingsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.m_SettingsToolStripMenuItem.Text = "&Settings";
            this.m_SettingsToolStripMenuItem.Click += new System.EventHandler(this.m_SettingsToolStripMenuItem_Click);
            // 
            // m_RefreshToolStripMenuItem
            // 
            this.m_RefreshToolStripMenuItem.Name = "m_RefreshToolStripMenuItem";
            this.m_RefreshToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.m_RefreshToolStripMenuItem.Text = "&Manual Refresh";
            this.m_RefreshToolStripMenuItem.Click += new System.EventHandler(this.m_RefreshToolStripMenuItem_Click);
            // 
            // m_StartStopToolStripMenuItem
            // 
            this.m_StartStopToolStripMenuItem.Name = "m_StartStopToolStripMenuItem";
            this.m_StartStopToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.m_StartStopToolStripMenuItem.Text = "Stop &Auto Refresh";
            this.m_StartStopToolStripMenuItem.Click += new System.EventHandler(this.m_StartStopToolStripMenuItem_Click);
            // 
            // m_StockSearchToolStripMenuItem
            // 
            this.m_StockSearchToolStripMenuItem.Name = "m_StockSearchToolStripMenuItem";
            this.m_StockSearchToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.m_StockSearchToolStripMenuItem.Text = "S&tock Search";
            this.m_StockSearchToolStripMenuItem.Click += new System.EventHandler(this.m_StockSearchToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_AboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // m_AboutToolStripMenuItem
            // 
            this.m_AboutToolStripMenuItem.Name = "m_AboutToolStripMenuItem";
            this.m_AboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.m_AboutToolStripMenuItem.Text = "&About";
            this.m_AboutToolStripMenuItem.Click += new System.EventHandler(this.m_AboutToolStripMenuItem_Click);
            // 
            // m_ToolStrip
            // 
            this.m_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_RefreshtoolStripButton,
            this.m_AddStockToolStripButton,
            this.m_DeleteToolStripButton,
            this.m_StartStopToolStripButton});
            this.m_ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.m_ToolStrip.Name = "m_ToolStrip";
            this.m_ToolStrip.Size = new System.Drawing.Size(500, 25);
            this.m_ToolStrip.TabIndex = 1;
            this.m_ToolStrip.Text = "toolStrip1";
            // 
            // m_RefreshtoolStripButton
            // 
            this.m_RefreshtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_RefreshtoolStripButton.Image = global::StockBag.Properties.Resources.RefreshStocks2;
            this.m_RefreshtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_RefreshtoolStripButton.Name = "m_RefreshtoolStripButton";
            this.m_RefreshtoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.m_RefreshtoolStripButton.ToolTipText = "Manual Refresh";
            this.m_RefreshtoolStripButton.Click += new System.EventHandler(this.m_RefreshtoolStripButton_Click);
            // 
            // m_AddStockToolStripButton
            // 
            this.m_AddStockToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_AddStockToolStripButton.Image = global::StockBag.Properties.Resources.AddStock;
            this.m_AddStockToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_AddStockToolStripButton.Name = "m_AddStockToolStripButton";
            this.m_AddStockToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.m_AddStockToolStripButton.Text = "Add New Stock";
            this.m_AddStockToolStripButton.ToolTipText = "Add Stock";
            this.m_AddStockToolStripButton.Click += new System.EventHandler(this.m_AddStockToolStripButton_Click);
            // 
            // m_DeleteToolStripButton
            // 
            this.m_DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_DeleteToolStripButton.Image = global::StockBag.Properties.Resources.DeleteStock;
            this.m_DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_DeleteToolStripButton.Name = "m_DeleteToolStripButton";
            this.m_DeleteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.m_DeleteToolStripButton.Text = "Remove Stock";
            this.m_DeleteToolStripButton.ToolTipText = "Delete Stock";
            this.m_DeleteToolStripButton.Click += new System.EventHandler(this.m_DeleteToolStripButton_Click);
            // 
            // m_StartStopToolStripButton
            // 
            this.m_StartStopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_StartStopToolStripButton.Image = global::StockBag.Properties.Resources.StopAutoRefresh;
            this.m_StartStopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_StartStopToolStripButton.Name = "m_StartStopToolStripButton";
            this.m_StartStopToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.m_StartStopToolStripButton.Text = "Stop Auto Refresh";
            this.m_StartStopToolStripButton.Click += new System.EventHandler(this.m_StartStopToolStripButton_Click);
            // 
            // m_StatusStrip
            // 
            this.m_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.m_StatusStrip.Location = new System.Drawing.Point(0, 375);
            this.m_StatusStrip.Name = "m_StatusStrip";
            this.m_StatusStrip.Size = new System.Drawing.Size(500, 22);
            this.m_StatusStrip.TabIndex = 2;
            this.m_StatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoToolTip = true;
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(485, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Ready";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.m_StockTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.m_StockInfoList);
            this.splitContainer1.Size = new System.Drawing.Size(500, 326);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 4;
            // 
            // m_StockTree
            // 
            this.m_StockTree.ContextMenuStrip = this.m_ContextMenuStrip;
            this.m_StockTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_StockTree.HideSelection = false;
            this.m_StockTree.Location = new System.Drawing.Point(0, 0);
            this.m_StockTree.Name = "m_StockTree";
            this.m_StockTree.Size = new System.Drawing.Size(153, 326);
            this.m_StockTree.TabIndex = 0;
            this.m_StockTree.DoubleClick += new System.EventHandler(this.m_StockTree_DoubleClick);
            this.m_StockTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.m_StockTree_AfterSelect);
            // 
            // m_ContextMenuStrip
            // 
            this.m_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_AddToolStripMenuItem,
            this.m_RemoveToolStripMenuItem,
            this.m_EditToolStripMenuItem,
            this.m_DetailsToolStripMenuItem});
            this.m_ContextMenuStrip.Name = "m_ContextMenuStrip";
            this.m_ContextMenuStrip.Size = new System.Drawing.Size(220, 92);
            // 
            // m_AddToolStripMenuItem
            // 
            this.m_AddToolStripMenuItem.Name = "m_AddToolStripMenuItem";
            this.m_AddToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.m_AddToolStripMenuItem.Text = "Add Stock";
            this.m_AddToolStripMenuItem.Click += new System.EventHandler(this.m_AddToolStripMenuItem_Click);
            // 
            // m_RemoveToolStripMenuItem
            // 
            this.m_RemoveToolStripMenuItem.Name = "m_RemoveToolStripMenuItem";
            this.m_RemoveToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.m_RemoveToolStripMenuItem.Text = "Remove Selected Stock";
            this.m_RemoveToolStripMenuItem.Click += new System.EventHandler(this.m_RemoveToolStripMenuItem_Click);
            // 
            // m_EditToolStripMenuItem
            // 
            this.m_EditToolStripMenuItem.Name = "m_EditToolStripMenuItem";
            this.m_EditToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.m_EditToolStripMenuItem.Text = "Edit Selected Stock";
            this.m_EditToolStripMenuItem.Click += new System.EventHandler(this.m_EditToolStripMenuItem_Click);
            // 
            // m_DetailsToolStripMenuItem
            // 
            this.m_DetailsToolStripMenuItem.Name = "m_DetailsToolStripMenuItem";
            this.m_DetailsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.m_DetailsToolStripMenuItem.Text = "Show Selected Stock Details";
            this.m_DetailsToolStripMenuItem.Click += new System.EventHandler(this.m_DetailsToolStripMenuItem_Click);
            // 
            // m_StockInfoList
            // 
            this.m_StockInfoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.m_StockName,
            this.m_LastQuote,
            this.m_PercentChange,
            this.m_PreviousQuote,
            this.m_Change,
            this.m_BuyPrice,
            this.m_BuyQuantity,
            this.m_NetPercentChange,
            this.m_Investment,
            this.m_NetChange,
            this.m_CurrentValue});
            this.m_StockInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_StockInfoList.FullRowSelect = true;
            this.m_StockInfoList.GridLines = true;
            this.m_StockInfoList.Location = new System.Drawing.Point(0, 0);
            this.m_StockInfoList.Name = "m_StockInfoList";
            this.m_StockInfoList.Size = new System.Drawing.Size(343, 326);
            this.m_StockInfoList.TabIndex = 0;
            this.m_StockInfoList.UseCompatibleStateImageBehavior = false;
            this.m_StockInfoList.View = System.Windows.Forms.View.Details;
            this.m_StockInfoList.DoubleClick += new System.EventHandler(this.m_StockInfoList_DoubleClick);
            // 
            // m_StockName
            // 
            this.m_StockName.Text = "Stock";
            this.m_StockName.Width = 137;
            // 
            // m_LastQuote
            // 
            this.m_LastQuote.Text = "Last Quote";
            this.m_LastQuote.Width = 69;
            // 
            // m_PercentChange
            // 
            this.m_PercentChange.Text = "%Change";
            this.m_PercentChange.Width = 61;
            // 
            // m_PreviousQuote
            // 
            this.m_PreviousQuote.Text = "Prev Quote";
            this.m_PreviousQuote.Width = 70;
            // 
            // m_Change
            // 
            this.m_Change.Text = "Change";
            this.m_Change.Width = 52;
            // 
            // m_BuyPrice
            // 
            this.m_BuyPrice.Text = "Buy Price";
            this.m_BuyPrice.Width = 62;
            // 
            // m_BuyQuantity
            // 
            this.m_BuyQuantity.Text = "Buy Quantity";
            this.m_BuyQuantity.Width = 79;
            // 
            // m_NetPercentChange
            // 
            this.m_NetPercentChange.Text = "Net %Change";
            this.m_NetPercentChange.Width = 80;
            // 
            // m_Investment
            // 
            this.m_Investment.Text = "Inv. Amount";
            this.m_Investment.Width = 72;
            // 
            // m_NetChange
            // 
            this.m_NetChange.Text = "Net Change";
            this.m_NetChange.Width = 80;
            // 
            // m_CurrentValue
            // 
            this.m_CurrentValue.Text = "Curr. Value";
            this.m_CurrentValue.Width = 86;
            // 
            // m_RefreshTimer
            // 
            this.m_RefreshTimer.Enabled = true;
            this.m_RefreshTimer.Interval = 2000;
            this.m_RefreshTimer.Tick += new System.EventHandler(this.m_RefreshTimer_Tick);
            // 
            // m_DataRequestTimer
            // 
            this.m_DataRequestTimer.Enabled = true;
            this.m_DataRequestTimer.Interval = 60000;
            this.m_DataRequestTimer.Tick += new System.EventHandler(this.m_DataRequestTimer_Tick);
            // 
            // m_ImageList
            // 
            this.m_ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_ImageList.ImageStream")));
            this.m_ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.m_ImageList.Images.SetKeyName(0, "StopAutoRefresh.ico");
            this.m_ImageList.Images.SetKeyName(1, "StartAutoRefresh.ico");
            // 
            // StockBagMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 397);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.m_StatusStrip);
            this.Controls.Add(this.m_ToolStrip);
            this.Controls.Add(this.m_MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.m_MenuStrip;
            this.Name = "StockBagMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Predictor";
            this.m_MenuStrip.ResumeLayout(false);
            this.m_MenuStrip.PerformLayout();
            this.m_ToolStrip.ResumeLayout(false);
            this.m_ToolStrip.PerformLayout();
            this.m_StatusStrip.ResumeLayout(false);
            this.m_StatusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.m_ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip m_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip m_ToolStrip;
        private System.Windows.Forms.ToolStripButton m_RefreshtoolStripButton;
        private System.Windows.Forms.ToolStripButton m_AddStockToolStripButton;
        private System.Windows.Forms.ToolStripButton m_DeleteToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem m_StockSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton m_StartStopToolStripButton;
        private System.Windows.Forms.StatusStrip m_StatusStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView m_StockTree;
        private System.Windows.Forms.ListView m_StockInfoList;
        private System.Windows.Forms.ColumnHeader m_StockName;
        private System.Windows.Forms.ColumnHeader m_LastQuote;
        private System.Windows.Forms.ColumnHeader m_Change;
        private System.Windows.Forms.ColumnHeader m_PreviousQuote;
        private System.Windows.Forms.ColumnHeader m_PercentChange;
        private System.Windows.Forms.ColumnHeader m_BuyPrice;
        private System.Windows.Forms.ColumnHeader m_NetPercentChange;
        private System.Windows.Forms.ColumnHeader m_NetChange;
        private System.Windows.Forms.ColumnHeader m_BuyQuantity;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ColumnHeader m_Investment;
        private System.Windows.Forms.ColumnHeader m_CurrentValue;
        private System.Windows.Forms.Timer m_RefreshTimer;
        private System.Windows.Forms.Timer m_DataRequestTimer;
        private System.Windows.Forms.ImageList m_ImageList;
        private System.Windows.Forms.ToolStripMenuItem m_StartStopToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip m_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem m_RemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_DetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_AddToolStripMenuItem;
    }
}

