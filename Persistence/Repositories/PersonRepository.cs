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
                personDetail.vacation_leave_credit = 10;
                personDetail.sick_leave_credit = 10;
                PlutoContext.PersonDetails.Add(personDetail);
            }
            PlutoContext.ChangeTracker.DetectChanges();
            await PlutoContext.SaveChangesAsync();
            return personDetail.userId;
        }
        public async Task<PersonDetail> GetPDSById(Guid id)
        {
            return await PlutoContext.PersonDetails.Where(w => w.personId == id).FirstOrDefaultAsync();
        }

        public async Task<PersonDetail> GetPDSById(Guid id, int idType)
        {
            if(idType == 1)
            {
                return await PlutoContext.PersonDetails.Where(w => w.userId == id).FirstOrDefaultAsync();
            }
            else
            {
                return await PlutoContext.PersonDetails.Where(w => w.personId == id).FirstOrDefaultAsync();
            }
        }

        public List<PersonList_vw> GetPDSListView()
        {
            return PlutoContext.PersonList_vws.ToList();
        }

        public async Task<PersonDetail> GetPDSByUserId(Guid id)
        {
            return await PlutoContext.PersonDetails.Where(w => w.userId == id).FirstOrDefaultAsync();
        }

        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
    }
}
