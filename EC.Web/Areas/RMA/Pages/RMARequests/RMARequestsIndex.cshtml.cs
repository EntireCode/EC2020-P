using System.Collections.Generic;
using System.Threading.Tasks;
using EC.Web.Areas.RMA.Data;
using EC.Web.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.RMA.Pages.RMARequests
{
    public class RMARequestsIndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public RMARequestsIndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<RMARequest> RMARequests { get; set; }

        public async Task OnGetAsync()
        {
            RMARequests = await _context.RMARequests.Include(x => x.RMACases).Include(x => x.SubmittedByUser).ToListAsync();
        }
    }
}