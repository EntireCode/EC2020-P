using System.ComponentModel.DataAnnotations;

namespace EC.Web.Areas.Shared.Data.ViewModels
{
    public class B1ProductViewModel
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        [Display(Name = "Customer Part Number")]
        public string FrgnName { get; set; }
    }
}
