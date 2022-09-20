using UnitTests.Examples.Logic.LondonStyle;

namespace UnitTests.Examples.Logic.LondonStyle;

public interface ITicketStore
{
    int GetSeats(Location location);
    void AddSeats(Location location, int seats);
    void RemoveSeats(Location location, int seats);
    bool HasEnoughInventory(Location location, int sets);
}