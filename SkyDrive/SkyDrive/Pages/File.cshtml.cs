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

namespace SkyDrive.Pages.Private
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

        //public async Task OnGetAsync(int? id)
        //{
         //   if (id != null)
        //    {
           //     OnPostDownloadFile();
           // }
         //   await getFilesByUserID();
       // }

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
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserID")?.Value;
            Files = await _context.FileMapping.Where(u => u.UserID == userId).Select(n => n).ToListAsync();
            Message = "Download a file";
        }

        private async Task<ActionResult> OnPostDownloadFile(int? id)
        {
            if (id == null)
            {
                return null;
            }
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserID")?.Value;
            var downloadFile = await _context.FileMapping.Where(u => u.UserID == userId && u.ID == id).Select(n => n).FirstOrDefaultAsync();
            byte[] fileBytes = System.IO.File.ReadAllBytes(Path.Combine(_environment.ContentRootPath, "uploads", downloadFile.File));
            string fileName = downloadFile.File;
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        private async Task SaveFileByUserID()
        {

            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserID")?.Value;
            var file = Path.Combine(_environment.ContentRootPath, "uploads", Upload.FileName);

            var uploadFile = new FileMapping
            {
                UserID = User.Claims.FirstOrDefault(c => c.Type == "UserID")?.Value,
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


