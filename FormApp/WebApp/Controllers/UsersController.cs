using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookRentalObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace WebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly BookRentalDBContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public UsersController(BookRentalDBContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
        }

        // GET: Users
        public async Task<IActionResult> Index(string searchEmail, string isActive)
        {
            var users = _context.Users.Include(u => u.UserRole).AsQueryable();

            if (!string.IsNullOrEmpty(searchEmail))
            {
                users = users.Where(u => u.Email.Contains(searchEmail));
            }

            if (!string.IsNullOrEmpty(isActive))
            {
                bool status = isActive == "true";
                users = users.Where(u => u.IsActive == status);
            }

            return View(await users.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var user = await _context.Users
                .Include(u => u.UserRole)
                .FirstOrDefaultAsync(m => m.UserId == id);

            return user == null ? NotFound() : View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            ViewBag.RoleList = new SelectList(_context.UserRoles.ToList(), "UserRoleId", "Role");
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                var identityUser = new IdentityUser
                {
                    UserName = user.Email,
                    Email = user.Email,
                    EmailConfirmed = true
                };

                var result = await _userManager.CreateAsync(identityUser, "Default@123");

                if (result.Succeeded)
                {
                    _context.Users.Add(user);
                    await _context.SaveChangesAsync();

                    var roleName = _context.UserRoles
                        .FirstOrDefault(r => r.UserRoleId == user.UserRoleId)?.Role;

                    if (!string.IsNullOrEmpty(roleName))
                        await _userManager.AddToRoleAsync(identityUser, roleName);

                    return RedirectToAction(nameof(Index));
                }

                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
            }

            ViewBag.RoleList = new SelectList(_context.UserRoles.ToList(), "UserRoleId", "Role", user.UserRoleId);
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();

            ViewBag.RoleList = new SelectList(_context.UserRoles.ToList(), "UserRoleId", "Role", user.UserRoleId);
            return View(user);
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, User user)
        {
            if (id != user.UserId) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    // Get original user email before update
                    var originalUser = await _context.Users.AsNoTracking()
                        .FirstOrDefaultAsync(u => u.UserId == id);

                    if (originalUser == null) return NotFound();

                    // Update custom user
                    _context.Update(user);
                    await _context.SaveChangesAsync();

                    // Update Identity user
                    var identityUser = await _userManager.FindByEmailAsync(originalUser.Email);
                    if (identityUser != null)
                    {
                        // If email changed, update username and email
                        if (originalUser.Email != user.Email)
                        {
                            identityUser.UserName = user.Email;
                            identityUser.Email = user.Email;
                        }

                        var updateResult = await _userManager.UpdateAsync(identityUser);
                        if (!updateResult.Succeeded)
                        {
                            throw new Exception(string.Join(", ", updateResult.Errors.Select(e => e.Description)));
                        }

                        // Update role
                        var newRole = _context.UserRoles
                            .FirstOrDefault(r => r.UserRoleId == user.UserRoleId)?.Role;

                        if (!string.IsNullOrEmpty(newRole))
                        {
                            var currentRoles = await _userManager.GetRolesAsync(identityUser);
                            await _userManager.RemoveFromRolesAsync(identityUser, currentRoles);
                            await _userManager.AddToRoleAsync(identityUser, newRole);
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Error updating user: " + ex.Message);
                }
            }

            ViewBag.RoleList = new SelectList(_context.UserRoles.ToList(), "UserRoleId", "Role", user.UserRoleId);
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var user = await _context.Users
                .Include(u => u.UserRole)
                .FirstOrDefaultAsync(m => m.UserId == id);

            return user == null ? NotFound() : View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return RedirectToAction(nameof(Index));

            try
            {
                // Delete from Identity first
                var identityUser = await _userManager.FindByEmailAsync(user.Email);
                if (identityUser != null)
                {
                    var result = await _userManager.DeleteAsync(identityUser);
                    if (!result.Succeeded)
                    {
                        throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));
                    }
                }

                // Then delete from custom table
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error deleting user: " + ex.Message);
                return View("Delete", user);
            }
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}