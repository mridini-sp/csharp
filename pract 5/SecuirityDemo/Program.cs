using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SecuirityDemo.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(o =>
    o.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDefaultIdentity<IdentityUser>(o =>
    o.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Create Admin role and Admin user
using (var scope = app.Services.CreateScope())
{
    var rm = scope.ServiceProvider
        .GetRequiredService<RoleManager<IdentityRole>>();

    var um = scope.ServiceProvider
        .GetRequiredService<UserManager<IdentityUser>>();

    if (!await rm.RoleExistsAsync("Admin"))
        await rm.CreateAsync(new IdentityRole("Admin"));

    var user = await um.FindByEmailAsync("admin@gmail.com");

    if (user == null)
    {
        user = new IdentityUser
        {
            UserName = "admin@gmail.com",
            Email = "admin@gmail.com",
            EmailConfirmed = true
        };

        await um.CreateAsync(user, "Admin@123");
    }

    if (!await um.IsInRoleAsync(user, "Admin"))
        await um.AddToRoleAsync(user, "Admin");
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();