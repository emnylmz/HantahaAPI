using HantahaAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HantahaAPI.Data
{
    internal class VerbItemConfiguration : IEntityTypeConfiguration<VerbItem>
    {
        public void Configure(EntityTypeBuilder<VerbItem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Context).IsRequired().HasMaxLength(300);
            builder.ToTable("VerbItem");
        }
    }
}


