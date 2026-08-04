using FluentValidation;
using FluentValidation.Results;
using Moq;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;
using SmartDigitalPsico.Service.Test.TestSupport;

namespace SmartDigitalPsico.Service.Test.DataEntity.SystemDomains;

[TestFixture]
public class NotificationTemplateServiceTests
{
    // Cenário: template encontrado pela chave e cultura.
    // Objetivo: retornar DTO mapeado com sucesso.
    [Test]
    public async Task GetNotificationTemplatesAsync_TemplateFound_ReturnsMappedDto()
    {
        // Arrange
        var context = new TemplateServiceContext();
        context.Repository.Setup(x => x.GetNotificationTemplateAsync("welcome", It.IsAny<string>()))
            .ReturnsAsync(new NotificationTemplate { Id = 1, Subject = "Welcome", Body = "<p>Hi</p>", TemplateKey = "welcome" });

        // Act
        var result = await context.Service.GetNotificationTemplatesAsync("welcome");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.Subject.Should().Be("Welcome");
        }
    }

    // Cenário: template não encontrado.
    // Objetivo: retornar falha informando ausência.
    [Test]
    public async Task GetNotificationTemplatesAsync_TemplateMissing_ReturnsFailure()
    {
        // Arrange
        var context = new TemplateServiceContext();
        context.Repository.Setup(x => x.GetNotificationTemplateAsync("missing", It.IsAny<string>()))
            .Returns(Task.FromResult<NotificationTemplate?>(null));

        // Act
        var result = await context.Service.GetNotificationTemplatesAsync("missing");

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: criação com body HTML.
    // Objetivo: sanitizar body antes de delegar ao fluxo base.
    [Test]
    public async Task Create_ValidDto_SanitizesBodyAndPersists()
    {
        // Arrange
        var context = new TemplateServiceContext();
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<NotificationTemplate>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Create(It.IsAny<NotificationTemplate>()))
            .ReturnsAsync((NotificationTemplate e) => { e.Id = 5; return e; });

        // Act
        var result = await context.Service.Create(new AddNotificationTemplateDto
        {
            Subject = "Sub",
            Body = "<script>alert(1)</script><p>Safe</p>",
            TemplateKey = "key",
            Language = "en-US"
        });

        // Assert
        result.Success.Should().BeTrue();

        context.Repository.Verify(x => x.Create(It.Is<NotificationTemplate>(t => !t.Body.Contains("<script>", StringComparison.OrdinalIgnoreCase))), Times.Once);
    }

    // Cenário: atualização com body HTML.
    // Objetivo: sanitizar body antes de delegar ao fluxo base.
    [Test]
    public async Task Update_ValidDto_SanitizesBodyAndUpdates()
    {
        // Arrange
        var context = new TemplateServiceContext();
        var entity = new NotificationTemplate { Id = 10, Subject = "Old", Body = "old", TemplateKey = "k", Language = "en-US", Enable = true };
        context.Repository.Setup(x => x.FindByID(10)).ReturnsAsync(entity);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<NotificationTemplate>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);

        // Act
        var result = await context.Service.Update(new UpdateNotificationTemplateDto
        {
            Id = 10,
            Subject = "New",
            Body = "<img onerror=\"x\" src=\"y\">Text",
            TemplateKey = "k",
            Language = "en-US",
            Enable = true
        });

        // Assert
        result.Success.Should().BeTrue();

        context.Repository.Verify(x => x.Update(It.Is<NotificationTemplate>(t => !t.Body.Contains("onerror", StringComparison.OrdinalIgnoreCase))), Times.Once);
    }

    private sealed class TemplateServiceContext
    {
        public ServiceTestContext Context { get; } = new();
        public Mock<INotificationTemplateRepository> Repository { get; } = new();
        public Mock<IValidator<NotificationTemplate>> Validator { get; } = new();
        public NotificationTemplateService Service { get; }

        public TemplateServiceContext()
        {
            Service = new NotificationTemplateService(
                Context.SharedServices,
                Context.Config,
                Context.SharedRepositories,
                Repository.Object,
                Context.ApplicationLanguageRepository.Object,
                Validator.Object);
        }
    }
}
