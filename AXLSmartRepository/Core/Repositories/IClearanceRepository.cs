using AXLSmartRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Repositories
{
    public interface IClearanceRepository : IRepository<ClearanceDetail>
    {
        Task<Guid> UpdateClearanceDetailAsync(ClearanceDetail clearanceDetail);
        Task<ClearanceDetail> GetClearanceById(Guid id);
        List<ClearanceList_vw> GetClearaneListView();
    }
}
