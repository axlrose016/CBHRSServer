using AXLSmartRepository.Core;
using AXLSmartRepository.Core.Models;
using AXLSmartWebAPI.ActionFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AXLSmartWebAPI.Controllers.PerformanceMgntCtrl
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(CheckUserAccess))]
    public class PerformanceMgntController : ControllerBase
    {
        private IUnitOfWork unitOfWork { get; set; }

        //BUDGET UTILIZATION
        public PerformanceMgntController(IUnitOfWork _unitOfWork) { unitOfWork = _unitOfWork; }

        [HttpPost, Route("PostBudgetUtil")]
        public async Task<ActionResult> PostBudgetUtil([FromBody] BudgetUtilizationDetail pMgntDetail)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                Guid pMgnt = await unitOfWork.PerformanceMgnts.UpdateBudgetUtilizationDetailAsync(pMgntDetail);
                return Ok(pMgnt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetBudgetUtilList")]
        public ActionResult GetBudgetUtilList()
        {
            var pMgntList = unitOfWork.PerformanceMgnts.GetBudgetUtilizationListView();
            if (pMgntList == null)
            {
                return NotFound();
            }
            return Ok(pMgntList);
        }

        [HttpGet, Route("GetBudgetUtil/{id}")]
        public async Task<ActionResult> GetBudgetUtil([FromRoute] Guid id)
        {
            var pMgnt = await unitOfWork.PerformanceMgnts.GetBudgetUtilizationById(id);
            if (pMgnt == null)
            {
                return NotFound();
            }
            return Ok(pMgnt);
        }

        //ORGANIZATIONAL GOAL

        [HttpPost, Route("PostOrgGoal")]
        public async Task<ActionResult> PostOrgGoal([FromBody] OrganizationalGoalDetail pMgntDetail)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                Guid pMgnt = await unitOfWork.PerformanceMgnts.UpdateOrganizationalGoalDetailAsync(pMgntDetail);
                return Ok(pMgnt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetOrgGoalList")]
        public ActionResult GetOrgGoalList()
        {
            var pMgntList = unitOfWork.PerformanceMgnts.GetOrganizationalGoalListView();
            if (pMgntList == null)
            {
                return NotFound();
            }
            return Ok(pMgntList);
        }

        [HttpGet, Route("GetOrgGoal/{id}")]
        public async Task<ActionResult> GetOrgGoal([FromRoute] Guid id)
        {
            var pMgnt = await unitOfWork.PerformanceMgnts.GetOrganizationalGoalById(id);
            if (pMgnt == null)
            {
                return NotFound();
            }
            return Ok(pMgnt);
        }

        //HR STAFFING GOAL

        [HttpPost, Route("PostHRStaffing")]
        public async Task<ActionResult> PostHRStaffing([FromBody] HRStaffingPlanDetail pMgntDetail)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                Guid pMgnt = await unitOfWork.PerformanceMgnts.UpdateHRStaffingDetailAsync(pMgntDetail);
                return Ok(pMgnt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetHRStaffing")]
        public ActionResult GetHRStaffing()
        {
            var pMgntList = unitOfWork.PerformanceMgnts.GetHRStaffingListView();
            if (pMgntList == null)
            {
                return NotFound();
            }
            return Ok(pMgntList);
        }

        [HttpGet, Route("GetHRStaffing/{id}")]
        public async Task<ActionResult> GetHRStaffing([FromRoute] Guid id)
        {
            var pMgnt = await unitOfWork.PerformanceMgnts.GetHRStaffingById(id);
            if (pMgnt == null)
            {
                return NotFound();
            }
            return Ok(pMgnt);
        }

        //COMPLAINT DETAIL

        [HttpPost, Route("PostComplaintDetail")]
        public async Task<ActionResult> PostComplaintDetail([FromBody] ComplaintDetail pMgntDetail)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                Guid pMgnt = await unitOfWork.PerformanceMgnts.UpdateComplaintDetailAsync(pMgntDetail);
                return Ok(pMgnt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetComplaintList")]
        public ActionResult GetComplaintList()
        {
            var pMgntList = unitOfWork.PerformanceMgnts.GetComplaintDetailListView();
            if (pMgntList == null)
            {
                return NotFound();
            }
            return Ok(pMgntList);
        }

        [HttpGet, Route("GetComplaintDetail/{id}")]
        public async Task<ActionResult> GetComplaintDetail([FromRoute] Guid id)
        {
            var pMgnt = await unitOfWork.PerformanceMgnts.GetComplaintDetailById(id);
            if (pMgnt == null)
            {
                return NotFound();
            }
            return Ok(pMgnt);
        }
    }
}
