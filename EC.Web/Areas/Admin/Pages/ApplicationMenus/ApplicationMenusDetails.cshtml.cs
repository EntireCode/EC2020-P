using System.Linq;
using System.Threading.Tasks;
using EC.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.Admin.Pages.ApplicationMenus
{
    public class ApplicationMenusDetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ApplicationMenusDetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationMenu ApplicationMenu { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ApplicationMenu = await _context.ApplicationMenus
                .Include(a => a.Parent).FirstOrDefaultAsync(m => m.Id == id);

            if (ApplicationMenu == null)
            {
                return NotFound();
            }

            var menus = (from m in _context.ApplicationMenus
                         select new SelectListItem
                         {
                             Value = m.Id,
                             Text = m.Name
                         }).ToList();

            ViewData["AvailableMenus"] = menus;

            return Page();
        }
    }
}