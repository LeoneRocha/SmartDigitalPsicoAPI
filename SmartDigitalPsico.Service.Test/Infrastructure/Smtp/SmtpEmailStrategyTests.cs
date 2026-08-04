using SmartDigitalPsico.Domain.DTO.SMTP;
using SmartDigitalPsico.Service.Infrastructure.Smtp;

namespace SmartDigitalPsico.Service.Test.Infrastructure.Smtp;

[TestFixture]
public class SmtpEmailStrategyTests
{
    // Cenário: envio de e-mail com servidor SMTP indisponível.
    // Objetivo: montar MailMessage e tentar envio (cobre construção do cliente SMTP).
    [Test]
    public void SendEmailAsync_InvalidServer_ThrowsAfterBuildingMessage()
    {
        // Arrange

        // Act
        var strategy = new SmtpEmailStrategy(new SmtpSettingsDto
        {
            SenderEmail = "sender@test.com",
            SenderName = "Sender",
            Server = "127.0.0.1",
            Port = 1,
            Username = "user",
            Password = "pass",
            EnableSsl = true
        });
        var message = new EmailMessageDto
        {
            Subject = "Test",
            Message = "<p>Hello</p>",
            ToEmails = ["recipient@test.com", "other@test.com"]
        };

        var action = () => strategy.SendEmailAsync(message).GetAwaiter().GetResult();

        // Assert
        action.Should().Throw<Exception>();
    }
}
