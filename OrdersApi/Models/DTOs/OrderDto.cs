namespace OrdersApi.Models.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int UserId { get; set; } // User FK
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Pending";
    }
}
