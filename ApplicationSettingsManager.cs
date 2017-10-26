using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace StockBag
{
    class ApplicationSettingsManager
    {
        private const string DATA_ACCESS_INTERVAL = "DataAccessInterval";
        private const string LIST_REFRESH_INTERVAL = "ListRefreshInterval";
        private const string INDEX1_NAME = "Index1Name";
        private const string INDEX2_NAME = "Index2Name";
        private const string INDEX1_CODE = "Index1Code";
        private const string INDEX2_CODE = "Index2Code";
        private const string AUTO_REFRESH = "AutoRefresh";

        private string m_ApplicationSettingsFile = "";
        private uint m_DataAccessInterval = 60; //Seconds
        private uint m_ListRefreshInterval = 2; //Seconds
        private string m_Index1Name = "";
        private string m_Index2Name = "";
        private string m_Index1Code = "";
        private string m_Index2Code = "";
        private bool m_AutoRefresh = true;

        public ApplicationSettingsManager()
        {

        }

        public string ApplicationSettingsFile
        {
            get
            {
                return m_ApplicationSettingsFile;
            }
            set
            {
                m_ApplicationSettingsFile = value;
            }
        }

        public uint DataAccessInterval
        {
            get
            {
                return m_DataAccessInterval;
            }
            set
            {
                m_DataAccessInterval = value;
            }
        }

        public uint ListRefreshInterval
        {
            get
            {
                return m_ListRefreshInterval;
            }
            set
            {
                m_ListRefreshInterval = value;
            }
        }

        public string Index1Name
        {
            get
            {
                return m_Index1Name;
            }
            set
            {
                m_Index1Name = value;
            }
        }

        public string Index2Name
        {
            get
            {
                return m_Index2Name;
            }
            set
            {
                m_Index2Name = value;
            }
        }

        public string Index1Code
        {
            get
            {
                return m_Index1Code;
            }
            set
            {
                m_Index1Code = value;
            }
        }

        public string Index2Code
        {
            get
            {
                return m_Index2Code;
            }
            set
            {
                m_Index2Code = value;
            }
        }

        public bool AutoRefresh
        {
            get
            {
                return m_AutoRefresh;
            }
            set
            {
                m_AutoRefresh = value;
            }
        }

        public void LoadApplicationSettings()
        {
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load(m_ApplicationSettingsFile);
                XmlNodeList nodeList = document.GetElementsByTagName("ApplicationSettings");

                foreach (XmlNode node in nodeList[0].ChildNodes)
                {
                    switch (node.Name)
                    {
                        case DATA_ACCESS_INTERVAL:
                            m_DataAccessInterval = Convert.ToUInt32(node.FirstChild.Value);
                            break;
                        case LIST_REFRESH_INTERVAL:
                            m_ListRefreshInterval = Convert.ToUInt32(node.FirstChild.Value);
                            break;
                        case INDEX1_NAME:
                            if (node.FirstChild == null)
                                m_Index1Name = "";
                            else
                                m_Index1Name = node.FirstChild.Value;
                            break;
                        case INDEX2_NAME:
                            if (node.FirstChild == null)
                                m_Index2Name = "";
                            else
                                m_Index2Name = node.FirstChild.Value;
                            break;
                        case INDEX1_CODE:
                            if (node.FirstChild == null)
                                m_Index1Code = "";
                            else
                                m_Index1Code = node.FirstChild.Value;
                            break;
                        case INDEX2_CODE:
                            if (node.FirstChild == null)
                                m_Index2Code = "";
                            else
                                m_Index2Code = node.FirstChild.Value;
                            break;
                        case AUTO_REFRESH:
                            m_AutoRefresh = Convert.ToBoolean(node.FirstChild.Value);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch(Exception e)
            {
            }
        }

        public void SaveApplicationSettings()
        {
            XmlWriter writer = XmlWriter.Create(m_ApplicationSettingsFile);
            writer.WriteStartDocument();
            writer.WriteStartElement("ApplicationSettings");
            writer.WriteElementString(DATA_ACCESS_INTERVAL, m_DataAccessInterval.ToString());
            writer.WriteElementString(LIST_REFRESH_INTERVAL, m_ListRefreshInterval.ToString());
            writer.WriteElementString(INDEX1_NAME, m_Index1Name);
            writer.WriteElementString(INDEX2_NAME, m_Index2Name);
            writer.WriteElementString(INDEX1_CODE, m_Index1Code);
            writer.WriteElementString(INDEX2_CODE, m_Index2Code);
            writer.WriteElementString(AUTO_REFRESH, m_AutoRefresh.ToString());
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
