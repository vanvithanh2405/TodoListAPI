
using Microsoft.EntityFrameworkCore;
using TodoList.Infrastructure.Data.DbContexts;
using TodoList.Infrastructure.Data.Mappers;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddDbContext<MainDbContext>(options =>
{
    options.UseSqlServer(connectionString,
                                providerOptions => { providerOptions.EnableRetryOnFailure(); providerOptions.UseCompatibilityLevel(120); });
}, ServiceLifetime.Transient);

builder.Services.AddAutoMapper(typeof(MainMapper));

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

app.Run();
