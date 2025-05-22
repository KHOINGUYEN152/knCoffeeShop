using knCoffeeShop.Models;
using Microsoft.EntityFrameworkCore;
namespace knCoffeeShop.Data
{
    public class CoffeeShopDbContext : DbContext
    {
        public CoffeeShopDbContext(DbContextOptions<CoffeeShopDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Espresso", Price = 25.00m, Detail = "Cà phê đen đậm đặc, nguyên chất", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = true },
                new Product { Id = 2, Name = "Latte", Price = 30.50m, Detail = "Sự kết hợp hoàn hảo giữa espresso và sữa tươi", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = false },
                new Product { Id = 3, Name = "Cappuccino", Price = 32.75m, Detail = "Espresso, sữa nóng và bọt sữa mềm mịn", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = true },
                new Product { Id = 4, Name = "Americano", Price = 28.00m, Detail = "Espresso pha loãng với nước nóng, hương vị nhẹ nhàng", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = false },
                new Product { Id = 5, Name = "Mocha", Price = 35.25m, Detail = "Sự hòa quyện của espresso, sữa nóng và socola ngọt ngào", ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = true }
            );
        }

    }
}