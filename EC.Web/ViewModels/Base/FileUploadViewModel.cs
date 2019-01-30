using System.ComponentModel.DataAnnotations;

namespace EC.Web.ViewModels.Base
{
    public class FileUploadViewModel
    {
        [Required]
        [Display(Name = "File Name")]
        [StringLength(60, MinimumLength = 3)]
        public string FileName { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

    }
}
