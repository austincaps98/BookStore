using System;
using System.Linq;

namespace BookStore.Models
{
    public class EFBookStoreRepository : IBookStoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookStoreRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
