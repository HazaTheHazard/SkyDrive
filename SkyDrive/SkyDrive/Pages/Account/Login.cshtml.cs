using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SkyDrive.Data;
using SkyDrive.Models;

using Microsoft.AspNetCore.Authentication.Cookies;
using System.Collections.Generic;


using System;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace SkyDrive.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SkyDrive.Models.SkyDriveContext _context;

        public LoginModel(SkyDrive.Models.SkyDriveContext context)
        {
            _context = context;
        }

        public string ReturnUrl { get; private set; }

        public string ErrorMessage { get; set; }

        [BindProperty]
        public Models.Account Account { get; set; }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;

            if (ModelState.IsValid)
            {
                var user = await LoginByUsernamePasswordMethodAsync(Account.Email, Account.Password);

                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Email),
                    new Claim(ClaimTypes.NameIdentifier, user.UserId),
                    new Claim("FullName", user.FullName),
                };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme, 
                    new ClaimsPrincipal(claimsIdentity));

                return LocalRedirect(Url.GetLocalUrl(returnUrl));
            }

            return Page();
        }

        private async Task<Models.Account> LoginByUsernamePasswordMethodAsync(string email, string password)
        {
            var userProfile = await _context.Account
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Email == email && m.Password == password);

            if (userProfile == null)
            {
                return null;
            }
            else
            {

                return new Models.Account()
                {
                    Email = userProfile.Email,
                    FullName = userProfile.FullName,
                    UserId = userProfile.UserId
                 };
            }
        }
    }
}
