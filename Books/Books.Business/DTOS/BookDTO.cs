using Books.Domain.Entities;

namespace Books.Business.DTOS;

public class BookDTO
{
    public int Id { get;  set; }
    
    public string Name { get;   set; }
    
    public double Price { get; set; }
    
    public double Fee { get; set; }
    
    public SpecificationsDTO Specifications { get; set; }
}