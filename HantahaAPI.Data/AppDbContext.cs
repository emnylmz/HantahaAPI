using System;
using System.Reflection;
using HantahaAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace HantahaAPI.Data
{
    public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
		{
		}

        public DbSet<User> Users { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<SystemLog> SystemLog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}

