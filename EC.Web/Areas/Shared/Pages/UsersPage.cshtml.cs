using System.Collections.Generic;
using EC.Web.Areas.Shared.Data.ViewModels;
using EC.Web.Services.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EC.Web.Areas.Shared.Pages
{
    public class UsersPageModel : PageModel
    {
        private readonly IUserService _userService;

        public List<UserSelectListViewModel> UsersDataList;

        public UsersPageModel(IUserService userService)
        {
            _userService = userService;
        }

        public void PopulateUsersDataList(string claimType, string claimValue)
        {
            UsersDataList = _userService.GetUsers(claimType, claimValue);
        }

        public void OnGet()
        {
        }
    }
}