

using EF_CORE_FluentApi_Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_CORE_FluentApi_Homework3.Configurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.Property(d => d.Name).HasColumnType("nvarchar(25)");
        builder.HasIndex(d => d.Name);
    }
}
