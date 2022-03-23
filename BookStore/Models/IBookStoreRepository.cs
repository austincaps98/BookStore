using System;
using System.Linq;

namespace BookStore.Models
{
    public interface IBookStoreRepository
    {
        IQueryable<Book> Books { get; }

        public void SaveBook(Book b);

        public void CreateBook(Book b);

        public void DeleteBook(Book b);
    }

}
