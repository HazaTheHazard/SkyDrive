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

        public String ActiveNote { get; set; }

        private readonly SkyDrive.Models.SkyDriveContext _context;

        public NotesModel(SkyDrive.Models.SkyDriveContext context)
        {
            Message = "Welcome to your notes.";
            _context = context;
        }

        public async Task OnPostAsync(int id)
        {
            var UserNotes = await FetchNotesByUserID();
            Notes = UserNotes;
            ActiveNote = Notes[id - 1].Body;
        }

        public async Task OnGetAsync(int? id)
        {     
            var  UserNotes = await FetchNotesByUserID();
            Notes = UserNotes;
        }

        private async Task<List<Note>> FetchNotesByUserID()
        {
            var UserId = User.Claims.FirstOrDefault(c => c.Type == "UserID")?.Value;
            var NoteList = await _context.Note.AsNoTracking().ToListAsync();

            if (NoteList.GetType() == typeof(List<Note>))
            {
                return NoteList;
            }
            return null;
        }
    }
}


