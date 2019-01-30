using System.Collections.Generic;
using System.Threading.Tasks;
using EC.Web.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.Admin.Pages.ApplicationRoles
{
    public class ApplicationRolesIndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ApplicationRolesIndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ApplicationRole> ApplicationRole { get; set; }

        public async Task OnGetAsync()
        {
            ApplicationRole = await _context.ApplicationRoles.ToListAsync();
        }
    }
}