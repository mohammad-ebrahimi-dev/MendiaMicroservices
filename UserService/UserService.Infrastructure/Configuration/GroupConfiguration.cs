using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserService.Domain.Entity;

namespace UserService.Domain.Configuration
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(x => x.User)
                .WithOne(u => u.Group)
                .HasForeignKey<Group>(x => x.UserId);
        }
    }
}
