using EC.Web.Data;
using EC.Web.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EC.Web.ViewComponents.Base
{
    public class ApplicationMenusViewComponent : ViewComponent
    {
        private IApplicationMenuService _menuService;
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationMenusViewComponent(
            IApplicationMenuService menuService,
            UserManager<ApplicationUser> userManager)
        {
            _menuService = menuService;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string filter)
        {
            var menus = new List<ApplicationMenu>();
            var roleNames = new List<string>();
            //roleNames.Add("anonymous");
            var userName = this.User.Identity.Name;
            if (!string.IsNullOrEmpty(userName))
            {
                var user = await _userManager.FindByNameAsync(userName);
                var rolesAssigned = await _userManager.GetRolesAsync(user);
                roleNames.AddRange(rolesAssigned);
            }

            var assignedMenus = await _menuService.GetAssignedApplicationMenusAsync(roleNames);

            assignedMenus = assignedMenus.Where(x => x.Parent != null && x.Parent.Name == filter).OrderBy(x => x.Position).ToList();

            foreach (var menu in assignedMenus)
            {
                if (!menus.Exists(x => x.Name == menu.Name))
                {
                    menus.Add(menu);
                }
            }

            var menuContent = string.Empty;

            foreach (var menu in menus)
            {
                menuContent += PopulateMenuItem(menu, null);
            }
            //var firstTierMenus = menus.Where(x => x.Parent == null);
            //foreach (var menu in firstTierMenus)
            //{
            //    menuContent += PopulateMenuItem(menu, null);
            //}
            return View("ApplicationMenus", menuContent);
        }        

        private string PopulateMenuItem(ApplicationMenu menu, ApplicationMenu parent)
        {
            string result = string.Empty;

            if (menu.Children != null)
            {
                if (menu.Children.Count == 0)
                {
                    result = CreateLinkItem(menu.AreaName, menu.FolderName, menu.PageName, menu.Name, parent);
                }
                else
                {
                    result += CreateStartDropdown(menu.Name);
                    var children = menu.Children.OrderBy(x => x.Position).ToList();
                    foreach (var menuItem in children)
                    {
                        result += PopulateMenuItem(menuItem, menu);
                    }
                    result += CreateClosingDropdown();
                }
            }
            else
            {
                result += CreateLinkItem(menu.AreaName, menu.FolderName, menu.PageName, menu.Name, parent);
            }
            return result;
        }

        private string CreateLinkItem(string areaName, string folderName, string pageName, string menuName, ApplicationMenu parent)
        {
            var path = string.Empty;

            if (!string.IsNullOrEmpty(areaName))
            {
                path += string.Format("/{0}", areaName);
            }
            if (!string.IsNullOrEmpty(folderName))
            {
                path += string.Format("/{0}", folderName);
            }
            if (!string.IsNullOrEmpty(pageName))
            {
                path += string.Format("/{0}", pageName);
            }

            string result = string.Empty;
            if (parent == null)
            {
                result = "<li class=\"nav-item\">";
                result += string.Format("<a class=\"nav-link\" href=\"{0}\">{1}</a>", path, menuName);
                result += "</li>";
            }
            else
                result += string.Format("<a class=\"dropdown-item\" href=\"{0}\">{1}</a>", path, menuName);

            return result;
        }

        private string CreateStartDropdown(string menuName)
        {
            string result = string.Empty;
            result = "<li class=\"nav-item dropdown\">";
            result += string.Format("<a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"navbarDropdown\" role=\"button\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">{0}</a>", menuName);
            result += string.Format("<div class=\"dropdown-menu\" aria-labelledby=\"navbarDropdown\">");
            return result;
        }

        private string CreateClosingDropdown()
        {
            string result = string.Empty;
            result = "</div>";
            result += "</li>";
            return result;
        }
    }
}
