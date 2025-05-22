

using knCoffeeShop.Models.Interfaces; // Đảm bảo namespace trùng với tên project của bạn
using System.Collections.Generic;
using System.Linq;

namespace knCoffeeShop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        // Dữ liệu giả để test trước khi tích hợp database
        private List<Product> ProductsList = new List<Product>()
        {
            new Product{ Id = 1, Name = "Espresso", Price= 25m, Detail="Cà phê đen đậm đặc", ImageUrl="https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = true},
            new Product{ Id = 2, Name = "Latte", Price= 30m, Detail="Cà phê sữa béo ngậy", ImageUrl="https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = false},
            new Product{ Id = 3, Name = "Cappuccino", Price= 32m, Detail="Cà phê sữa với lớp bọt dày", ImageUrl="https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = true},
            new Product{ Id = 4, Name = "Americano", Price= 28m, Detail="Espresso pha loãng với nước nóng", ImageUrl="https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = false},
            new Product{ Id = 5, Name = "Mocha", Price= 35m, Detail="Cà phê sữa pha socola", ImageUrl="https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", IsTrendingProduct = true}
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return ProductsList;
        }

        public Product? GetProductDetail(int id)
        {
            return ProductsList.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return ProductsList.Where(p => p.IsTrendingProduct);
        }
    }
}