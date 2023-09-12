using Microsoft.EntityFrameworkCore;
using RecommendationEngineService;
using RecommendationEngineService.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterServices();


// Add database context with initialization
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<RecommendationDbContext>(options =>
    options.UseSqlServer(connectionString)
        .EnableSensitiveDataLogging() // Optional for debugging
        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)); // Optional for read-only operations

var app = builder.Build();

// Database initialization
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<RecommendationDbContext>();
        context.Database.EnsureCreated();
    }
    catch (Exception ex)
    {
        // Handle any exceptions related to database initialization here
        // For example, log the error or take appropriate action
    }
}

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
