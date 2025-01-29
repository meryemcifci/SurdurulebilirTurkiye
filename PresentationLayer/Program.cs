using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer;
using EntityLayer;
using EntityLayer.Concrete;
using System;
using SürdürülebilirTürkiye.DataAccessLayer;

var builder = WebApplication.CreateBuilder(args);

// DbContext
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

// Identity
builder.Services.AddIdentity<User, Role>(options =>
{

    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 8;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedAccount = false;
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;

})
    .AddEntityFrameworkStores<Context>()
    .AddDefaultTokenProviders();


var app = builder.Build();

// Middleware'ler
app.UseAuthentication();
app.UseAuthorization();

// Rolleri ve admin kullanýcýsýný oluþtur
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<Role>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

    // Roller oluþtur
    if (!await roleManager.RoleExistsAsync("Admin"))
    {
        await roleManager.CreateAsync(new Role { Name = "Admin" });
    }
    if (!await roleManager.RoleExistsAsync("User"))
    {
        await roleManager.CreateAsync(new Role { Name = "User" });
    }

    // Admin kullanýcýsý oluþtur
    if (await userManager.FindByEmailAsync("meryemcifcii06@gmail.com") == null)
    {
        var adminUser = new User
        {
            UserName = "meryemcifcii06@gmail.com",
            Email = "meryemcifcii06@gmail.com",
            FullName = "Admin User"
        };
        await userManager.CreateAsync(adminUser, "Admin123!");
        await userManager.AddToRoleAsync(adminUser, "Admin");
    }
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();