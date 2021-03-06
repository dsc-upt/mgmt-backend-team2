//using Backend.Database;
//using Microsoft.EntityFrameworkCore;

using Backend.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuring database

 var connectionString = "Host=backend;Port=6969;Database=users-ariana;Username=guest;Password=cocacola";
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));
 
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
