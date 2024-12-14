namespace OrdersApi.Models.DTOs
{
    public class OrderDetailDto
    {
        public int Id { get; set; }
        public int OrderId { get; set; } // Order FK
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}
