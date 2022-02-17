using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private IBookStoreRepository repo;

        public HomeController (IBookStoreRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            var books = repo.Books.ToList();

            return View(books);
        }
    }
}
