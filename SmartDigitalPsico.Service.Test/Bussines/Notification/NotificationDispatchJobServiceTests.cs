using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using Serilog;
using SmartDigitalPsico.Domain.DTO.Gender.UPDATE;
using SmartDigitalPsico.Domain.DTO.Office.UPDATE;
using SmartDigitalPsico.Domain.DTO.RoleGroup.UPDATE;
using SmartDigitalPsico.Domain.DTO.Leaves.UPDATE;
using SmartDigitalPsico.Domain.DTO.Specialty.UPDATE;
using SmartDigitalPsico.Domain.DTO.Notification.UPDATE;
using SmartDigitalPsico.Domain.DTO.Application.UPDATE;
using SmartDigitalPsico.Domain.DTO.Audit.UPDATE;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Service.Bussines.Notification;

using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Service.Test.Bussines.Notification;

[TestFixture]
public class NotificationDispatchJobServiceTests
{
    // Cenário: não há registros pendentes de notificação.
    // Objetivo: concluir o processamento sem erros e sem atualizar nada.
    [Test]
    public async Task ProcessPendingNotificationsAsync_NoPendingRecords_CompletesWithoutUpdates()
    {
        // Arrange
        var context = new DispatchJobContext();
        context.NotificationRecordsService.Setup(x => x.GetPendingNotificationsAsync()).ReturnsAsync([]);

        // Act
        await context.Service.ProcessPendingNotificationsAsync();

        // Assert
        context.NotificationRecordsService.Verify(x => x.Update(It.IsAny<UpdateNotificationRecordsDto>()), Times.Never);
    }

    // Cenário: registros pendentes existem, mas nenhuma regra está vencida.
    // Objetivo: filtrar tudo e não processar nada.
    [Test]
    public async Task ProcessPendingNotificationsAsync_RulesNotDue_SkipsProcessing()
    {
        // Arrange
        var context = new DispatchJobContext();
        var futureRule = new NotificationRuleStatus { IsSent = false, ScheduledSendTime = DateTime.UtcNow.AddDays(5) };
        var record = new NotificationRecord { Id = 1, TokenId = Guid.NewGuid(), NotificationRules = [futureRule] };
        context.NotificationRecordsService.Setup(x => x.GetPendingNotificationsAsync()).ReturnsAsync([record]);

        // Act
        await context.Service.ProcessPendingNotificationsAsync();

        // Assert
        context.NotificationRecordsService.Verify(x => x.Update(It.IsAny<UpdateNotificationRecordsDto>()), Times.Never);
    }

    // Cenário: registro pendente com TokenId vazio.
    // Objetivo: ignorar o registro por não ter token válido.
    [Test]
    public async Task ProcessPendingNotificationsAsync_EmptyTokenId_SkipsRecord()
    {
        // Arrange
        var context = new DispatchJobContext();
        var dueRule = new NotificationRuleStatus { IsSent = false, ScheduledSendTime = DateTime.UtcNow.AddMinutes(-5) };
        var record = new NotificationRecord { Id = 2, TokenId = Guid.Empty, NotificationRules = [dueRule] };
        context.NotificationRecordsService.Setup(x => x.GetPendingNotificationsAsync()).ReturnsAsync([record]);

        // Act
        await context.Service.ProcessPendingNotificationsAsync();

        // Assert
        context.NotificationRecordsService.Verify(x => x.Update(It.IsAny<UpdateNotificationRecordsDto>()), Times.Never);
    }

    // Cenário: registro pendente cujo pacote de agenda não é encontrado.
    // Objetivo: ignorar o registro sem lançar exceção.
    [Test]
    public async Task ProcessPendingNotificationsAsync_MissingPackage_SkipsRecord()
    {
        // Arrange
        var context = new DispatchJobContext();
        var token = Guid.NewGuid();
        var dueRule = new NotificationRuleStatus { IsSent = false, ScheduledSendTime = DateTime.UtcNow.AddMinutes(-5) };
        var record = new NotificationRecord { Id = 3, TokenId = token, NotificationRules = [dueRule] };
        context.NotificationRecordsService.Setup(x => x.GetPendingNotificationsAsync()).ReturnsAsync([record]);
        context.ScheduleCalendarRepository.Setup(x => x.GetByUniqueTokenAsync(token.ToString())).Returns(Task.FromResult<ScheduleCalendar?>(null));

        // Act
        await context.Service.ProcessPendingNotificationsAsync();

        // Assert
        context.NotificationRecordsService.Verify(x => x.Update(It.IsAny<UpdateNotificationRecordsDto>()), Times.Never);
    }

    // Cenário: registro pendente com pacote encontrado e paciente vinculado.
    // Objetivo: notificar, marcar a regra como enviada e persistir a atualização.
    [Test]
    public async Task ProcessPendingNotificationsAsync_ValidPendingRecord_NotifiesAndUpdatesRecord()
    {
        // Arrange
        var context = new DispatchJobContext();
        var token = Guid.NewGuid();
        var dueRule = new NotificationRuleStatus { NotificationRuleId = 1, IsSent = false, ScheduledSendTime = DateTime.UtcNow.AddMinutes(-5) };
        var record = new NotificationRecord { Id = 4, TokenId = token, EventDate = DateTime.UtcNow, NotificationRules = [dueRule] };
        context.NotificationRecordsService.Setup(x => x.GetPendingNotificationsAsync()).ReturnsAsync([record]);

        var package = new ScheduleCalendar
        {
            Id = 77,
            OwnerKey = "medical:9",
            SubjectKey = "patient:5",
            UniqueToken = token.ToString(),
            ScheduleData =
            [
                new ScheduleCalendarItem { StartDateTime = DateTime.UtcNow, PackageId = 77 }
            ]
        };
        context.ScheduleCalendarRepository.Setup(x => x.GetByUniqueTokenAsync(token.ToString())).ReturnsAsync(package);
        context.PatientRepository.Setup(x => x.FindAsync(5, It.IsAny<System.Linq.Expressions.Expression<Func<Patient, object>>[]>()))
            .ReturnsAsync(new Patient { Id = 5, Medical = new Medical { Id = 9 } });
        context.MedicalCalenderNotificationService.Setup(x => x.NotifyAsync(It.IsAny<MedicalCalendar>(), EMedicalCalendarActionType.NotificationDispatch))
            .Returns(Task.CompletedTask);
        context.NotificationRecordsService.Setup(x => x.Update(It.IsAny<UpdateNotificationRecordsDto>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<SmartDigitalPsico.Domain.DTO.Notification.GET.GetNotificationRecordsDto>());

        int? lastProcessed = null;

        // Act
        context.Service.ProgressChanged += (_, args) => lastProcessed = args.Processed;

        await context.Service.ProcessPendingNotificationsAsync();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            dueRule.IsSent.Should().BeTrue();
            lastProcessed.Should().NotBeNull();
        }
        context.NotificationRecordsService.Verify(x => x.Update(It.IsAny<UpdateNotificationRecordsDto>()), Times.Once);
        context.MedicalCalenderNotificationService.Verify(x => x.NotifyAsync(It.IsAny<MedicalCalendar>(), EMedicalCalendarActionType.NotificationDispatch), Times.Once);
    }

    // Cenário: registro com regras nulas.
    // Objetivo: ignorar registro sem regras de notificação.
    [Test]
    public async Task ProcessPendingNotificationsAsync_NullRules_SkipsRecord()
    {
        // Arrange
        var context = new DispatchJobContext();
        var record = new NotificationRecord { Id = 5, TokenId = Guid.NewGuid(), NotificationRules = null! };
        context.NotificationRecordsService.Setup(x => x.GetPendingNotificationsAsync()).ReturnsAsync([record]);

        // Act
        await context.Service.ProcessPendingNotificationsAsync();

        // Assert
        context.NotificationRecordsService.Verify(x => x.Update(It.IsAny<UpdateNotificationRecordsDto>()), Times.Never);
    }

    // Cenário: registro com múltiplas regras parcialmente pendentes.
    // Objetivo: marcar enviadas e manter próximo agendamento para regras futuras.
    [Test]
    public async Task ProcessPendingNotificationsAsync_PartialRulesSent_KeepsNextScheduledTime()
    {
        // Arrange
        var context = new DispatchJobContext();
        var token = Guid.NewGuid();
        var dueRule = new NotificationRuleStatus { NotificationRuleId = 1, IsSent = false, ScheduledSendTime = DateTime.UtcNow.AddMinutes(-10) };
        var futureRule = new NotificationRuleStatus { NotificationRuleId = 2, IsSent = false, ScheduledSendTime = DateTime.UtcNow.AddDays(2) };
        var record = new NotificationRecord { Id = 6, TokenId = token, EventDate = DateTime.UtcNow, NotificationRules = [dueRule, futureRule] };
        context.NotificationRecordsService.Setup(x => x.GetPendingNotificationsAsync()).ReturnsAsync([record]);
        var package = new ScheduleCalendar
        {
            Id = 88,
            OwnerKey = "medical:2",
            SubjectKey = "patient:4",
            UniqueToken = token.ToString(),
            ScheduleData = [new ScheduleCalendarItem { StartDateTime = DateTime.UtcNow, PackageId = 88, SubjectKey = "patient:4", OwnerKey = "medical:2" }]
        };
        context.ScheduleCalendarRepository.Setup(x => x.GetByUniqueTokenAsync(token.ToString())).ReturnsAsync(package);
        context.PatientRepository.Setup(x => x.FindAsync(4, It.IsAny<System.Linq.Expressions.Expression<Func<Patient, object>>[]>()))
            .ReturnsAsync(new Patient { Id = 4, Medical = new Medical { Id = 2 } });
        context.MedicalCalenderNotificationService.Setup(x => x.NotifyAsync(It.IsAny<MedicalCalendar>(), It.IsAny<EMedicalCalendarActionType>()))
            .Returns(Task.CompletedTask);
        context.NotificationRecordsService.Setup(x => x.Update(It.IsAny<UpdateNotificationRecordsDto>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<SmartDigitalPsico.Domain.DTO.Notification.GET.GetNotificationRecordsDto>());

        // Act
        await context.Service.ProcessPendingNotificationsAsync();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            dueRule.IsSent.Should().BeTrue();
            futureRule.IsSent.Should().BeFalse();
            record.IsCompleted.Should().BeFalse();
            record.NextScheduledSendTime.Should().Be(futureRule.ScheduledSendTime);
        }
    }

    private sealed class DispatchJobContext
    {
        public Mock<INotificationRecordsService> NotificationRecordsService { get; } = new();
        public Mock<IMedicalCalenderNotificationService> MedicalCalenderNotificationService { get; } = new();
        public Mock<IScheduleCalendarRepository> ScheduleCalendarRepository { get; } = new();
        public Mock<IPatientRepositories> PatientRepositories { get; } = new();
        public Mock<IPatientRepository> PatientRepository { get; } = new();
        public Mock<IAppLogger> Logger { get; } = new();
        public NotificationDispatchJobService Service { get; }

        public DispatchJobContext()
        {
            PatientRepositories.SetupGet(x => x.PatientRepository).Returns(PatientRepository.Object);
            Service = new NotificationDispatchJobService(
                NotificationRecordsService.Object,
                MedicalCalenderNotificationService.Object,
                ScheduleCalendarRepository.Object,
                PatientRepositories.Object,
                Logger.Object);
        }
    }
}
