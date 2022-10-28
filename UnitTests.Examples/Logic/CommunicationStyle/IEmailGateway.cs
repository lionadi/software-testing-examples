namespace UnitTests.Examples.Logic.CommunicationStyle;

public interface IEmailGateway
{
    void SendVerificationEmail(string userEmail);
}