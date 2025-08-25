using MiniShop.Filters;
using MiniShop.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllersWithViews();

builder.Services.AddControllersWithViews(o =>
{
    o.Filters.Add<UserLogFilter>();
});

builder.Services.AddSingleton<IProductRepository, InMemoryProductRepository>();
builder.Services.AddHttpContextAccessor();

// Sessions (30 min idle timeout)
builder.Services.AddMemoryCache();
builder.Services.AddSession(o =>
{
    o.Cookie.Name = ".MiniShop.Session";
    o.IdleTimeout = TimeSpan.FromMinutes(30);
    o.Cookie.HttpOnly = true;
    o.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
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
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
