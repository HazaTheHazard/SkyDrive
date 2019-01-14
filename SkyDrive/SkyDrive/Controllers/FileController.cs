using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Hosting;
using SkyDrive.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace SkyDrive.Controllers
{
    [Route("[controller]/[action]")]
    public class FileController : Controller
    {

        private IHostingEnvironment _environment;

        public FileController(IHostingEnvironment environment, SkyDriveContext context)
        {
            _context = context;
            _environment = environment;
        }

        private readonly SkyDriveContext _context;

        [HttpPost]
        public async Task<ActionResult> DownloadFile(string button, int id)
        {
            var userId = User.Identity.GetUserId();
            var downloadFile = await _context.FileMapping.Where(u => u.UserId == userId && u.ID == id).Select(n => n).FirstOrDefaultAsync();
            byte[] fileBytes = System.IO.File.ReadAllBytes(Path.Combine(_environment.ContentRootPath, "uploads", Path.GetFileName(downloadFile.File)));
            string fileName = downloadFile.File;
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        [HttpPost]
        public async Task<ActionResult> ShareFile(int id, string SharedEmail)
        {
            var userId = User.Identity.GetUserId();
            var fetchFile = await _context.FileMapping.Where(u => u.UserId == userId && u.ID == id).Select(n => n).FirstOrDefaultAsync();
            var findUser = await _context.Account.Where(e => e.Email == SharedEmail).Select(a => a).FirstOrDefaultAsync();

            var sendFile = new FileMapping
            {
                UserId = findUser.UserId,
                File = fetchFile.File,
            };


            _context.FileMapping.Add(sendFile);

            await _context.SaveChangesAsync();
            return Redirect("/Files/Home");
        }
    }
}
