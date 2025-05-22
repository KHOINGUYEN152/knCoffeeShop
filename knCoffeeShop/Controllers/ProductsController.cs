
using knCoffeeShop.Models.Interfaces; // Import namespace của interface
using Microsoft.AspNetCore.Mvc;
using System.Linq; // Thường cần cho các thao tác LINQ trên IEnumerable

namespace knCoffeeShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository; // Khai báo một instance của IProductRepository

        // Constructor injection: ASP.NET Core sẽ tự động inject IProductRepository vào đây
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // Action để hiển thị danh sách tất cả sản phẩm
        public IActionResult Shop()
        {
            // Gọi phương thức từ repository để lấy dữ liệu
            var products = _productRepository.GetAllProducts();
            // Truyền dữ liệu sang View
            return View(products);
        }

        // Action để hiển thị chi tiết một sản phẩm theo ID
        public IActionResult Detail(int id)
        {
            var product = _productRepository.GetProductDetail(id);
            // Xử lý trường hợp không tìm thấy sản phẩm
            if (product == null)
            {
                return NotFound(); // Trả về lỗi 404
            }
            return View(product);
        }
    }
}