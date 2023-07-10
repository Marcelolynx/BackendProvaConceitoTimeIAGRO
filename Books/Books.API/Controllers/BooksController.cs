using Books.Business.Interfaces;
using Microsoft.AspNetCore.Mvc; 

namespace Books.API.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;

    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    [Route("")]
    public IActionResult GetBooks()
    {
        var books = _bookService.GetBooks();
        return Ok(books);
    }
    
    [HttpGet]
    [Route("search-by-author")]
    public IActionResult SerachByAuthor([FromQuery] string author)
    {
        var books = _bookService.SearchByAuthor(author);

        if (books.Any() is false)
            return NotFound(new
            {
                Message = "Nao foi encontrado nenhum livro com o autor:  " + author
            });
        
        return Ok(books);
    }
} 