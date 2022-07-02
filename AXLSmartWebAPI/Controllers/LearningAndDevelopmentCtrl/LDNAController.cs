using AXLSmartRepository.Core;
using AXLSmartRepository.Core.Models;
using AXLSmartWebAPI.ActionFilters;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace AXLSmartWebAPI.Controllers.LearningAndDevelopmentCtrl
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(CheckUserAccess))]
    public class LDNAController : ControllerBase
    {
        private IUnitOfWork unitOfWork { get; set; }
        public LDNAController(IUnitOfWork _unitOfWork) { unitOfWork = _unitOfWork; }
        [HttpPost, Route("PostLDNA")]
        public async Task<ActionResult> PostLDNA([FromBody] LDNADetails ldnaDetail)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                Guid ldnaId = await unitOfWork.LDNA.UpdateLDNADetails(ldnaDetail);
                return Ok(ldnaId);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetLDNAList")]
        public ActionResult GetLDNAList()
        {
            var ldnaLst = unitOfWork.LDNA.GetLDNAList();
            if(ldnaLst == null)
            {
                return NoContent();
            }
            return Ok(ldnaLst);
        }
        [HttpGet, Route("GetLDNA/{id}")]
        public ActionResult GetLDNAById([FromRoute] Guid id)
        {
            var ldna = unitOfWork.LDNA.Find(x => x.ldnaId == id).FirstOrDefault();
            if(ldna == null)
            {
                return NoContent();
            }
            return Ok(ldna);
        }

        [HttpGet, Route("ExportLDNAConsolidated")]
        public ActionResult ExportLDNAResult_sp()
        {
            List<LDNAConsolidated_sp> res = unitOfWork.LDNA.GetLDNAConsolidated_Sps().Result;
            if (res.Count <= 0)
                return NoContent();
            return Ok(res);
        }
    }
}
