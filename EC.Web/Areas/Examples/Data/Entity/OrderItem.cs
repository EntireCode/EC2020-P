namespace EC.Web.Areas.Examples.Data.Entity
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        public int ItemNo { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int Quantity { get; set; }

    }
}
