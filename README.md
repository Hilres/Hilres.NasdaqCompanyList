# Gets stock symbols from the NASDAQ website

**The URL does not work.  This project has been archived.**

This will retrieve a list of stock symbols for the NASDAQ, NYSE or AMEX exchanges.  The source of the data is from the Nasdaq website.  The data columns are "Symbol", "Name", "LastSale", "MarketCap", "IPOyear", "Sector", "industry" and "Summary Quote".

Data from: https://old.nasdaq.com/screening/company-list.aspx
https://old.nasdaq.com/screening/companies-by-name.aspx?letter=0&render=download

## Using Hilres.NasdaqCompanyList

```csharp
ExchangeSymbol exchange = ExchangeSymbol.NYSE;
NasdaqCompanyListClient client = new NasdaqCompanyListClient();
IEnumerable<Company> companies = await client.GetCompanyListAsync(exchange);
```
