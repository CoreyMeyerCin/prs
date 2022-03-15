using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using DotNETcapstone.Models;

namespace DotNETcapstone.Models
{
    public class AppDbContext:DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(
                    "server=localhost\\sqlexpress;database=prs-capstone-server;trusted_connection=true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(e => e.HasIndex(x => x.Id).IsUnique(true));
            builder.Entity<User>(e=> e.HasIndex(x => x.Username).IsUnique(true));

            builder.Entity<Vendor>(e => e.HasIndex(x => x.Id).IsUnique(true));
            builder.Entity<Vendor>(e => e.HasIndex(x => x.Code).IsUnique(true));

            builder.Entity<Product>(e => e.HasIndex(x => x.Id).IsUnique(true));
            builder.Entity<Product>(e => e.HasIndex(x => x.PartNbr).IsUnique(true));
        }
        public DbSet<DotNETcapstone.Models.Vendor> Vendor { get; set; }
        public DbSet<DotNETcapstone.Models.Request> Request { get; set; }
        public DbSet<DotNETcapstone.Models.RequestLine> RequestLine { get; set; }
        
    }
}
