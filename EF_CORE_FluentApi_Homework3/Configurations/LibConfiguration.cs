

using EF_CORE_FluentApi_Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_CORE_FluentApi_Homework3.Configurations;

public class LibConfiguration : IEntityTypeConfiguration<Lib>
{
    public void Configure(EntityTypeBuilder<Lib> builder)
    {
        builder.Property(l => l.FirstName).HasColumnType("nvarchar(10)").IsRequired();
        builder.Property(l => l.LastName).HasColumnType("nvarchar(15)").IsRequired();
    }
}
