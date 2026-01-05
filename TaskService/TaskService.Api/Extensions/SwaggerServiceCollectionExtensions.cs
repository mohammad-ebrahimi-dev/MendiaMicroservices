using Microsoft.OpenApi;

namespace TaskService.Api.Extensions
{
    public static class SwaggerServiceCollectionExtensions
    {
        public static IServiceCollection AddTaskServiceSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Task Service API",
                    Version = "v1"
                });
            });
            return services;
        }
    }
}
