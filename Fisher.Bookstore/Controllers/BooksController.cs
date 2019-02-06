using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    [Route("books")]
    public class BooksController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            //return Content("Hello World (Books for Index)");
            return View();
        }
        [Route("new")]
        public IActionResult New()
        {
            //return Content("Hello World (Books/New)");
            return View();
        }
        [Route("best-sellers")]
        public IActionResult BestSellers()
        {
            //return Content("Hello World (Books/Best)");
            return View();
        }
    }
}