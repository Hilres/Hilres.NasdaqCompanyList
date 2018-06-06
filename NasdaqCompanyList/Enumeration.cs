// <copyright file="Enumeration.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace Hilres.NasdaqCompanyList
{
    /// <summary>
    /// List of valid exchanges.
    /// https://www.stockmarketclock.com/exchanges
    /// </summary>
    public enum ExchangeSymbol
    {
        /// <summary>
        /// National Association of Securities Dealers Automated Quotation system.
        /// </summary>
        NASDAQ,

        /// <summary>
        /// New York Stock Exchange.
        /// </summary>
        NYSE,

        /// <summary>
        /// American Stock Exchange.
        /// </summary>
        AMEX
    }
}