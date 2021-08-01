using DotNetCore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCore.Infrastructure.Data.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("post");

            builder.ToTable("post");

            builder.Property(e => e.PostId).HasColumnName("post_id");

            builder.Property(e => e.CreateAt)
                .HasColumnName("create_at")
                .HasColumnType("date");

            builder.Property(e => e.Description)
                .HasColumnName("description")
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Image)
                .HasColumnName("image")
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.UsersId).HasColumnName("users_id");

            builder.HasOne(d => d.Users)
                .WithMany(p => p.Post)
                .HasForeignKey(d => d.UsersId)
                .HasConstraintName("FK__post__users_id__3E52440B");
        }
    }
}
