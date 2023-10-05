using System;
using HantahaAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HantahaAPI.Data
{
    internal class LanguageCountryConfiguration : IEntityTypeConfiguration<LanguageCountry>
    {
        public void Configure(EntityTypeBuilder<LanguageCountry> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.ToTable("LanguageCountry");
        }
    }
}


