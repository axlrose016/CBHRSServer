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
    public class PES11Repository : Repository<PES11Detail>, IPES11Repository
    {
        public PES11Repository(PlutoContext _context) : base(_context) { }

        public async Task<PES11Detail> GetPES11ById(Guid id)
        {
            return await PlutoContext.PES11s.Where(w => w.pes11Id == id).FirstOrDefaultAsync();

        }

        public List<PES11List_vw> GetPES11ListView()
        {
            return PlutoContext.PES11List_vws.ToList();
        }

        public async Task<Guid> UpdatePES11DetailAsync(PES11Detail pesDetail)
        {
            var pes = PlutoContext.PES11s.AsNoTracking().AsEnumerable().Where(w => w.pes11Id == pesDetail.pes11Id).FirstOrDefault();
            if (pes != null)
            {
                PlutoContext.PES11s.Update(pesDetail);
            }
            else
            {
                PlutoContext.PES11s.Add(pesDetail);
            }
            PlutoContext.ChangeTracker.DetectChanges();
            await PlutoContext.SaveChangesAsync();
            return pesDetail.pes11Id;
        }

        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
    }
}
