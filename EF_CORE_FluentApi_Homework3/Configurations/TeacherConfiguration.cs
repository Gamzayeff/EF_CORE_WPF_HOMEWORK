

using EF_CORE_FluentApi_Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_CORE_FluentApi_Homework3.Configurations;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.Property(t => t.FirstName).HasColumnType("nvarchar(20)").IsRequired();
        builder.Property(t => t.LastName).HasColumnType("nvarchar(25)").IsRequired();
        builder.HasOne(t => t.Department).WithMany(d => d.Teachers).HasForeignKey(t => t.DepartmentId);
    }
}
