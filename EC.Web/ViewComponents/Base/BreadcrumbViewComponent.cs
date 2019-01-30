using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EC.Web.ViewComponents.Base
{
    public class BreadcrumbViewComponent : ViewComponent
    {
        public BreadcrumbViewComponent()
        {

        }

        public IViewComponentResult Invoke(string filter)
        {
            var path = HttpContext.Request.Path.ToString();

            var routes = path.Split('/');
            var breadcrumbs = new List<string>();
            for(int i=1; i<routes.Length;i++)
            {
                breadcrumbs.Add(routes[i]);
            }
            if (breadcrumbs[0].Trim() == "")
                breadcrumbs.Clear();

            return View("Breadcrumb", breadcrumbs);
        }
    }
}
