using Books.API.Entity;

namespace Books.API.DTO;

public class ReadBookDTO
{
    public int Id { get;  set; }
    
    public string Title { get;  set; }
    
    public double price { get;  set; }
    
    public Specifications Specifications { get;  set; }
}