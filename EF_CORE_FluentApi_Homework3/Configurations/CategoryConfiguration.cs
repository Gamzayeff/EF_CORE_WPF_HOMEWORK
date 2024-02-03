
using EF_CORE_FluentApi_Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_CORE_FluentApi_Homework3.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(c => c.Name).HasColumnType("nvarchar(20)").IsRequired();
        builder.HasMany(c => c.Books).WithOne(b => b.Category).HasForeignKey(b => b.CategoryId);
    }
}
