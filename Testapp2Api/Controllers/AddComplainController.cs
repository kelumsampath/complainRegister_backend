using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
        public Resp Post([FromBody] Complain complainData)
        {
            try
            {
                EntityEntry<Complain> obj = this._context.complain.Add(complainData);
                this._context.SaveChanges();

                Resp R = new Resp
                {
                    state = true,
                    msg="Complain Registered!"
                };
                return R;
            }
            catch (Exception e1)
            {


                Resp R = new Resp
                {
                    state = false,
                    msg = "Error!"
                };
                return R;

            }
        }
    }
}