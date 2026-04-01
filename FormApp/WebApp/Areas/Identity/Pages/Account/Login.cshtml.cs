<<<<<<< HEAD
﻿#nullable disable

using System.ComponentModel.DataAnnotations;
using BookRentalObject;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
=======
﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BookRentalObject;
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624

namespace WebApp.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly BookRentalDBContext _context;

<<<<<<< HEAD
        public LoginModel(
            SignInManager<IdentityUser> signInManager,
            ILogger<LoginModel> logger,
            BookRentalDBContext context)
        {
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
=======
        public LoginModel(SignInManager<IdentityUser> signInManager, ILogger<LoginModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
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
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string ErrorMessage { get; set; }

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
            public string Email { get; set; }

<<<<<<< HEAD
=======
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

<<<<<<< HEAD
=======
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624
            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

<<<<<<< HEAD
        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");
            ReturnUrl = returnUrl;

            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ReturnUrl = returnUrl;
=======
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (!ModelState.IsValid)
<<<<<<< HEAD
            {
                return Page();
            }

            var email = Input.Email.Trim();

            var businessUser = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Email == email);

            if (businessUser == null)
=======
                return Page();

            var user = _context.Users.FirstOrDefault(x => x.Email == Input.Email);
            if (user == null)
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return Page();
            }

<<<<<<< HEAD
            if (!businessUser.IsActive)
=======
            if (!user.IsActive)
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624
            {
                ModelState.AddModelError(string.Empty, "Your account is inactive.");
                return Page();
            }

<<<<<<< HEAD
            var result = await _signInManager.PasswordSignInAsync(
                email,
                Input.Password,
                Input.RememberMe,
                lockoutOnFailure: false);
=======
            var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624

            if (result.Succeeded)
            {
                _logger.LogInformation("User logged in.");
                return LocalRedirect(Url.IsLocalUrl(returnUrl) ? returnUrl : "~/");
            }
<<<<<<< HEAD

=======
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624
            if (result.RequiresTwoFactor)
            {
                return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, Input.RememberMe });
            }
<<<<<<< HEAD

=======
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624
            if (result.IsLockedOut)
            {
                _logger.LogWarning("User account locked out.");
                return RedirectToPage("./Lockout");
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return Page();
        }
<<<<<<< HEAD
    }
}
=======

    }
}
>>>>>>> 95e447b4cdcdb53e96b6bfe072c0c520faa19624
