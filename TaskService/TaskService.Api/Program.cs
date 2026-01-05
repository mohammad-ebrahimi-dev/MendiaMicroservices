using Microsoft.EntityFrameworkCore;
using TaskService.Infrastructure.DContexts;
using TaskService.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder);

var app = builder.Build();

// Configure middlewares
ConfigureMiddlewares(app);

// Run the application
app.Run();

void ConfigureServices(WebApplicationBuilder builder)
{
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();

    builder.Services.AddMediatR(cfg =>
    {
        cfg.RegisterServicesFromAssembly(typeof(TaskService.Application.Queries.GetTaskCommand).Assembly);
    });

    var connectionString = builder.Configuration["ConnectionStrings:Default"];
    builder.Services.AddDbContext<ProgramDbContext>(options =>
    {
        options.UseSqlServer(connectionString);
    });

    builder.Services.AddTaskServiceSwagger();

    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowGateway", policy =>
            policy.WithOrigins("https://localhost:7021")
                  .AllowAnyHeader()
                  .AllowAnyMethod());
    });
}

void ConfigureMiddlewares(WebApplication app)
{
    app.UseCors("AllowGateway");

    if (app.Environment.IsDevelopment())
    {
        // مسیر Swagger JSON
        app.UseSwagger();

        app.UseSwaggerUI();
    }

    // Enable HTTPS redirection and map controllers
    app.UseHttpsRedirection();
    app.MapControllers();
}
