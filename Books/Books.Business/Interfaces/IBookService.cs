using Books.Business.DTOS;

namespace Books.Business.Interfaces;

public interface IBookService
{ 
    List<BookDTO> GetBooks();
    List<BookDTO> SearchByAuthor(string author);
    List<BookDTO> SearchByTitle(string title);

    List<BookDTO> OrderByPrice(double price);
}