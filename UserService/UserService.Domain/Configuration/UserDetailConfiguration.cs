using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserService.Domain.Entity;

namespace UserService.Domain.Configuration
{
    public class UserDetailConfiguration : IEntityTypeConfiguration<UserDetail>
    {
        public void Configure(EntityTypeBuilder<UserDetail> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.BirthDate)
                   .IsRequired();

            builder.Property(x => x.NationalCode)
                   .HasMaxLength(10)
                   .IsUnicode(false);

            builder.Property(x => x.Address)
                   .HasMaxLength(250);

            builder.Property(x => x.PhoneNumber)
                   .HasMaxLength(15)
                   .IsUnicode(false);

            builder.HasOne(u => u.User)
                   .WithOne(u => u.UserDetail)
                   .HasForeignKey<UserDetail>(x => x.UserId)
                   .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(r => r.User)
                   .WithOne(u => u.UserDetail)
                   .HasForeignKey<UserDetail>(r => r.UserId);
        }
    }
}