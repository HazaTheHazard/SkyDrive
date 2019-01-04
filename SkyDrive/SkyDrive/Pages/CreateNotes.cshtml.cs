using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SkyDrive.Models;


namespace SkyDrive.Pages.Private
{
    public class CreateNotesModel : PageModel
    {
        public string Message { get; private set; }

        private readonly SkyDriveContext _context;

        public CreateNotesModel(SkyDriveContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int? id)
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
                UserID = User.Claims.FirstOrDefault(c => c.Type == "UserID")?.Value,
                Title = title,
                Body = note
            };


            _context.Note.Add(createdNote);

            await _context.SaveChangesAsync();
            Response.Redirect("/Notes");
        }
    }
}


