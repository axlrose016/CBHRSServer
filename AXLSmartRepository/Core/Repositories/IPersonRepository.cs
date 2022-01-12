using AXLSmartRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Repositories
{
    public interface IPersonRepository : IRepository<PersonDetail>
    {
        Task<Guid> UpdatePersonDetailsAsync(PersonDetail personDetail);
        Task<PersonDetail> GetPDSById(Guid id);
        List<PersonList_vw> GetPDSListView();
    }
}
