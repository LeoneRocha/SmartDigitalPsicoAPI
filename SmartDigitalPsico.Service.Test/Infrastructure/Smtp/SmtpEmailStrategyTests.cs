using SmartDigitalPsico.Service;
namespace SmartDigitalPsico.Service.Test.Infrastructure.Smtp;
    using User = global::SmartDigitalPsico.Domain.EntityModels.User;
                                
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
        var strategy = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp.SmtpEmailStrategy(new SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP.SmtpSettingsDto
        {
            SenderEmail = "sender@test.com",
            SenderName = "Sender",
            Server = "127.0.0.1",
            Port = 1,
            Username = "user",
            Password = "pass",
            EnableSsl = true
        });
        var message = new global::SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP.EmailMessageDto
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
