using Books.Domain.Entities;
using Xunit;
namespace Books.Tests.Tests.BooksDomain.BookTests;

public class CalculateFeeTests
{
    [Fact]
    public void CalculateFee_ReturnsCorrectValue()
    {
        // Arrange
        double price = 100;
        double expectedFee = 20;
        var target = new Book(price);

        // Act
        double actualFee = target.CalculateFee();

        // Assert
        Assert.Equal(expectedFee, actualFee);
    }
}
