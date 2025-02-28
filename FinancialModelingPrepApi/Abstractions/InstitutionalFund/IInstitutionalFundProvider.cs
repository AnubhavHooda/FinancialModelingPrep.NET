﻿using InvestEasy.FinancialModelingPrep.Model;
using InvestEasy.FinancialModelingPrep.Model.InstitutionalFund;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvestEasy.FinancialModelingPrep.Abstractions.InstitutionalFund
{
    public interface IInstitutionalFundProvider
    {
        #region 13F
        /// <summary>
        /// Complete list of all institutional investment managers by cik 
        /// </summary>
        /// <returns></returns>
        public Task<ApiResponse<List<CikListResponse>>> Get13FListAsync();

        /// <summary>
        /// Cusip mapper
        /// </summary>
        /// <param name="cusip"></param>
        /// <returns></returns>
        public Task<ApiResponse<CusipMapperResponse>> MapCusipAsync(string cusip);

        /// <summary>
        /// FORM 13F cik search by name 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<ApiResponse<List<CikListResponse>>> SearchCikByName(string name);

        /// <summary>
        /// FORM 13F get company name by cik
        /// </summary>
        /// <param name="cik"></param>
        /// <returns></returns>
        public Task<ApiResponse<List<CikListResponse>>> GetCompanyNameByCik(string cik);

        /// <summary>
        /// FORM 13F statements provides position-level report of all institutional investment managers with more than $100m in assets under management (i.e. Berkshire hathaway cik).
        /// </summary>
        /// <param name="cik"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public Task<ApiResponse<List<Form13FResponse>>> GetForm13FAsync(string cik, string date);
        #endregion
    }
}
