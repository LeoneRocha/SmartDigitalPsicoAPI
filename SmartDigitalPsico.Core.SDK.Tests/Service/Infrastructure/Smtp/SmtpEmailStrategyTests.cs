using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp;
namespace SmartDigitalPsico.Core.SDK.Tests.Infrastructure.Smtp;

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
        var smtpSettingsMock = new Moq.Mock<ISmtpSettingsDto>();
        smtpSettingsMock.Setup(s => s.SenderEmail).Returns("sender@test.com");
        smtpSettingsMock.Setup(s => s.SenderName).Returns("Sender");
        smtpSettingsMock.Setup(s => s.Server).Returns("127.0.0.1");
        smtpSettingsMock.Setup(s => s.Port).Returns(1);
        smtpSettingsMock.Setup(s => s.Username).Returns("user");
        smtpSettingsMock.Setup(s => s.Password).Returns("pass");
        smtpSettingsMock.Setup(s => s.EnableSsl).Returns(true);
        var strategy = new SmtpEmailStrategy(smtpSettingsMock.Object);
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

