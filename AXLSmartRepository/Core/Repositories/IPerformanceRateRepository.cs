using AXLSmartRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Repositories
{
    public interface IPerformanceRateRepository: IRepository<PerformanceRateDetails>
    {
        Task<Guid> UpdatePerformanceRate(PerformanceRateDetails performanceDetail);
        Task<PerformanceRateDetails> GetPerformanceById(Guid id);
        List<PerformanceRateResult_vw> GetPerformanceList();
    }
}
