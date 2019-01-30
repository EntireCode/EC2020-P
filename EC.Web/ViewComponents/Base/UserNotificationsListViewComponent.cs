using EC.Web.ViewModels.Base;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EC.Web.ViewComponents.Base
{
    public class UserNotificationsListViewComponent : ViewComponent
    {
        public UserNotificationsListViewComponent()
        {

        }

        public IViewComponentResult Invoke()
        {
            var userNotifications = new List<UserNotificationViewModel>();
            userNotifications.Add(new UserNotificationViewModel
            {
                NotificationDescription = "New user registered",
                NotificationIcon = "icon-user-follow",
                NotificationTextColor = "text-success",
                NotificationURL = "#"
            });
            userNotifications.Add(new UserNotificationViewModel
            {
                NotificationDescription = "User deleted",
                NotificationIcon = "icon-user-unfollow",
                NotificationTextColor = "text-danger",
                NotificationURL = "#"
            });
            userNotifications.Add(new UserNotificationViewModel
            {
                NotificationDescription = "Sales report is ready",
                NotificationIcon = "icon-chart",
                NotificationTextColor = "text-info",
                NotificationURL = "#"
            });
            userNotifications.Add(new UserNotificationViewModel
            {
                NotificationDescription = "New client",
                NotificationIcon = "icon-basket-loaded",
                NotificationTextColor = "text-primary",
                NotificationURL = "#"
            });
            userNotifications.Add(new UserNotificationViewModel
            {
                NotificationDescription = "Server overloaded",
                NotificationIcon = "icon-speedometer text-warning",
                NotificationTextColor = "text-success",
                NotificationURL = "#"
            });
            return View("UserNotificationsList", userNotifications);
        }
    }
}
