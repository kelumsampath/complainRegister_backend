using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Testapp2Api.Models;

namespace Testapp2Api.Controllers
{
    [Route("api/addcomplain")]
    [ApiController]
    public class AddComplainController : ControllerBase
    {
        
        [HttpPost]
        public Complain Post([FromBody] Complain complainData)
        {
            //model data
            return complainData;
        }
    }
}