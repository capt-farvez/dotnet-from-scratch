using book_api_sqlite.Models;
using book_api_sqlite.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
// Register support for MVC-style controllers
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
// Register SQLite with AppDbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register Services (Make sure it's Scoped or Transient, not Singleton)
builder.Services.AddScoped<IBookService, BookService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


// Define a minimal GET endpoint at root URL "/"
app.MapGet("/", () => {
    return "Hello, This is landing page";
});

app.MapControllers();

app.Run();