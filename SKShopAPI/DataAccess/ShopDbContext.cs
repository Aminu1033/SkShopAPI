using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SKShopAPI.Data;
using SKShopAPI.Entities;

namespace SKShopAPI.DataAccess
{
    public class ShopDbContext : IdentityDbContext<User>
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) { }         
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(InitialData.GetProducts());
            modelBuilder.Entity<Category>().HasData(InitialData.GetCategories());

            modelBuilder.Entity<IdentityRole>().HasData(InitialData.GetRoles());          

        }


    }
}
