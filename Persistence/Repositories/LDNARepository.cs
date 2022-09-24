using AXLSmartRepository.Core.Models;
using AXLSmartRepository.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Persistence.Repositories
{
    public class LDNARepository : Repository<LDNADetails>, ILDNARepository
    {
        public LDNARepository(PlutoContext _context) : base(_context) { }
        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }

        public async Task<LDNADetails> GetLDNAById(Guid id)
        {
            return await PlutoContext.LDNADetails.Where(w => w.ldnaId == id).FirstOrDefaultAsync();
        }

        public async Task<List<LDNAConsolidated_sp>> GetLDNAConsolidated_Sps()
        {
            return await PlutoContext.LDNAConsolidated_Sps.FromSqlRaw("[dbo].[LDNAResult_sp]").ToListAsync();
        }

        public List<LDNAList_vw> GetLDNAList()
        {
            return PlutoContext.LDNAList_vws.ToList();
        }

        public async Task<Guid> UpdateLDNADetails(LDNADetails ldnaDetail)
        {
            var ldna = PlutoContext.LDNADetails.AsNoTracking().AsEnumerable().Where(w => w.ldnaId == ldnaDetail.ldnaId).FirstOrDefault();
            if(ldna != null)
            {
                PlutoContext.LDNADetails.Update(ldnaDetail);
            }
            else
            {
                PlutoContext.LDNADetails.Add(ldnaDetail);
            }
            PlutoContext.ChangeTracker.DetectChanges();
            await PlutoContext.SaveChangesAsync();
            return ldnaDetail.ldnaId;
        }
    }
}
