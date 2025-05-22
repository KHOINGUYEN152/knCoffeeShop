using knCoffeeShop.Models.Interfaces;
using knCoffeeShop.Models.Services;
// ... (các lệnh using khác)

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// >>> THÊM ĐOẠN CODE NÀY VÀO ĐÂY <<<
builder.Services.AddScoped<IProductRepository, ProductRepository>();
// >>> HẾT ĐOẠN CODE CẦN THÊM <<<

var app = builder.Build();

// ... (phần còn lại của Program.cs)


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
