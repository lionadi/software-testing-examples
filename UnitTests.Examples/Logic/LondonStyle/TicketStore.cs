namespace UnitTests.Examples.Logic.LondonStyle;

public class TicketStore
{
    private IList<SeatInventory> _seatsInventory = new List<SeatInventory>();
    public void AddSeats(Location location, int seats)
    {
        if (_seatsInventory.Any(o => o.Location == location))
        {
            _seatsInventory.Single(o => o.Location == location).Seats += seats;
        }
        else
        {
            _seatsInventory.Add(new SeatInventory() { Location = location, Seats = seats});    
        }
    }
    public int GetSeats(Location location)
    {
        return _seatsInventory.Single(o => o.Location == location).Seats;
    }

    public void RemoveSeats(Location location, int seats)
    {
        _seatsInventory.Single(o => o.Location == location).Seats -= seats;

    }
}