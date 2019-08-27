using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Testapp2Api.Models;

namespace Testapp2Api.Controllers
{
    [Route("api/ViewComplain")]
    [ApiController]
    public class ViewComplainController : ControllerBase
    {
        //db
        private dbContext _context;
        public ViewComplainController(dbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Complain> GetComplain()
        {
            Complain cmp = new Complain
            {
                ComplainerName = "kelum",
                houseNo = 656,
                complain = "dsddscscdsc"
            };
            List<Complain> ob=this._context.complain.ToList();
            
            return ob;
        }
    }
}