using InvestEasy.FinancialModelingPrep.Model;
using InvestEasy.FinancialModelingPrep.Model.Crypto;
using InvestEasy.FinancialModelingPrep.Model.StockMarket;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvestEasy.FinancialModelingPrep.Abstractions.StockMarket
{
    public interface ICryptoMarketProvider
    {
        public Task<ApiResponse<List<CryptoItem>>> GetAvilableCryptocurrencies();

        public Task<ApiResponse<List<CryptoHistoricalPricePeriodListing>>> GetHistoricalPrices(string symbol, HistoricalPricingPeriod period);

        public Task<ApiResponse<CryptoHistoricalPriceDailyItem>> GetDailyPrices(string symbol);
    }
}
