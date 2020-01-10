using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Represents the HUB of operations
    /// </summary>
    public interface IMarketOperator : IDisposable
    {
        IMarketChannel CurrentChannel { get; set; }

        Task<Quote> GetQuote(string symbol);
        Task<IEnumerable<Quote>> GetQuotes(IEnumerable<string> symbols);
    }
}
