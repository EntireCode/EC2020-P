using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EC.Web.Data
{
    public class ApplicationMenu
    {
        public string Id { get; set; }

        [StringLength(30)]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Display(Name="Menu Caption")]
        public string MenuCaption { get; set; }

        public string Icon { get; set; }

        [MaxLength(30)]
        [Display(Name = "Area Name")]
        public string AreaName { get; set; }

        [MaxLength(30)]
        [Display(Name = "Folder Name")]
        public string FolderName { get; set; }

        [MaxLength(30)]
        [Display(Name = "Page Name")]
        public string PageName { get; set; }

        public int Position { get; set; }

        [Display(Name = "Is Default?")]
        [DefaultValue(false)]
        public bool IsDefault { get; set; }

        [Display(Name = "Parent Id")]
        public string ParentId { get; set; }

        [ForeignKey("ParentId")]
        public virtual ApplicationMenu Parent { get; set; }

        public virtual List<ApplicationMenu> Children { get; set; }
    }
}
