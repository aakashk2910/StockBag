using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace StockBag
{
    public partial class AddEditStockForm : Form
    {
        public AddEditStockForm()
        {
            InitializeComponent();
        }

        public void SetStockType(StockType stockType)
        {
            if (stockType == StockType.WatchListStock)
            {
                //Hide/Rename controls
                m_LabelAveragePrice.Text = "Target Price";
                m_LabelQuantity.Visible = false;
                m_StockQuantity.Visible = false;
            }
        }

        public string StockCode
        {
            get
            {
                return m_StockCode.Text;
            }
            set
            {
                m_StockCode.Text = value;
            }
        }

        public string StockName
        {
            get
            {
                return m_StockName.Text;
            }
            set
            {
                m_StockName.Text = value;
            }
        }

        public System.UInt32 StockQuantity
        {
            get
            {
                try
                {
                    return Convert.ToUInt32(m_StockQuantity.Text);
                }
                catch
                {
                    return 0;
                }
            }
            set
            {
                m_StockQuantity.Text = value.ToString();
            }
        }

        public float StockAveragePrice
        {
            get
            {
                try
                {
                    return Convert.ToSingle(m_StockAveragePrice.Text);
                }
                catch
                {
                    return 0f;
                }
            }
            set
            {
                m_StockAveragePrice.Text = String.Format("{0:F2}",value);
            }
        }

        private void m_Search_Click(object sender, EventArgs e)
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

        private void m_StockQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToUInt32(m_StockQuantity.Text);
                m_OK.Enabled = true;
            }
            catch
            {
                m_OK.Enabled = false;
            }
        }

        private void m_StockAveragePrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToSingle(m_StockAveragePrice.Text);
                m_OK.Enabled = true;
            }
            catch
            {
                m_OK.Enabled = false;
            }
        }

        private void m_StockCode_TextChanged(object sender, EventArgs e)
        {
            if (m_StockCode.Text.Trim().Length == 0)
                m_OK.Enabled = false;
            else
                m_OK.Enabled = true;
        }

        private void m_StockName_TextChanged(object sender, EventArgs e)
        {
            if (m_StockName.Text.Trim().Length == 0)
                m_OK.Enabled = false;
            else
                m_OK.Enabled = true;
        }
    }
}