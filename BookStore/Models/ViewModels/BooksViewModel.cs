using System;
using System.Linq;

namespace BookStore.Models.ViewModels
{
    public class BooksViewModel
    {
       public IQueryable<Book> Books { get; set; }
       public PageInfo PageInfo { get; set; }
    }
}
