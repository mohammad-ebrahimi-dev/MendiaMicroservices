public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddSwaggerGen();
        builder.Services.AddControllers();
        var app = builder.Build();
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("https://localhost:5001/swagger/v1/swagger.json", "UserService");
                options.SwaggerEndpoint("https://localhost:5097/swagger/v1/swagger.json", "TaskService API");
                options.RoutePrefix = string.Empty;
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
