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
    public class ClearanceRepository : Repository<ClearanceDetail>, IClearanceRepository
    {
        public ClearanceRepository(PlutoContext _context) : base(_context) { }

        public async Task<ClearanceDetail> GetClearanceById(Guid id)
        {
            return await PlutoContext.Clearances.Where(w => w.clearanceId == id).FirstOrDefaultAsync();
        }

        public List<ClearanceList_vw> GetClearaneListView()
        {
            return PlutoContext.ClearanceList_vws.ToList();
        }

        public async Task<Guid> UpdateClearanceDetailAsync(ClearanceDetail clearanceDetail)
        {
            var clearance = PlutoContext.Clearances.AsNoTracking().AsEnumerable().Where(w => w.clearanceId == clearanceDetail.clearanceId).FirstOrDefault();
            if(clearance != null)
            {
                PlutoContext.Clearances.Update(clearanceDetail);
            }
            else
            {
                PlutoContext.Clearances.Add(clearanceDetail);
            }
            PlutoContext.ChangeTracker.DetectChanges();
            await PlutoContext.SaveChangesAsync();
            return clearanceDetail.clearanceId;
        }

        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
    }
}
