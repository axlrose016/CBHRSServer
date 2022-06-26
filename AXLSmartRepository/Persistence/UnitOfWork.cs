using AXLSmartRepository.Core;
using AXLSmartRepository.Core.Models;
using AXLSmartRepository.Core.Repositories;
using AXLSmartRepository.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext Context;
        public IUserRepository Users { get; set; }
        public IPersonRepository Persons { get; set; }
        public ILibraryRepository Libraries { get; set; }
        public ISettingRepository Settings { get; set; }
        public IWorkplaceApplicationPlanRepository WorkplaceApplicationPlans { get; set; }
        public ILDNARepository LDNA { get; set; }
        public IClearanceRepository Clearances { get; set; }
        public IPES11Repository PES11s { get; set; }
        public IPerformanceMgntRepository PerformanceMgnts { get; set; }
        public IRecruitmentRepository Recruitment { get; set; }
        public IPerformanceRateRepository PerformanceRates { get; set; }

        public UnitOfWork(PlutoContext _context)
        {
            Context = _context;
            Users = new UserRepository(Context);
            Persons = new PersonRepository(Context);
            Libraries = new LibraryRepository(Context);
            Settings = new SettingRepository(Context);
            WorkplaceApplicationPlans = new WorkplaceApplicationPlanRepository(Context);
            LDNA = new LDNARepository(Context);
            Clearances = new ClearanceRepository(Context);
            PES11s = new PES11Repository(Context);
            PerformanceMgnts = new PerformanceMgntRepository(Context);
            Recruitment = new RecruitmentRepository(Context);
            PerformanceRates = new PerformanceRateRepository(Context);
        }

        public int Complete()
        {
            return Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
