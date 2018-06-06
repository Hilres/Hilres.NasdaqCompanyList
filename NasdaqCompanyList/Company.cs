// <copyright file="Company.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace Hilres.NasdaqCompanyList
{
    /// <summary>
    /// Company class.
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Gets or sets industry.
        /// </summary>
        public string Industry { get; set; }

        /// <summary>
        /// Gets or sets IPO year.
        /// </summary>
        public int? IPOyear { get; set; }

        /// <summary>
        /// Gets or sets last sale.
        /// </summary>
        public float? LastSale { get; set; }

        /// <summary>
        /// Gets or sets market cap.
        /// </summary>
        public string MarketCap { get; set; }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets sector.
        /// </summary>
        public string Sector { get; set; }

        /// <summary>
        /// Gets or sets summary quote.
        /// </summary>
        public string SummaryQuote { get; set; }

        /// <summary>
        /// Gets or sets Symbol.
        /// </summary>
        public string Symbol { get; set; }
    }
}