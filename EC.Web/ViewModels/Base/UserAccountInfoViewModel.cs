namespace EC.Web.ViewModels.Base
{
    public class UserAccountInfoViewModel
    {
        public string UserName { get; set; }
        public string UserAvatarURL { get; set; }
        public string UserEmail { get; set; }
        public int Updates { get; set; }
        public int Messages { get; set; }
        public int Tasks { get; set; }
        public int Comments { get; set; }
        public int Payments { get; set; }
        public int Projects { get; set; }
    }
}
