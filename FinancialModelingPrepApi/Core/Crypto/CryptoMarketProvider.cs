using InvestEasy.FinancialModelingPrep.Abstractions.StockMarket;
using InvestEasy.FinancialModelingPrep.Core.Http;
using InvestEasy.FinancialModelingPrep.Model;
using InvestEasy.FinancialModelingPrep.Model.Crypto;
using InvestEasy.FinancialModelingPrep.Model.StockMarket;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace InvestEasy.FinancialModelingPrep.Core.StockMarket
{
    public sealed class CryptoMarketProvider : ICryptoMarketProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public CryptoMarketProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new System.ArgumentNullException(nameof(client));
        }

        public Task<ApiResponse<List<CryptoItem>>> GetAvilableCryptocurrencies()
        {

            const string url = "[version]/symbol/available-cryptocurrencies";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() }
            };

            return client.GetJsonAsync<List<CryptoItem>>(url, pathParams, null);
        }

        public Task<ApiResponse<CryptoHistoricalPriceDailyItem>> GetDailyPrices(string symbol)
        {
            const string url = "[version]/historical-price-full/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol }
            };

            return client.GetJsonAsync<CryptoHistoricalPriceDailyItem>(url, pathParams, null);
        }

        public Task<ApiResponse<List<CryptoHistoricalPricePeriodListing>>> GetHistoricalPrices(string symbol, HistoricalPricingPeriod period)
        {
            const string url = "[version]/historical-chart/[pricePeriod]/[symbol]";

            string pricePeriod = EnumMappings.HistoricalPrices[period];

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
                { "symbol", symbol },
                { "pricePeriod", pricePeriod }
            };

            var queryString = new QueryStringBuilder();

            return client.GetJsonAsync<List<CryptoHistoricalPricePeriodListing>>(url, pathParams, queryString);
        }
    }
}
