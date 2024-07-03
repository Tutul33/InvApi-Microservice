using AdminService.DIServices;
using InvApi.InterCom.RabbirMQListener;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Register MediatR
ConfigureMediatRServices.Register(builder);
ConfigureRabbitMQServices.Register(builder);
ConfigureServices.RegisterServices(builder.Services);
// Register other services including RabbitMqConsumerService




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
