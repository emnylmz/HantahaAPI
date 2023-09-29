using System;
using HantahaAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HantahaAPI.Data
{
    internal class BlackListTokenConfiguration : IEntityTypeConfiguration<BlackListToken>
    {
        public void Configure(EntityTypeBuilder<BlackListToken> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Token).IsRequired();
            builder.ToTable("BlackListToken");
        }
    }
}


