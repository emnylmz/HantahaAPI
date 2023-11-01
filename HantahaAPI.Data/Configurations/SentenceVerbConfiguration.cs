using HantahaAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HantahaAPI.Data
{
    internal class SentenceVerbConfiguration : IEntityTypeConfiguration<SentenceVerb>
    {
        public void Configure(EntityTypeBuilder<SentenceVerb> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.ToTable("SentenceVerb");
        }
    }
}


