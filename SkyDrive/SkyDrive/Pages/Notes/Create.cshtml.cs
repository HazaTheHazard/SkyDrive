using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SkyDrive.Models;


namespace SkyDrive.Pages.Notes
{
    public class CreateModel : PageModel
    {
        public string Message { get; private set; }

        private readonly SkyDriveContext _context;

        public CreateModel(SkyDriveContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public async Task OnPostAsync(string title, string note)
        {
            await SaveNoteByUserID(title, note);
        }

        private async Task SaveNoteByUserID(string title, string note)
        {
            var createdNote = new Note
            {
                UserId = User.Identity.GetUserId(),
                Title = title,
                Body = note
            };


            _context.Note.Add(createdNote);

            await _context.SaveChangesAsync();
            Response.Redirect("/Notes/Notes");
        }
    }
}


