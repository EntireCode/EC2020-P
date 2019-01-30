using System.Linq;
using System.Threading.Tasks;
using EC.Web.Data;
using EC.Web.Services.Alert;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.Admin.Pages.ApplicationRoles
{
    public class ApplicationRolesEditModel : RoleMenusPageModel
    {
        private readonly ApplicationDbContext _context;

        public ApplicationRolesEditModel(ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync(string[] selectedMenuIds)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var role = await _context.ApplicationRoles.FirstOrDefaultAsync(m => m.Id == ApplicationRole.Id);

            if (role == null)
            {
                return NotFound();
            }

            if (ApplicationRole.Name != role.Name)
            {
                role.Name = ApplicationRole.Name;
                role.NormalizedName = ApplicationRole.Name.ToUpper();
            }

            if (ApplicationRole.Description != role.Description)
            {
                role.Description = ApplicationRole.Description;
            }

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    await _context.SaveChangesAsync();
                    UpdateRoleMenus(_context, selectedMenuIds, role.Id);
                    transaction.Commit();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    transaction.Rollback();
                    if (!ApplicationRoleExists(ApplicationRole.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw ex;
                    }
                }
            }

            return RedirectToPage("./ApplicationRolesIndex").WithSuccess("You are redirected!", string.Format("Role: {0} with Id {1} deleted!", ApplicationRole.Name, ApplicationRole.Id));
        }

        private bool ApplicationRoleExists(string id)
        {
            return _context.ApplicationRoles.Any(e => e.Id == id);
        }

        
    }
}