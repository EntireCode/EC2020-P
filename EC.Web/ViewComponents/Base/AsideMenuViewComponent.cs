using Microsoft.AspNetCore.Mvc;

namespace EC.Web.ViewComponents.Base
{
    public class AsideMenuViewComponent : ViewComponent
    {
        public AsideMenuViewComponent()
        {

        }

        public IViewComponentResult Invoke(string filter)
        {
            return View("AsideMenu");
        }
    }
}
