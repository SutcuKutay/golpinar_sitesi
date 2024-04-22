using Microsoft.EntityFrameworkCore;
using WebSitesi.Data;
using WebSitesi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//CodeFirst yaklaþýmý. Projenin son halinde kullanýlmýyor.//
//builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Golpinar")));

//DataBaseFirst yaklaþýmý//
builder.Services.AddScoped<DataBaseFirstDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
