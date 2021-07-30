using DotNetCore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCore.Infrastructure.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> builder)
        {
            builder.ToTable("employees");

            builder.HasKey(e => e.EmployeeId)
                .HasName("PK__employee__C52E0BA84DB75922");

            builder.ToTable("employees");

            builder.Property(e => e.EmployeeId)
                .HasColumnName("employee_id")
                .ValueGeneratedNever();

            builder.Property(e => e.CreatedAt)
                .HasColumnName("created_at")
                .HasColumnType("datetime");

            builder.Property(e => e.FirstName)
                .HasColumnName("first_name")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasColumnName("last_name")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Salary).HasColumnName("salary");
        }
    }
}
