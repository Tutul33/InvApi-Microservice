using DTOs.Command;
using DTOs.Response;
using MediatR;
using System;
using DTOs.Command;

namespace InvApi.Handler
{
    public class OrderCommandHandler : IRequestHandler<CreateOrderCommand, CreateOrderCommandResponse>
    {
        public OrderCommandHandler()//(AppDbContext dbContext)
        {
            
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            
            CreateOrderCommandResponse obj = new CreateOrderCommandResponse();
            return obj; // Returning the ID of the created order
        }
    }
}
