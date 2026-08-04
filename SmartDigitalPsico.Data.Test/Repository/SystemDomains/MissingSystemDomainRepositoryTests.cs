using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.Repository.SystemDomains;

[TestFixture]
public class MissingSystemDomainRepositoryTests : BaseTests
{
    // Cenário: uma sessão é criada e depois renovada para o mesmo usuário.
    // Objetivo: manter uma única sessão com os tokens atualizados.
    [Test]
    public async Task SaveSessionAsync_NewAndExistingSession_PersistsLatestValues()
    {
        // Arrange
        var repository = new UserTokenSessionRepository(_mockContext!);
        var session = new UserTokenSession
        {
            UserId = 42,
            AccessToken = "first",
            RefreshToken = "refresh",
            ExpiresAt = DateTime.UtcNow.AddHours(1),
            RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(1)
        };

        // Act
        await repository.SaveSessionAsync(session);
        session.AccessToken = "renewed";
        await repository.SaveSessionAsync(session);
        var result = await repository.GetSessionAsync(42);

        // Assert
        result.Should().NotBeNull();
        result!.AccessToken.Should().Be("renewed");
        _mockContext!.UserTokenSessions.Should().ContainSingle();
    }

    // Cenário: não há template na linguagem solicitada.
    // Objetivo: retornar o template pt-BR habilitado como fallback.
    [Test]
    public async Task GetNotificationTemplateAsync_RequestedLanguageMissing_ReturnsPortugueseFallback()
    {
        // Arrange
        _mockContext!.NotificationTemplates.Add(new NotificationTemplate
        {
            TemplateKey = "appointment",
            Language = "pt-BR",
            Enable = true
        });
        await _mockContext.SaveChangesAsync();
        var repository = new NotificationTemplateRepository(_mockContext);

        // Act
        var result = await repository.GetNotificationTemplateAsync("appointment", "en-US");

        // Assert
        result.Should().NotBeNull();
        result!.Language.Should().Be("pt-BR");
    }

    // Cenário: não há pt-BR, apenas outra linguagem.
    // Objetivo: cobrir o fallback final FirstOrDefaultAsync().
    [Test]
    public async Task GetNotificationTemplateAsync_NoPortuguese_ReturnsAnyEnabledTemplate()
    {
        // Arrange
        _mockContext!.NotificationTemplates.Add(new NotificationTemplate
        {
            TemplateKey = "appointment",
            Language = "en-US",
            Enable = true
        });
        await _mockContext.SaveChangesAsync();
        var repository = new NotificationTemplateRepository(_mockContext);

        // Act
        var result = await repository.GetNotificationTemplateAsync("appointment", "fr-FR");

        // Assert
        result!.Language.Should().Be("en-US");
    }

    // Cenário: regras habilitadas e desabilitadas para o mesmo médico.
    // Objetivo: filtrar por tipo, estado e médico.
    [Test]
    public async Task GetNotificationRulesAsync_MatchingCriteria_ReturnsOnlyMatchingRules()
    {
        // Arrange
        _mockContext!.NotificationRules.AddRange(
            new NotificationRule { MedicalId = 7, IsEnabled = true, NotificationType = ENotificationType.BeforeAppointment },
            new NotificationRule { MedicalId = 7, IsEnabled = false, NotificationType = ENotificationType.BeforeAppointment });
        await _mockContext.SaveChangesAsync();
        var repository = new NotificationRulesRepository(_mockContext);

        // Act
        var result = await repository.GetNotificationRulesAsync(ENotificationType.BeforeAppointment, true, 7);

        // Assert
        result.Should().ContainSingle();
        result[0].IsEnabled.Should().BeTrue();
    }

    // Cenário: existem notificações de dois agendamentos.
    // Objetivo: remover todas as notificações de um token específico.
    [Test]
    public async Task DeleteAllByTokenAsync_MatchingToken_RemovesOnlyMatchingRecords()
    {
        // Arrange
        var tokenToDelete = Guid.NewGuid();
        _mockContext!.NotificationRecords.AddRange(
            new NotificationRecord { TokenId = tokenToDelete, EventDate = DateTime.UtcNow },
            new NotificationRecord { TokenId = Guid.NewGuid(), EventDate = DateTime.UtcNow });
        await _mockContext.SaveChangesAsync();
        var repository = new NotificationRecordsRepository(_mockContext);

        // Act
        var result = await repository.DeleteAllByTokenAsync(tokenToDelete);

        // Assert
        result.Should().BeTrue();
        _mockContext.NotificationRecords.Should().ContainSingle();
    }

    // Cenário: consultas, atualização e exclusões de NotificationRecords por token/evento.
    // Objetivo: cobrir GetPending, Update, DeleteByTokenAndEvent e DeleteAllByToken.
    [Test]
    public async Task NotificationRecords_QueriesUpdatesAndDeletesMatchingRecords()
    {
        // Arrange
        var token = Guid.NewGuid();
        var today = DateTime.UtcNow.Date;
        var pending = new NotificationRecord
        {
            TokenId = token,
            EventDate = today.AddDays(2),
            NextScheduledSendTime = today.AddHours(2),
            NotificationRules = []
        };
        var sameTokenOtherEvent = new NotificationRecord { TokenId = token, EventDate = today.AddDays(3), NextScheduledSendTime = today.AddHours(3) };
        var other = new NotificationRecord { TokenId = Guid.NewGuid(), EventDate = today.AddDays(3), NextScheduledSendTime = today.AddHours(3) };
        _mockContext!.NotificationRecords.AddRange(pending, sameTokenOtherEvent, other);
        await _mockContext.SaveChangesAsync();
        var repository = new NotificationRecordsRepository(_mockContext);

        // Act
        (await repository.GetPendingNotificationsAsync()).Should().Contain(pending);
        pending.IsCompleted = true;
        (await repository.Update(pending)).IsCompleted.Should().BeTrue();
        (await repository.DeleteByTokenAndEventAsync(token, sameTokenOtherEvent.EventDate)).Should().BeTrue();
        (await repository.DeleteAllByTokenAsync([other.TokenId])).Should().BeTrue();

        // Assert
        _mockContext.NotificationRecords.Should().ContainSingle();
    }

    // Cenário: repositórios sem comportamento específico adicional.
    // Objetivo: validar a composição com o contexto de dados.
    [Test]
    public void Constructors_ContextProvided_CreateRepositories()
    {
        // Arrange
        var repositories = new object[]
        {
            new LeavesRepository(_mockContext!),
            new AuditDataSelectiveEntityLogRepository(_mockContext!)
        };

        // Act
        var result = repositories;

        // Assert
        result.Should().OnlyContain(repository => repository != null);
    }
}
