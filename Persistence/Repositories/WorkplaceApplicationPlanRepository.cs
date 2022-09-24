using AXLSmartRepository.Core.Models;
using AXLSmartRepository.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Persistence.Repositories
{
    public class WorkplaceApplicationPlanRepository : Repository<WorkplaceAppicationPlan>, IWorkplaceApplicationPlanRepository
    {
        public WorkplaceApplicationPlanRepository(PlutoContext _context) : base(_context) { }

        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }

        public async Task<WorkplaceAppicationPlan> GetWAPById(Guid id)
        {
            return await PlutoContext.WorkplaceAppicationPlans.Where(w => w.wapId == id).FirstOrDefaultAsync();
        }

        public List<WorkplaceApplicationPlan_vw> GetWAPListView()
        {
            return PlutoContext.WorkplaceApplicationPlan_vws.ToList();
        }

        public List<WorkplaceAppicationPlan> GetWAPList()
        {
            return PlutoContext.WorkplaceAppicationPlans.ToList();
        }

        public async Task<Guid> UpdateWAPDetailsAsync(WorkplaceAppicationPlan wapDetail)
        {
            var wap = PlutoContext.WorkplaceAppicationPlans.AsNoTracking().AsEnumerable().Where(w => w.wapId == wapDetail.wapId).FirstOrDefault();
            if(wap != null)
            {
                PlutoContext.WorkplaceAppicationPlans.Update(wapDetail);
            }
            else
            {
                PlutoContext.WorkplaceAppicationPlans.Add(wapDetail);
            }
            PlutoContext.ChangeTracker.DetectChanges();
            await PlutoContext.SaveChangesAsync();
            return wapDetail.wapId;
        }
    }
}
