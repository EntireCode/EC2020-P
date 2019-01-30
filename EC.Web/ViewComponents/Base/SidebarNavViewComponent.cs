using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EC.Web.ViewComponents.Base
{
    public class SidebarNavViewComponent : ViewComponent
    {
        public SidebarNavViewComponent()
        {

        }

        public IViewComponentResult Invoke()
        {
            return View("SidebarNav");        
        }
    }
}
