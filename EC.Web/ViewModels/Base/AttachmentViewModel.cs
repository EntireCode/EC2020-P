using System.ComponentModel.DataAnnotations;

namespace EC.Web.ViewModels.Base
{
    public class AttachmentViewModel
    {
        [Display(Name="File Name")]
        public string FileName { get; set; }

        public long Size { get; set; }
    }
}
