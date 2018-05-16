using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DialogFlow.Fulfillment.Dotnet.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoogleHomeAzureTest.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Request")]
    public class RequestController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]DialogFlowRequest request)
        {
            // Request.HttpContext.Response.Headers["Content-type"] = "application/json; charset=utf-8";
            // Request.HttpContext.Response.Headers.Add("Content-type", "application/json; charset=utf-8");

            return Ok( DialogFlowResponse.GetFulfillmentTextResponse("The status is CLOSED!"));
        }
    }
}