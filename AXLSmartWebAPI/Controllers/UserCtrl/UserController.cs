using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AXLSmartRepository.Core;
using AXLSmartRepository.Core.Models;
using AXLSmartRepository.Core.Repositories;
using AXLSmartWebAPI.ActionFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AXLSmartWebAPI.Controllers.UserCtrl
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUnitOfWork unitOfWork { get; set; }
        public UserController(IUnitOfWork _unitOfWork) { unitOfWork = _unitOfWork; }

        [ServiceFilter(typeof(CheckUserAccess))]
        [HttpGet, Route("GetUser/{id}")]
        public async Task<ActionResult> GetUserById([FromRoute] Guid id)
        {
            var user = await unitOfWork.Users.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [ServiceFilter(typeof(CheckUserAccess))]
        [HttpGet, Route("GetAllUser")]
        public IEnumerable<User> GetAllUser()
        {
            return unitOfWork.Users.GetAll();
        }

        [ServiceFilter(typeof(CheckUserAccess))]
        [HttpGet, Route("GetAllUserList_vw")]
        public ActionResult GetAllUserList_vw()
        {
            var userLst = unitOfWork.Users.GetUserListView();
            if (userLst == null)
            {
                return NotFound();
            }
            return Ok(userLst);
        }

        [HttpPost, Route("PostUser")]
        public async Task<ActionResult> PostUser([FromBody] User user)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            string uId = await unitOfWork.Users.UpdateUserAsync(user);
            if (uId == "00000000-0000-0000-0000-000000000000")
                return Conflict("User Name already exist, Please try another.");

            return Ok(Guid.Parse(uId));
        }

        [HttpGet, Route("GetUserAccess/{id}")]
        public async Task<ActionResult> GetUserAccess([FromRoute] Guid id)
        {
            var user = await unitOfWork.Users.GetUserById(id);
            if(user != null)
            {
                var role = unitOfWork.Libraries.GetUserLevel(user.user_level);
                if (role != null)
                    return Ok(role);
            }
            return NoContent();
        }
    }
}
