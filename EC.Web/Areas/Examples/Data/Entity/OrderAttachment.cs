namespace EC.Web.Areas.Examples.Data.Entity
{
    public class OrderAttachment
    {
        public string Id { get; set; }

        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        public string FileName { get; set; }

        public long Size { get; set; }
    }
}
