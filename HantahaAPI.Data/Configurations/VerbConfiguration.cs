using HantahaAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HantahaAPI.Data
{
    internal class VerbConfiguration : IEntityTypeConfiguration<Verb>
    {
        public void Configure(EntityTypeBuilder<Verb> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(300);
            builder.ToTable("Verb");
        }
    }
}


