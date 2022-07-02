using AXLSmartRepository.Core;
using AXLSmartRepository.Core.Models;
using AXLSmartWebAPI.ActionFilters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AXLSmartWebAPI.Controllers.PersonCtrl
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(CheckUserAccess))]
    public class ClearanceController : ControllerBase
    {
        private IUnitOfWork unitOfWork { get; set; }
        public ClearanceController(IUnitOfWork _unitOfWork) { unitOfWork = _unitOfWork; }
        [HttpPost, Route("PostClearance")]
        public async Task<ActionResult> PostClearance([FromBody] ClearanceDetail clearanceDetail)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                Guid clearanceId = await unitOfWork.Clearances.UpdateClearanceDetailAsync(clearanceDetail);
                return Ok(clearanceId);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetClearanceList")]
        public ActionResult GetClearanceList()
        {
            var clearanceLst = unitOfWork.Clearances.GetClearaneListView();
            if(clearanceLst == null)
            {
                return NotFound();
            }
            return Ok(clearanceLst);
        }

        [HttpGet,Route("GetClearance/{id}")]
        public async Task<ActionResult> GetClearanceById([FromRoute] Guid id)
        {
            var clearance = await unitOfWork.Clearances.GetClearanceById(id);
            if(clearance == null)
            {
                return NotFound();
            }
            return Ok(clearance);
        }

    }
}
