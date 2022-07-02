using AdvanceXtensionLibrary.AXL_Class;
using AXLSmartRepository.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AXLSmartWebAPI.ActionFilters
{
    public class CheckUserAccess : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            try
            {
                string _token = context.HttpContext.Request.Headers["AXLToken"].FirstOrDefault();
                string _source = context.HttpContext.Request.Headers["AXLSource"].FirstOrDefault();
                string _uId = context.HttpContext.Request.Headers["AXLUId"].FirstOrDefault();
                if ((_source == null) || (_uId == null) || (_token == null))
                {
                    context.Result = new BadRequestObjectResult("Access Denied");
                    return;
                }
                else
                {
                    Guid _unsaltedToken = AXL_GenLib.Decode(_token);
                    if (_uId != _unsaltedToken.ToString())
                    {
                        context.Result = new BadRequestObjectResult("Access Denied");
                        return;
                    }
                }
                await next();
            } catch (Exception ex)
            {
                context.Result = new BadRequestObjectResult("AXLAPI: " +ex.Message);
            }
     
        }
    }
}
