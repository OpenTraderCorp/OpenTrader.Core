using System;

namespace Library
{
    /// <summary>
    /// Represents the last price at which a security or commodity traded,
    /// meaning the most recent price to which a buyer and seller agreed and at
    /// which some amount of the asset was transacted.
    /// </summary>
    public class Quote
    {
        /// <summary>
        /// Security Simbol
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Security detailed name or short description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Exchange Code of the security
        /// </summary>
        public string ExchangeCode { get; set; }

        /// <summary>
        /// The type of the security quoted
        /// </summary>
        public SecurityType Type { get; set; }

        /// <summary>
        /// Detailed information about the price, including the bid and ask
        /// </summary>
        public PriceDetails PriceInformation { get; set; }

        /// <summary>
        /// Current day's volume
        /// </summary>
        public long Volume { get; set; }

        /// <summary>
        /// Avarage volume of the security
        /// </summary>
        public long AverageVolume { get; set; }

        /// <summary>
        /// Volume of the last price
        /// </summary>
        public long LastVolume { get; set; }

        /// <summary>
        /// Most recent trade date
        /// </summary>
        public DateTime? TradeDate { get; set; }

        /// <summary>
        /// Size of the bid
        /// </summary>
        public long Bidsize { get; set; }

        /// <summary>
        /// Bid exchange code
        /// </summary>
        public string BidExchangeCode { get; set; }

        /// <summary>
        /// Date of bid price
        /// </summary>
        public DateTime? BidDate { get; set; }

        /// <summary>
        /// Size of Ask
        /// </summary>
        public long AskSize { get; set; }

        /// <summary>
        /// Ask Exchange Code
        /// </summary>
        public string AskExchangeCode { get; set; }

        /// <summary>
        /// Data of Ask price
        /// </summary>
        public DateTime AskDate { get; set; }

        /// <summary>
        /// Options Details. Only present if the current quote is a Option
        /// </summary>
        public OptionQuoteDetails OptionDetails { get; set; }
    }
}
