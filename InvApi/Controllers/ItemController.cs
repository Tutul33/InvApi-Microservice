using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using System.Text.Json;
using System.Text;
using DTOs.Command;
using InvApi.Common;

namespace InvApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateItem([FromBody] CreateItemCommand order)
        {
            // Serialize order to JSON
            var orderJson = JsonSerializer.Serialize(order);

            // Publish message to RabbitMQ
            PublishMessages.Publish("itemQueue", orderJson);

            return Ok("Order created and message sent to inventory service.");
        }
    }    
}
