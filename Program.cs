using APIBurger_PriscilaZuniga.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using APIBurger_PriscilaZuniga.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<APIBurger_PriscilaZunigaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("APIBurger_PriscilaZunigaContext") ?? throw new InvalidOperationException("Connection string 'APIBurger_PriscilaZunigaContext' not found.")));

// Add services to the container.

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapBurgerEndpoints();



app.Run();
