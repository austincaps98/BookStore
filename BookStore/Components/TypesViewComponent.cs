using System;
using System.Linq;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private IBookStoreRepository repo { get; set; }

        public TypesViewComponent (IBookStoreRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(types);
        }
    }
}
