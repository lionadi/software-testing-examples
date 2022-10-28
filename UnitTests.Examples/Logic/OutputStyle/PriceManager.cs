namespace UnitTests.Examples.Logic.OutputStyle;

public class PriceManager
{
    public decimal CalculateTotalPrice(IList<Ticket> tickets)
    {
        decimal discount = 1m;

        if (tickets.Count > 5)
        {
            discount = 0.05m;
        } else 
        if (tickets.Count > 10)
        {
            discount = 0.10m;
        }

        return tickets.Sum(o => o.Price) * discount;
    }
}