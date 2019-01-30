using EC.Web.ViewModels.Base;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EC.Web.ViewComponents.Base
{
    public class UserTasksListViewComponent : ViewComponent
    {
        public UserTasksListViewComponent()
        {

        }

        public IViewComponentResult Invoke()
        {
            var userTasks = new List<UserTaskViewModel>();
            userTasks.Add(new UserTaskViewModel
            {
                TaskName = "Upgrade NPM Bower",
                CompletePercentage = 0,
                BgColor = "bg-info"
            });
            userTasks.Add(new UserTaskViewModel
            {
                TaskName = "ReactJS Version",
                CompletePercentage = 25,
                BgColor = "bg-danger"
            });
            userTasks.Add(new UserTaskViewModel
            {
                TaskName = "VueJS Version",
                CompletePercentage = 50,
                BgColor = "bg-warning"
            });
            userTasks.Add(new UserTaskViewModel
            {
                TaskName = "Add new layouts",
                CompletePercentage = 75,
                BgColor = "bg-info"
            });
            userTasks.Add(new UserTaskViewModel
            {
                TaskName = "Angular 2 Cli Version",
                CompletePercentage = 100,
                BgColor = "bg-success"
            });
            return View("UserTasksList", userTasks);
        }
    }
}
