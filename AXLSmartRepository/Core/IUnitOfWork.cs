using AXLSmartRepository.Core.Models;
using AXLSmartRepository.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; set; }
        IPersonRepository Persons { get; set; }
        ILibraryRepository Libraries { get; set; }
        ISettingRepository Settings { get; set; }
        IWorkplaceApplicationPlanRepository WorkplaceApplicationPlans { get; set; }
        ILDNARepository LDNA { get; set; }
        IClearanceRepository Clearances { get; set; }
        IPES11Repository PES11s { get; set; }
        IPerformanceMgntRepository PerformanceMgnts { get; set; }
        IRecruitmentRepository Recruitment { get; set; }
        IPerformanceRateRepository PerformanceRates { get; set; }
        int Complete();
    }
}
