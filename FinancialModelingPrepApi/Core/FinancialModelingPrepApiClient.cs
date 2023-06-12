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

namespace InvestEasy.FinancialModelingPrep.Core
{
    /// <inheritdoc/>
    public class FinancialModelingPrepApiClient : IFinancialModelingPrepApiClient
    {
        /// <inheritdoc/>
        public ICompanyValuationProvider CompanyValuation { get; }

        /// <inheritdoc/>
        public IMarketIndexesProvider MarketIndexes { get; }

        /// <inheritdoc/>
        public IAdvancedDataProvider AdvancedData { get; }

        /// <inheritdoc/>
        public ICalendarsProvider Calendars { get; }

        /// <inheritdoc/>
        public IInstitutionalFundProvider InstitutionalFund { get; }

        /// <inheritdoc/>
        public IStockTimeSeriesProvider StockTimeSeries { get; }

        /// <inheritdoc/>
        public IStockMarketProvider StockMarket { get; }

        /// <inheritdoc/>
        public IStockStatisticsProvider StockStatistics { get; }

        /// <inheritdoc/>
        public ICryptoMarketProvider Crypto { get; }

        /// <inheritdoc/>
        public IFundProvider Fund { get; }

        /// <inheritdoc/>
        public IEconomicsProvider Economics { get; }

        /// <inheritdoc/>
        public FinancialModelingPrepApiClient(ICompanyValuationProvider companyValuation,
                                              IMarketIndexesProvider marketIndexes,
                                              IAdvancedDataProvider advancedData,
                                              ICalendarsProvider calendars,
                                              IInstitutionalFundProvider institutionalFund,
                                              IStockTimeSeriesProvider stockTimeSeries,
                                              IStockMarketProvider stockMarket,
                                              IStockStatisticsProvider stockStatistics,
                                              ICryptoMarketProvider cryptoMarket,
                                              IFundProvider fund,
                                              IEconomicsProvider economics)
        {
            CompanyValuation = companyValuation;
            MarketIndexes = marketIndexes;
            AdvancedData = advancedData;
            Calendars = calendars;
            InstitutionalFund = institutionalFund;
            StockTimeSeries = stockTimeSeries;
            StockMarket = stockMarket;
            StockStatistics = stockStatistics;
            Crypto = cryptoMarket;
            Fund = fund;
            Economics = economics;
        }
    }
}
