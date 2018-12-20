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

        public string DeleteNotifcation { get; private set; }

        public List<Note> Notes { get; private set; }

        public Note ActiveNote { get; set; }

        private readonly SkyDriveContext _context;

        public NotesModel(SkyDriveContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int? id)
        {
            await FetchNotesByUserID(id);
        }

        public async Task OnPostAsync(int id, int? delete)
        {
            if (delete != null) await DeleteActiveNote(delete);
            await FetchNotesByUserID(id);
        }

        private async Task FetchNotesByUserID(int? id)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserID")?.Value;
            // TODO: Refactor to return titles
            Notes = await _context.Note.Where(u => u.UserID == userId).Select(n => n).ToListAsync();
            Message = Notes.Count > 0 ? "Welcome to your notes." : "No Notes found :(";
            //
            if (id != null)
            {
                ActiveNote = await _context.Note.Where(u => u.UserID == userId && u.ID == id).Select(n => n).FirstOrDefaultAsync();
            }
        }

        // Change to have a modal for delete rather than H3
        private async Task DeleteActiveNote(int? id)
        {
            var note = await _context.Note
                             .AsNoTracking()
                             .FirstOrDefaultAsync(m => m.ID == id);
            if (note == null)
            {
                DeleteNotifcation = "Error Deleting Note :(";
            }

            try
            {
                _context.Note.Remove(note);
                await _context.SaveChangesAsync();
                DeleteNotifcation = "Sucessfully Deleted Note :)";
            }
            catch (DbUpdateException /* ex */)
            {
                throw new System.ArgumentException("Something went wrong", "original");
            }
        }
    }
}


