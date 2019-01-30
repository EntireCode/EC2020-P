using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EC.Web.Data;
using EC.Web.Services.Alert;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EC.Web.Areas.Admin.Pages.ApplicationMenus
{
    public class ApplicationMenusCreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ApplicationMenusCreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            var menus = (from m in _context.ApplicationMenus
                         select new SelectListItem
                         {
                             Value = m.Id,
                             Text = m.Name
                         }).ToList();
            ViewData["AvailableMenus"] = menus;
            return Page();
        }

        [BindProperty]
        public ApplicationMenu ApplicationMenu { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ApplicationMenus.Add(ApplicationMenu);
            await _context.SaveChangesAsync();

            return RedirectToPage("./ApplicationMenusIndex").WithSuccess("You are redirected!", string.Format("Menu: {0} created.", ApplicationMenu.Name));
        }
    }
}