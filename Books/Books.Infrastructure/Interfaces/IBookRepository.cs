using Books.Domain.Entities;

namespace Books.Data.Interfaces;

public interface IBookRepository
{
    List<Book> GetBooks();
}