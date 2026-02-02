using Microsoft.EntityFrameworkCore;
using TaskService.Api.Extensions;
using TaskService.Infrastructure.DContexts;

public class Program
{
    public static void Main(string[] args)
    {
    var builder = WebApplication.CreateBuilder(args);

    ConfigureServices(builder);

    var app = builder.Build();

    ConfigureMiddlewares(app);

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
            app.UseSwagger();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Task Service v1");
                options.RoutePrefix = "";
            });
        }

        app.UseHttpsRedirection();
        app.MapControllers();
    }

}
}
