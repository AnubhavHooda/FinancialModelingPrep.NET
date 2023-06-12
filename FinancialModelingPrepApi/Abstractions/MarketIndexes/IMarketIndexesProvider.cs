using InvestEasy.FinancialModelingPrep.Model;
using InvestEasy.FinancialModelingPrep.Model.MarketIndexes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvestEasy.FinancialModelingPrep.Abstractions.MarketIndexes
{
    public interface IMarketIndexesProvider
    {
        Task<ApiResponse<List<IndexConstituentResponse>>> GetSP500CompaniesAsync();
        Task<ApiResponse<List<IndexConstituentResponse>>> GetNasdaqCompaniesAsync();
        Task<ApiResponse<List<IndexConstituentResponse>>> GetDowJonesCompaniesAsync();
    }
}
