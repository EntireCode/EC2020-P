using System;
using System.Collections.Generic;
using System.Linq;
using EC.Web.Data;
using EC.Web.ViewModels.Admin;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EC.Web.Areas.Admin.Pages.ApplicationUsers
{
    public class RolesPageModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public List<AssignedRoleDataViewModel> AssignedRolesDataList;

        public RolesPageModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public void PopulateRolesPageModelModel(ApplicationDbContext context, ApplicationUser user)
        {
            AssignedRolesDataList = new List<AssignedRoleDataViewModel>();

            if (user != null)
            {
                AssignedRolesDataList = (from ar in context.Roles
                                         join ur in context.UserRoles.Where(x => x.UserId == user.Id) on ar.Id equals ur.RoleId into loj
                                         from l in loj.DefaultIfEmpty()
                                         select new AssignedRoleDataViewModel
                                         {
                                             Id = ar.Id,
                                             Name = ar.Name,
                                             Assigned = l == null ? false : true
                                         }).ToList();
            }
            else
            {
                AssignedRolesDataList = (from ar in context.Roles
                                         select new AssignedRoleDataViewModel
                                         {
                                             Id = ar.Id,
                                             Name = ar.Name,
                                             Assigned = false
                                         }).ToList();
            }
        }

        public void UpdateUserRoles(ApplicationDbContext context, string[] selectedRoles, ApplicationUser user)
        {
            var roles = context.Roles.ToList();

            var originalRolesAssigned = AssignedRolesDataList.Where(x => x.Assigned).Select(x => x.Id).ToList();

            foreach (var role in roles)
            {
                if (selectedRoles.Contains(role.Id))
                {
                    if (!originalRolesAssigned.Contains(role.Id))
                    {
                        _userManager.AddToRoleAsync(user, role.Name).Wait();
                    }
                }
                else
                {
                    if (originalRolesAssigned.Contains(role.Id))
                    {
                        _userManager.RemoveFromRoleAsync(user, role.Name).Wait();
                    }
                }
            }
        }        
    }
}