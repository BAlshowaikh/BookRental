<<<<<<< HEAD
﻿#nullable disable

using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;
using BookRentalObject;
using Microsoft.AspNetCore.Authentication;
=======
﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using BookRentalObject;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
=======
using Microsoft.Extensions.Logging;
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624

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
<<<<<<< HEAD

=======
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624
        public RegisterModel(
            UserManager<IdentityUser> userManager,
            IUserStore<IdentityUser> userStore,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
<<<<<<< HEAD
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

=======
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _context = new BookRentalDBContext();
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

<<<<<<< HEAD
=======
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

<<<<<<< HEAD
            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Confirm Password")]
=======
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

<<<<<<< HEAD
=======

>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624
        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
<<<<<<< HEAD
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
=======
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                var user = CreateUser();

                await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    if (!await _userManager.IsInRoleAsync(user, "User"))
                    {
                        await _userManager.AddToRoleAsync(user, "User");
                    }

                    var newUser = new User
                    {
                        Email = Input.Email,
                        FirstName = Input.Email.Split('@')[0],
                        UserRoleId = 3,  
                        IsActive = true
                    };

                    _context.Users.Add(newUser);
                    await _context.SaveChangesAsync();

                    var userId = await _userManager.GetUserIdAsync(user);
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }

                // Add identity errors to model state
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // Something failed, redisplay form
            return Page();
        }


        private IdentityUser CreateUser()
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624
        {
            try
            {
                return Activator.CreateInstance<IdentityUser>();
            }
            catch
            {
<<<<<<< HEAD
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
=======
                throw new InvalidOperationException($"Can't create an instance of '{nameof(IdentityUser)}'. " +
                    $"Ensure that '{nameof(IdentityUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<IdentityUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<IdentityUser>)_userStore;
        }
    }
}
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624
