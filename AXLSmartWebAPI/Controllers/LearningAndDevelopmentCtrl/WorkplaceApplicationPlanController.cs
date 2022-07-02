using AXLSmartRepository.Core;
using AXLSmartRepository.Core.Models;
using AXLSmartWebAPI.ActionFilters;
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
    public class WorkplaceApplicationPlanController : ControllerBase
    {
        private IUnitOfWork unitOfWork { get; set; }
        public WorkplaceApplicationPlanController(IUnitOfWork _unitOfWork) { unitOfWork = _unitOfWork; }
        [HttpPost, Route("PostWAP")]
        public async Task<ActionResult> PostWAP([FromBody] WorkplaceAppicationPlan wapDetails)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                Guid wapId = await unitOfWork.WorkplaceApplicationPlans.UpdateWAPDetailsAsync(wapDetails);
                return Ok(wapId);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetWAPList")]
        public ActionResult GetWAPList()
        {
            var wapLst = unitOfWork.WorkplaceApplicationPlans.GetWAPListView();
            //var wapLst = unitOfWork.WorkplaceApplicationPlans.GetWAPList();
            if(wapLst == null)
            {
                return NoContent();
            }
            return Ok(wapLst);
        }
        [HttpGet, Route("GetWAPList_vw")]
        public ActionResult GetAPList_vw()
        {
            var wapLst = unitOfWork.WorkplaceApplicationPlans.GetWAPListView();
            if(wapLst == null)
            {
                return NoContent();
            }
            return Ok(wapLst);
        }
        [HttpGet, Route("GetWAP/{id}")]
        public ActionResult GetWAPById([FromRoute] Guid id)
        {

            var wap = unitOfWork.WorkplaceApplicationPlans.Find(w => w.wapId == id).FirstOrDefault();

            if (wap == null)
            {
                return NoContent();
            }
            return Ok(wap);
        }
    }
}
