

using EF_CORE_FluentApi_Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_CORE_FluentApi_Homework3.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.Property(b => b.Name).HasColumnType("nvarchar(50)").IsRequired(true);
        builder.HasIndex(b => b.Name);

        builder.Property(b => b.Pages).HasColumnType("int").IsRequired();
        builder.Property(b => b.YearPress).HasColumnType("int").IsRequired();
        builder.Property(b => b.Quantity).HasColumnType("int").HasDefaultValue(1);
        builder.Property(b => b.Comment).HasColumnType("nvarchar(100)").HasDefaultValue("cox qeseng kitabdir");
    }
}
