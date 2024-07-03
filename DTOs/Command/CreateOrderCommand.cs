using DTOs.Response;
using MediatR;
using System.Text.Json.Serialization;

namespace DTOs.Command
{
    public class CreateOrderCommand : IRequest<CreateOrderCommandResponse>
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("productName")]
        public string ProductName { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        // Assuming Price might not be present in your JSON
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
    }
}
