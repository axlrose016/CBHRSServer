using AXLSmartRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Repositories
{
    public interface ILibraryRepository
    {
        #region For Region
        //Get Record
        lib_region GetRegion(int id); // Get Specific Record with code.
        IEnumerable<lib_region> GetAllRegion(); // Get All Record.
        IEnumerable<lib_region> FindRegion(Expression<Func<lib_region, bool>> predicate); // Get Record with predicate.

        //Add Record
        Task<int> UpdateRegion(lib_region entity); // Add Record
        Task<int> UpdateRegionRangeAsync(List<lib_region> entities); // Add Multiple Records

        //Remove Record
        void RemoveRegion(lib_region entity); // Remove Record
        void RemoveRegionRange(IEnumerable<lib_region> entities); // Remove Records.
        #endregion

        #region For Province
        //Get Record
        lib_province GetProvince(int id); // Get Specific Record with code.
        IEnumerable<lib_province> GetAllProvince(); // Get All Record.
        IEnumerable<lib_province> FindProvince(Expression<Func<lib_province, bool>> predicate); // Get Record with predicate.

        //Add Record
        Task<int> UpdateProvince(lib_province entity); // Add Record
        Task<int> UpdateProvinceRangeAsync(List<lib_province> entities); // Add Multiple Records
        //Remove Record
        void RemoveProvince(lib_province entity); // Remove Record
        void RemoveProvinceRange(IEnumerable<lib_province> entities); // Remove Records.
        #endregion

        #region For City
        //Get Record
        lib_city GetCity(int id); // Get Specific Record with code.
        IEnumerable<lib_city> GetAllCity(); // Get All Record.
        IEnumerable<lib_city> FindCity(Expression<Func<lib_city, bool>> predicate); // Get Record with predicate.

        //Add Record
        Task<int> UpdateCity(lib_city entity); // Add Record
        Task<int> UpdateCityRangeAsync(List<lib_city> entities); // Add Multiple Records

        //Remove Record
        void RemoveCity(lib_city entity); // Remove Record
        void RemoveCityRange(IEnumerable<lib_city> entities); // Remove Records.
        #endregion

        #region For Barangay
        //Get Record
        lib_brgy GetBrgy(int id); // Get Specific Record with code.
        IEnumerable<lib_brgy> GetAllBrgy(); // Get All Record.
        IEnumerable<lib_brgy> FindBrgy(Expression<Func<lib_brgy, bool>> predicate); // Get Record with predicate.

        //Add Record
        Task<int> UpdateBrgy(lib_brgy entity); // Add Record
        Task<int> UpdateBrgyRangeAsync(List<lib_brgy> entities); // Add Multiple Records

        //Remove Record
        void RemoveBrgy(lib_brgy entity); // Remove Record
        void RemoveBrgyRange(IEnumerable<lib_brgy> entities); // Remove Records.
        #endregion

        #region For User Level
        //Get Record
        lib_user_level GetUserLevel(int id); // Get Specific Record with code.
        IEnumerable<lib_user_level> GetAllUserLevel(); // Get All Record.
        IEnumerable<lib_user_level> FindUserLevel(Expression<Func<lib_user_level, bool>> predicate); // Get Record with predicate.

        //Add Record
        Task<int> UpdateUserLevel(lib_user_level entity); // Add Record
        Task<int> UpdateUserLevelRangeAsync(List<lib_user_level> entities); // Add Multiple Records

        //Remove Record
        void RemoveUserLevel(lib_user_level entity); // Remove Record
        void RemoveUserLevelRange(IEnumerable<lib_user_level> entities); // Remove Records.
        #endregion

        #region For Department Library
        //Get Record
        lib_department GetDepartment(int id); // Get Specific Record with code.
        IEnumerable<lib_department> GetAllDepartment(); // Get All Record.
        IEnumerable<lib_department> FindDepartment(Expression<Func<lib_department, bool>> predicate); // Get Record with predicate.

        //Add Record
        Task<int> UpdateDepartment(lib_department entity); // Add Record
        Task<int> UpdateDepartmentRangeAsync(List<lib_department> entities); // Add Multiple Records

        //Remove Record
        void RemoveDepartment(lib_department entity); // Remove Record
        void RemoveDepartmentRange(IEnumerable<lib_department> entities); // Remove Records.
        #endregion
        #region For Request Type Library
        //Get Record
        lib_request_type GetRequestType(int id); // Get Specific Record with code.
        IEnumerable<lib_request_type> GetAllRequestType(); // Get All Record.
        IEnumerable<lib_request_type> FindRequestType(Expression<Func<lib_request_type, bool>> predicate); // Get Record with predicate.

        //Add Record
        Task<int> UpdateRequestType(lib_request_type entity); // Add Record
        Task<int> UpdateRequestTypeRangeAsync(List<lib_request_type> entities); // Add Multiple Records

        //Remove Record
        void RemoveRequestType(lib_request_type entity); // Remove Record
        void RemoveRequestTypeRange(IEnumerable<lib_request_type> entities); // Remove Records.
        #endregion
        #region For Job Category Library
        //Get Record
        lib_job_category GetJobCategory(int id); // Get Specific Record with code.
        IEnumerable<lib_job_category> GetAllJobCategory(); // Get All Record.
        IEnumerable<lib_job_category> FindJobCategory(Expression<Func<lib_job_category, bool>> predicate); // Get Record with predicate.

        //Add Record
        Task<int> UpdateJobCategory(lib_job_category entity); // Add Record
        Task<int> UpdateJobCategoryRangeAsync(List<lib_job_category> entities); // Add Multiple Records

        //Remove Record
        void RemoveJobCategory(lib_job_category entity); // Remove Record
        void RemoveJobCategoryRange(IEnumerable<lib_job_category> entities); // Remove Records.
        #endregion
        #region For Core Compentency
        //Get Record
        lib_core_competency GetCoreCompetency(int id); // Get Specific Record with code.
        IEnumerable<lib_core_competency> GetAllCoreCompetency(); // Get All Record.
        IEnumerable<lib_core_competency> FindCoreCompetency(Expression<Func<lib_core_competency, bool>> predicate); // Get Record with predicate.

        //Add Record
        Task<int> UpdateCoreCompetency(lib_core_competency entity); // Add Record
        Task<int> UpdateCoreCompetencyRangeAsync(List<lib_core_competency> entities); // Add Multiple Records

        //Remove Record
        void RemoveCoreCompetency(lib_core_competency entity); // Remove Record
        void RemoveCoreCompetencyRange(IEnumerable<lib_core_competency> entities); // Remove Records.
        #endregion
        #region For Compentency Category
        //Get Record
        lib_competency_category GetCompetencyCategory(int id); // Get Specific Record with code.
        IEnumerable<lib_competency_category> GetAllCompetencyCategory(); // Get All Record.
        IEnumerable<lib_competency_category> FindCompetencyCategory(Expression<Func<lib_competency_category, bool>> predicate); // Get Record with predicate.

        //Add Record
        Task<int> UpdateCompetencyCategory(lib_competency_category entity); // Add Record
        Task<int> UpdateCompetencyCategoryRangeAsync(List<lib_competency_category> entities); // Add Multiple Records

        //Remove Record
        void RemoveCompetencyCategory(lib_competency_category entity); // Remove Record
        void RemoveCompetencyCategoryRange(IEnumerable<lib_competency_category> entities); // Remove Records.
        #endregion
        #region For Occupational Service Code
        //Get Record
        lib_occupational_service_code GetOccupationalServiceCode(string id); // Get Specific Record with code.
        IEnumerable<lib_occupational_service_code> GetAllOccupationalServiceCode(); // Get All Record.
        IEnumerable<lib_occupational_service_code> FindOccupationalServiceCode(Expression<Func<lib_occupational_service_code, bool>> predicate); // Get Record with predicate.

        //Add Record
        Task<string> UpdateOccupationalServiceCode(lib_occupational_service_code entity); // Add Record
        Task<int> UpdateOccupationalServiceCodeRangeAsync(List<lib_occupational_service_code> entities); // Add Multiple Records

        //Remove Record
        void RemoveOccupationalServiceCode(lib_occupational_service_code entity); // Remove Record
        void RemoveOccupationalServiceCodeRange(IEnumerable<lib_occupational_service_code> entities); // Remove Records.
        #endregion
        #region For Occupational Group Code
        //Get Record
        lib_occupational_group_code GetOccupationalGroupCode(string id); // Get Specific Record with code.
        IEnumerable<lib_occupational_group_code> GetAllOccupationalGroupCode(); // Get All Record.
        IEnumerable<lib_occupational_group_code> FindOccupationalGroupCode(Expression<Func<lib_occupational_group_code, bool>> predicate); // Get Record with predicate.

        //Add Record
        Task<string> UpdateOccupationalGroupCode(lib_occupational_group_code entity); // Add Record
        Task<int> UpdateOccupationalGroupCodeRangeAsync(List<lib_occupational_group_code> entities); // Add Multiple Records

        //Remove Record
        void RemoveOccupationalGroupCode(lib_occupational_group_code entity); // Remove Record
        void RemoveOccupationalGroupCodeRange(IEnumerable<lib_occupational_group_code> entities); // Remove Records.
        #endregion
    }
}
