#nullable disable

using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;
using BookRentalObject;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly IUserEmailStore<IdentityUser> _emailStore;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly BookRentalDBContext _context;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            IUserStore<IdentityUser> userStore,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            BookRentalDBContext context)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore(userManager, userStore);
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [StringLength(100)]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required]
            [StringLength(100)]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Phone]
            [StringLength(50)]
            [Display(Name = "Contact Number")]
            public string ContactNo { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Confirm Password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var email = Input.Email.Trim();

            var roleMapping = GetRoleMappingFromEmail(email);
            if (roleMapping == null)
            {
                ModelState.AddModelError("Input.Email", "This email domain is not allowed for registration.");
                return Page();
            }

            var businessUserExists = await _context.Users
                .AsNoTracking()
                .AnyAsync(x => x.Email == email);

            if (businessUserExists)
            {
                ModelState.AddModelError("Input.Email", "A business user with this email already exists.");
                return Page();
            }

            var identityUserExists = await _userManager.FindByEmailAsync(email);
            if (identityUserExists != null)
            {
                ModelState.AddModelError("Input.Email", "An account with this email already exists.");
                return Page();
            }

            var identityUser = CreateUser();

            await _userStore.SetUserNameAsync(identityUser, email, CancellationToken.None);
            await _emailStore.SetEmailAsync(identityUser, email, CancellationToken.None);

            var createIdentityResult = await _userManager.CreateAsync(identityUser, Input.Password);

            if (!createIdentityResult.Succeeded)
            {
                foreach (var error in createIdentityResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                return Page();
            }

            try
            {
                var addRoleResult = await _userManager.AddToRoleAsync(identityUser, roleMapping.IdentityRole);
                if (!addRoleResult.Succeeded)
                {
                    foreach (var error in addRoleResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }

                    await _userManager.DeleteAsync(identityUser);
                    return Page();
                }

                var newBusinessUser = new User
                {
                    FirstName = Input.FirstName.Trim(),
                    LastName = Input.LastName.Trim(),
                    Email = email,
                    ContactNo = string.IsNullOrWhiteSpace(Input.ContactNo) ? null : Input.ContactNo.Trim(),
                    UserRoleId = roleMapping.BusinessUserRoleId,
                    IsActive = true,
                    //HasLibraryCard = false
                };

                _context.Users.Add(newBusinessUser);
                await _context.SaveChangesAsync();

                _logger.LogInformation("User created a new account with password.");

                var userId = await _userManager.GetUserIdAsync(identityUser);
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(identityUser);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                var callbackUrl = Url.Page(
                    "/Account/ConfirmEmail",
                    pageHandler: null,
                    values: new { area = "Identity", userId, code, returnUrl },
                    protocol: Request.Scheme);

                if (_emailSender != null)
                {
                    await _emailSender.SendEmailAsync(
                        email,
                        "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
                }

                if (_userManager.Options.SignIn.RequireConfirmedAccount)
                {
                    return RedirectToPage("RegisterConfirmation", new { email, returnUrl });
                }

                await _signInManager.SignInAsync(identityUser, isPersistent: false);
                return LocalRedirect(returnUrl);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating business user record for {Email}", email);

                await _userManager.DeleteAsync(identityUser);

                ModelState.AddModelError(string.Empty, "Registration failed. Please try again.");
                return Page();
            }
        }

        private static RoleMapping GetRoleMappingFromEmail(string email)
        {
            var atIndex = email.LastIndexOf('@');
            if (atIndex < 0 || atIndex == email.Length - 1)
            {
                return null;
            }

            var domain = email[(atIndex + 1)..].Trim().ToLowerInvariant();

            return domain switch
            {
                "admin.com" => new RoleMapping("Admin", 1),
                "manager.com" => new RoleMapping("Manager", 2),
                "customer.com" => new RoleMapping("User", 3),
                _ => null
            };
        }

        //sealed: No other class can inherit from it
        // Purpose: Since you need to return two pieces of information ( the String for Identity and the Integer for your Business Database),
        // you can't just return one value. This class "packages" them together.
        private sealed class RoleMapping
        {
            public string IdentityRole { get; }
            public int BusinessUserRoleId { get; }

            public RoleMapping(string identityRole, int businessUserRoleId)
            {
                IdentityRole = identityRole;
                BusinessUserRoleId = businessUserRoleId;
            }
        }

        private static IdentityUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<IdentityUser>();
            }
            catch
            {
                throw new InvalidOperationException(
                    $"Can't create an instance of '{nameof(IdentityUser)}'. " +
                    $"Ensure that '{nameof(IdentityUser)}' is not an abstract class and has a parameterless constructor.");
            }
        }

        private static IUserEmailStore<IdentityUser> GetEmailStore(
            UserManager<IdentityUser> userManager,
            IUserStore<IdentityUser> userStore)
        {
            if (!userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }

            return (IUserEmailStore<IdentityUser>)userStore;
        }
    }
}