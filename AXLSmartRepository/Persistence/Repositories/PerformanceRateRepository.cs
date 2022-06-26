using AXLSmartRepository.Core.Models;
using AXLSmartRepository.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Persistence.Repositories
{
    public class PerformanceRateRepository : Repository<PerformanceRateDetails>, IPerformanceRateRepository
    {
        public PerformanceRateRepository(PlutoContext _context) : base(_context) { }
        public async Task<PerformanceRateDetails> GetPerformanceById(Guid id)
        {
            return await PlutoContext.PerformanceRateDetails.Where(w => w.performanceRateId == id).FirstOrDefaultAsync();
        }

        public List<PerformanceRateResult_vw> GetPerformanceList()
        {
            return PlutoContext.PerformanceRateResult_vws.ToList();
        }

        public async Task<Guid> UpdatePerformanceRate(PerformanceRateDetails performanceDetail)
        {
            var performance = PlutoContext.PerformanceRateDetails.AsNoTracking().AsEnumerable().Where(w => w.performanceRateId == performanceDetail.performanceRateId).FirstOrDefault();
            if(performance != null)
            {
                PlutoContext.PerformanceRateDetails.Update(performanceDetail);
            }
            else
            {
                PlutoContext.PerformanceRateDetails.Add(performanceDetail);
            }
            PlutoContext.ChangeTracker.DetectChanges();
            await PlutoContext.SaveChangesAsync();
            return performanceDetail.performanceRateId;
        }

        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
    }
}
