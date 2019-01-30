namespace EC.Web.Areas.Examples.Data.ViewModel
{
    public class OrderAttachmentViewModel
    {
        public string Id { get; set; }

        public int OrderId { get; set; }

        public virtual OrderViewModel Order { get; set; }

        public string FileName { get; set; }

        public long Size { get; set; }
    }
}
