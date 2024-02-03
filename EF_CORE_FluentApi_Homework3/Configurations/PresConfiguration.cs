using EF_CORE_FluentApi_Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_FluentApi_Homework3.Configurations;

public class PresConfiguration : IEntityTypeConfiguration<Pres>
{
    public void Configure(EntityTypeBuilder<Pres> builder)
    {
        builder.Property(p => p.Name).HasColumnType("varchar(20)").IsRequired(true);
        builder.HasMany(p => p.Books).WithOne(b => b.Pres).HasForeignKey(b => b.PresId);
    }
}
