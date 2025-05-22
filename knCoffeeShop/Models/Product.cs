namespace knCoffeeShop.Models // Đảm bảo namespace trùng với tên project của bạn
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Detail { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public bool IsTrendingProduct { get; set; } // Thêm thuộc tính này
    }
}