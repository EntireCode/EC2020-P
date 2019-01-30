using System.Threading.Tasks;
using EC.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.Admin.Pages.ApplicationRoles
{
    public class ApplicationRolesDetailsModel : RoleMenusPageModel
    {
        private readonly ApplicationDbContext _context;

        public ApplicationRolesDetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}