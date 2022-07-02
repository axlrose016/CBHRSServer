using AXLSmartRepository.Core;
using AXLSmartRepository.Core.Models;
using AXLSmartWebAPI.ActionFilters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AXLSmartWebAPI.Controllers.SettingCtrl
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(CheckUserAccess))]
    public class SettingController : ControllerBase
    {
        private IUnitOfWork unitOfWork { get; set; }
        public SettingController(IUnitOfWork _unitOfWork) { unitOfWork = _unitOfWork; }
        #region Job Requisition
        [HttpPost, Route("PostJobRequisition")]
        public async Task<ActionResult> PostJobRequisition([FromBody] JobRequisition jobRequisition)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                Guid jobRequisitionId = await unitOfWork.Settings.UpdateJobRequisition(jobRequisition);
                return Ok(jobRequisitionId);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetJobRequisitionList")]
        public ActionResult GetJobRequisitionList()
        {
            var requisitionLst = unitOfWork.Settings.GetAllJobRequisitions();
            if(requisitionLst == null)
            { return NotFound(); }
            return Ok(requisitionLst);
        }

        [HttpGet, Route("GetJobRequisitionList_vw")]
        public ActionResult GetJobRequisitionList_vw()
        {
            var jobRequisitionLst = unitOfWork.Settings.GetJobRequisitionList_vw();
            if (jobRequisitionLst == null)
            {
                return NotFound();
            }
            return Ok(jobRequisitionLst);
        }

        [HttpGet,Route("GetJobRequisition/{id}")]
        public async Task<ActionResult> GetJobRequisitionById([FromRoute] Guid id)
        {
            var requisition = await unitOfWork.Settings.GetJobRequisitionAsync(id);
            if(requisition == null)
            {
                return NotFound();
            }
            return Ok(requisition);
        }
        #endregion
        #region Job Classification
        [HttpPost, Route("PostJobClassification")]
        public async Task<ActionResult> PostJobClassification([FromBody] JobClassification jobClassification)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                int jobClassificationId = await unitOfWork.Settings.UpdateJobClassification(jobClassification);
                return Ok(jobClassificationId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetJobClassificationList")]
        public ActionResult GetJobClassificationList()
        {
            var jobClassificationLst = unitOfWork.Settings.GetAllJobClassifications();
            if (jobClassificationLst == null)
            { return NotFound(); }
            return Ok(jobClassificationLst);
        }

        [HttpGet, Route("GetJobClassification/{id}")]
        public async Task<ActionResult> GetJobClassificationById([FromRoute] int id)
        {
            var jobClassification = await unitOfWork.Settings.GetJobClassificationAsync(id);
            if (jobClassification == null)
            {
                return NotFound();
            }
            return Ok(jobClassification);
        }
        #endregion
    }
}
