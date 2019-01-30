using System;
using System.Collections.Generic;
using System.Linq;
using EC.Web.Data;
using EC.Web.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.Admin.Pages.ApplicationRoles
{
    public class RoleMenusPageModel : PageModel
    {
        public List<RoleMenuDataViewModel> AssignedRoleMenusDataList { get; set; }

        public RoleMenusPageModel()
        {
            AssignedRoleMenusDataList = new List<RoleMenuDataViewModel>();
        }

        public void PopulateAssignedRoleMenus(ApplicationDbContext context, string roleId)
        {
            var availableMenus = context.ApplicationMenus.ToList();

            var roleMenus = context.ApplicationRoleMenus.Where(x => x.RoleId == roleId).ToList();

            AssignedRoleMenusDataList = (from a in availableMenus
                                         join r in roleMenus on a.Id equals r.MenuId into loj
                                         from l in loj.DefaultIfEmpty()
                                         where a.IsDefault == false
                                         select new RoleMenuDataViewModel
                                         {
                                             MenuId = a.Id,
                                             MenuFullName = string.Format(
                                                 "{0}{1}{2}{3}{4}",
                                                 a.AreaName,
                                                 string.IsNullOrEmpty(a.AreaName) ? "" : "/",
                                                 a.FolderName,
                                                 string.IsNullOrEmpty(a.FolderName) ? "" : "/",
                                                 a.PageName),
                                             MenuCaption = a.MenuCaption,
                                             IsAssigned = l == null ? false : true
                                         }).ToList();
        }

        public void UpdateRoleMenus(ApplicationDbContext context, string[] selectedMenuIds, string roleId)
        {
            // get current assigned RoleMenus
            var roleMenus = context.ApplicationRoleMenus.Where(x => x.RoleId == roleId).ToList();

            // remove menu not selected
            foreach (var rm in roleMenus)
            {
                if (!selectedMenuIds.Contains(rm.MenuId))
                {
                    context.ApplicationRoleMenus.Remove(rm);
                }
            }
            // add new menu selected
            foreach (var menuId in selectedMenuIds)
            {
                var roleMenu = context.ApplicationRoleMenus.Where(x => x.RoleId == roleId && x.MenuId == menuId).FirstOrDefault();
                if (roleMenu == null)
                    context.ApplicationRoleMenus.Add(new ApplicationRoleMenu
                    {
                        RoleId = roleId,
                        MenuId = menuId,
                    });
            }
            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw ex;
            }
        }        

        private bool ApplicationRoleExists(ApplicationDbContext context, string id)
        {
            return context.ApplicationRoles.Any(e => e.Id == id);
        }
    }
}