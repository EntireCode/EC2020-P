using EC.Web.ViewModels.Base;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EC.Web.ViewComponents.Base
{
    public class UserMessagesListViewComponent : ViewComponent
    {
        public UserMessagesListViewComponent()
        {

        }

        public IViewComponentResult Invoke()
        {
            var userMessages = new List<UserMessageViewModel>();
            userMessages.Add(new UserMessageViewModel
            {
                MessageTitle = "Important message",
                MessageDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt...",
                MessageURL = "#",
                IsImportant = true,
                Sender = "John Doe",
                SenderEmail = "admin@bootstrapmaster.com",
                SenderAvatar = "/img/avatars/7.jpg",
                MessageReceivedAt = "Just now",
                BadgeType = "badge-success"
            });
            userMessages.Add(new UserMessageViewModel
            {
                MessageTitle = "Important message",
                MessageDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt...",
                MessageURL = "#",
                IsImportant = false,
                Sender = "John Doe",
                SenderEmail = "admin@bootstrapmaster.com",
                SenderAvatar = "/img/avatars/7.jpg",
                MessageReceivedAt = "5 minutes ago",
                BadgeType = "badge-warning"
            });
            userMessages.Add(new UserMessageViewModel
            {
                MessageTitle = "Important message",
                MessageDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt...",
                MessageURL = "#",
                IsImportant = false,
                Sender = "John Doe",
                SenderEmail = "admin@bootstrapmaster.com",
                SenderAvatar = "/img/avatars/7.jpg",
                MessageReceivedAt = "1:52 PM",
                BadgeType = "badge-danger"
            });
            userMessages.Add(new UserMessageViewModel
            {
                MessageTitle = "Important message",
                MessageDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt...",
                MessageURL = "#",
                IsImportant = false,
                Sender = "John Doe",
                SenderEmail = "admin@bootstrapmaster.com",
                SenderAvatar = "/img/avatars/7.jpg",
                MessageReceivedAt = "4:03 PM",
                BadgeType = "badge-info"
            });
            return View("UserMessagesList", userMessages);
        }
    }
}
