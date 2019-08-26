using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Testapp2Api.Models;

namespace Testapp2Api.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "name dcdsdc" };
        }

        [HttpPost]
        public Models.Test Post([FromBody] Test value)
        {
            
            return value;
        }
    }
}