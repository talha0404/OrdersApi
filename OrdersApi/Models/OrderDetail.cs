namespace OrdersApi.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; } // Order FK
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice => Quantity * UnitPrice;


        public Order Order { get; set; } // Each Order Detail belongs to one order
        public Product Product { get; set; } // OrderDetail Should
    }
}
