using System;
namespace Library
{
    public enum SecurityType
    {
        Undefined = 0,
        //Stocks are fractional pieces of publicly traded companies. This is
        //the most basic type of security.
        Stock = 1,
        //Options are financial instruments that are derivatives based on the
        //value of underlying securities such as stocks.
        Option = 2,
        //An exchange-traded fund (ETF) is a type of security that involves a
        //collection of securities—such as stocks—that often tracks an
        //underlying index, although they can invest in any number of industry
        //sectors or use various strategies.
        ETF = 3,
        //Indices consist of a hypothetical portfolio of securities representing
        //a particular market or a segment of it
        Index = 4,
        //A mutual fund is a type of financial vehicle made up of a pool of
        //money collected from many investors to invest in securities like
        //stocks, bonds, money market instruments, and other assets
        Mutual_Fund = 5,
    }

    public enum OptionExpirationType
    {
        Undefined = 0,
        //Give the holder the right, but not the obligation, to sell a stock
        //if it reaches a certain strike price by the expiration date
        Puts = 1,
        //Give the holder the right, but not the obligation, to buy a stock if
        //it reaches a certain strike price by the expiration date
        Calls = 2
    }
}
