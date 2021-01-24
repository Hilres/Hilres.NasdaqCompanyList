# Gets stock symbols from the Nasdaq website

[![NuGet](https://img.shields.io/badge/NuGet-0.1.0-blue.svg)](https://www.myget.org/feed/hilres/package/nuget/Hilres.NasdaqCompanyList)

This will retrieve a list of stock symbols for the NASDAQ, NYSE or AMEX exchanges.  The source of the data is from the Nasdaq website.  The data columns are "Symbol", "Name", "LastSale", "MarketCap", "IPOyear", "Sector", "industry" and "Summary Quote".

Data from: https://www.nasdaq.com/screening/company-list.aspx
https://old.nasdaq.com/screening/companies-by-name.aspx?letter=0&render=download

## Using Hilres.NasdaqCompanyList

```csharp
ExchangeSymbol exchange = ExchangeSymbol.NYSE;
NasdaqCompanyListClient client = new NasdaqCompanyListClient();
IEnumerable<Company> companies = await client.GetCompanyListAsync(exchange);
```
