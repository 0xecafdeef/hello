using System;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[Controller]")]
    public class HelloWorldController : Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            throw new NotImplementedException();
        }
    }
}