var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/user-service/swagger.json", "User Service");
        options.SwaggerEndpoint("https://localhost:5001/swagger/v1/swagger.json", "Task Service API");
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

