using HantahaAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HantahaAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            // PostgreSQL eski zaman damgası davranışını etkinleştir
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<SystemLog> SystemLog { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Verb> Verb { get; set; }
        public DbSet<VerbItem> VerbItem { get; set; }
        public DbSet<Sentence> Sentence { get; set; }
        public DbSet<SentenceItem> SentenceItem { get; set; }
        public DbSet<LanguageCountry> LanguageCountry { get; set; }

        public DbSet<TokenTracker> TokenTrackers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}

