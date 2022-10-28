using System.Data.Common;
using Moq;
using UnitTests.Examples.Logic.LondonStyle;

namespace UnitTests.Examples;

// Class-container for a cohesive set of tests
public class LondonStyleTests
{
    [Fact]
    public void TicketBookingSucceedsWhenTicketsAvailable()
    {
        // Arrange
        var storeMock = new Mock<ITicketStore>();
        storeMock.Setup(x => x.HasEnoughInventory(Location.Balcony, 10)).Returns(true);
        var customer = new Customer();
        
        // Act
        bool success = customer.Book(storeMock.Object, Location.Balcony, 5);
        
        // Assert
        Assert.True(success);
        storeMock.Verify(x => x.RemoveSeats(Location.Balcony, 5), Times.Once);
    }
}