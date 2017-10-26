using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockBag
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public uint DataAccessInterval
        {
            get
            {
                return Convert.ToUInt32(m_DataAccessInterval.Text);
            }
            set
            {
                m_DataAccessInterval.Text = value.ToString();
            }
        }

        public uint ListRefreshInterval
        {
            get
            {
                return Convert.ToUInt32(m_ListRefreshInterval.Text);
            }
            set
            {
                m_ListRefreshInterval.Text = value.ToString();
            }
        }

        public string Index1Name
        {
            get
            {
                return m_Index1Name.Text;
            }
            set
            {
                m_Index1Name.Text = value;
            }
        }

        public string Index1Code
        {
            get
            {
                return m_Index1Code.Text;
            }
            set
            {
                m_Index1Code.Text = value;
            }
        }

        public string Index2Name
        {
            get
            {
                return m_Index2Name.Text;
            }
            set
            {
                m_Index2Name.Text = value; 
            }
        }

        public string Index2Code
        {
            get
            {
                return m_Index2Code.Text;
            }
            set
            {
                m_Index2Code.Text = value;
            }
        }

        private void m_DataAccessInterval_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToUInt32(m_DataAccessInterval.Text);
                m_OK.Enabled = true;
            }
            catch
            {
                m_OK.Enabled = false;
            }
        }

        private void m_ListRefreshInterval_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToUInt32(m_ListRefreshInterval.Text);
                m_OK.Enabled = true;
            }
            catch
            {
                m_OK.Enabled = false;
            }
        }
    }
}