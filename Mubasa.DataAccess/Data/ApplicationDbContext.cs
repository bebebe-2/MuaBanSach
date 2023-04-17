using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mubasa.Models;

namespace Mubasa.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Ward> Wards { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<ShoppingItem> ShoppingItems { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Address>()
                .HasOne(x => x.Province)
                .WithMany(x => x.Addresses)
                .HasForeignKey(x => x.ProvinceId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Address>()
                .HasOne(x => x.Ward)
                .WithMany(x => x.Addresses)
                .HasForeignKey(x => x.WardId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<OrderHeader>()
                .HasOne(x => x.Province)
                .WithMany(x => x.OrderHeaders)
                .HasForeignKey(x => x.ProvinceId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<OrderHeader>()
                .HasOne(x => x.Ward)
                .WithMany(x => x.OrderHeaders)
                .HasForeignKey(x => x.WardId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}