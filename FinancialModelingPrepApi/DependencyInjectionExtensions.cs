using InvestEasy.FinancialModelingPrep.Abstractions.AdvancedData;
using InvestEasy.FinancialModelingPrep.Abstractions.Calendars;
using InvestEasy.FinancialModelingPrep.Abstractions.CompanyValuation;
using InvestEasy.FinancialModelingPrep.Abstractions.Economics;
using InvestEasy.FinancialModelingPrep.Abstractions.Fund;
using InvestEasy.FinancialModelingPrep.Abstractions.Http;
using InvestEasy.FinancialModelingPrep.Abstractions.InstitutionalFund;
using InvestEasy.FinancialModelingPrep.Abstractions.MarketIndexes;
using InvestEasy.FinancialModelingPrep.Abstractions.Statistics;
using InvestEasy.FinancialModelingPrep.Abstractions.StockMarket;
using InvestEasy.FinancialModelingPrep.Abstractions.StockTimeSeries;
using InvestEasy.FinancialModelingPrep.Core;
using InvestEasy.FinancialModelingPrep.Core.AdvancedData;
using InvestEasy.FinancialModelingPrep.Core.Calendars;
using InvestEasy.FinancialModelingPrep.Core.CompanyValuation;
using InvestEasy.FinancialModelingPrep.Core.Economics;
using InvestEasy.FinancialModelingPrep.Core.Fund;
using InvestEasy.FinancialModelingPrep.Core.Http;
using InvestEasy.FinancialModelingPrep.Core.InstitutionalFund;
using InvestEasy.FinancialModelingPrep.Core.MarketIndexes;
using InvestEasy.FinancialModelingPrep.Core.Statistics;
using InvestEasy.FinancialModelingPrep.Core.StockMarket;
using InvestEasy.FinancialModelingPrep.Core.StockTimeSeries;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace InvestEasy.FinancialModelingPrep
{
    public static class DependencyInjectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IFinancialModelingPrepApiClient"/> to the services.
        /// This package does not override any existing registrations. 
        /// </summary>
        /// <param name="services">DI Service Collection</param>
        /// <param name="options">FMP Options <see cref="FinancialModelingPrepOptions"/> if left as null it will use the default options and default API Key</param>
        public static void AddFinancialModelingPrepApiClient(this IServiceCollection services, FinancialModelingPrepOptions options = null)
        {
            services.TryAddSingleton(options ?? new FinancialModelingPrepOptions());

            services.AddLogging();

            services.AddHttpClient<FinancialModelingPrepHttpClient>(client 
                => client.BaseAddress = new Uri("https://financialmodelingprep.com/api/"));

            services.TryAddSingleton<IFinancialModelingPrepApiClient, FinancialModelingPrepApiClient>();
            services.TryAddSingleton<IRequestRateLimiter, RequestRateLimiter>();
            services.TryAddTransient<ICompanyValuationProvider, CompanyValuationProvider>();
            services.TryAddTransient<IMarketIndexesProvider, MarketIndexesProvider>();
            services.TryAddTransient<IAdvancedDataProvider, AdvancedDataProvider>();
            services.TryAddTransient<ICalendarsProvider, CalendarsProvider>();
            services.TryAddTransient<IInstitutionalFundProvider, InstitutionalFundProvider>();
            services.TryAddTransient<IStockTimeSeriesProvider, StockTimeSeriesProvider>();
            services.TryAddTransient<IStockMarketProvider, StockMarketProvider>();
            services.TryAddTransient<ICryptoMarketProvider, CryptoMarketProvider>();
            services.TryAddTransient<IStockStatisticsProvider, StockStatisticsProvider>();
            services.TryAddTransient<IFundProvider, FundProvider>();
            services.TryAddTransient<IEconomicsProvider, EconomicsProvider>();
        }
    }
}
