using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EC.Web.Areas.RMA.Data;
using EC.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.RMA.Pages.RMACases
{
    public class RMACasesIndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public RMACasesIndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<RMACase> RMACases { get; set; }

        public async Task OnGetAsync(string id)
        {
            RMACases = await _context.RMACases
                .Include(x => x.Attachments)
                .Include(x => x.RMAStages)
                .Where(x => x.RMARequestId == id).ToListAsync();
        }
    }
}