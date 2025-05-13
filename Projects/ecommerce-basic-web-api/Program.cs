// Create a builder to configure the web application (sets up hosting, logging, etc.)
var builder = WebApplication.CreateBuilder(args);

// Register support for MVC-style controllers
builder.Services.AddControllers();
// Register services for Swagger (API documentation & testing UI)
builder.Services.AddEndpointsApiExplorer();  // Enables support for minimal APIs in Swagger
builder.Services.AddSwaggerGen();           // Generates Swagger/OpenAPI docs
// Register the CategoryService with Dependency Injection
builder.Services.AddSingleton<ecommerce_basic_web_api.Services.ICategoryService, ecommerce_basic_web_api.Services.CategoryService>();

// Build the application from the builder configuration
var app = builder.Build();

// Enable Swagger and Swagger UI only in development mode
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();       // Generate the Swagger JSON
    app.UseSwaggerUI();     // Show the Swagger UI at /swagger
}

// Redirect HTTP requests to HTTPS
app.UseHttpsRedirection();

// Define a minimal GET endpoint at root URL "/"
app.MapGet("/", () => {
    return "Hello, This is landing page";
});

// Middleware to handle authorization (does nothing unless you configure policies)
app.UseAuthorization();

// Map controller routes like /api/categories
app.MapControllers();

// Start the web application
app.Run();