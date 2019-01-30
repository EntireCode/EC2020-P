using EC.Web.Data;
using EC.Web.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EC.Web.ViewComponents.Base
{
    public class SidebarNavApplicationMenuViewComponent : ViewComponent
    {
        private IApplicationMenuService _menuService;
        private readonly UserManager<ApplicationUser> _userManager;
        private const string doubleQuote = "\"";

        public SidebarNavApplicationMenuViewComponent(
            IApplicationMenuService menuService,
            UserManager<ApplicationUser> userManager)
        {
            _menuService = menuService;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menus = new List<ApplicationMenu>();
            var roleNames = new List<string>();
            roleNames.Add("anonymous");
            var userName = this.User.Identity.Name;
            if (!string.IsNullOrEmpty(userName))
            {
                var user = await _userManager.FindByNameAsync(userName);
                var rolesAssigned = await _userManager.GetRolesAsync(user);
                roleNames.AddRange(rolesAssigned);
            }

            var assignedMenus = await _menuService.GetAssignedApplicationMenusAsync(roleNames);

            foreach (var menu in assignedMenus.OrderBy(x => x.Position))
            {
                if (!menus.Exists(x => x.Name == menu.Name))
                {
                    menus.Add(menu);
                }
            }

            var menuContent = string.Empty;

            var firstTierMenus = menus.Where(x => x.Parent == null);
            foreach (var menu in firstTierMenus)
            {
                menuContent += PopulateMenuItem(menu, null);
            }
            return View("SidebarNavApplicationMenu", menuContent);
        }

        private string PopulateMenuItem(ApplicationMenu menu, ApplicationMenu parent)
        {
            string result = string.Empty;

            if (menu.Children != null)
            {
                if (menu.Children.Count == 0)
                {
                    result = CreateLinkItem(menu, parent);
                }
                else
                {
                    result += CreateStartDropdown(menu);
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
                result += CreateLinkItem(menu, parent);
            }
            return result;
        }

        private string CreateLinkItem(ApplicationMenu menu, ApplicationMenu parent)
        {
            var path = string.Empty;

            if (!string.IsNullOrEmpty(menu.AreaName))
            {
                path += string.Format("/{0}", menu.AreaName);
            }
            if (!string.IsNullOrEmpty(menu.FolderName))
            {
                path += string.Format("/{0}", menu.FolderName);
            }
            if (!string.IsNullOrEmpty(menu.PageName))
            {
                path += string.Format("/{0}", menu.PageName);
            }

            string result = string.Empty;
                result = string.Format("<li class={0}nav-item{0}>", doubleQuote);                
                result += string.Format("<a class={0}nav-link{0} href={0}{1}{0}><i class={0}{2}{0}></i> {3}</a>", doubleQuote, path, menu.Icon, menu.MenuCaption);
                result += "</li>";

            return result;
        }

        private string CreateStartDropdown(ApplicationMenu menu)
        {
            string result = string.Empty;
            result = string.Format("<li class={0}nav-item nav-dropdown{0}>", doubleQuote);
            result += string.Format("<a class={0}nav-link nav-dropdown-toggle{0} href={0}#{0}><i class={0}{1}{0}></i> {2}</a>", doubleQuote, menu.Icon, menu.MenuCaption);
            result += string.Format("<ul class={0}nav-dropdown-items{0}>", doubleQuote);
            return result;
        }

        private string CreateClosingDropdown()
        {
            string result = string.Empty;
            result = "</ul>";
            result += "</li>";
            return result;
        }
    }
}
