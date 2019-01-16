using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World (Books for Index)");
        }
        public IActionResult New()
        {
            return Content("Hello World (Books/New)");
        }
        public IActionResult BestSellers()
        {
            return Content("Hello World (Books/Best)");
        }
    }
}