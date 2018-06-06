// <copyright file="NasdaqCompanyListClientTest.cs" company="None">
// Copyright (c) None. All rights reserved.
// </copyright>

namespace Hilres.NasdaqCompanyList.Test
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>
    /// Nasdaq company list client test class.
    /// </summary>
    public class NasdaqCompanyListClientTest
    {
        /// <summary>
        /// Test get company list
        /// </summary>
        /// <param name="exchange">Exchange to test.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Theory]
        [InlineData(ExchangeSymbol.AMEX)]
        [InlineData(ExchangeSymbol.NASDAQ)]
        [InlineData(ExchangeSymbol.NYSE)]
        public async Task TestGetCompanyListAsync(ExchangeSymbol exchange)
        {
            var client = new NasdaqCompanyListClient();
            IEnumerable<Company> result = await client.GetCompanyListAsync(exchange);

            Assert.NotNull(result);
            Assert.True(result.Any(), $"No results for {exchange}.");

            Company company = result.First();
            Assert.IsType<string>(company.Symbol);
        }
    }
}