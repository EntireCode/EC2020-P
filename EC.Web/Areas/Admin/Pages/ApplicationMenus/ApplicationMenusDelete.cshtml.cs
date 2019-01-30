using System.Linq;
using System.Threading.Tasks;
using EC.Web.Data;
using EC.Web.Services.Alert;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.Admin.Pages.ApplicationMenus
{
    public class ApplicationMenusDeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ApplicationMenusDeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ApplicationMenu = await _context.ApplicationMenus.FindAsync(id);

            if (ApplicationMenu != null)
            {
                _context.ApplicationMenus.Remove(ApplicationMenu);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./ApplicationMenusIndex").WithSuccess("You are redirected!", string.Format("Menu: {0} with Id: {1} deleted.", ApplicationMenu.Name, ApplicationMenu.Id)); ;
        }
    }
}