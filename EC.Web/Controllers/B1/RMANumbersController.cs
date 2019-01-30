using System.Linq;
using EC.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace EC.Web.Controllers.B1
{
    [Route("api/[controller]")]
    [ApiController]
    public class RMANumbersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RMANumbersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetNext")]
        public ActionResult<long> GetNext()
        {
            var number = _context.RMANumbers.FirstOrDefault();
            var nextNumber = ++number.CurrentRMANumber;
            _context.SaveChanges();
            return nextNumber;
        }
    }
}