using Microsoft.AspNetCore.Mvc;

namespace EC.Web.ViewComponents.Base
{
    public class StatusMessageViewComponent : ViewComponent
    {
        public StatusMessageViewComponent()
        {

        }

        public IViewComponentResult Invoke()
        {
            return View("StatusMessage");
        }
    }
}
