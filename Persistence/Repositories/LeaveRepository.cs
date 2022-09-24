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
    public class LeaveRepository : Repository<LeaveDetail>, ILeaveRepository
    {
        public LeaveRepository(PlutoContext _context) : base(_context) { }

        public async Task<LeaveDetail> GetLeaveAppById(Guid id)
        {
            return await PlutoContext.LeaveDetails.Where(w => w.leaveAppId == id).FirstOrDefaultAsync();
        }

        public List<LeaveList_vw> GetLeaveAppListView()
        {
            return PlutoContext.LeaveList_vws.ToList();
        }

        public async Task<Guid> UpdateLeaveDetailAsync(LeaveDetail leaveDetail)
        {
            var leave = PlutoContext.LeaveDetails.AsNoTracking()
                .AsEnumerable().Where(w => w.leaveAppId == leaveDetail.leaveAppId).FirstOrDefault();

            if(leave != null)
            {
                PlutoContext.LeaveDetails.Update(leaveDetail);
            }
            else
            {
                PlutoContext.LeaveDetails.Add(leaveDetail);
            }
            PlutoContext.ChangeTracker.DetectChanges();
            await PlutoContext.SaveChangesAsync();
            return leaveDetail.leaveAppId;
        }
        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
    }
}
