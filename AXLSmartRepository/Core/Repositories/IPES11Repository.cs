using AXLSmartRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Repositories
{
    public interface IPES11Repository : IRepository<PES11Detail>
    {
        Task<Guid> UpdatePES11DetailAsync(PES11Detail pesDetail);
        Task<PES11Detail> GetPES11ById(Guid id);
        List<PES11List_vw> GetPES11ListView();
    }
}
