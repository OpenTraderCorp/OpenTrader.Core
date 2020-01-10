using System;
namespace Library
{
    public class PriceDetails
    {
        /// <summary>
        ///Last Price
        ////// </summary>
        public double? Last { get; set; }


        public double? Change { get; set; }

        /// <summary>
        /// Open Price of the current session
        /// </summary>
        public double? Open { get; set; }

        /// <summary>
        /// Highest price recorded for the current session
        /// </summary>
        public double? High { get; set; }

        /// <summary>
        /// Lowest price recorded for the current session
        /// </summary>
        public double? Low { get; set; }

        /// <summary>
        /// Close price for the current session
        /// </summary>
        public double? Close { get; set; }

        /// <summary>
        /// Previous close price
        /// </summary>
        public double Prevclose { get; set; }

        /// <summary>
        /// Ask Price
        /// </summary>
        public double Ask { get; set; }

        /// <summary>
        /// Bid Price
        /// </summary>
        public double Bid { get; set; }

        /// <summary>
        /// Highest recorded price for the last 52 weeks (1 year time)
        /// </summary>
        public double? Week52_High { get; set; }

        /// <summary>
        /// Lowest recorded price for the last 52 weeks (1 year time)
        /// </summary>
        public double? Week52_Low { get; set; }
    }
}
