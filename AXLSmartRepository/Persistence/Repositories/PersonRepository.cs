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
    public class PersonRepository : Repository<PersonDetail>, IPersonRepository
    {
        public PersonRepository(PlutoContext _context) : base(_context) { }


        public async Task<Guid> UpdatePersonDetailsAsync(PersonDetail personDetail)
        {
            var person = PlutoContext.PersonDetails.AsNoTracking().AsEnumerable().Where(w => w.personId == personDetail.personId).FirstOrDefault();
            if (person != null)
            {
                PlutoContext.PersonDetails.Update(personDetail);
            }
            else
            {
                PlutoContext.PersonDetails.Add(personDetail);
            }
            PlutoContext.ChangeTracker.DetectChanges();
            await PlutoContext.SaveChangesAsync();
            return personDetail.personId;
        }
        public async Task<PersonDetail> GetPDSById(Guid id)
        {
            return await PlutoContext.PersonDetails.Where(w => w.userId == id).FirstOrDefaultAsync();
        }

        public List<PersonList_vw> GetPDSListView()
        {
            return PlutoContext.PersonList_vws.ToList();
        }

        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
    }
}
