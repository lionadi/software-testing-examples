using UnitTests.Examples.Logic;

namespace UnitTests.Examples;

public class Customer
{
    public bool Book(TicketStore store, Location location, int seats)
    {
        store.RemoveSeats(location, seats);
        // Some other logic
        return true;
    }
}