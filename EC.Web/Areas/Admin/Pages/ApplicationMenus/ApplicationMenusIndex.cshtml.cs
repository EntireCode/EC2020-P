using System.Collections.Generic;
using System.Threading.Tasks;
using EC.Web.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.Admin.Pages.ApplicationMenus
{
    public class ApplicationMenusIndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ApplicationMenusIndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ApplicationMenu> ApplicationMenus { get; set; }

        public async Task OnGet()
        {
            ApplicationMenus = await _context.ApplicationMenus.Include(m => m.Parent).ToListAsync();
        }
    }
}