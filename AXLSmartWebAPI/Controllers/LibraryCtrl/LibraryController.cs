using AXLSmartRepository.Core;
using AXLSmartRepository.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AXLSmartWebAPI.Controllers.LibraryCtrl
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private IUnitOfWork unitOfWork { get; set; }
        public LibraryController(IUnitOfWork _unitOfWork) { unitOfWork = _unitOfWork; }
        
        [HttpGet, Route("GetAllRegion")]
        public ActionResult GetAllRegion()
        {
            var regions = unitOfWork.Libraries.GetAllRegion();
            if (regions.Count() == 0)
            {
                return NotFound();
            }
            return Ok(regions);
        }
        
        [HttpGet,Route("GetAllUserLevel")]
        public ActionResult GetAllUserLevel()
        {
            var userLevel = unitOfWork.Libraries.GetAllUserLevel();
            if(userLevel.Count() == 0)
            {
                return NotFound();
            }
            return Ok(userLevel);
        }

        [HttpGet, Route("GetUserLevel")]
        public ActionResult GetUserLevelById(int id)
        {
            var userLevel = unitOfWork.Libraries.GetUserLevel(id);
            if(userLevel == null)
            {
                return NoContent();
            }
            return Ok(userLevel);
        }

        [HttpGet, Route("GetRegionByCode")]
        public ActionResult GetRegionByCode(string region_code) 
        {
            var region = unitOfWork.Libraries.FindRegion(w => w.region_code == region_code);
            if(region == null) 
            { 
                return NotFound(); 
            }
            return Ok(region.ToList());
        }

        [HttpGet, Route("GetAllProvince")]
        public ActionResult GetAllProvince()
        {
            var provinces = unitOfWork.Libraries.GetAllProvince();
            if(provinces == null)
            {
                return NotFound();
            }
            return Ok(provinces);
        }

        [HttpGet, Route("GetProvinceByRegion")]
        public ActionResult GetProvinceByRegion(string region_code)
        {
            var provinces = unitOfWork.Libraries.FindProvince(w => w.region_code == region_code);
            if(provinces == null)
            {
                return NotFound();
            }
            return Ok(provinces.ToList());
        }

        [HttpGet, Route("GetAllCity")]
        public ActionResult GetAllCity()
        {
            var cities = unitOfWork.Libraries.GetAllCity();
            if(cities == null)
            {
                return NotFound();
            }
            return Ok(cities);
        }

        [HttpGet, Route("GetCityByProvince")]
        public ActionResult GetCityByProvince(string prov_code)
        {
            var cities = unitOfWork.Libraries.FindCity(w => w.prov_code == prov_code);
            if(cities == null)
            {
                return NotFound();
            }
            return Ok(cities.ToList());
        }

        [HttpGet, Route("GetAllBrgy")]
        public ActionResult GetAllBrgy()
        {
            var barangays = unitOfWork.Libraries.GetAllBrgy();
            if(barangays == null)
            {
                return NotFound();
            }
            return Ok(barangays);
        }

        [HttpGet, Route("GetBrgyByCity")]
        public ActionResult GetBrgyByCity(string city_code)
        {
            var barangays = unitOfWork.Libraries.FindBrgy(w => w.city_code == city_code);
            if(barangays == null)
            {
                return NotFound();
            }
            return Ok(barangays.ToList());
        }

        [HttpGet, Route("GetAllRequestType")]
        public ActionResult GetAllRequestType()
        {
            var request_type = unitOfWork.Libraries.GetAllRequestType();
            if(request_type == null)
            {
                return NoContent();
            }
            return Ok(request_type);
        }

        [HttpGet, Route("GetRequestType")]
        public ActionResult GetRequestTypebyId(int id)
        {
            var request_type = unitOfWork.Libraries.GetRequestType(id);
            if(request_type == null)
            {
                return NoContent();
            }
            return Ok(request_type);
        }

        [HttpGet, Route("GetAllDepartment")]
        public ActionResult GetAllDepartment()
        {
            var departments = unitOfWork.Libraries.GetAllDepartment();
            if(departments == null)
            {
                return NoContent();
            }
            return Ok(departments);
        }

        [HttpGet,Route("GetDepartment")]
        public ActionResult GetAllDepartmentById(int id)
        {
            var department = unitOfWork.Libraries.GetDepartment(id);
            if(department == null)
            {
                return NoContent();
            }
            return Ok(department);
        }

        [HttpGet, Route("GetAllJobCategory")]
        public ActionResult GetAllJobCategory()
        {
            var job_categories = unitOfWork.Libraries.GetAllJobCategory();
            if(job_categories == null)
            {
                return NoContent();
            }
            return Ok(job_categories);
        }

        [HttpGet, Route("GetJobCategory")]
        public ActionResult GetJobCategoryById(int id)
        {
            var job_category = unitOfWork.Libraries.GetJobCategory(id);
            if(job_category == null)
            {
                return NoContent();
            }
            return Ok(job_category);
        }

        [HttpGet, Route("GetAllCoreCompetency")]
        public ActionResult GetAllCoreCompetency()
        {
            var core_competency = unitOfWork.Libraries.GetAllCoreCompetency();
            if(core_competency == null)
            {
                return NoContent();
            }
            return Ok(core_competency);
        }

        [HttpGet, Route("GetCoreCompetency")]
        public ActionResult GetCoreCompetencyById(int id)
        {
            var core_competency = unitOfWork.Libraries.GetCoreCompetency(id);
            if(core_competency == null)
            {
                return NoContent();
            }
            return Ok(core_competency);
        }

        [HttpGet, Route("GetAllCompetencyCategory")]
        public ActionResult GetAllCompetencyCategory()
        {
            var competency_category = unitOfWork.Libraries.GetAllCompetencyCategory();
            if (competency_category == null)
            {
                return NoContent();
            }
            return Ok(competency_category);
        }

        [HttpGet, Route("GetCompetencyCategory")]
        public ActionResult GetCompetencyCategoryById(int id)
        {
            var competency_category = unitOfWork.Libraries.GetCompetencyCategory(id);
            if (competency_category == null)
            {
                return NoContent();
            }
            return Ok(competency_category);
        }

        [HttpPost, Route("PostUserLevel")]
        public async Task<ActionResult> PostUserLevel([FromBody] lib_user_level user_level)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                int rowid = await unitOfWork.Libraries.UpdateUserLevel(user_level);
                return Ok(rowid);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost, Route("PostRequestType")]
        public async Task<ActionResult> PostRequstType([FromBody] lib_request_type request_type)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                int rowid = await unitOfWork.Libraries.UpdateRequestType(request_type);
                return Ok(rowid);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost, Route("PostDepartment")]
        public async Task<ActionResult> PostDepartment([FromBody] lib_department department)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                int rowid = await unitOfWork.Libraries.UpdateDepartment(department);
                return Ok(rowid);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost, Route("PostJobCategory")]
        public async Task<ActionResult> PostJobCategory([FromBody] lib_job_category job_category)
        {
            try
            {
                if(!ModelState.IsValid) { return BadRequest(ModelState); }
                int rowid = await unitOfWork.Libraries.UpdateJobCategory(job_category);
                return Ok(rowid);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost, Route("PostRegion")]
        public async Task<ActionResult> PostRegion([FromBody] lib_region region)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                int rowid = await unitOfWork.Libraries.UpdateRegion(region);
                return Ok(rowid);

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost, Route("PostProvince")]
        public async Task<ActionResult> PostProvince([FromBody] lib_province province)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                int rowid = await unitOfWork.Libraries.UpdateProvince(province);
                return Ok(rowid);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost, Route("PostCity")]
        public async Task<ActionResult> PostCity([FromBody] lib_city city)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                int rowid = await unitOfWork.Libraries.UpdateCity(city);
                return Ok(rowid);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost, Route("PostBrgy")]
        public async Task<ActionResult> PostBrgy([FromBody] lib_brgy brgy)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                int rowid = await unitOfWork.Libraries.UpdateBrgy(brgy);
                return Ok(rowid);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost, Route("PostCoreCompetency")]
        public async Task<ActionResult> PostCoreCompetency([FromBody] lib_core_competency core_competency)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                int rowid = await unitOfWork.Libraries.UpdateCoreCompetency(core_competency);
                return Ok(rowid);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost,Route("PostCompetencyCategory")]
        public async Task<ActionResult> PostCompetencyCategory([FromBody] lib_competency_category competency_category)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                int rowid = await unitOfWork.Libraries.UpdateCompetencyCategory(competency_category);
                return Ok(rowid);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost, Route("PostMultipleRegion")]
        public async Task<ActionResult> PostMultipleRegion([FromBody] List<lib_region> regions)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                int count = await unitOfWork.Libraries.UpdateRegionRangeAsync(regions);
                return Ok(count);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost, Route("PostMultipleProvince")]
        public async Task<ActionResult> PostMultipleProvince([FromBody] List<lib_province> provinces)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                int count = await unitOfWork.Libraries.UpdateProvinceRangeAsync(provinces);

                return Ok(count);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost, Route("PostMultipleCity")]
        public async Task<ActionResult> PostMultipleCity([FromBody] List<lib_city> cities)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                int count = await unitOfWork.Libraries.UpdateCityRangeAsync(cities);
                return Ok(count);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost, Route("PostMultipleBrgy")]
        public async Task<ActionResult> PostMultipleBrgy([FromBody] List<lib_brgy> barangays)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                int count = await unitOfWork.Libraries.UpdateBrgyRangeAsync(barangays);
                return Ok(count);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost, Route("PostMultipleCoreCompetency")]
        public async Task<ActionResult> PostMultipleCoreCompetency([FromBody] List<lib_core_competency> core_competencies)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                int count = await unitOfWork.Libraries.UpdateCoreCompetencyRangeAsync(core_competencies);
                return Ok(count);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost, Route("PostMultipleCompetencyCategory")]
        public async Task<ActionResult> PostMultipleCompetencyCategory([FromBody] List<lib_competency_category> competency_categories)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                int count = await unitOfWork.Libraries.UpdateCompetencyCategoryRangeAsync(competency_categories);
                return Ok(count);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
