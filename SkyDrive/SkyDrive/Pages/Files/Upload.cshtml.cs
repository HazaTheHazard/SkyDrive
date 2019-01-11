using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SkyDrive.Models;

namespace SkyDrive.Pages.Files
{
    public class UploadModel : PageModel
    {
        private readonly SkyDrive.Models.SkyDriveContext _context;
        private IHostingEnvironment _environment;

        public UploadModel(IHostingEnvironment environment, SkyDriveContext context)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public IFormFile FileMapping { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            await SaveFileByUserID();
            return RedirectToPage("./Home");
        }
        private async Task SaveFileByUserID()
        {
            //ViewData["UserId"] = new SelectList(_context.Account, "UserId", "UserId");
            var userId = User.Identity.GetUserId();
            var file = Path.Combine(_environment.ContentRootPath, "uploads", FileMapping.FileName);

            var uploadFile = new FileMapping
            {
                UserId = userId,
                File = FileMapping.FileName,
            };
            _context.FileMapping.Add(uploadFile);
            await _context.SaveChangesAsync();

            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await FileMapping.CopyToAsync(fileStream);
            }
        }

    }
}