﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Models.ViewModels;
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

        public IActionResult Index(string bookCategory, int pageNum = 1)
        {
            int pageSize = 20;

            var x = new BooksViewModel
            {
                Books = repo.Books
                .Where(b => b.Category == "Marriage")
                .OrderBy(b => b.Classification)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks =
                        (bookCategory == "Marriage"
                        ? repo.Books.Count()
                        : repo.Books.Where(x => x.Category == "Marriage").Count()),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(x);
        }
    }
}
