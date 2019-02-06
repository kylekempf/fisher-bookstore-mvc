using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            //return Content("Hello World (Authors for Index)");
            return View();
        }
        public IActionResult Featured()
        {
            
            var featuredAuthor = new Author ()
            {
                AuthorId = 1,
                Name = "J.K. Rowling"
            };
            //return Content("Hello World (Authors/featured)");
            return View(featuredAuthor);
        }
    }
}