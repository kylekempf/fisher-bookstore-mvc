using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World (Authors for Index)");
        }
        public IActionResult Featured()
        {
            return Content("Hello World (Authors/featured)");
        }
    }
}