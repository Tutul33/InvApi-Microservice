using MediatR;

namespace DTOs.Command
{
    public class UpdateInventoryCommand : IRequest<bool>
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
