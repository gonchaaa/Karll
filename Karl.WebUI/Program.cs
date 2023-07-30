using Karl.Business.Abstract;
using Karl.Business.Concrete;
using Karl.DataAccess.Abstract;
using Karl.DataAccess.Concrete.EntityFrameWork;
using Karl.DataAccess.Concrete.Sqlite;
using Karl.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDefaultIdentity<User>().AddRoles<IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddScoped<ICategoryService,CategoryManager>();
builder.Services.AddScoped<ICategoryDal,EfCategoryDal>();

builder.Services.AddScoped<AppDbContext>();

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}/{seourl?}");
});


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}/{seourl?}");

app.Run();
