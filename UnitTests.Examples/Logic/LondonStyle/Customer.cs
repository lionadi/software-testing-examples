namespace UnitTests.Examples.Logic.LondonStyle;

public class Customer
{
    public bool Book(ITicketStore store, Location location, int seats)
    {
        store.RemoveSeats(location, seats);
        // Some other logic
        return true;
    }
}