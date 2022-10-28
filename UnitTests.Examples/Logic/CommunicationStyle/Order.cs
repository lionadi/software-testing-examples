namespace UnitTests.Examples.Logic.CommunicationStyle;

public class Order
{
    private readonly IEmailGateway _emailGateway;
    public Order(IEmailGateway emailGateway)
    {
        _emailGateway = emailGateway;
    }
    
    // Some logic to hold the order data...
    
    
    public void FinalizeOrder()
    {
        // Some logic to finalize the order and determine the verification email address...

        var userEmail = "john.doe@email.com"; // Hard coded for example
        
        _emailGateway.SendVerificationEmail(userEmail);
    }
}