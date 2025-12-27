using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace TaskService.Infrastructure.DContext
{
    public class ProgramDbContext : DbContext
    {
        DbSet<Task> Tasks { get; set; }
        DbSet<Group> Groups { get; set; }
    }
}
