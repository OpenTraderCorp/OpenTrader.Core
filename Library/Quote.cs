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
        //Security Simbol
        public string Symbol { get; set; }

        //Security detailed name or short description
        public string Description { get; set; }

        //Exchange Code of the security
        public string ExchangeCode { get; set; }

        //The type of the security quoted
        public SecurityType Type { get; set; }

        //Detailed information about the price, including the bid and ask
        public PriceDetails PriceInformation { get; set; }

        //Current day's volume
        public long Volume { get; set; }

        //Avarage volume of the security
        public long AverageVolume { get; set; }

        //Volume of the last price
        public long LastVolume { get; set; }

        //Most recent trade date
        public DateTime? TradeDate { get; set; }

        //Size of the bid
        public long Bidsize { get; set; }

        //Bid exchange code
        public string BidExchangeCode { get; set; }

        //Date of bid price
        public DateTime? BidDate { get; set; }

        //Size of Ask
        public long AskSize { get; set; }

        //Ask Exchange Code
        public string AskExchangeCode { get; set; }

        //Data of Ask price
        public DateTime AskDate { get; set; }

        //Options Details. Only present if the current quote is a Option
        public OptionQuoteDetails OptionDetails {get;set;}
    }
}
