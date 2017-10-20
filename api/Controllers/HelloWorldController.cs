using System;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    /// <summary>
    /// A Controller to handle requests and greet requestors in kind
    /// </summary>
    [Route("api/[Controller]")]
    public class HelloWorldController : Controller
    {
        /// <summary>
        /// Get a friendly greeting via Http GET
        /// </summary>
        /// <response code="200">On sucessul greeting </response>
        [HttpGet]
        public ActionResult Get()
        {
            return new ObjectResult("Hello, world");
        }
    }
}