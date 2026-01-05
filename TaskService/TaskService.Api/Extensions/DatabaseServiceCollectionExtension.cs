using Microsoft.EntityFrameworkCore;
using TaskService.Infrastructure.DContexts;

namespace TaskService.Api.Extensions
{
    public static class DatabaseServiceCollectionExtension
    {
        public static IServiceCollection AddTaskServiceDatabase(this IServiceCollection services , string ConnectionString)
        {
            services.AddDbContext<ProgramDbContext>(options =>
            {
                options.UseSqlServer(ConnectionString);
            });
            return services;
        }
    }
}
