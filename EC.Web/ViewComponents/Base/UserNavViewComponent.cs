using Microsoft.AspNetCore.Mvc;

namespace EC.Web.ViewComponents.Base
{
    public class UserNavViewComponent : ViewComponent
    {
        public UserNavViewComponent()
        {

        }

        public IViewComponentResult Invoke()
        {
            return View("UserNav");
        }
    }
}
