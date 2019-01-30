namespace EC.Web.ViewModels.Base
{
    public class UserMessageViewModel
    {
        public string Sender { get; set; }
        public string SenderEmail { get; set; }
        public string SenderAvatar { get; set; }
        public string MessageURL { get; set; }
        public bool IsImportant { get; set; }
        public string MessageTitle { get; set; }
        public string MessageDescription { get; set; }
        public string MessageReceivedAt { get; set; }
        public string BadgeType { get; set; }
    }
}
