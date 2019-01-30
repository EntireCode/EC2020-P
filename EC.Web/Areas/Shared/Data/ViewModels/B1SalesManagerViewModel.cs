using System.ComponentModel.DataAnnotations;

namespace EC.Web.Areas.Shared.Data.ViewModels
{
    public class B1SalesManagerViewModel
    {
        [Display(Name = "User Code")]
        public string FldValue { get; set; }

        [Display(Name = "Sales Manager Name")]
        public string Descr { get; set; }
    }
}
