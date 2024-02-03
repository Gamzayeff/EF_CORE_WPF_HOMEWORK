
using EF_CORE_FluentApi_Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_CORE_FluentApi_Homework3.Configurations;

public class S_CardConfiguration : IEntityTypeConfiguration<S_Card>
{
    public void Configure(EntityTypeBuilder<S_Card> builder)
    {
        builder.Property(sc => sc.DateOut).IsRequired().HasColumnType("datetime");
        builder.Property(sc => sc.DateIn).IsRequired().HasColumnType("datetime");
        builder.HasOne(sc => sc.Book).WithMany(b => b.S_Cards).HasForeignKey(sc => sc.BookId);
        builder.HasOne(sc => sc.Lib).WithMany(l => l.S_Cards).HasForeignKey(sc => sc.LibId);
        builder.HasOne(sc => sc.Student).WithMany(s => s.S_Cards).HasForeignKey(sc => sc.StudentId);
    }
}
