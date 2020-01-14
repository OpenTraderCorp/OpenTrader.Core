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

    /// <summary>
    /// The health status of a given entity, process or autonomous agent
    /// </summary>
    public enum AgentStatus
    {
        /// <summary>
        /// No status could be obtained.
        /// If the agent persist on this state for long, it will be forcefully shutdown.
        /// </summary>
        Unresponsive = 0,

        /// <summary>
        /// Operating as designed
        /// </summary>
        Operational = 1,

        /// <summary>
        /// The entity is preparing itself to enter operational mode
        /// </summary>
        StartingUp = 2,

        /// <summary>
        /// The entity received the shutdown command and it's clearing itself
        /// </summary>
        ShuttingDown = 3,

        /// <summary>
        /// The entity is alive but it's not operating. It continues to receive
        /// data such as Quotes and Ticks, and respond to commands, but it does
        /// not issue orders.
        /// </summary>
        Paused = 4,

        /// <summary>
        /// An error state that could not be recovered from
        /// </summary>
        Failure = 5,

        /// <summary>
        /// This is the status of a entity that has been shutdown or never started
        /// in the first place
        /// </summary>
        Off = 6,

        /// <summary>
        /// This agent is handling some kind of problem and requires assistance.
        /// The platform will try to provide extended resources and time allocation
        /// and increase the healthcheck rate.
        /// If the agent persist on this state for long, it will be gracefuly shutdown.
        /// </summary>
        Distressed = 7
    }

    /// <summary>
    /// Indicates how the shutdown order should be handled
    /// </summary>
    public enum ShutdownOrderSeverity
    {
        /// <summary>
        /// A shutdown that has been request on a controlled fashion. Failure to
        /// comply will not result in forceful termination.
        /// </summary>
        Graceful = 1,
        /// <summary>
        /// A shutdown that has been initiated automatically by the platform.
        /// Failure to comply will result in forceful termination
        /// </summary>
        Abrupt = 2,
        /// <summary>
        /// A shutdown that has been initiated automatically and is platform wide.
        /// Communications might have been disrupted and should be tested. No
        /// guarantees are offered in this case.
        /// </summary>
        Emergency = 3
    }
}
