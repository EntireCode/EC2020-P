using EC.Web.Data;
using EC.Web.ViewModels.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace EC.Web.ViewComponents.Base
{
    public class UserAccountInfoViewComponent : ViewComponent
    {
        private ApplicationDbContext _context;

        public UserAccountInfoViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var user = _context.ApplicationUsers.FirstOrDefault(x => x.UserName == User.Identity.Name);

            if (user == null)
            {
                throw new Exception("User not found!");
            }

            var userAccountInfo = new UserAccountInfoViewModel
            {
                UserName = user.UserName,
                UserAvatarURL = user.AvatarURL,
                UserEmail = user.Email,
                Updates = 42,
                Messages = 42,
                Tasks = 42,
                Comments = 42,
                Payments = 42,
                Projects = 42
            };
            return View("UserAccountInfo", userAccountInfo);
        }
    }
}
