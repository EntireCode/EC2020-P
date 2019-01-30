using Microsoft.AspNetCore.Mvc;

namespace EC.Web.ViewComponents.Base
{
    public class FooterViewComponent : ViewComponent
    {

        public FooterViewComponent()
        {
        }

        public IViewComponentResult Invoke(string filter)
        {
            return View("Footer");
        }
    }
}
