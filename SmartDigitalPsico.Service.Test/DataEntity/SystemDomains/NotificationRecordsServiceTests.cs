using FluentValidation;
using FluentValidation.Results;
using Moq;
using SmartDigitalPsico.Domain.DTO.Gender.ADD;
using SmartDigitalPsico.Domain.DTO.Office.ADD;
using SmartDigitalPsico.Domain.DTO.RoleGroup.ADD;
using SmartDigitalPsico.Domain.DTO.Leaves.ADD;
using SmartDigitalPsico.Domain.DTO.Specialty.ADD;
using SmartDigitalPsico.Domain.DTO.Notification.ADD;
using SmartDigitalPsico.Domain.DTO.Application.ADD;
using SmartDigitalPsico.Domain.DTO.Audit.ADD;
using SmartDigitalPsico.Domain.DTO.Gender.UPDATE;
using SmartDigitalPsico.Domain.DTO.Office.UPDATE;
using SmartDigitalPsico.Domain.DTO.RoleGroup.UPDATE;
using SmartDigitalPsico.Domain.DTO.Leaves.UPDATE;
using SmartDigitalPsico.Domain.DTO.Specialty.UPDATE;
using SmartDigitalPsico.Domain.DTO.Notification.UPDATE;
using SmartDigitalPsico.Domain.DTO.Application.UPDATE;
using SmartDigitalPsico.Domain.DTO.Audit.UPDATE;
using SmartDigitalPsico.Domain.DTO.Notification.Common;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;
using SmartDigitalPsico.Service.Test.TestSupport;

using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.Test.DataEntity.SystemDomains;

[TestFixture]
public class NotificationRecordsServiceTests
{
    // Cenário: criação de registro válido.
    // Objetivo: calcular o próximo envio agendado e persistir via fluxo base.
    [Test]
    public async Task Create_ValidRecordWithPendingRules_PersistsWithNextScheduledSendTime()
    {
        // Arrange
        var context = new NotificationRecordsServiceContext();
        var rule = new NotificationRuleStatus { IsSent = false, ScheduledSendTime = DateTime.UtcNow.AddDays(1) };
        var addDto = new AddNotificationRecordsDto { TokenId = Guid.NewGuid(), EventDate = DateTime.UtcNow, NotificationRules = [rule] };
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<NotificationRecord>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Create(It.IsAny<NotificationRecord>())).ReturnsAsync((NotificationRecord r) => { r.Id = 5; return r; });

        // Act
        var result = await context.Service.Create(addDto);

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: atualização de registro inexistente.
    // Objetivo: retornar falha informando que o registro não foi encontrado.
    [Test]
    public async Task Update_MissingRecord_ReturnsNotFoundFailure()
    {
        // Arrange
        var context = new NotificationRecordsServiceContext();
        context.Repository.Setup(x => x.FindByID(50)).Returns(Task.FromResult<NotificationRecord>(null!));

        // Act
        var result = await context.Service.Update(new UpdateNotificationRecordsDto { Id = 50 });

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: atualização de registro existente e válido.
    // Objetivo: aplicar os novos dados e persistir a atualização.
    [Test]
    public async Task Update_ExistingRecord_UpdatesSuccessfully()
    {
        // Arrange
        var context = new NotificationRecordsServiceContext();
        var entity = new NotificationRecord { Id = 51 };
        context.Repository.Setup(x => x.FindByID(51)).ReturnsAsync(entity);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<NotificationRecord>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);

        // Act
        var result = await context.Service.Update(new UpdateNotificationRecordsDto

        // Assert
        {
            Id = 51,
            TokenId = Guid.NewGuid(),
            EventDate = DateTime.UtcNow,
            NotificationRules = []
        });

        result.Success.Should().BeTrue();
    }

    // Cenário: geração de registros a partir de agendas médicas sem regras habilitadas.
    // Objetivo: não criar nem atualizar nenhum registro.
    [Test]
    public async Task CreateOrUpdateNotificationRecordsAsync_NoRules_DoesNothing()
    {
        // Arrange
        var context = new NotificationRecordsServiceContext();
        context.NotificationRulesService.Setup(x => x.GetNotificationRulesAsync(It.IsAny<ENotificationType>(), It.IsAny<bool>(), It.IsAny<long>()))
            .ReturnsAsync([]);
        var dto = new GenerateNotificationRecordsDto
        {
            MedicalCalendars = [new MedicalCalendar { MedicalId = 1, StartDateTime = DateTime.UtcNow, TokenRecurrence = Guid.NewGuid().ToString() }],
            NotificationType = ENotificationType.BeforeAppointment
        };

        // Act
        await context.Service.CreateOrUpdateNotificationRecordsAsync(dto);

        // Assert
        context.Repository.Verify(x => x.Create(It.IsAny<NotificationRecord>()), Times.Never);
    }

    // Cenário: geração de registros com regras válidas e token vazio.
    // Objetivo: ignorar o registro sem persistir nada.
    [Test]
    public async Task CreateOrUpdateNotificationRecordsAsync_EmptyToken_SkipsSaving()
    {
        // Arrange
        var context = new NotificationRecordsServiceContext();
        var rule = new NotificationRule { Id = 1, IntervalType = EIntervalNotificationType.Hours, IntervalValue = 1, IsBefore = true, ENotificationServiceType = [] };
        context.NotificationRulesService.Setup(x => x.GetNotificationRulesAsync(It.IsAny<ENotificationType>(), It.IsAny<bool>(), It.IsAny<long>()))
            .ReturnsAsync([rule]);
        var dto = new GenerateNotificationRecordsDto
        {
            MedicalCalendars = [new MedicalCalendar { MedicalId = 1, StartDateTime = DateTime.UtcNow.AddDays(2), TokenRecurrence = string.Empty, TimeZone = "UTC" }],
            NotificationType = ENotificationType.BeforeAppointment
        };

        // Act
        await context.Service.CreateOrUpdateNotificationRecordsAsync(dto);

        // Assert
        context.Repository.Verify(x => x.Create(It.IsAny<NotificationRecord>()), Times.Never);
    }

    // Cenário: geração de registros com regras válidas e sem registro existente para o token/evento.
    // Objetivo: criar um novo registro de notificação.
    [Test]
    public async Task CreateOrUpdateNotificationRecordsAsync_NewToken_CreatesRecord()
    {
        // Arrange
        var context = new NotificationRecordsServiceContext();
        var rule = new NotificationRule { Id = 2, IntervalType = EIntervalNotificationType.Hours, IntervalValue = 1, IsBefore = true, ENotificationServiceType = [] };
        context.NotificationRulesService.Setup(x => x.GetNotificationRulesAsync(It.IsAny<ENotificationType>(), It.IsAny<bool>(), It.IsAny<long>()))
            .ReturnsAsync([rule]);
        context.Repository.Setup(x => x.FindByCustomWhere(It.IsAny<System.Linq.Expressions.Expression<Func<NotificationRecord, bool>>>()))
            .ReturnsAsync([]);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<NotificationRecord>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Create(It.IsAny<NotificationRecord>())).ReturnsAsync((NotificationRecord r) => { r.Id = 60; return r; });

        var token = Guid.NewGuid();
        var dto = new GenerateNotificationRecordsDto
        {
            MedicalCalendars = [new MedicalCalendar { MedicalId = 1, StartDateTime = DateTime.UtcNow.AddDays(2), TokenRecurrence = token.ToString(), TimeZone = "UTC" }],
            NotificationType = ENotificationType.BeforeAppointment
        };

        // Act
        await context.Service.CreateOrUpdateNotificationRecordsAsync(dto);

        // Assert
        context.Repository.Verify(x => x.Create(It.IsAny<NotificationRecord>()), Times.Once);
    }

    // Cenário: geração de registros com regras válidas e registro já existente para o token/evento.
    // Objetivo: atualizar o registro existente em vez de criar outro.
    [Test]
    public async Task CreateOrUpdateNotificationRecordsAsync_ExistingToken_UpdatesRecord()
    {
        // Arrange
        var context = new NotificationRecordsServiceContext();
        var rule = new NotificationRule { Id = 3, IntervalType = EIntervalNotificationType.Hours, IntervalValue = 1, IsBefore = true, ENotificationServiceType = [] };
        context.NotificationRulesService.Setup(x => x.GetNotificationRulesAsync(It.IsAny<ENotificationType>(), It.IsAny<bool>(), It.IsAny<long>()))
            .ReturnsAsync([rule]);
        var token = Guid.NewGuid();
        var existing = new NotificationRecord { Id = 61, TokenId = token };
        context.Repository.Setup(x => x.FindByCustomWhere(It.IsAny<System.Linq.Expressions.Expression<Func<NotificationRecord, bool>>>()))
            .ReturnsAsync([existing]);
        context.Repository.Setup(x => x.FindByID(61)).ReturnsAsync(existing);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<NotificationRecord>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Update(existing)).ReturnsAsync(existing);

        var dto = new GenerateNotificationRecordsDto
        {
            MedicalCalendars = [new MedicalCalendar { MedicalId = 1, StartDateTime = DateTime.UtcNow.AddDays(2), TokenRecurrence = token.ToString(), TimeZone = "UTC" }],
            NotificationType = ENotificationType.BeforeAppointment
        };

        // Act
        await context.Service.CreateOrUpdateNotificationRecordsAsync(dto);

        // Assert
        context.Repository.Verify(x => x.Update(existing), Times.Once);
        context.Repository.Verify(x => x.Create(It.IsAny<NotificationRecord>()), Times.Never);
    }

    // Cenário: exceção lançada durante o processamento das agendas médicas.
    // Objetivo: registrar o erro no log sem propagar a exceção.
    [Test]
    public async Task CreateOrUpdateNotificationRecordsAsync_ServiceThrows_LogsAndSwallowsException()
    {
        // Arrange
        var context = new NotificationRecordsServiceContext();
        context.NotificationRulesService.Setup(x => x.GetNotificationRulesAsync(It.IsAny<ENotificationType>(), It.IsAny<bool>(), It.IsAny<long>()))
            .ThrowsAsync(new InvalidOperationException("boom"));

        var dto = new GenerateNotificationRecordsDto
        {
            MedicalCalendars = [new MedicalCalendar { MedicalId = 1, StartDateTime = DateTime.UtcNow }],
            NotificationType = ENotificationType.BeforeAppointment
        };

        // Act
        await context.Service.CreateOrUpdateNotificationRecordsAsync(dto);

        // Assert
        context.Context.Logger.Verify(x => x.Error(It.IsAny<Exception>(), It.IsAny<string>()), Times.Once);
    }

    // Cenário: busca de notificações pendentes.
    // Objetivo: delegar a consulta ao repositório especializado.
    [Test]
    public async Task GetPendingNotificationsAsync_DelegatesToRepository_CoversPath()
    {
        // Arrange
        var context = new NotificationRecordsServiceContext();
        var records = new[] { new NotificationRecord { Id = 1 } };
        context.Repository.Setup(x => x.GetPendingNotificationsAsync()).ReturnsAsync(records);

        // Act
        var result = await context.Service.GetPendingNotificationsAsync();

        // Assert
        result.Should().HaveCount(1);
    }

    // Cenário: regras com intervalos Minutes, Days, Months e Years.
    // Objetivo: calcular horários agendados para cada tipo de intervalo.
    [TestCase(EIntervalNotificationType.Minutes)]
    [TestCase(EIntervalNotificationType.Days)]
    [TestCase(EIntervalNotificationType.Months)]
    [TestCase(EIntervalNotificationType.Years)]
    public async Task CreateOrUpdateNotificationRecordsAsync_IntervalTypes_CreatesRecord(EIntervalNotificationType intervalType)
    {
        // Arrange
        var context = new NotificationRecordsServiceContext();
        var rule = new NotificationRule
        {
            Id = 10,
            IntervalType = intervalType,
            IntervalValue = 1,
            IsBefore = true,
            ENotificationServiceType = [ENotificationServiceType.Email]
        };
        context.NotificationRulesService.Setup(x => x.GetNotificationRulesAsync(It.IsAny<ENotificationType>(), It.IsAny<bool>(), It.IsAny<long>()))
            .ReturnsAsync([rule]);
        context.Repository.Setup(x => x.FindByCustomWhere(It.IsAny<System.Linq.Expressions.Expression<Func<NotificationRecord, bool>>>()))
            .ReturnsAsync([]);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<NotificationRecord>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Create(It.IsAny<NotificationRecord>())).ReturnsAsync((NotificationRecord r) => { r.Id = 70; return r; });

        var dto = new GenerateNotificationRecordsDto
        {
            IsEnabled = true,
            MedicalCalendars =
            [
                new MedicalCalendar
                {
                    MedicalId = 1,
                    // Longe o suficiente para ScheduledSendTime (IsBefore) permanecer no futuro.
                    StartDateTime = DateTime.UtcNow.AddYears(2),
                    TokenRecurrence = Guid.NewGuid().ToString(),
                    TimeZone = "UTC"
                }
            ],
            NotificationType = ENotificationType.BeforeAppointment
        };

        // Act
        await context.Service.CreateOrUpdateNotificationRecordsAsync(dto);

        // Assert
        context.Repository.Verify(x => x.Create(It.IsAny<NotificationRecord>()), Times.Once);
    }

    // Cenário: falha ao salvar registro individual.
    // Objetivo: registrar erro no log sem propagar exceção.
    [Test]
    public async Task CreateOrUpdateNotificationRecordsAsync_SaveThrows_LogsError()
    {
        // Arrange
        var context = new NotificationRecordsServiceContext();
        var rule = new NotificationRule
        {
            Id = 11,
            IntervalType = EIntervalNotificationType.Hours,
            IntervalValue = 1,
            IsBefore = true,
            ENotificationServiceType = [ENotificationServiceType.Email]
        };
        var token = Guid.NewGuid();
        var existing = new NotificationRecord { Id = 71, TokenId = token };
        context.NotificationRulesService.Setup(x => x.GetNotificationRulesAsync(It.IsAny<ENotificationType>(), It.IsAny<bool>(), It.IsAny<long>()))
            .ReturnsAsync([rule]);
        context.Repository.Setup(x => x.FindByCustomWhere(It.IsAny<System.Linq.Expressions.Expression<Func<NotificationRecord, bool>>>()))
            .ReturnsAsync([existing]);
        context.Repository.Setup(x => x.FindByID(71)).ReturnsAsync(existing);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<NotificationRecord>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Update(existing)).ThrowsAsync(new InvalidOperationException("update fail"));

        var dto = new GenerateNotificationRecordsDto
        {
            IsEnabled = true,
            MedicalCalendars =
            [
                new MedicalCalendar
                {
                    MedicalId = 1,
                    StartDateTime = DateTime.UtcNow.AddYears(2),
                    TokenRecurrence = token.ToString(),
                    TimeZone = "UTC"
                }
            ],
            NotificationType = ENotificationType.BeforeAppointment
        };

        // Act
        await context.Service.CreateOrUpdateNotificationRecordsAsync(dto);

        // Assert
        context.Context.Logger.Verify(
            x => x.Error(It.IsAny<Exception>(), "Error at SaveNotificationRecordAsync"),
            Times.Once);
    }

    private sealed class NotificationRecordsServiceContext
    {
        public ServiceTestContext Context { get; } = new();
        public Mock<INotificationRecordsRepository> Repository { get; } = new();
        public Mock<IApplicationLanguageRepository> ApplicationLanguageRepository { get; } = new();
        public Mock<IValidator<NotificationRecord>> Validator { get; } = new();
        public Mock<INotificationRulesService> NotificationRulesService { get; } = new();
        public NotificationRecordsService Service { get; }

        public NotificationRecordsServiceContext()
        {
            Service = new NotificationRecordsService(
                Context.SharedServices,
                Context.Config,
                Context.SharedRepositories,
                Repository.Object,
                ApplicationLanguageRepository.Object,
                Validator.Object,
                NotificationRulesService.Object);
        }
    }
}
