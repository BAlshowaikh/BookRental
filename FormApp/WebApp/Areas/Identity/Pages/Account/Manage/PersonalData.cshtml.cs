// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BookRentalObject;
using System.Net;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Areas.Identity.Pages.Account.Manage
{
    public class PersonalDataModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<PersonalDataModel> _logger;
        private readonly BookRentalDBContext _context;

        public PersonalDataModel(
            UserManager<IdentityUser> userManager,
            ILogger<PersonalDataModel> logger)
        {
            _userManager = userManager;
            _logger = logger;
            _context = new BookRentalDBContext();
        }

        [BindProperty]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [BindProperty]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [BindProperty]
        [Display(Name = "Contact Number")]
        public string contactNo { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");

            var customUser = _context.Users.FirstOrDefault(x => x.Email == user.Email);
            if (customUser != null)
            {
                firstName = customUser.FirstName;
                lastName = customUser.LastName;
                contactNo = customUser.ContactNo;
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");

            var customUser = _context.Users.FirstOrDefault(x => x.Email == user.Email);
            if (customUser != null)
            {
                customUser.FirstName = firstName;
                customUser.LastName = lastName;
                customUser.ContactNo = contactNo;

                _context.Users.Update(customUser);
                await _context.SaveChangesAsync();

                TempData["StatusMessage"] = "Your profile has been updated successfully.";
            }

            return RedirectToPage(); // reload page after update
        }
    }
}