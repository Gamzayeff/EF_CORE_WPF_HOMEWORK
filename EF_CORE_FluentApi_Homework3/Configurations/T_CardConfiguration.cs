

using EF_CORE_FluentApi_Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_CORE_FluentApi_Homework3.Configurations;

public class T_CardConfiguration : IEntityTypeConfiguration<T_Card>
{
    public void Configure(EntityTypeBuilder<T_Card> builder)
    {
        builder.Property(tc => tc.DateOut).IsRequired().HasColumnType("datetime");
        builder.Property(tc => tc.DateIn).IsRequired().HasColumnType("datetime");
        builder.HasOne(tc => tc.Book).WithMany(b => b.T_Cards).HasForeignKey(tc => tc.BookId);
        builder.HasOne(tc => tc.Lib).WithMany(l => l.T_Cards).HasForeignKey(tc => tc.LibId);
        builder.HasOne(tc => tc.Teacher).WithMany(t => t.T_Cards).HasForeignKey(tc => tc.TeacherId);
    }
}
