namespace EC.Web.Areas.Examples.Data.ViewModel
{
    public class OrderItemViewModel
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public virtual OrderViewModel Order { get; set; }

        public int ItemNo { get; set; }

        public int ProductId { get; set; }

        public virtual ProductViewModel Product { get; set; }

        public double UnitPrice { get; set; }

        public int Quantity { get; set; }

        public double Amount { get { return UnitPrice * Quantity; } }
    }
}
