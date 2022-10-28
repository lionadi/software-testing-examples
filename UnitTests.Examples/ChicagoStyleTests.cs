using System.Data.Common;
using UnitTests.Examples.Logic.ChicagoStyle;

namespace UnitTests.Examples;

// Class-container for a cohesive set of tests
public class ChicagoStyleTests
{
    [Fact]
    public void TicketBookingSucceedsWhenTicketsAvailable()
    {
        // Arrange
        var store = new TicketStore();
        store.AddSeats(Location.Balcony, 10);
        var customer = new Customer();
        
        // Act
        bool success = customer.Book(store, Location.Balcony, 5);
        
        // Assert
        Assert.True(success);
        Assert.Equal(5, store.GetSeats(Location.Balcony));
    }
}