using Books.Business.DTOS;
using Books.Business.Interfaces;
using Books.Data.Interfaces;
using Books.Domain.Entities;

namespace Books.Business.Services;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;   
    }

    public List<BookDTO> GetBooks()
    {
        var books = _bookRepository.GetBooks().OrderBy(book => book.Price).ToList();
        return ConvertToBookDTOList(books);
    }

    public List<BookDTO> SearchByAuthor(string author)
    {
        var books = _bookRepository.GetBooks();

        var bookSearched =  books.Where(book =>
            book.Specifications.Author.ToLower()
                .Contains(author.ToLower()))
            .ToList();
       
        return ConvertToBookDTOList(bookSearched);
    }
    public List<BookDTO> OrderByPrice(double price)
    {
        var books = _bookRepository.GetBooks();

        var bookSearched = books.Where(book => book.Price <= price).OrderBy(b => b.Price).ToList();

        return ConvertToBookDTOList(bookSearched); 
    }
    
    public List<BookDTO> SearchByTitle(string title)
    {
        var books = _bookRepository.GetBooks();
        
        var bookSearched =  books.Where(book =>
                book.Name.ToLower()
                    .Contains(title.ToLower()))
            .ToList();
       
        return ConvertToBookDTOList(bookSearched);
    }

    private List<BookDTO> ConvertToBookDTOList(List<Book> books)
    {
        var booksDTO = new List<BookDTO>();

        foreach (var book in books)
            booksDTO.Add(ConvertToBookDTO(book));

        return booksDTO;
    }

    private BookDTO ConvertToBookDTO(Book book)
        => new BookDTO
        {
            Id = book.Id,
            Fee = book.Fee,
            Price = book.Price,
            Name = book.Name,
            Specifications = new SpecificationsDTO
            {
                Author = book.Specifications.Author,
                Genres = book.Specifications.Genres,
                Published = book.Specifications.Published,
                PageCount = book.Specifications.PageCount,
                Illustrator = book.Specifications.Illustrator
            }
        };
}