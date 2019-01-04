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
    public class MessengerModel : PageModel
    {
        public string Message { get; private set; }

        private readonly SkyDriveContext _context;

        public MessengerModel(SkyDriveContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Message = "TODO: Page needs implementing";
        }

        public async Task OnPostAsync()
        {
        }
    }
}


