using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Xml;
using System.Timers;

namespace StockBag
{
    public partial class StockBagMainForm : Form
    {
        private Hashtable m_StockHash = new Hashtable();
        private SettingsForm m_SettingsForm = new SettingsForm();
        private System.Threading.Thread m_DataRequestThread = null;
        bool m_AutoRefresh = true;
        private ApplicationSettingsManager m_ApplicationSettings = new ApplicationSettingsManager();
        private const string APPLICATION_SETTINGS_FILE = "ApplicationSettings.xml";
        private StockData m_Index1Data = new StockData();
        private StockData m_Index2Data = new StockData();
        bool m_ErrorOccured = false;
        private string PORTFOLIO_NAME = "My Portfolio";
        private string WATCHLIST_NAME = "My Watch List";

        public StockBagMainForm()
        {
            InitializeComponent();
            LoadStockData();
            m_RefreshtoolStripButton.Enabled = false;
            m_RefreshToolStripMenuItem.Enabled = false;
            m_ApplicationSettings.ApplicationSettingsFile = ExecutableDirectory + "\\" +
                APPLICATION_SETTINGS_FILE;
            m_ApplicationSettings.LoadApplicationSettings();
            m_AutoRefresh = !m_ApplicationSettings.AutoRefresh; //As we call toolbar handler
            m_StartStopToolStripButton_Click(null, null);

            //Set timer intervals read from app settings
            m_RefreshTimer.Interval = (int)m_ApplicationSettings.ListRefreshInterval * 1000;
            m_DataRequestTimer.Interval = (int)m_ApplicationSettings.DataAccessInterval * 1000;
        }

        void m_RefreshTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DisplayStockList();
        }

        private void m_StockTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DisplayStockList();

            if (e.Node.Tag == null)
            {
                m_EditToolStripMenuItem.Enabled = false;
                m_RemoveToolStripMenuItem.Enabled = false;
                m_DetailsToolStripMenuItem.Enabled = false;
            }
            else
            {
                m_EditToolStripMenuItem.Enabled = true;
                m_RemoveToolStripMenuItem.Enabled = true;
                m_DetailsToolStripMenuItem.Enabled = true;
            }
        }

        private void m_RefreshtoolStripButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                try
                {
                    UpdateStockHash();
                    DisplayStockList();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("An Error Occurred\nException Message: " + ee.Message);
                }
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void UpdateStockHash()
        {
            try
            {
                ErrorOccured = false;
                //Get Index Data
                if (m_ApplicationSettings.Index1Code.Length > 0)
                    GetStockData(m_ApplicationSettings.Index1Code, m_Index1Data);
                if (m_ApplicationSettings.Index2Code.Length > 0)
                    GetStockData(m_ApplicationSettings.Index2Code, m_Index2Data);

                //Copy has contents to an array
                StockData[] stockList = new StockData[m_StockHash.Count];
                lock (m_StockHash.SyncRoot)
                {
                    int index = 0;
                    foreach (string stockCode in m_StockHash.Keys)
                    {
                        stockList[index] = (StockData)m_StockHash[stockCode];
                        index++;
                    }
                }

                //Get stock live data from web
                foreach (StockData stockData in stockList)
                {
                    GetStockData(stockData.Code, stockData);
                }

                //Update back in Hash table
                lock (m_StockHash.SyncRoot)
                {
                    foreach (StockData stockData in stockList)
                    {
                        if (m_StockHash.ContainsKey(stockData.Code))
                        {
                            m_StockHash[stockData.Code] = stockData;
                        }
                    }
                }
            }
            catch (System.Threading.ThreadAbortException)
            {
            }
            catch (Exception ee)
            {
                try
                {
                    ErrorOccured = true;
                    this.Text = "StockBag - " + "Error: " + ee.Message;
                }
                catch
                {
                }
            }
        }

        private bool ErrorOccured
        {
            get
            {
                lock(this)
                {
                    return m_ErrorOccured;
                }
            }
            set
            {
                lock (this)
                {
                    m_ErrorOccured = value;
                }
            }
        }

        private void GetStockData(string stockCode, StockData stockData)
        {
            string serverUrl = @"http://in.finance.yahoo.com/d/quotes.csv?s="+stockCode+
                    "&f=sl1d1t1c1ohgvj1pp2owern&e=.csv";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(serverUrl);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream(), 
                Encoding.ASCII);

            string stockDataString = reader.ReadLine();
            string[] stockDataContents = stockDataString.Split(',');

            stockData.Code = stockCode;
            stockData.Last = stockDataContents[1];
            stockData.Date = stockDataContents[2];
            stockData.Time = stockDataContents[3];
            stockData.Change = stockDataContents[4];
            stockData.Open = stockDataContents[5];
            stockData.High = stockDataContents[6];
            stockData.Low = stockDataContents[7];
            stockData.Volume = stockDataContents[8];
            stockData.MarketCapital = stockDataContents[9];
            stockData.PreviousClose = stockDataContents[10];
            stockData.PctChange = stockDataContents[11];
            stockData.AnnRange = stockDataContents[12];
            stockData.Earnings = stockDataContents[13];
            stockData.PERatio = stockDataContents[14];

            response.Close();
        }

        //Depending on selected node - display latest data in list
        private void DisplayStockList()
        {
            TreeNode parent = ParentContext;

            if (ParentContext.Text == WATCHLIST_NAME)
                m_StockInfoList.Columns[5].Text = "Target Price";
            else
                m_StockInfoList.Columns[5].Text = "Buy Price";
            //Display Index(s) on Title Bar
            DisplayIndexInTitleBar();

            m_StockInfoList.Items.Clear();
            
            if(m_StockHash.Count == 0)
                return;

            float todaysChange = 0;
            float netChange = 0;
            float totalInitial = 0;
            float totalCurrent = 0;

            foreach (TreeNode child in parent.Nodes)
            {
                StockData stockData = (StockData)m_StockHash[child.Tag as string];
                if (stockData != null)
                {
                    float diff=0, percentDiff=0, netDiff=0, percentNetDiff=0;
                    ListViewItem item = new ListViewItem(new string[] { child.Text,
                        "Error"});
                    try
                    {
                        diff = Convert.ToSingle(stockData.Last) -
                            Convert.ToSingle(stockData.PreviousClose);
                        percentDiff = (diff * 100) / Convert.ToSingle(stockData.PreviousClose);

                        netDiff = (Convert.ToSingle(stockData.Last) - stockData.BuyPrice) *
                            stockData.BuyQuantity;
                        percentNetDiff = (netDiff * 100) / (stockData.BuyPrice * stockData.BuyQuantity);

                        todaysChange += diff * stockData.BuyQuantity;
                        netChange += netDiff;
                        totalInitial += stockData.BuyPrice * stockData.BuyQuantity;
                        totalCurrent += Convert.ToSingle(stockData.Last) * stockData.BuyQuantity;

                        item = new ListViewItem(new string[] { child.Text, 
                        String.Format("{0:F2}",Convert.ToSingle(stockData.Last)),
                        String.Format("{0:F2}%",percentDiff),
                        String.Format("{0:F2}",Convert.ToSingle(stockData.PreviousClose)),
                        String.Format("{0:F2}",diff),
                        String.Format("{0:F2}",stockData.BuyPrice),
                        stockData.BuyQuantity.ToString(),
                        String.Format("{0:F2}%",percentNetDiff),
                        String.Format("{0:F2}",stockData.BuyPrice * stockData.BuyQuantity),
                        String.Format("{0:F2}",netDiff),
                        String.Format("{0:F2}",Convert.ToSingle(stockData.Last) * stockData.BuyQuantity)
                        });

                        item.Tag = stockData.Code;
                    }
                    catch
                    {
                    }

                    //Change sub item colors depending on sign
                    if (item.SubItems.Count > 2) //If no error has occurred while getting this stock
                    {
                        item.UseItemStyleForSubItems = false;
                        //Percent Difference
                        if (percentDiff > 0)
                        {
                            item.SubItems[2].ForeColor = Color.DarkGreen;
                            item.SubItems[2].Text = "+" + item.SubItems[2].Text;
                        }
                        else if (percentDiff < 0)
                            item.SubItems[2].ForeColor = Color.Red;
                        else
                            item.SubItems[2].ForeColor = Color.Black;
                        //Difference
                        if (diff > 0)
                        {
                            item.SubItems[4].ForeColor = Color.DarkGreen;
                            item.SubItems[4].Text = "+" + item.SubItems[4].Text;
                        }
                        else if (diff < 0)
                            item.SubItems[4].ForeColor = Color.Red;
                        else
                            item.SubItems[4].ForeColor = Color.Black;
                        //Percent Net Difference
                        if (percentNetDiff > 0)
                        {
                            item.SubItems[7].ForeColor = Color.DarkGreen;
                            item.SubItems[7].Text = "+" + item.SubItems[7].Text;
                        }
                        else if (percentNetDiff < 0)
                            item.SubItems[7].ForeColor = Color.Red;
                        else
                            item.SubItems[7].ForeColor = Color.Black;
                        //Net Difference
                        if (netDiff > 0)
                        {
                            item.SubItems[9].ForeColor = Color.DarkGreen;
                            item.SubItems[9].Text = "+" + item.SubItems[9].Text;
                        }
                        else if (netDiff < 0)
                            item.SubItems[9].ForeColor = Color.Red;
                        else
                            item.SubItems[9].ForeColor = Color.Black;
                    }
                    
                    m_StockInfoList.Items.Add(item);
                }
            }

            //Update Status Bar
            if (ParentContext.Text == PORTFOLIO_NAME)
            {
                string statusText = "";
                if (todaysChange < 0)
                    statusText = "Todays Loss: ";
                else
                    statusText = "Todays Gain: ";
                statusText += String.Format("{0:F2}({1:F2}%)", todaysChange, 
                    (100*todaysChange)/totalInitial);

                if (netChange < 0)
                    statusText += " Net Loss: ";
                else
                    statusText += " Net Gain: ";
                statusText += String.Format("{0:F2}({1:F2}%)", netChange, (100*netChange)/totalInitial);

                statusText += " Investment: " + totalInitial + " Current Value: " + 
                    totalCurrent;
                Font font2 = new Font(toolStripStatusLabel1.Font.FontFamily,
                    toolStripStatusLabel1.Font.Size, FontStyle.Bold);
                toolStripStatusLabel1.Font = font2;
                toolStripStatusLabel1.Text = statusText;
            }
            else
            {
                toolStripStatusLabel1.Text = "";
            }
        }

        private TreeNode ParentContext
        {
            get
            {
                if (m_StockTree.SelectedNode == null)
                    return m_StockTree.Nodes[0];
                else if (m_StockTree.SelectedNode.Tag == null)
                    return m_StockTree.SelectedNode;
                else
                    return m_StockTree.SelectedNode.Parent;
            }
        }

        private void DisplayIndexInTitleBar()
        {
            if (ErrorOccured == true)
                return;     //Let the error message be there on title bar

            string indexText = "StockBag";

            try
            {
                float index1Last = Convert.ToSingle(m_Index1Data.Last);
                if (m_ApplicationSettings.Index1Code != "" &&
                    index1Last != 0)
                {
                    float index1PrevClose = Convert.ToSingle(m_Index1Data.PreviousClose);
                    float index1Diff = index1Last - index1PrevClose;
                    string index1DiffText;
                    if (index1Diff > 0)
                        index1DiffText = "(+" + String.Format("{0:F2})", index1Diff);
                    else
                        index1DiffText = "(" + String.Format("{0:F2})", index1Diff);
                    indexText += " - " + m_ApplicationSettings.Index1Name + " : " +
                            String.Format("{0:F2}", index1Last) + index1DiffText;
                }

                float index2Last = Convert.ToSingle(m_Index2Data.Last);
                if (m_ApplicationSettings.Index2Code != "" &&
                    index2Last != 0)
                {
                    float index2PrevClose = Convert.ToSingle(m_Index2Data.PreviousClose);
                    float index2Diff = index2Last - index2PrevClose;
                    string index2DiffText;
                    if (index2Diff > 0)
                        index2DiffText = "(+" + String.Format("{0:F2})", index2Diff);
                    else
                        index2DiffText = "(" + String.Format("{0:F2})", index2Diff);
                    indexText += " " + m_ApplicationSettings.Index2Name + " : " +
                            String.Format("{0:F2}", index2Last) + index2DiffText;
                }
            }
            catch (Exception e)
            {
            }

            this.Text = indexText;
        }

        private void m_AddStockToolStripButton_Click(object sender, EventArgs e)
        {
            AddEditStockForm addStockForm = new AddEditStockForm();
            TreeNode parent = ParentContext;
            if (parent.Text == PORTFOLIO_NAME)
            {
                addStockForm.Text = "Add Stock To Portfolio";
                addStockForm.SetStockType(StockType.PortfolioStock);
            }
            else
            {
                addStockForm.Text = "Add Stock To Watch List";
                addStockForm.SetStockType(StockType.WatchListStock);
            }

            if (addStockForm.ShowDialog() == DialogResult.OK)
            {
                TreeNode newNode = new TreeNode(addStockForm.StockName);
                StockData stockData = new StockData();
                stockData.Code = addStockForm.StockCode;
                stockData.BuyPrice = addStockForm.StockAveragePrice;
                stockData.BuyQuantity = addStockForm.StockQuantity;
                newNode.Tag = addStockForm.StockCode;

                lock (m_StockHash.SyncRoot)
                {
                    if (m_StockHash[addStockForm.StockCode] == null)
                    {
                        parent.Nodes.Add(newNode);
                        m_StockHash.Add(addStockForm.StockCode, stockData);
                        DisplayStockList();
                    }
                    else
                    {
                        MessageBox.Show("Stock Already Exists in either portfolio or watch list. Please add a stock with different code");
                    }
                    SaveStockData();
                }
            }
        }

        private void m_DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (m_StockTree.SelectedNode != null && m_StockTree.SelectedNode.Nodes.Count == 0)
            {
                lock (m_StockHash.SyncRoot)
                {
                    m_StockHash.Remove(m_StockTree.SelectedNode.Tag as string);
                    m_StockTree.Nodes[0].Nodes.Remove(m_StockTree.SelectedNode);
                    SaveStockData();
                }
                DisplayStockList();
            }
        }

        private void m_SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Load Settings
            m_SettingsForm.DataAccessInterval = m_ApplicationSettings.DataAccessInterval;
            m_SettingsForm.ListRefreshInterval = m_ApplicationSettings.ListRefreshInterval;
            m_SettingsForm.Index1Name = m_ApplicationSettings.Index1Name;
            m_SettingsForm.Index2Name = m_ApplicationSettings.Index2Name;
            m_SettingsForm.Index1Code = m_ApplicationSettings.Index1Code;
            m_SettingsForm.Index2Code = m_ApplicationSettings.Index2Code;

            if (m_SettingsForm.ShowDialog() == DialogResult.OK)
            {
                //Save settings
                m_ApplicationSettings.DataAccessInterval = m_SettingsForm.DataAccessInterval;
                m_ApplicationSettings.ListRefreshInterval = m_SettingsForm.ListRefreshInterval;
                m_ApplicationSettings.Index1Name = m_SettingsForm.Index1Name;
                m_ApplicationSettings.Index2Name = m_SettingsForm.Index2Name;
                m_ApplicationSettings.Index1Code = m_SettingsForm.Index1Code;
                m_ApplicationSettings.Index2Code = m_SettingsForm.Index2Code;
                m_ApplicationSettings.SaveApplicationSettings();

                //Set timer intervals read from app settings
                m_RefreshTimer.Interval = (int)m_ApplicationSettings.ListRefreshInterval * 1000;
                m_DataRequestTimer.Interval = (int)m_ApplicationSettings.DataAccessInterval * 1000;
            }
        }

        private void m_RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_RefreshtoolStripButton_Click(sender, e);
        }

        private void m_StockSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://in.finance.yahoo.com/lookup?");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Not Able to launch Search browser window.\nException Message: " + ee.Message);
            }
        }

        private void LoadStockData()
        {
            m_StockTree.Nodes.Clear();
            m_StockHash.Clear();

            TreeNode parent = new TreeNode(PORTFOLIO_NAME);
            m_StockTree.Nodes.Add(parent);
            TreeNode parentWatchList = new TreeNode(WATCHLIST_NAME);
            m_StockTree.Nodes.Add(parentWatchList);

            if (File.Exists(StockBagDataFile) == true)
            {
                XmlDocument document = new XmlDocument();
                document.Load(StockBagDataFile);

                //Add Portfolio Stocks
                XmlNodeList nodeList = document.GetElementsByTagName("Portfolio");
                foreach (XmlNode node in nodeList[0].ChildNodes)
                {
                    TreeNode child = new TreeNode(node.Attributes["Name"].Value);
                    child.Tag = node.Attributes["Code"].Value;

                    StockData stockData = new StockData();
                    stockData.Code = node.Attributes["Code"].Value;
                    stockData.BuyQuantity = Convert.ToUInt32(node.Attributes["BuyQuantity"].Value);
                    stockData.BuyPrice = Convert.ToSingle(node.Attributes["BuyPrice"].Value);

                    m_StockHash.Add(stockData.Code, stockData);

                    parent.Nodes.Add(child);
                }

                //Add WatchList Stocks
                nodeList = document.GetElementsByTagName("WatchList");
                foreach (XmlNode node in nodeList[0].ChildNodes)
                {
                    TreeNode child = new TreeNode(node.Attributes["Name"].Value);
                    child.Tag = node.Attributes["Code"].Value;

                    StockData stockData = new StockData();
                    stockData.Code = node.Attributes["Code"].Value;
                    stockData.BuyPrice = Convert.ToSingle(node.Attributes["TargetPrice"].Value);
                    stockData.BuyQuantity = 1;

                    m_StockHash.Add(stockData.Code, stockData);

                    parentWatchList.Nodes.Add(child);
                }

                m_StockTree.SelectedNode = parent;
            }
        }

        private void SaveStockData()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            XmlWriter writer = XmlWriter.Create(StockBagDataFile);
            
            writer.WriteStartDocument();
            writer.WriteStartElement("StockBagData");

            //Save current Portfolio
            writer.WriteStartElement("Portfolio");
            foreach (TreeNode node in m_StockTree.Nodes[0].Nodes)
            {
                StockData stockData = (StockData)m_StockHash[node.Tag as string];
                writer.WriteStartElement("Stock");
                writer.WriteAttributeString("Code", stockData.Code);
                writer.WriteAttributeString("Name", node.Text);
                writer.WriteAttributeString("BuyPrice", String.Format("{0:F2}",stockData.BuyPrice));
                writer.WriteAttributeString("BuyQuantity", stockData.BuyQuantity.ToString());
                writer.WriteEndElement();
                writer.WriteWhitespace("\r\n");
            }
            writer.WriteEndElement();
            writer.WriteWhitespace("\r\n");

            //Write Watch List 
            writer.WriteStartElement("WatchList");
            foreach (TreeNode node in m_StockTree.Nodes[1].Nodes)
            {
                StockData stockData = (StockData)m_StockHash[node.Tag as string];
                writer.WriteStartElement("Stock");
                writer.WriteAttributeString("Code", stockData.Code);
                writer.WriteAttributeString("Name", node.Text);
                writer.WriteAttributeString("TargetPrice", String.Format("{0:F2}", stockData.BuyPrice));
                writer.WriteEndElement();
                writer.WriteWhitespace("\r\n");
            }
            writer.WriteEndElement();
            writer.WriteWhitespace("\r\n");

            writer.WriteEndElement();
            writer.WriteWhitespace("\r\n");
            writer.WriteEndDocument();
            writer.Close();
        }

        private string StockBagDataFile
        {
            get
            {
                return ExecutableDirectory + "\\StockBagData.xml";
            }
        }

        public string ExecutableDirectory
        {
            get
            {
                string path = Application.ExecutablePath;
                path = path.Substring(0, path.LastIndexOf('\\'));
                return path;
            }
        }

        private void m_RefreshTimer_Tick(object sender, EventArgs e)
        {
            DisplayStockList();
        }

        private void m_DataRequestTimer_Tick(object sender, EventArgs e)
        {
            //Start the thread only if previous timer initiated thread is terminated
            if (m_DataRequestThread != null && m_DataRequestThread.ThreadState !=
                System.Threading.ThreadState.Stopped)
                return;

            UpdateStockHashThread();
        }

        private void UpdateStockHashThread()
        {
            m_DataRequestThread = new System.Threading.Thread(
             UpdateStockHash);
            m_DataRequestThread.Start();
        }

        private void m_StartStopToolStripButton_Click(object sender, EventArgs e)
        {
            if (m_AutoRefresh == true)  //We need to stop auto refresh
            {
                m_AutoRefresh = false;
                m_DataRequestTimer.Stop();
                m_RefreshTimer.Stop();
                m_StartStopToolStripButton.Image = m_ImageList.Images[1];
                m_StartStopToolStripButton.ToolTipText = "Start Automatic Refresh";
                m_RefreshtoolStripButton.Enabled = true;
                m_StartStopToolStripMenuItem.Text = "Start Auto Refresh";
                m_RefreshToolStripMenuItem.Enabled = true;

                //If the refresh thread is running abort it
                if (m_DataRequestThread !=null && m_DataRequestThread.IsAlive)
                    m_DataRequestThread.Abort();
            }
            else  //We need to start auto refresh
            {
                m_AutoRefresh = true;
                m_DataRequestTimer.Start();
                m_RefreshTimer.Start();
                m_StartStopToolStripButton.Image = m_ImageList.Images[0];
                m_StartStopToolStripButton.ToolTipText = "Stop Automatic Refresh";
                m_RefreshtoolStripButton.Enabled = false;
                m_StartStopToolStripMenuItem.Text = "Stop Auto Refresh";
                m_RefreshToolStripMenuItem.Enabled = false;

                //Start the refresh thread
                UpdateStockHashThread();
            }

            m_ApplicationSettings.AutoRefresh = m_AutoRefresh;
            m_ApplicationSettings.SaveApplicationSettings();
        }

        private void m_StartStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_StartStopToolStripButton_Click(sender, e);
        }

        private void m_EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditStockForm editStockForm = new AddEditStockForm();
            editStockForm.Text = "Edit Selected Stock";
            TreeNode parent = ParentContext;
            if (parent.Text == PORTFOLIO_NAME)
                editStockForm.SetStockType(StockType.PortfolioStock);
            else
                editStockForm.SetStockType(StockType.WatchListStock);

            string stockCode = m_StockTree.SelectedNode.Tag as string;
            StockData stockData;
            lock (m_StockHash.SyncRoot)
            {
                stockData = m_StockHash[stockCode] as StockData;
                editStockForm.StockCode = stockCode;
                editStockForm.StockName = m_StockTree.SelectedNode.Text;
                editStockForm.StockQuantity = stockData.BuyQuantity;
                editStockForm.StockAveragePrice = stockData.BuyPrice;
            }

            if (editStockForm.ShowDialog() == DialogResult.OK)
            {
                lock (m_StockHash.SyncRoot)
                {
                    //Check whether stock code name is changes & the changed name already exists
                    if (editStockForm.StockCode != stockCode &&
                        m_StockHash[editStockForm.StockCode] != null)
                    {
                        MessageBox.Show("Another stock with same stock code already exists. Please choose a different stock code");
                        return;
                    }
                    //Remove the Old stockData entry
                    m_StockHash.Remove(stockCode);

                    TreeNode node = m_StockTree.SelectedNode;
                    stockData.Code = editStockForm.StockCode;
                    stockData.BuyPrice = editStockForm.StockAveragePrice;
                    stockData.BuyQuantity = editStockForm.StockQuantity;
                    node.Text = editStockForm.StockName;
                    node.Tag = editStockForm.StockCode;
                    m_StockHash.Add(editStockForm.StockCode, stockData);
                    SaveStockData();
                }

                DisplayStockList();
            }
        }

        private void m_AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_AddStockToolStripButton_Click(sender, e);
        }

        private void m_RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_DeleteToolStripButton_Click(sender, e);
        }

        private void m_DetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDetails stockDetails = new StockDetails();
            string stockCode = m_StockTree.SelectedNode.Tag as string;
            StockData stockData = m_StockHash[stockCode] as StockData;
            stockDetails.SetStockDetails(stockData, m_StockTree.SelectedNode.Text);
            stockDetails.Show();
        }

        private void m_AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void m_ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_StockTree_DoubleClick(object sender, EventArgs e)
        {
            if (m_StockTree.SelectedNode != null &&
                m_StockTree.SelectedNode.Tag != null)
            {
                m_DetailsToolStripMenuItem_Click(sender, e);
            }
        }

        private void m_StockInfoList_DoubleClick(object sender, EventArgs e)
        {
            if (m_StockInfoList.SelectedItems.Count == 0)
                return;

            //Show stock details dialog
            StockDetails stockDetails = new StockDetails();
            string stockCode = m_StockInfoList.SelectedItems[0].Tag as string;
            StockData stockData = m_StockHash[stockCode] as StockData;
            stockDetails.SetStockDetails(stockData, m_StockInfoList.SelectedItems[0].Text);
            stockDetails.Show();
        }

    }
}
