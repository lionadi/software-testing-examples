using Moq;
using UnitTests.Examples.Logic.CommunicationStyle;

namespace UnitTests.Examples;

public class CommunicationStyleTests
{
    [Fact]
    public void ShouldSendEmailVerification()
    {
        // Arrange
        var emailGatewayMock = new Mock<IEmailGateway>();
        var sut = new Order(emailGatewayMock.Object);
        
        // Act
        sut.FinalizeOrder();

        // Assert
        emailGatewayMock.Verify( o => o.SendVerificationEmail("john.doe@email.com"), Times.Once);
    }
}