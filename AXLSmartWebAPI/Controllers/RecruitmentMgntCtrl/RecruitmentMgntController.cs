using AXLSmartRepository.Core;
using AXLSmartRepository.Core.Models;
using AXLSmartWebAPI.ActionFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AXLSmartWebAPI.Controllers.RecruitmentMgntCtrl
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(CheckUserAccess))]
    public class RecruitmentMgntController : ControllerBase
    {
        private IUnitOfWork unitOfWork { get; set; }

        public RecruitmentMgntController(IUnitOfWork _unitOfWork) { unitOfWork = _unitOfWork; }
        [HttpPost, Route("PostAppointmentDetail")]
        public async Task<ActionResult> PostAppointmentDetail([FromBody] AppointmentDetail appDetail)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                Guid detail = await unitOfWork.Recruitment.UpdateAppointmentDetailAsync(appDetail);
                return Ok(detail);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetAppointmentList")]
        public ActionResult GetAppointmentList()
        {
            var appList = unitOfWork.Recruitment.GetAppointmentListView();
            if(appList == null)
            {
                return NotFound();
            }
            return Ok(appList);
        }

        [HttpGet, Route("GetAppointmentDetail/{id}")]
        public async Task<ActionResult> GetAppointmentDetail([FromRoute] Guid id)
        {
            var aDetail = await unitOfWork.Recruitment.GetAppointmetById(id);
            if(aDetail == null)
            {
                return NotFound();
            }
            return Ok(aDetail);
        }
    }
}
