using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World (About/Index)");
        }
        public IActionResult History()
        {
            return Content("Hello World (About/History)");
        }
        public IActionResult Location()
        {
            return Content("Hello World (About/Location)");
        }
    }
}