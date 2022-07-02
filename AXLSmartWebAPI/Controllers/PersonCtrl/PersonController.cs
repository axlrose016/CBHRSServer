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
    public class PersonController : ControllerBase
    {
        private IUnitOfWork unitOfWork { get; set; }
        public PersonController(IUnitOfWork _unitOfWork) { unitOfWork = _unitOfWork; }
        [HttpPost, Route("PostPDS")]
        public async Task<ActionResult> PostPerson([FromBody] PersonDetail personDetail)
        {
            try
            {
                if (!ModelState.IsValid) { return BadRequest(ModelState); }
                Guid personId = await unitOfWork.Persons.UpdatePersonDetailsAsync(personDetail);

                return Ok(personId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetPDSList")]
        public ActionResult GetPersonList()
        {
            //var personLst = unitOfWork.Persons.GetAll().Where(w => w.is_deleted != true).AsQueryable().Include(x => x.region_code);
            var personLst = unitOfWork.Persons.GetPDSListView();
            if (personLst == null)
            {
                return NotFound();
            }
            return Ok(personLst);
        }

        [HttpGet, Route("GetPDS/{id}")]
        public async Task<ActionResult> GetPersonById([FromRoute] Guid id)
        {
            
            var person = await unitOfWork.Persons.GetPDSById(id);
            if(person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpGet, Route("GetPDSIdByUserId")]
        public ActionResult GetPDSByUserId(Guid userId)
        {
            var person = unitOfWork.Persons.Find(w => w.userId == userId).FirstOrDefault();
            if(person == null)
            {
                return NotFound();
            }
            return Ok(person.personId);
        }
    }
}