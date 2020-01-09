using System;
namespace Library
{
    public class OptionQuoteDetails
    {
        //Open interest in option
        public int? OpenInterest { get; set; }

        //Size of the option contract. Typically 100.
        public long ContractSize { get; set; }

        //The last day that derivative contracts, such as options or futures, are valid.
        public DateTime ExpirationDate { get; set; }

        //The type of the option
        public OptionExpirationType Type { get; set; }
    }

}
