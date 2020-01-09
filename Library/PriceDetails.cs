using System;
namespace Library
{
    internal class PriceDetails
    {
        //Last Price
        public double? Last { get; set; }
        //
        public double? Change { get; set; }
        //Open Price of the current session
        public double? Open { get; set; }
        //Highest price recorded for the current session
        public double? High { get; set; }
        //Lowest price recorded for the current session
        public double? Low { get; set; }
        //Close price for the current session
        public double? Close { get; set; }
        //Previous close price
        public double Prevclose { get; set; }
        //Ask Price
        public double Ask { get; set; }
        //Bid Price
        public double Bid { get; set; }
        //Highest recorded price for the last 52 weeks (1 year time)
        public double? Week52_High { get; set; }
        //Lowest recorded price for the last 52 weeks (1 year time)
        public double? Week52_Low { get; set; }
    }
}
