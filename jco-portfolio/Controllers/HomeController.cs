using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blog()
        {
            ViewData["Message"] = "Blog posts made by James";

            return View();
        }

        public IActionResult GoToProjects()
        {
            ViewData["Message"] = "Projects made by James";

            return View();
        }

        public IActionResult GoToAdmin()
        {
            ViewData["Message"] = "Admin Login";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}