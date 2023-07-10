using System.Collections;
using Books.Domain.Entities;
using Xunit;
namespace Books.Tests.Tests.BooksDomain.BookTests;

public class CalculateFeeTests
{
    [Fact]
    public void CalculateFee_ShouldCalculateCorrectly()
    {
        // Arrange
        int id = 1;
        string name = "Example Book";
        double price = 100.0;

        string published = "test";
        string author = "author name";
        int pageCount = 0;
        List<string> illustrator = new List<string>();
        List<string> genres = new List<string>();
        
        var specifications = new Specifications(published,  author,  pageCount,   illustrator,   genres); 
        var book = new Book(id, name, price, specifications);
        double expectedFee = (price * 20) / 100;

        // Act
        double actualFee = book.CalculateFee();

        // Assert
        Assert.Equal(expectedFee, actualFee);
    }
}
