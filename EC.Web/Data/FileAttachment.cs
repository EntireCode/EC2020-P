using System;
using System.ComponentModel.DataAnnotations;

namespace EC.Web.Data
{
    public class FileAttachment
    {
        public string Id { get; set; }

        [Display(Name="Object Name")]
        public string ObjectName { get; set; }

        [Display(Name = "Object Id")]
        public string ObjectId { get; set; }

        [Display(Name = "Item No")]
        public int ItemNo { get; set; }

        [Display(Name = "File Name")]
        public string FileName { get; set; }

        public long Size { get; set; }

        [Display(Name = "Uploaded By User Id")]
        public string UploadedByUserId { get; set; }

        [Display(Name = "Uploaded By User")]
        public virtual ApplicationUser UploadedByUser { get; set; }

        [Display(Name = "Uploaded Date")]
        public DateTime UploadedDate { get; set; }
    }
}
