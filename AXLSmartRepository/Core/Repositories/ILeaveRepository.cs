using AXLSmartRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Repositories
{
    public interface ILeaveRepository : IRepository<LeaveDetail>
    {
        Task<Guid> UpdateLeaveDetailAsync(LeaveDetail leaveDetail);
        Task<LeaveDetail> GetLeaveAppById(Guid id);
        List<LeaveList_vw> GetLeaveAppListView();
    }

}
