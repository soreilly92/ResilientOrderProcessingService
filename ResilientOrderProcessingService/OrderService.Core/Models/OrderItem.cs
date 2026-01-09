namespace OrderService.Core
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
