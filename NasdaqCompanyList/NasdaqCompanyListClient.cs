// <copyright file="NasdaqCompanyListClient.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace Hilres.NasdaqCompanyList
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using Hilres.CSV;

    /// <summary>
    /// Nasdaq company list client class.
    /// </summary>
    public class NasdaqCompanyListClient
    {
        /// <summary>
        /// Get company list.
        /// </summary>
        /// <param name="exchange">The exchange to get the company names.</param>
        /// <returns>List of companies.</returns>
        public async Task<IEnumerable<Company>> GetCompanyListAsync(ExchangeSymbol exchange)
        {
            string url = $"https://www.nasdaq.com/screening/companies-by-name.aspx?exchange={exchange}&render=download";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
            request.Headers.Add(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");

            using (HttpWebResponse response = (HttpWebResponse)(await request.GetResponseAsync()))
            using (Stream responseStream = response.GetResponseStream())
            using (TextReader reader = new StreamReader(responseStream))
            {
                string[] header = CSV.Import(reader);

                IEnumerable<Company> companies = CSV.ImportToArray(reader)
                    .Select(r => new Company
                    {
                        Symbol = r[0],
                        Name = r[1],
                        LastSale = Parse.NullFloat(r[2]),
                        MarketCap = r[3],
                        IPOyear = Parse.NullInt(r[4]),
                        Sector = r[5],
                        Industry = r[6],
                        SummaryQuote = r[7]
                    });

                return companies.ToArray();
            }

            //// "Symbol","Name","LastSale","MarketCap","IPOyear","Sector","industry","Summary Quote",
            //// https://www.nasdaq.com/screening/companies-by-industry.aspx
        }
    }
}