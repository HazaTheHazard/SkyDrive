using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SkyDrive.Models;
using Microsoft.AspNetCore.Authorization;

namespace SkyDrive.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Description page.";

            return View();
        }

        [Authorize]
        public IActionResult Files()
        {
            ViewData["Message"] = "Your Files page.";

            return View();
        }

        [Authorize]
        public IActionResult Notes()
        {
            ViewData["Message"] = "Your Note page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
