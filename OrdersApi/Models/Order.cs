namespace OrdersApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; } // User FK
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Pending";

        public User User { get; set; } // Many-to-One
        public ICollection<OrderDetail> OrderDetails { get; set; } // One-to-Many
    }
}
