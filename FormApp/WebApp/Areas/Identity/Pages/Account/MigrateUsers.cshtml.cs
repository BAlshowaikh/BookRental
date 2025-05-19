using BookRentalObject;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


public class MigrateUsersModel : PageModel
{
    private readonly BookRentalDBContext _context;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public string Message { get; set; }

    public MigrateUsersModel(
        BookRentalDBContext context,
        UserManager<IdentityUser> userManager,
        RoleManager<IdentityRole> roleManager)
    {
        _context = context;
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public async Task<IActionResult> OnGetAsync()
    {
        var users = _context.Users.ToList();
        int migrated = 0;

        foreach (var user in users)
        {
            var existing = await _userManager.FindByEmailAsync(user.Email);
            if (existing != null)
                continue;

            var identityUser = new IdentityUser
            {
                UserName = user.Email,
                Email = user.Email,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(identityUser, "Test@123");

            if (!result.Succeeded)
                continue;

            string role = user.UserRoleId switch
            {
                1 => "Admin",
                2 => "Manager",
                3 => "User",
                _ => "User"
            };

            if (!await _roleManager.RoleExistsAsync(role))
            {
                await _roleManager.CreateAsync(new IdentityRole(role));
            }

            await _userManager.AddToRoleAsync(identityUser, role);
            migrated++;
        }

        Message = $"✅ Migration complete: {migrated} users created.";
        return Page();
    }
}
