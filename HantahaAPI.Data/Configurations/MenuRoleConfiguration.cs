using System;
using System.Reflection.Emit;
using HantahaAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HantahaAPI.Data
{
    internal class MenuRoleConfiguration : IEntityTypeConfiguration<MenuRole>
    {
        public void Configure(EntityTypeBuilder<MenuRole> builder)
        {
            builder.HasKey(x => x.MenuRoleId);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.MenuId).IsRequired();
            builder.Property(x => x.RoleId).IsRequired();
            builder.HasOne(ur => ur.Role)
                   .WithMany(r => r.MenuRoles)
                   .HasForeignKey(ur => ur.RoleId);
            builder.HasOne(ur => ur.Menu)
                   .WithMany(r => r.MenuRoles)
                   .HasForeignKey(ur => ur.MenuId);

            builder.ToTable("MenuRole");
        }
    }
}

