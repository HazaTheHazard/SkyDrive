using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SkyDrive.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNet.Identity;

namespace SkyDrive.Pages.Files
{
    public class FileModel : PageModel
    {
        public string Message { get; private set; }
        private IHostingEnvironment _environment;

        public FileModel(IHostingEnvironment environment, SkyDriveContext context)
        {
            _context = context;
            _environment = environment;
        }
        public List<FileMapping> Files { get; private set; }

        [BindProperty]
        public IFormFile Upload { get; set; }

        private readonly SkyDriveContext _context;

        public async Task<ActionResult> OnGetAsync(int? id)
        {
            await getFilesByUserID();
            return await OnPostDownloadFile(id);
        }

        public async Task OnPostAsync()
        {
            await SaveFileByUserID();
            await getFilesByUserID();
        }

        private async Task getFilesByUserID()
        {
            var userId = User.Identity.GetUserId();
            Files = await _context.FileMapping.Where(u => u.UserId == userId).Select(n => n).ToListAsync();
            Message = "Download a file";
        }

        private async Task<ActionResult> OnPostDownloadFile(int? id)
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

        private async Task SaveFileByUserID()
        {

            var userId = User.Identity.GetUserId();
            var file = Path.Combine(_environment.ContentRootPath, "uploads", Upload.FileName);

            var uploadFile = new FileMapping
            {
                UserId = userId,
                File = Upload.FileName,
            };
            _context.FileMapping.Add(uploadFile);

            await _context.SaveChangesAsync();
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await Upload.CopyToAsync(fileStream);
            }
        }
    }
}


