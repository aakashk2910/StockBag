using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockBag
{
    public partial class StockDetails : Form
    {
        public StockDetails()
        {
            InitializeComponent();
        }

        internal void SetStockDetails(StockData stockData, string name)
        {
            m_StockName.Text = name;
            m_StockCode.Text = stockData.Code;
            m_LastQuote.Text = stockData.Last;
            m_Date.Text = stockData.Date;
            m_Time.Text = stockData.Time;
            m_Change.Text = stockData.Change;
            m_Open.Text = stockData.Open;
            m_High.Text = stockData.High;
            m_Low.Text = stockData.Low;
            m_Volume.Text = stockData.Volume;
            m_MarketCapital.Text = stockData.MarketCapital;
            m_PreviousClose.Text = stockData.PreviousClose;
            m_PercentChange.Text = stockData.PctChange;
            //m_AnnRange.Text = stockData.AnnRange;
            //m_Earnings.Text = stockData.Earnings;
            m_PERatio.Text = stockData.PERatio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}