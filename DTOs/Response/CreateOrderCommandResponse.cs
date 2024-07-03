namespace DTOs.Response
{
    public class CreateOrderCommandResponse
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
