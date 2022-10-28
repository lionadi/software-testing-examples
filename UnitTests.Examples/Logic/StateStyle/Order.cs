namespace UnitTests.Examples.Logic.StateStyle;

public class Order
{
    private readonly List<Ticket> _tickets = new List<Ticket>();
    public IReadOnlyList<Ticket> Tickets
    {
        get { return _tickets.ToList(); }
    }

    public void AddProduct(Ticket product)
    {
        _tickets.Add(product);
    }
}