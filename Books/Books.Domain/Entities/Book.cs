namespace Books.Domain.Entities;

public class Book
{
    public int Id { get; private set; }
    
    public string Name { get; private set; }
    
    public double Price { get; private set; }
    
    public double Fee { get; private set; }
    
    public Specifications Specifications { get; private set; }

    public Book(int id, string name, double price, Specifications specifications)
    {
        Id = id;
        Name = name;
        Price = price;
        Specifications = specifications;
        Fee = CalculateFee();
    }

    public Book(double price)
    {
        Price = price;
    }

    public double CalculateFee() => (Price * 20) / 100;

}