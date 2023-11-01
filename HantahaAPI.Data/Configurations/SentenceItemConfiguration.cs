using HantahaAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HantahaAPI.Data
{
    internal class SentenceItemConfiguration : IEntityTypeConfiguration<SentenceItem>
    {
        public void Configure(EntityTypeBuilder<SentenceItem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Context).IsRequired().HasMaxLength(300);
            builder.ToTable("SentenceItem");
        }
    }
}


