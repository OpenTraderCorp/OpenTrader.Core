using System;
namespace Library
{
    /// <summary>
    /// Represents the entity that will execute buy and sell orders primarily.
    /// This could represents a Broker or a Exchange.
    /// </summary>
    /// <remarks>
    /// Brokers and Exchanges offer unique API's to perform trades, get quotes
    /// and other financials operations. This is meant as a abstraction layer
    /// which keeps the platform vendor-agnostic. Each implementation is supposed
    /// to adapt the data to the specific format of the broker/exchange.
    /// </remarks>
    public interface IMarketChannel
    {
    }
}
