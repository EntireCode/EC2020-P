namespace EC.Web.Areas.Shared.Data.ViewModels
{
    public class UserSelectListViewModel
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }
    }
}
