using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            //return Content("Hello World (About/Index)");
            return View();
        }
        public IActionResult History()
        {
            //return Content("Hello World (About/History)");
            return View();
        }
        public IActionResult Location()
        {
            //return Content("Hello World (About/Location)");
            return View();
        }
    }
}