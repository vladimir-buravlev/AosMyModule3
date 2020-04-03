using AosMyModule3.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AosMyModule3.Web.Controllers.Api
{
    [Route("api/AosMyModule3")]
    public class AosMyModule3Controller : Controller
    {
        // GET: api/AosMyModule3
        [HttpGet]
        [Route("")]
        [Authorize(ModuleConstants.Security.Permissions.Read)]
        public ActionResult<string> Get()
        {
            return Ok(new { result = "Hello world!" });
        }
    }
}
