using InvestEasy.FinancialModelingPrep.Abstractions.MarketIndexes;
using InvestEasy.FinancialModelingPrep.Core.Http;
using InvestEasy.FinancialModelingPrep.Model;
using InvestEasy.FinancialModelingPrep.Model.CompanyValuation;
using InvestEasy.FinancialModelingPrep.Model.MarketIndexes;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace InvestEasy.FinancialModelingPrep.Core.MarketIndexes
{
    public class MarketIndexesProvider : IMarketIndexesProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public MarketIndexesProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new System.ArgumentNullException(nameof(client));
        }

        public Task<ApiResponse<List<IndexConstituentResponse>>> GetDowJonesCompaniesAsync()
        {
            const string url = "[version]/dowjones_constituent";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
            };

            return client.GetJsonAsync<List<IndexConstituentResponse>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<IndexConstituentResponse>>> GetNasdaqCompaniesAsync()
        {
            const string url = "[version]/nasdaq_constituent";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
            };

            return client.GetJsonAsync<List<IndexConstituentResponse>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<IndexConstituentResponse>>> GetSP500CompaniesAsync()
        {
            const string url = "[version]/sp500_constituent";

            var pathParams = new NameValueCollection()
            {
                { "version", ApiVersion.v3.ToString() },
            };

            return client.GetJsonAsync<List<IndexConstituentResponse>>(url, pathParams, null);
        }
    }
}
