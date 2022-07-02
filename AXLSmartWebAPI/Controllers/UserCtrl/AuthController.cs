using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvanceXtensionLibrary.AXL_Class;
using AdvanceXtensionLibrary.AXL_Security;
using AXLSmartRepository.Core;
using AXLSmartWebAPI.Classes;
using AXLSmartWebAPI.Models.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AXLSmartWebAPI.Controllers.UserCtrl
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IUnitOfWork unitOfWork { get; set; }
        public AuthController(IUnitOfWork _unitOfWork) { unitOfWork = _unitOfWork; }

        [HttpPost, Route("LoginUser")]
        public ActionResult LoginUser([FromBody] AuthCredentials credentials)
        {
            string conStr = STV.conStr;
            string outUname = string.Empty;
            Guid outUid = new Guid("00000000-0000-0000-0000-000000000000");
            if (String.IsNullOrEmpty(credentials.username) || String.IsNullOrEmpty(credentials.password)) { return Ok("Please Enter Username or Password."); }

            //PROCESS 1: GET THE Name and ID of the User if user is validated.
            axl_guard.login_axl_security(conStr, "Users", "userName", "userId", credentials.username, credentials.password, out outUname, out outUid);
            if (String.IsNullOrEmpty(outUname))
            {
                return NotFound("Invalid Credentials, Please try again.");
            }
            else
            {
                //PROCESS 2: GENERATE TOKEN FOR Username and UserId
                DateTime TokenDate = DateTime.Now;
                var bakedToken = GenerateToken(TokenDate, outUid, outUname);
                return Ok(bakedToken);
            }
        }

        public TokenModel GenerateToken(DateTime tokendate, Guid _userId, string _userName)
        {
            string saltedToken = AXL_GenLib.Encode(_userId);
            string _personId = "0";
            var person = unitOfWork.Persons.Find(w => w.userId == _userId).FirstOrDefault();
            if(person == null) { _personId = "0"; }
            else { _personId = person.personId.ToString(); }
            if (!String.IsNullOrEmpty(saltedToken))
            {
                return new TokenModel
                {
                    token = saltedToken,
                    expiration = tokendate.AddMinutes(480).ToString(),
                    userId = _userId.ToString(),
                    userName = _userName,
                    personId = _personId
                };
            }
            return null;
        }
    }

}