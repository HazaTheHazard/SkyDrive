using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SkyDrive.Models;

namespace SkyDrive.Pages.Files
{
    public class DeleteModel : PageModel
    {
        private readonly SkyDrive.Models.SkyDriveContext _context;

        public DeleteModel(SkyDrive.Models.SkyDriveContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FileMapping FileMapping { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FileMapping = await _context.FileMapping
                .Include(f => f.Auth).FirstOrDefaultAsync(m => m.ID == id);

            if (FileMapping == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FileMapping = await _context.FileMapping.FindAsync(id);

            if (FileMapping != null)
            {
                _context.FileMapping.Remove(FileMapping);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Home");
        }
    }
}
