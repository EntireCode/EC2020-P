using System.Threading.Tasks;
using EC.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.Admin.Pages.ApplicationUsers
{
    public class ApplicationUsersDetailModel : RolesPageModel
    {
        private readonly ApplicationDbContext _context;

        public ApplicationUsersDetailModel(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager) : base(userManager)
        {
            _context = context;
        }

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
    }
}