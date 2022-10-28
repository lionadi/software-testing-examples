using UnitTests.Examples.Logic.StateStyle;

namespace UnitTests.Examples;

public class StateStyleTests
{
    [Fact]
    public void ShouldAddProductsToAnOrder()
    {
        // Arrange
        var ticket1 = new Ticket() { Price = 20, SeatNumber = 1};
        var ticket2 = new Ticket() { Price = 30, SeatNumber = 2};
        var sut = new Order();

        // Act
        sut.AddProduct(ticket1);
        sut.AddProduct(ticket2);
        
        Assert.Equal(2, sut.Tickets.Count);
        Assert.Equal(ticket1, sut.Tickets[0]);
        Assert.Equal(ticket2, sut.Tickets[1]);
    }
}