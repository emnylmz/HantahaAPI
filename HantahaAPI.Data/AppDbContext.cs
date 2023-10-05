using System;
using System.Reflection;
using HantahaAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace HantahaAPI.Data
{
    public class AppDbContext:DbContext
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
        public DbSet<LanguageCountry> LanguageCountry { get; set; }
        //public DbSet<BlackListToken> BlackListToken { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}

