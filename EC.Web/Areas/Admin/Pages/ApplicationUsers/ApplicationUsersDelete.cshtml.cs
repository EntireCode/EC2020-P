using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EC.Web.Data;
using EC.Web.Services.Alert;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.Admin.Pages.ApplicationUsers
{
    public class ApplicationUsersDeleteModel : RolesPageModel
    {
        private readonly ApplicationDbContext _context;

        public ApplicationUsersDeleteModel(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager) : base(userManager)
        {
            _context = context;
        }

        [BindProperty]
        public ApplicationUser ApplicationUser { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ApplicationUser = await _context.ApplicationUsers.FirstOrDefaultAsync(m => m.Id == id);

            if (ApplicationUser == null)
            {
                return NotFound();
            }

            PopulateRolesPageModelModel(_context, ApplicationUser);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ApplicationUser = await _context.ApplicationUsers.FindAsync(id);

            if (ApplicationUser != null)
            {
                _context.ApplicationUsers.Remove(ApplicationUser);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./ApplicationUsersIndex")
                .WithSuccess("You are redirected!", string.Format("User: {0} with Id {1} deleted!", ApplicationUser.UserName, ApplicationUser.Id));
        }
    }
}