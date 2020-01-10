using System;
namespace Library
{
    public enum SecurityType
    {
        Undefined = 0,

        /// <summary>
        /// Stocks are fractional pieces of publicly traded companies. This is
        /// the most basic type of security.
        /// </summary>
        Stock = 1,

        /// <summary>
        /// Options are financial instruments that are derivatives based on the
        /// value of underlying securities such as stocks.
        /// </summary>
        Option = 2,

        /// <summary>
        /// An exchange-traded fund (ETF) is a type of security that involves a
        /// collection of securities—such as stocks—that often tracks an
        /// underlying index, although they can invest in any number of industry
        /// sectors or use various strategies.
        /// </summary>
        ETF = 3,

        /// <summary>
        /// Indices consist of a hypothetical portfolio of securities representing
        /// a particular market or a segment of it
        /// </summary>
        Index = 4,

        /// <summary>
        /// A mutual fund is a type of financial vehicle made up of a pool of
        // money collected from many investors to invest in securities like
        // stocks, bonds, money market instruments, and other assets
        /// </summary>
        Mutual_Fund = 5,
    }

    public enum OptionExpirationType
    {
        Undefined = 0,

        /// <summary>
        /// Give the holder the right, but not the obligation, to sell a stock
        // if it reaches a certain strike price by the expiration date
        /// </summary>
        Puts = 1,

        /// <summary>
        /// Give the holder the right, but not the obligation, to buy a stock if
        //it reaches a certain strike price by the expiration date
        /// </summary>
        Calls = 2
    }

    public enum MessageSeverity
    {
        /// <summary>
        /// Used for advanced troubleshooting. This message usally constains
        /// operation transaction time, variable mapping and others informations
        /// relavant only to the tecnical team
        /// </summary>
        Verbose = 0,
        /// <summary>
        /// Messages that help troubleshooting problems. These are to be read and
        /// understood primarily by developers and system administrators
        /// </summary>
        Debug = 1,
        /// <summary>
        /// Messages that provide data and/or relevant information aimed for
        /// system administrators
        /// </summary>
        Information = 2,
        /// <summary>
        /// Indicates a condition that does not yet represents a problem but that
        /// if not remediated/troubleshoot will cause problems. This message should
        /// state the current state and the threshold where problems are expected
        /// </summary>
        Warning = 3,
        /// <summary>
        /// An error that caused some operation to fail.
        /// </summary>
        Error = 4,
        /// <summary>
        /// A situation caused by an error where some kind of damage was incurred
        /// or is imminent.
        /// </summary>
        Critical = 5
    }
}
