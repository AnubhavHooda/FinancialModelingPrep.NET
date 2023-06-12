using System;
using System.Threading.Tasks;

namespace InvestEasy.FinancialModelingPrep.Abstractions.Http
{
    public interface IRequestRateLimiter
    {
        public Task<(bool wasThrottled, TimeSpan totalDelay)> ThrottleAsync();
        public void ReleaseThrottle();
    }
}
