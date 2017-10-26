using System;
using System.Collections.Generic;
using System.Text;

namespace StockBag
{
    public enum StockType
    {
        PortfolioStock = 0,
        WatchListStock = 1
    }

    class StockData
    {
        public string Code;
        public string Last;
        public string Date;
        public string Time;
        public string Change;
        public string Open;
        public string High;
        public string Low;
        public string Volume;
        public string MarketCapital;
        public string PreviousClose;
        public string PctChange;
        public string AnnRange;
        public string Earnings;
        public string PERatio;

        public float BuyPrice;
        public UInt32 BuyQuantity;
    }
}
