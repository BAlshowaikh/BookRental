using BookRentalObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using BookRentalWebIdentity.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<BookRentalDBContext>(options => options.UseSqlServer(
   builder.Configuration.GetConnectionString("DefaultConnection")
    ));

// Add the Identity context connection
builder.Services.AddDbContext<IdentityContext>(options => options.UseSqlServer(
   builder.Configuration.GetConnectionString("IdentityContextConnection")
    ));

builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<IdentityContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

// Seed user role if not roles exist create them (Once the app start these data will be added automatically)
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    string[] roles = { "User", "Manager", "Admin" };

    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }
}

app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
