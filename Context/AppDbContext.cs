using Microsoft.EntityFrameworkCore;

using LOH_UserManagement.Entities;

namespace LOH_UserManagement.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<LOHUser> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Seller> Sellers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // User-Seller relationship
            builder.Entity<LOHUser>()
                .HasOne(u => u.Seller)
                .WithOne(s => s.User)
                .HasForeignKey<Seller>(s => s.UserId);

            // User-Buyer relationship
            builder.Entity<LOHUser>()
                .HasOne(u => u.Buyer)
                .WithOne(b => b.User)
                .HasForeignKey<Buyer>(b => b.UserId);

            // User-Wallet relationship
            builder.Entity<LOHUser>()
                .HasOne(u => u.Wallet)
                .WithOne(w => w.User)
                .HasForeignKey<Wallet>(w => w.UserId);

        }
    }
}
