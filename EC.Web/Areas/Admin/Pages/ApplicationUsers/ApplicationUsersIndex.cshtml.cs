using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EC.Web.Data;
using EC.Web.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.Admin.Pages.ApplicationUsers
{
    public class ApplicationUsersIndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ApplicationUsersIndexModel(ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IList<UserViewModel> Users { get; set; }

        public async Task OnGetAsync()
        {
            var users = await _context.ApplicationUsers.ToListAsync();
            Users = new List<UserViewModel>();
            foreach (var user in users)
            {
                var userVM = _mapper.Map<UserViewModel>(user);
                var userRoles = (from ur in _context.UserRoles
                                 join r in _context.Roles on ur.RoleId equals r.Id
                                 where ur.UserId == user.Id
                                 select r.Name).ToList();
                userVM.AssignedRoles = string.Join(",", userRoles);
                Users.Add(userVM);
            }
        }
    }
}