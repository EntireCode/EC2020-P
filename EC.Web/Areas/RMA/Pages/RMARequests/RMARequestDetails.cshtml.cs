using System.Threading.Tasks;
using EC.Web.Areas.RMA.Data;
using EC.Web.Areas.Shared.Services;
using EC.Web.Data;
using EC.Web.Services.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.RMA.Pages.RMARequests
{
    public class RMARequestDetailsModel : RMARequestBaseModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserService _userService;
        private readonly IB1UserService _b1UserService;
        private readonly IB1ProductService _b1ProductService;
        private readonly IB1CardService _b1CardService;

        public RMARequestDetailsModel(ApplicationDbContext context, 
            IUserService userService,
            IB1UserService b1UserService,
            IB1CardService b1CardService,
            IB1ProductService b1ProductService) : base(userService, b1UserService, b1CardService, b1ProductService)
        {
            _context = context;
            _userService = userService;
            _b1UserService = b1UserService;
            _b1ProductService = b1ProductService;
            _b1CardService = b1CardService;
        }

        public RMARequest RMARequest { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RMARequest = await _context.RMARequests.Include(x => x.RMACases)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (RMARequest == null)
            {
                return NotFound();
            }            

            return Page();
        }
    }
}