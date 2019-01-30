using EC.Web.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EC.Web.Services
{
    public class ApplicationMenuService : IApplicationMenuService
    {
        private readonly ApplicationDbContext _context;

        public ApplicationMenuService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ApplicationMenu>> GetApplicationMenusAsync()
        {            
            var allMenus = new List<ApplicationMenu>();
            allMenus = _context.ApplicationMenus.Include(x => x.Parent).ToList();
            var menus = allMenus.Where(x => x.Parent == null).OrderBy(x => x.Position).ToList();
            return menus;
        }

        public async Task<List<ApplicationMenu>> GetAssignedApplicationMenusAsync(List<string> roleNames)
        {
            var roleIds = await _context.ApplicationRoles.Where(x => roleNames.Contains(x.Name)).Select(x => x.Id).ToListAsync();

            var allMenuIds = await _context.ApplicationRoleMenus.Where(x => roleIds.Contains(x.RoleId)).Select(x => x.MenuId).ToListAsync();

            var allMenus = await (from m in _context.ApplicationMenus.Include(x => x.Parent)
                                  where allMenuIds.Contains(m.Id) || m.IsDefault
                                  select m).ToListAsync();

            return allMenus;
        }        
    }
}
