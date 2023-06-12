using InvestEasy.FinancialModelingPrep.Abstractions.AdvancedData;
using InvestEasy.FinancialModelingPrep.Abstractions.Calendars;
using InvestEasy.FinancialModelingPrep.Abstractions.CompanyValuation;
using InvestEasy.FinancialModelingPrep.Abstractions.Economics;
using InvestEasy.FinancialModelingPrep.Abstractions.Fund;
using InvestEasy.FinancialModelingPrep.Abstractions.InstitutionalFund;
using InvestEasy.FinancialModelingPrep.Abstractions.MarketIndexes;
using InvestEasy.FinancialModelingPrep.Abstractions.Statistics;
using InvestEasy.FinancialModelingPrep.Abstractions.StockMarket;
using InvestEasy.FinancialModelingPrep.Abstractions.StockTimeSeries;

namespace InvestEasy.FinancialModelingPrep
{
    /// <summary>
    /// FMP Client that exposes different sections of Endpoints
    /// </summary>
    public interface IFinancialModelingPrepApiClient
    {
        /// <summary>
        /// Advanced Data Endpoints are grouped here
        /// Note: most of these endpoints require a premium API Key
        /// </summary>
        public IAdvancedDataProvider AdvancedData { get; }

        /// <summary>
        /// All Company Valuation Endpoints are grouped here
        /// </summary>
        public ICompanyValuationProvider CompanyValuation { get; }

        /// <summary>
        /// All Market Index Endpoints are grouped here
        /// </summary>
        public IMarketIndexesProvider MarketIndexes { get; }

        /// <summary>
        /// All Calendar related Endpoints are grouped here (Earnings, IPO, stock splits, Dividends, Economic)
        /// </summary>
        public ICalendarsProvider Calendars { get; }

        /// <summary>
        /// All Instituational Fund Endpoints are grouped here
        /// </summary>
        public IInstitutionalFundProvider InstitutionalFund { get; }

        /// <summary>
        /// All Stock Time Series Endpoints are grouped here
        /// </summary>
        public IStockTimeSeriesProvider StockTimeSeries { get; }

        /// <summary>
        /// All Stock Market Related Endpoints are grouped here (Most Active, Gainers, Losers)
        /// </summary>
        public IStockMarketProvider StockMarket { get; }

        /// <summary>
        /// Statistic Related Endpoint are grouped here (Estimates)
        /// </summary>
        public IStockStatisticsProvider StockStatistics { get; }

        /// <summary>
        /// Cryptomarket related enpoints
        /// </summary>
        public ICryptoMarketProvider Crypto { get; }

        /// <summary>
        /// ETF/Mutual Fund related enpoints
        /// </summary>
        public IFundProvider Fund { get; }


        /// <summary>
        /// Economics related endpoints
        /// - Market risk premium
        /// - Treasury rates
        /// - Economic indicators
        /// </summary>
        public IEconomicsProvider Economics { get; }
    }
}
