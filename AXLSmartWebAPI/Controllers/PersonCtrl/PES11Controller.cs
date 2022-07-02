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
    public class PES11Controller : ControllerBase
    {
        private IUnitOfWork unitOfWork { get; set; }
        public PES11Controller(IUnitOfWork _unitOfWork) { unitOfWork = _unitOfWork; }
        [HttpPost, Route("PostPES11")]
        public async Task<ActionResult> PostClearance([FromBody] PES11Detail pesDetail)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                Guid pes11Id = await unitOfWork.PES11s.UpdatePES11DetailAsync(pesDetail);
                return Ok(pes11Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetPES11List")]
        public ActionResult GetPES11List()
        {
            var pesLst = unitOfWork.PES11s.GetPES11ListView();
            if (pesLst == null)
            {
                return NotFound();
            }
            return Ok(pesLst);
        }

        [HttpGet, Route("GetPES11/{id}")]
        public async Task<ActionResult> GetPES11ById([FromRoute] Guid id)
        {
            var pes = await unitOfWork.PES11s.GetPES11ById(id);
            if (pes == null)
            {
                return NotFound();
            }
            return Ok(pes);
        }
    }
}
