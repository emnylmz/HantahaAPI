using System;
using HantahaAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HantahaAPI.Data
{
    internal class FeedbackConfiguration : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(EntityTypeBuilder<Feedback> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Topic).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ReadStatus).IsRequired();
            builder.HasOne(ur => ur.User)
                   .WithMany(r => r.FeedBacks)
                   .HasForeignKey(ur => ur.CreatedBy);
            builder.ToTable("Feedback");
        }
    }
}

