using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SkyDrive.Models;
using Microsoft.EntityFrameworkCore;



namespace SkyDrive.Pages.Account
{
    public class CreateModel : PageModel
    {
        private readonly SkyDrive.Models.SkyDriveContext _context;

        public CreateModel(SkyDrive.Models.SkyDriveContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Account Account { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Account.Add(Account);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Login");
        }
    }
}