using System;
using HantahaAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HantahaAPI.Data
{
    internal class UserPasswordResetTokenConfiguration : IEntityTypeConfiguration<UserPasswordResetToken>
    {
        public void Configure(EntityTypeBuilder<UserPasswordResetToken> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ExpirationTime).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();
            builder.HasOne(ur => ur.User)
                   .WithMany(r => r.UserPasswordResetTokens)
                   .HasForeignKey(ur => ur.UserId);
            builder.ToTable("UserPasswordResetToken");
        }
    }
}

