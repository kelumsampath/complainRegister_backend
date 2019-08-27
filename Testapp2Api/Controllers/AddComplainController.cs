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

        //db
        private dbContext _context;
        public AddComplainController(dbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public Complain GetComplain()
        {
            Complain cmp = new Complain
            {
                    ComplainerName = "kelum",
	                houseNo=656,
	                complain="dsddscscdsc"
            };
            this._context.complain.Add(cmp);
            this._context.SaveChanges();
            return cmp;
        }

        [HttpPost]
        public Complain Post([FromBody] Complain complainData)
        {
            //model data
            return complainData;
        }
    }
}