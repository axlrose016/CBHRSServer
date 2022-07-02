using AXLSmartRepository.Core;
using AXLSmartRepository.Core.Models;
using AXLSmartWebAPI.ActionFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AXLSmartWebAPI.Controllers.LearningAndDevelopmentCtrl
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(CheckUserAccess))]
    public class PerformanceRatingController : ControllerBase
    {
        private IUnitOfWork unitOfWork { get; set; }
        public PerformanceRatingController(IUnitOfWork _unitOfWork) { unitOfWork = _unitOfWork; }
        [HttpPost, Route("PostRate")]
        public async Task<ActionResult> PostRate([FromBody] PerformanceRateDetails performance)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                Guid performanceId = await unitOfWork.PerformanceRates.UpdatePerformanceRate(performance);
                return Ok(performanceId);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetPerformanceRateList")]
        public ActionResult GetPerformanceList()
        {
            var performanceList = unitOfWork.PerformanceRates.GetPerformanceList();
            if(performanceList == null)
            {
                return NoContent();
            }
            return Ok(performanceList);
        }

        [HttpGet, Route("GetPerformanceRate/{id}")]
        public async Task<ActionResult> GetPerformanceRateById([FromRoute] Guid id)
        {
            var performance = await unitOfWork.PerformanceRates.GetPerformanceById(id);
            if(performance == null)
            {
                return NoContent();
            }
            return Ok(performance);
        }
    }
}
