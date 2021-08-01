using DotNetCore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCore.Infrastructure.Data.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("comment");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.CreateAt)
                .HasColumnName("create_at")
                .HasColumnType("date");

            builder.Property(e => e.Description)
                .HasColumnName("description")
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.IsActive).HasColumnName("is_active");

            builder.Property(e => e.PostId).HasColumnName("post_id");

            builder.Property(e => e.UsersId).HasColumnName("users_id");

            builder.HasOne(d => d.Post)
                .WithMany(p => p.Comment)
                .HasForeignKey(d => d.PostId)
                .HasConstraintName("FK__comment__post_id__412EB0B6");

            builder.HasOne(d => d.Users)
                .WithMany(p => p.Comment)
                .HasForeignKey(d => d.UsersId)
                .HasConstraintName("FK__comment__users_i__4222D4EF");
        }
    }
}
