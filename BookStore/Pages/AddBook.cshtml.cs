using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Infrastructure;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore.Pages
{
    public class AddBookModel : PageModel
    {
        private IBookStoreRepository repo { get; set; }

        public AddBookModel (IBookStoreRepository temp)
        {
            repo = temp;
        }

        public Cart cart { get; set; }

        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            cart.AddItem(b, 1);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
