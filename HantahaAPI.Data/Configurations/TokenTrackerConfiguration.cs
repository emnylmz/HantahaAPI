using HantahaAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HantahaAPI.Data
{
    internal class TokenTrackerConfiguration : IEntityTypeConfiguration<TokenTracker>
    {
        public void Configure(EntityTypeBuilder<TokenTracker> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.ExpirationDate).IsRequired();
            builder.Property(x => x.Token).IsRequired();
            builder.ToTable("TokenTrackers");
        }
    }
}


