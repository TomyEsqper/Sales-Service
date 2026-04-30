using Sales_Service.adapter.restful.v1.controller.Mapper;
using Sales_Service.application.Service;
using Sales_Service.domain;
using Sales_Service.infrastructure.DbContext;
using Sales_Service.infrastructure.Mapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure MySQL
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Register Dependencies
builder.Services.AddScoped<IOrderService, OrderServiceImp>();
builder.Services.AddScoped<Repository>();
// Register the RESTful mapper implementation
builder.Services.AddScoped<IAdapterMapper, AdapterMapper>();
builder.Services.AddScoped<IInfrastructureMapper, InfrastructureMapper>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

