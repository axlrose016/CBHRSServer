using AXLSmartRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Repositories
{
    public interface IWorkplaceApplicationPlanRepository : IRepository<WorkplaceAppicationPlan>
    {
        Task<Guid> UpdateWAPDetailsAsync(WorkplaceAppicationPlan wapDetail);
        Task<WorkplaceAppicationPlan> GetWAPById(Guid id);
        List<WorkplaceApplicationPlan_vw> GetWAPListView();
        List<WorkplaceAppicationPlan> GetWAPList();
    }
}
