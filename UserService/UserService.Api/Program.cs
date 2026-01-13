using UserService.Application.User.Commands;
using UserService.Application.Users;
using UserService.Infrastructure.Repository;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddControllers();
        builder.Services.AddSwaggerGen();
        builder.Services.AddScoped<IUser, CreateUser>();
        builder.Services.AddScoped<IUser, UpdateUser>();
        builder.Services.AddScoped<IUser, GetUser>();
        builder.Services.AddScoped<IUser, DeleteUser>();
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowGateway", policy =>
                policy.WithOrigins("https://localhost:7021")
                      .AllowAnyHeader()
                      .AllowAnyMethod());
        });
        var app = builder.Build();

        app.UseCors("AllowGateway");

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "User Service v1");
                options.RoutePrefix = "";
            });
        }

        app.UseHttpsRedirection();

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
        app.Run();
    }
}
