using System;

namespace EC.Web.Data.ViewModels
{
    public class FileAttachmentViewModel
    {
        public string Id { get; set; }

        public string ObjectName { get; set; }

        public string ObjectId { get; set; }

        public int ItemNo { get; set; }

        public string FileName { get; set; }

        public long Size { get; set; }

        public string UploadedByUserId { get; set; }

        public DateTime UploadedDate { get; set; }
    }
}
