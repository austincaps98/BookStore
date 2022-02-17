using System;
using System.Linq;

namespace BookStore.Models
{
    public interface IBookStoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
