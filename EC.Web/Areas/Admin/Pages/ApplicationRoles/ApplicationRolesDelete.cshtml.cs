using System.Threading.Tasks;
using EC.Web.Data;
using EC.Web.Services.Alert;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.Admin.Pages.ApplicationRoles
{
    public class ApplicationRolesDeleteModel : RoleMenusPageModel
    {
        private readonly ApplicationDbContext _context;

        public ApplicationRolesDeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ApplicationRole ApplicationRole { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ApplicationRole = await _context.ApplicationRoles.FirstOrDefaultAsync(m => m.Id == id);

            if (ApplicationRole == null)
            {
                return NotFound();
            }

            PopulateAssignedRoleMenus(_context, id);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ApplicationRole = await _context.ApplicationRoles.FindAsync(id);

            if (ApplicationRole != null)
            {
                _context.ApplicationRoles.Remove(ApplicationRole);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./ApplicationRolesIndex").WithSuccess("You are redirected!", string.Format("Role: {0} with Id: {1} deleted.", ApplicationRole.Name, ApplicationRole.Id));
        }
    }
}