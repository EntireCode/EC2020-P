using Microsoft.AspNetCore.Mvc;

namespace EC.Web.ViewComponents.Base
{
    public class AppHeaderViewComponent : ViewComponent
    {
        public AppHeaderViewComponent()
        {

        }

        public IViewComponentResult Invoke()
        {
            return View("AppHeader");
        }
    }
}
