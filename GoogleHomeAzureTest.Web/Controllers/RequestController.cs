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
        public async Task<JsonResult> Post([FromBody]DialogFlowRequest request)
        {
            return new JsonResult(DialogFlowResponse.GetFulfillmentTextResponse("The status is CLOSED!"));
        }
    }
}