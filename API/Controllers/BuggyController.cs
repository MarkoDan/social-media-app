using Core.Models;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly StoreContext _context;
        public BuggyController(StoreContext context)
        {
            _context = context;
            
        }

        [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetSecret()
        {
            return "secret text";
        }

        [HttpGet("not-found")]
        public ActionResult<AppUser> GetNotFound()
        {
            var thing = _context.AppUsers.Find(-1);

            if (thing == null)
            {
                return NotFound();
            }
            return thing;
        }

        [HttpGet("server-error")]
        public ActionResult<string> GetServerError()
        {   
            try
            {
                var thing = _context.AppUsers.Find(-1);

                var thingToReturn = thing.ToString();

                return thingToReturn;
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Computer says no!");
            }
           
        }

        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest("This was not a good request");
        }
    }
}