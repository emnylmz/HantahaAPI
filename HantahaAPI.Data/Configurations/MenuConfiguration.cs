using System;
using HantahaAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HantahaAPI.Data
{
    internal class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Path).IsRequired().HasMaxLength(150);
            builder.Property(x => x.MenuText).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Icon).HasMaxLength(150);
            builder.Property(x => x.IsActive).IsRequired();
            builder.ToTable("Menu");
            //burada menünün altındaki menüleri çekerken sorun çıkabilir 
        }
    }
}

