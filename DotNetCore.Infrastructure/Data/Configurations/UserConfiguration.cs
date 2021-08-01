using DotNetCore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCore.Infrastructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");

            builder.HasKey(e => e.UsersId)
                    .HasName("PK__user__3213E83FC13F5CAB");

            builder.ToTable("user");

            builder.Property(e => e.UsersId).HasColumnName("users_id");

            builder.Property(e => e.CreateAt)
                .HasColumnName("create_at")
                .HasColumnType("date");

            builder.Property(e => e.Email)
                .HasColumnName("email")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.FirstName)
                .HasColumnName("first_name")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.IsActive).HasColumnName("is_active");

            builder.Property(e => e.LastName)
                .HasColumnName("last_name")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
