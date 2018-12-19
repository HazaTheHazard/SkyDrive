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
    public class NotesModel : PageModel
    {
        public string Message { get; private set; }

        public List<Note> Notes { get; private set; }

        public Note ActiveNote { get; set; }

        private readonly SkyDrive.Models.SkyDriveContext _context;

        public NotesModel(SkyDrive.Models.SkyDriveContext context)
        {
            _context = context;
        }

        public async Task OnPostAsync(int id)
        {
            var UserNotes = await FetchNotesByUserID();
            Notes = UserNotes;
            ActiveNote = Notes[id - 1];
        }

        public async Task OnGetAsync(int? id)
        {     
            var  UserNotes = await FetchNotesByUserID();
            Message = UserNotes.Count > 0 ? "Welcome to your notes." : "No Notes found :(";
            Notes = UserNotes;
        }

        private async Task<List<Note>> FetchNotesByUserID()
        {
            var UserId = User.Claims.FirstOrDefault(c => c.Type == "UserID")?.Value;
            var NoteList = await _context.Note.Where(u => u.UserID == UserId).Select(n => n).ToListAsync();

            if (NoteList.GetType() == typeof(List<Note>))
            {
                return NoteList;
            }
            return null;
        }
    }
}


