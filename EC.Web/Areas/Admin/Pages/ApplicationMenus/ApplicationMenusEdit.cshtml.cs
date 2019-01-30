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
    public class ApplicationMenusEditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ApplicationMenusEditModel(ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ApplicationMenu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplicationMenuExists(ApplicationMenu.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./ApplicationMenusIndex").WithSuccess("You are redirected!", string.Format("Menu: {0} with Id: {1} modified successfully.", ApplicationMenu.Name, ApplicationMenu.Id));
        }

        private bool ApplicationMenuExists(string id)
        {
            return _context.ApplicationMenus.Any(e => e.Id == id);
        }
    }
}