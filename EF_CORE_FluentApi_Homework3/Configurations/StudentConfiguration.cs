

using EF_CORE_FluentApi_Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_CORE_FluentApi_Homework3.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.Property(s => s.FirstName).IsRequired().HasColumnType("nvarchar(20)");
        builder.Property(s => s.LastName).IsRequired().HasColumnType("nvarchar(25)");
        builder.Property(s => s.Term).IsRequired().HasColumnType("nvarchar(30)");
        builder.HasOne(s => s.Group).WithMany(g => g.Students).HasForeignKey(s => s.GroupId);
    }
}
