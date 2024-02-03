using EF_CORE_FluentApi_Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_CORE_FluentApi_Homework3.Configurations;
public class ThemeConfiguration : IEntityTypeConfiguration<Theme>
{
    public void Configure(EntityTypeBuilder<Theme> builder)
    {
        builder.Property(t => t.Name).HasColumnType("nvarchar(15)").IsRequired(true);
        builder.HasMany(t => t.Books).WithOne(b => b.Theme).HasForeignKey(b => b.ThemeId);
    }


}
