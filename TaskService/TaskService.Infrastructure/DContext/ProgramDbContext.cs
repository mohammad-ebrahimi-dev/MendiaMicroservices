using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace TaskService.Infrastructure.DContexts
{
    public class ProgramDbContext : DbContext
    {
        public ProgramDbContext(DbContextOptions<ProgramDbContext> options)
            : base(options)
        {
        }

        public DbSet<TaskService.Domain.Entity.Task> Tasks { get; set; }
        public DbSet<TaskService.Domain.Entity.Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
