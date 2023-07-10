using Books.Data.Interfaces;
using Books.Domain.Entities;
using Newtonsoft.Json;

namespace Books.Data.Services;
public class BookRepository : IBookRepository
{
    public List<Book> GetBooks()
    {
        var booksJson = File.ReadAllText("books.json");

        return JsonConvert.DeserializeObject<List<Book>>(booksJson);
    }
}