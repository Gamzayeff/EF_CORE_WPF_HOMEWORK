using EF_CORE_FluentApi_Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_FluentApi_Homework3.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.Property(a => a.FirstName).HasColumnType("nvarchar(20)").IsRequired(true);
        builder.Property(a => a.LastName).HasColumnType("nvarchar(30)").IsRequired(true);
        builder.HasMany(a => a.Books).WithOne(b => b.Author).HasForeignKey(b => b.AuthorId);
    }
}
