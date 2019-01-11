using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SkyDrive.Models;

namespace SkyDrive.Pages.Files
{
    public class HomeModel : PageModel
    {
        private readonly SkyDrive.Models.SkyDriveContext _context;

        private IHostingEnvironment _environment;

        public HomeModel(IHostingEnvironment environment, SkyDriveContext context)
        {
            _context = context;
            _environment = environment;
        }

        public IList<FileMapping> FileMapping { get;set; }

        public async Task OnGetAsync()
        {
            var userId = User.Identity.GetUserId();
            FileMapping = await _context.FileMapping.Where(u => u.UserId == userId).ToListAsync();
        }

        private async Task<ActionResult> OnDownloadFile(int? id)
        {
            if (id == null)
            {
                return null;
            }
            var userId = User.Identity.GetUserId();
            var downloadFile = await _context.FileMapping.Where(u => u.UserId == userId && u.ID == id).Select(n => n).FirstOrDefaultAsync();
            byte[] fileBytes = System.IO.File.ReadAllBytes(Path.Combine(_environment.ContentRootPath, "uploads", downloadFile.File));
            string fileName = downloadFile.File;
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

    }
}
