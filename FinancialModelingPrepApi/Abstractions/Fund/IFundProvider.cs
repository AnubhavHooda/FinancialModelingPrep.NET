using InvestEasy.FinancialModelingPrep.Model;
using InvestEasy.FinancialModelingPrep.Model.Fund;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvestEasy.FinancialModelingPrep.Abstractions.Fund
{
    public interface IFundProvider
    {
        public Task<ApiResponse<List<ETFStockExposureResponse>>> GetETFStockExposureAsync(string symbol);

    }
}
