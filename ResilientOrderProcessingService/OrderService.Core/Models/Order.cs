namespace OrderService.Core.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }

        public string CustomerId { get; set; }

        public List<OrderItem> Items { get; set; } = new();

        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        public DateTime CreatedAt { get; set; } 

        public DateTime? ProcessedAt { get; set; }


    }
}
