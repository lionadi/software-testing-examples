using UnitTests.Examples.Logic.OutputStyle;

namespace UnitTests.Examples;

public class OutputStyleTests
{
    [Fact]
    public void PriceShouldHaveNoDiscount()
    {
        // Arrange
        var tickets = new List<Ticket>()
        {
            new Ticket()
            {
                Price = 10,
                SeatNumber = 1
            },
            new Ticket()
            {
                Price = 10,
                SeatNumber = 2
            },
            new Ticket()
            {
                Price = 10,
                SeatNumber = 3
            },
        };
        var sut = new PriceManager();
        
        // Act
        var result = sut.CalculateTotalPrice(tickets);
        
        // Assert
        Assert.Equal(result, tickets.Sum( o=> o.Price));
    }
}