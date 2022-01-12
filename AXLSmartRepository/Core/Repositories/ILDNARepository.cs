using AXLSmartRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Repositories
{
    public interface ILDNARepository : IRepository<LDNADetails>
    {
        Task<Guid> UpdateLDNADetails(LDNADetails ldnaDetail);
        Task<LDNADetails> GetLDNAById(Guid id);
        List<LDNADetails> GetLDNAList();
        Task<List<LDNAConsolidated_sp>> GetLDNAConsolidated_Sps();
    }
}
