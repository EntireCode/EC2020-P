using EC.Web.Areas.RMA.Data;
using EC.Web.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EC.Web.Data
{
    public class DataSeed
    {
        public static async Task Initialize(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            // create admin, user roles
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new ApplicationRole("admin", "System administrator role.", DateTime.UtcNow));
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new ApplicationRole("user", "System user role.", DateTime.UtcNow));
            }

            // create admin user account
            if (await userManager.FindByNameAsync("admin") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@advantech.com",
                    Email = "admin@advantech.com",
                    FirstName = "Admin",
                    LastName = "Advantech",
                    EmailConfirmed = true,
                    AvatarURL = "/img/avatars/user.png"
                };
                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, "P@$$w0rd");
                    await userManager.AddToRoleAsync(user, "admin");
                    
                    await userManager.AddClaimAsync(user, new Claim(CustomClaimTypes.GivenName, user.FirstName));
                    await userManager.AddClaimAsync(user, new Claim(CustomClaimTypes.Surname, user.LastName));
                    await userManager.AddClaimAsync(user, new Claim(CustomClaimTypes.AvatarURL, user.AvatarURL));
                }
            }

            // create default menus
            if (!context.ApplicationMenus.Any())
            {
                context.ApplicationMenus.Add(new ApplicationMenu
                {
                    Name = "Home",
                    Description = "Home Page",
                    AreaName = "",
                    FolderName = "",
                    IsDefault = true,
                    Parent = null,
                    PageName = "Index",
                    Position = 1,
                    Children = new List<ApplicationMenu>()
                });                
                context.ApplicationMenus.Add(new ApplicationMenu
                {
                    Name = "About",
                    Description = "About Page",
                    AreaName = "",
                    FolderName = "",
                    IsDefault = true,
                    Parent = null,
                    PageName = "About",
                    Position = 2,
                    Children = new List<ApplicationMenu>()
                });
                context.ApplicationMenus.Add(new ApplicationMenu
                {
                    Name = "Contact",
                    Description = "Contact Page",
                    AreaName = "",
                    FolderName = "",
                    IsDefault = true,
                    Parent = null,
                    PageName = "Contact",
                    Position = 3,
                    Children = new List<ApplicationMenu>()
                });

                var adminMenu = new ApplicationMenu
                {
                    Name = "Admin",
                    Description = "Admin Link",
                    AreaName = "Admin",
                    FolderName = "",
                    IsDefault = false,
                    Parent = null,
                    PageName = "",
                    Position = 4,
                    MenuCaption = "Security",
                    Icon = "icon-shield",
                    Children = new List<ApplicationMenu>()
                };

                var usersMenu = new ApplicationMenu
                {
                    Name = "Users",
                    Description = "Users Management",
                    AreaName = "Admin",
                    FolderName = "ApplicationUsers",
                    IsDefault = false,
                    Parent = adminMenu,
                    PageName = "Index",
                    Position = 1,
                    Icon = "icon-user",
                    MenuCaption = "Users",
                    Children = new List<ApplicationMenu>()
                };

                var rolesMenu = new ApplicationMenu
                {
                    Name = "Roles",
                    Description = "Roles Setting",
                    AreaName = "Admin",
                    FolderName = "ApplicationRoles",
                    IsDefault = false,
                    Parent = adminMenu,
                    PageName = "Index",
                    Position = 2,
                    Icon = "icon-lock",
                    MenuCaption = "Roles",
                    Children = new List<ApplicationMenu>()
                };

                var menusMenu = new ApplicationMenu
                {
                    Name = "Menus",
                    Description = "Menus Setting",
                    AreaName = "Admin",
                    FolderName = "ApplicationMenus",
                    IsDefault = false,
                    Parent = adminMenu,
                    PageName = "Index",
                    Position = 3,
                    Icon = "fa fa-university",
                    MenuCaption = "Menus",
                    Children = new List<ApplicationMenu>()
                };

                adminMenu.Children.Add(usersMenu);
                adminMenu.Children.Add(rolesMenu);
                adminMenu.Children.Add(menusMenu);

                context.ApplicationMenus.Add(adminMenu);

                await context.SaveChangesAsync();
            }

            // Initialize RMANumber
            if (!context.RMANumbers.Any())
            {
                context.RMANumbers.Add(new RMANumber { CurrentRMANumber = 80000 });
                context.SaveChanges();
            }
        }
    }
}
