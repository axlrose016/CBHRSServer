using AXLSmartRepository.Core.Models;
using AXLSmartRepository.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Persistence.Repositories
{
    public class LibraryRepository : ILibraryRepository
    {
        private PlutoContext _Context;
        public LibraryRepository(PlutoContext _context) { _Context = _context; }

        public IEnumerable<lib_brgy> FindBrgy(Expression<Func<lib_brgy, bool>> predicate)
        {
            return _Context.Lib_Barangays.Where(predicate);
        }

        public IEnumerable<lib_city> FindCity(Expression<Func<lib_city, bool>> predicate)
        {
            return _Context.Lib_Cities.Where(predicate);
        }

        public IEnumerable<lib_competency_category> FindCompetencyCategory(Expression<Func<lib_competency_category, bool>> predicate)
        {
            return _Context.Lib_Competency_Categories.Where(predicate);
        }

        public IEnumerable<lib_core_competency> FindCoreCompetency(Expression<Func<lib_core_competency, bool>> predicate)
        {
            return _Context.Lib_Core_Competencies.Where(predicate);
        }

        public IEnumerable<lib_department> FindDepartment(Expression<Func<lib_department, bool>> predicate)
        {
            return _Context.Lib_Departments.Where(predicate);
        }

        public IEnumerable<lib_job_category> FindJobCategory(Expression<Func<lib_job_category, bool>> predicate)
        {
            return _Context.Lib_Job_Categories.Where(predicate);
        }

        public IEnumerable<lib_occupational_group_code> FindOccupationalGroupCode(Expression<Func<lib_occupational_group_code, bool>> predicate)
        {
            return _Context.Lib_Occupational_Group_Codes.Where(predicate);
        }

        public IEnumerable<lib_occupational_service_code> FindOccupationalServiceCode(Expression<Func<lib_occupational_service_code, bool>> predicate)
        {
            return _Context.Lib_Occupational_Service_Codes.Where(predicate);
        }

        public IEnumerable<lib_province> FindProvince(Expression<Func<lib_province, bool>> predicate)
        {
            return _Context.Lib_Provinces.Where(predicate);
        }

        public IEnumerable<lib_region> FindRegion(Expression<Func<lib_region, bool>> predicate)
        {
            return _Context.Lib_Regions.Where(predicate);
        }

        public IEnumerable<lib_request_type> FindRequestType(Expression<Func<lib_request_type, bool>> predicate)
        {
            return _Context.Lib_Request_Types.Where(predicate);
        }

        public IEnumerable<lib_user_level> FindUserLevel(Expression<Func<lib_user_level, bool>> predicate)
        {
            return _Context.Lib_User_Levels.Where(predicate);
        }

        public IEnumerable<lib_brgy> GetAllBrgy()
        {
            return _Context.Lib_Barangays.ToList();
        }

        public IEnumerable<lib_city> GetAllCity()
        {
            return _Context.Lib_Cities.ToList();
        }

        public IEnumerable<lib_competency_category> GetAllCompetencyCategory()
        {
            return _Context.Lib_Competency_Categories.ToList();
        }

        public IEnumerable<lib_core_competency> GetAllCoreCompetency()
        {
            return _Context.Lib_Core_Competencies.ToList();
        }

        public IEnumerable<lib_department> GetAllDepartment()
        {
            return _Context.Lib_Departments.ToList();
        }

        public IEnumerable<lib_job_category> GetAllJobCategory()
        {
            return _Context.Lib_Job_Categories.ToList();
        }

        public IEnumerable<lib_occupational_group_code> GetAllOccupationalGroupCode()
        {
            return _Context.Lib_Occupational_Group_Codes.ToList();
        }

        public IEnumerable<lib_occupational_service_code> GetAllOccupationalServiceCode()
        {
            return _Context.Lib_Occupational_Service_Codes.ToList();
        }

        public IEnumerable<lib_province> GetAllProvince()
        {
            return _Context.Lib_Provinces.ToList();
        }

        public IEnumerable<lib_region> GetAllRegion()
        {
            return _Context.Lib_Regions.ToList();
        }

        public IEnumerable<lib_request_type> GetAllRequestType()
        {
            return _Context.Lib_Request_Types.ToList();
        }

        public IEnumerable<lib_user_level> GetAllUserLevel()
        {
            return _Context.Lib_User_Levels.ToList();
        }

        public lib_brgy GetBrgy(int id)
        {
            return _Context.Lib_Barangays.Find(id);
        }

        public lib_city GetCity(int id)
        {
            return _Context.Lib_Cities.Find(id);
        }

        public lib_competency_category GetCompetencyCategory(int id)
        {
            return _Context.Lib_Competency_Categories.Find(id);
        }

        public lib_core_competency GetCoreCompetency(int id)
        {
            return _Context.Lib_Core_Competencies.Find(id);
        }

        public lib_department GetDepartment(int id)
        {
            return _Context.Lib_Departments.Find(id);
        }

        public lib_job_category GetJobCategory(int id)
        {
            return _Context.Lib_Job_Categories.Find(id);
        }

        public lib_occupational_group_code GetOccupationalGroupCode(string id)
        {
            return _Context.Lib_Occupational_Group_Codes.Find(id);
        }

        public lib_occupational_service_code GetOccupationalServiceCode(string id)
        {
            return _Context.Lib_Occupational_Service_Codes.Find(id);
        }

        public lib_province GetProvince(int id)
        {
            return _Context.Lib_Provinces.Find(id);
        }

        public lib_region GetRegion(int id)
        {
            return _Context.Lib_Regions.Find(id);
        }

        public lib_request_type GetRequestType(int id)
        {
            return _Context.Lib_Request_Types.Find(id);
        }

        public lib_user_level GetUserLevel(int id)
        {
            return _Context.Lib_User_Levels.Find(id);
        }

        public void RemoveBrgy(lib_brgy entity)
        {
            _Context.Lib_Barangays.Remove(entity);
        }

        public void RemoveBrgyRange(IEnumerable<lib_brgy> entities)
        {
            _Context.Lib_Barangays.RemoveRange(entities);
        }

        public void RemoveCity(lib_city entity)
        {
            _Context.Lib_Cities.Remove(entity);
        }

        public void RemoveCityRange(IEnumerable<lib_city> entities)
        {
            _Context.Lib_Cities.RemoveRange(entities);
        }

        public void RemoveCompetencyCategory(lib_competency_category entity)
        {
            _Context.Lib_Competency_Categories.Remove(entity);
        }

        public void RemoveCompetencyCategoryRange(IEnumerable<lib_competency_category> entities)
        {
            _Context.Lib_Competency_Categories.RemoveRange(entities);
        }

        public void RemoveCoreCompetency(lib_core_competency entity)
        {
            _Context.Lib_Core_Competencies.Remove(entity);
        }

        public void RemoveCoreCompetencyRange(IEnumerable<lib_core_competency> entities)
        {
            _Context.Lib_Core_Competencies.RemoveRange(entities);
        }

        public void RemoveDepartment(lib_department entity)
        {
            _Context.Lib_Departments.Remove(entity);
        }

        public void RemoveDepartmentRange(IEnumerable<lib_department> entities)
        {
            _Context.Lib_Departments.RemoveRange(entities);
        }

        public void RemoveJobCategory(lib_job_category entity)
        {
            _Context.Lib_Job_Categories.Remove(entity);
        }

        public void RemoveJobCategoryRange(IEnumerable<lib_job_category> entities)
        {
            _Context.Lib_Job_Categories.RemoveRange(entities);
        }

        public void RemoveOccupationalGroupCode(lib_occupational_group_code entity)
        {
            _Context.Lib_Occupational_Group_Codes.Remove(entity);
        }

        public void RemoveOccupationalGroupCodeRange(IEnumerable<lib_occupational_group_code> entities)
        {
            _Context.Lib_Occupational_Group_Codes.RemoveRange(entities);
        }

        public void RemoveOccupationalServiceCode(lib_occupational_service_code entity)
        {
            _Context.Lib_Occupational_Service_Codes.Remove(entity);
        }

        public void RemoveOccupationalServiceCodeRange(IEnumerable<lib_occupational_service_code> entities)
        {
            _Context.Lib_Occupational_Service_Codes.RemoveRange(entities);
        }

        public void RemoveProvince(lib_province entity)
        {
            _Context.Lib_Provinces.Remove(entity);
        }

        public void RemoveProvinceRange(IEnumerable<lib_province> entities)
        {
            _Context.Lib_Provinces.RemoveRange(entities);
        }

        public void RemoveRegion(lib_region entity)
        {
            _Context.Lib_Regions.Remove(entity);
        }

        public void RemoveRegionRange(IEnumerable<lib_region> entities)
        {
            _Context.Lib_Regions.RemoveRange(entities);
        }

        public void RemoveRequestType(lib_request_type entity)
        {
            _Context.Lib_Request_Types.Remove(entity);
        }

        public void RemoveRequestTypeRange(IEnumerable<lib_request_type> entities)
        {
            _Context.Lib_Request_Types.RemoveRange(entities);
        }

        public void RemoveUserLevel(lib_user_level entity)
        {
            _Context.Lib_User_Levels.Remove(entity);
        }

        public void RemoveUserLevelRange(IEnumerable<lib_user_level> entities)
        {
            _Context.Lib_User_Levels.RemoveRange(entities);
        }

        public async Task<int> UpdateBrgy(lib_brgy entity)
        {
            var brgy = _Context.Lib_Barangays.AsNoTracking().AsEnumerable().Where(w => w.brgy_code == entity.brgy_code).FirstOrDefault();
            if (brgy != null)
            {
                _Context.Lib_Barangays.Update(entity);
            }
            else
            {
                _Context.Lib_Barangays.Add(entity);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return entity.rowid;
        }

        public async Task<int> UpdateBrgyRangeAsync(List<lib_brgy> entities)
        {
            await _Context.Lib_Barangays.AddRangeAsync(entities);
            await _Context.SaveChangesAsync();
            return entities.Count;
        }

        public async Task<int> UpdateCity(lib_city entity)
        {
            var city = _Context.Lib_Cities.AsNoTracking().AsEnumerable().Where(w => w.city_code == entity.city_code).FirstOrDefault();
            if (city != null)
            {
                _Context.Lib_Cities.Update(entity);
            }
            else
            {
                _Context.Lib_Cities.Add(entity);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return entity.rowid;
        }

        public async Task<int> UpdateCityRangeAsync(List<lib_city> entities)
        {
            await _Context.Lib_Cities.AddRangeAsync(entities);
            await _Context.SaveChangesAsync();
            return entities.Count;
        }

        public async Task<int> UpdateCompetencyCategory(lib_competency_category entity)
        {
            var competency_category = _Context.Lib_Competency_Categories.AsNoTracking().AsEnumerable().Where(w => w.competencyId == entity.competencyId).FirstOrDefault();
            if(competency_category != null)
            {
                _Context.Entry(competency_category).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                _Context.Lib_Competency_Categories.Update(entity);
            }
            else
            {
                _Context.Lib_Competency_Categories.Add(entity);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return entity.competencyId;
        }

        public async Task<int> UpdateCompetencyCategoryRangeAsync(List<lib_competency_category> entities)
        {
            await _Context.Lib_Competency_Categories.AddRangeAsync(entities);
            await _Context.SaveChangesAsync();
            return entities.Count;
        }

        public async Task<int> UpdateCoreCompetency(lib_core_competency entity)
        {
            var core_competency = _Context.Lib_Core_Competencies.AsNoTracking().AsEnumerable().Where(w => w.coreCompetencyId == entity.coreCompetencyId).FirstOrDefault();
            if(core_competency != null)
            {
                _Context.Entry(core_competency).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                _Context.Lib_Core_Competencies.Update(entity);
            }
            else
            {
                _Context.Lib_Core_Competencies.Add(entity);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return entity.coreCompetencyId;
        }

        public async Task<int> UpdateCoreCompetencyRangeAsync(List<lib_core_competency> entities)
        {
            await _Context.Lib_Core_Competencies.AddRangeAsync(entities);
            await _Context.SaveChangesAsync();
            return entities.Count;
        }

        public async Task<int> UpdateDepartment(lib_department entity)
        {
            var department = _Context.Lib_Departments.AsNoTracking().AsEnumerable().Where(w => w.departmentId == entity.departmentId).FirstOrDefault();
            if (department != null)
            {
                _Context.Entry(department).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                _Context.Lib_Departments.Update(entity);
            }
            else
            {
                _Context.Lib_Departments.Add(entity);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return entity.departmentId;
        }

        public async Task<int> UpdateDepartmentRangeAsync(List<lib_department> entities)
        {
            await _Context.Lib_Departments.AddRangeAsync(entities);
            await _Context.SaveChangesAsync();
            return entities.Count;
        }

        public async Task<int> UpdateJobCategory(lib_job_category entity)
        {
            var jobCategory = _Context.Lib_Job_Categories.AsNoTracking().AsEnumerable().Where(w => w.jobCategoryId == entity.jobCategoryId).FirstOrDefault();
            if (jobCategory != null)
            {
                _Context.Entry(jobCategory).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                _Context.Lib_Job_Categories.Update(entity);
            }
            else
            {
                _Context.Lib_Job_Categories.Add(entity);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return entity.jobCategoryId;
        }

        public async Task<int> UpdateJobCategoryRangeAsync(List<lib_job_category> entities)
        {
            await _Context.Lib_Job_Categories.AddRangeAsync(entities);
            await _Context.SaveChangesAsync();
            return entities.Count;
        }

        public async Task<string> UpdateOccupationalGroupCode(lib_occupational_group_code entity)
        {
            var lib_occupation_group = _Context.Lib_Occupational_Group_Codes.AsNoTracking().AsEnumerable().Where(w => w.occupational_grp_code == entity.occupational_grp_code).FirstOrDefault();
            if (lib_occupation_group != null)
            {
                _Context.Entry(lib_occupation_group).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                _Context.Lib_Occupational_Group_Codes.Update(entity);
            }
            else
            {
                _Context.Lib_Occupational_Group_Codes.Add(entity);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return entity.occupational_grp_code;
        }

        public async Task<int> UpdateOccupationalGroupCodeRangeAsync(List<lib_occupational_group_code> entities)
        {
            await _Context.Lib_Occupational_Group_Codes.AddRangeAsync(entities);
            await _Context.SaveChangesAsync();
            return entities.Count;
        }

        public async Task<string> UpdateOccupationalServiceCode(lib_occupational_service_code entity)
        {
            var lib_occupation_service = _Context.Lib_Occupational_Service_Codes.AsNoTracking().AsEnumerable().Where(w => w.occupational_serv_code == entity.occupational_serv_code).FirstOrDefault();
            if (lib_occupation_service != null)
            {
                _Context.Entry(lib_occupation_service).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                _Context.Lib_Occupational_Service_Codes.Update(entity);
            }
            else
            {
                _Context.Lib_Occupational_Service_Codes.Add(entity);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return entity.occupational_serv_code;
        }

        public async Task<int> UpdateOccupationalServiceCodeRangeAsync(List<lib_occupational_service_code> entities)
        {
            await _Context.Lib_Occupational_Service_Codes.AddRangeAsync(entities);
            await _Context.SaveChangesAsync();
            return entities.Count;
        }

        public async Task<int> UpdateProvince(lib_province entity)
        {
            var province = _Context.Lib_Cities.AsNoTracking().AsEnumerable().Where(w => w.prov_code == entity.prov_code).FirstOrDefault();
            if (province != null)
            {
                _Context.Lib_Provinces.Update(entity);
            }
            else
            {
                _Context.Lib_Provinces.Add(entity);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return entity.rowid;
        }

        public async Task<int> UpdateProvinceRangeAsync(List<lib_province> entities)
        {
            await _Context.Lib_Provinces.AddRangeAsync(entities);
            await _Context.SaveChangesAsync();
            return entities.Count;
        }

        public async Task<int> UpdateRegion(lib_region entity)
        {
            var region = _Context.Lib_Regions.AsNoTracking().AsEnumerable().Where(w => w.region_code == entity.region_code).FirstOrDefault();
            if (region != null)
            {
                _Context.Lib_Regions.Update(entity);
            }
            else
            {
                _Context.Lib_Regions.Add(entity);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return entity.rowid;
        }

        public async Task<int> UpdateRegionRangeAsync(List<lib_region> entities)
        {
            await _Context.Lib_Regions.AddRangeAsync(entities);
            await _Context.SaveChangesAsync();
            return entities.Count;
        }

        public async Task<int> UpdateRequestType(lib_request_type entity)
        {
            var requestType = _Context.Lib_Request_Types.AsNoTracking().AsEnumerable().Where(w => w.requestTypeId == entity.requestTypeId).FirstOrDefault();
            if (requestType != null)
            {
                _Context.Entry(requestType).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                _Context.Lib_Request_Types.Update(entity);
            }
            else
            {
                _Context.Lib_Request_Types.Add(entity);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return entity.requestTypeId;
        }

        public async Task<int> UpdateRequestTypeRangeAsync(List<lib_request_type> entities)
        {
            await _Context.Lib_Request_Types.AddRangeAsync(entities);
            await _Context.SaveChangesAsync();
            return entities.Count;
        }

        public async Task<int> UpdateUserLevel(lib_user_level entity)
        {
            var userLevel = _Context.Lib_User_Levels.AsNoTracking().AsEnumerable().Where(w => w.userLevelId == entity.userLevelId).FirstOrDefault();
            if (userLevel != null)
            {
                _Context.Entry(userLevel).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                _Context.Lib_User_Levels.Update(entity);
            }
            else
            {
                _Context.Lib_User_Levels.Add(entity);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return entity.userLevelId;
        }

        public async Task<int> UpdateUserLevelRangeAsync(List<lib_user_level> entities)
        {
            await _Context.Lib_User_Levels.AddRangeAsync(entities);
            await _Context.SaveChangesAsync();
            return entities.Count;
        }
    }
}
