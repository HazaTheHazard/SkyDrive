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
    public class EditNoteModel : PageModel
    {
        public System.Collections.Specialized.NameValueCollection QueryString { get; }

        public string Message { get; private set; }

        private readonly SkyDriveContext _context;
        public Note ActiveNote { get; set; }

        public EditNoteModel(SkyDriveContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int id)
        {
        await FetchNotesByUserID(id);
        }

        public async Task OnPostAsync(string title, string note, int id)
        {
            await SaveNoteByUserID(title, note, id);
        }

        private async Task SaveNoteByUserID(string title, string note, int id)
        {
            var updatedNote = _context.Note.Find(id);
            updatedNote.Title = title;
            updatedNote.Body = note;

            await _context.SaveChangesAsync();
        }

        private async Task FetchNotesByUserID(int? id)
        {
            var userId = User.Identity.GetUserId();
            ActiveNote = await _context.Note.Where(u => u.UserId == userId && u.ID == id).Select(n => n).FirstOrDefaultAsync();
        }
    }
}

