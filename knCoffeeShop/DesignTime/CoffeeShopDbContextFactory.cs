using knCoffeeShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace knCoffeeShop.DesignTime
{
    public class CoffeeShopDbContextFactory : IDesignTimeDbContextFactory<CoffeeShopDbContext>
    {
        public CoffeeShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("CoffeeShopDbContextConnection");

            var builder = new DbContextOptionsBuilder<CoffeeShopDbContext>();
            builder.UseSqlServer(connectionString);

            return new CoffeeShopDbContext(builder.Options);
        }
    }
}