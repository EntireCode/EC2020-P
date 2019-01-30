using System.Linq;
using System.Threading.Tasks;
using EC.Web.Data;
using EC.Web.Services.Alert;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.Admin.Pages.ApplicationRoles
{
    public class ApplicationRolesCreateModel : RoleMenusPageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public ApplicationRolesCreateModel(ApplicationDbContext context,
            RoleManager<ApplicationRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
        }

        public IActionResult OnGet()
        {
            PopulateAssignedRoleMenus(_context, null);

            return Page();
        }

        [BindProperty]
        public ApplicationRole ApplicationRole { get; set; }

        public async Task<IActionResult> OnPostAsync(string[] selectedMenuIds)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _roleManager.CreateAsync(ApplicationRole);

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var role = _context.ApplicationRoles.FirstOrDefault(x => x.Name == ApplicationRole.Name);
                    UpdateRoleMenus(_context, selectedMenuIds, role.Id);
                    transaction.Commit();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }

            return RedirectToPage("./ApplicationRolesIndex").WithSuccess("You are redirected!", string.Format("Role: {0} created.", ApplicationRole.Name));
        }
    }
}