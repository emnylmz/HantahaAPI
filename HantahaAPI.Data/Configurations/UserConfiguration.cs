using System;
using HantahaAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HantahaAPI.Data
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Username).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.CountryId).IsRequired();
            builder.Property(x => x.Firstname).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Lastname).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastIV).IsRequired().HasMaxLength(100);
            builder.HasOne(ur => ur.Country)
                   .WithMany(r => r.Users)
                   .HasForeignKey(ur => ur.CountryId);
            builder.ToTable("User");
        }
    }
}

