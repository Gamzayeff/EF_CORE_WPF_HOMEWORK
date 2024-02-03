

using EF_CORE_FluentApi_Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_CORE_FluentApi_Homework3.Configurations;

public class FacultyConfiguration : IEntityTypeConfiguration<Faculty>
{
    public void Configure(EntityTypeBuilder<Faculty> builder)
    {
        builder.Property(f => f.Name).HasColumnType("nvarchar(15)");
        builder.HasIndex(f => f.Name);
        builder.HasMany(f => f.Groups).WithOne(g => g.Faculty).HasForeignKey(g => g.FacultyId);
    }
}
