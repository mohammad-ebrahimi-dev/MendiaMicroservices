using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserService.Domain.Entity;

namespace UserService.Domain.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(x => x.RoleName)
                .HasMaxLength(40)
                .IsRequired();

            builder.HasOne(r => r.User)
                   .WithOne(u => u.Role)
                   .HasForeignKey<Role>(r => r.UserId);

        }
    }
}
