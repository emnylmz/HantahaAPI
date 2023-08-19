using System;
using HantahaAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HantahaAPI.Data
{
    internal class SystemLogConfiguration : IEntityTypeConfiguration<SystemLog>
    {
        public void Configure(EntityTypeBuilder<SystemLog> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ExceptionMessage).IsRequired();
            builder.Property(x => x.ExceptionSource).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ExceptionUrl).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ExceptionType).IsRequired().HasMaxLength(255);
            builder.ToTable("SystemLog");
        }
    }
}

