using Moq;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Service.DataEntity.General;

namespace SmartDigitalPsico.Service.Test.DataEntity.General;

[TestFixture]
public class MedicalCalenderNotificationServiceTests
{
    // Cenário: ação Add com template disponível.
    // Objetivo: enviar e-mail com tokens substituídos.
    [Test]
    public async Task NotifyAsync_AddAction_SendsScheduledTemplate()
    {
        // Arrange
        var context = new NotificationContext();
        SetupTemplate(context, EmailTemplateTagConstants.AppointmentScheduledSuccess);
        var calendar = BuildCalendar();

        // Act
        await context.Service.NotifyAsync(calendar, EMedicalCalendarActionType.Add);

        // Assert
        context.SendNotification.Verify(x => x.SendNotificationAsync(
            It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.DataNotificationTemplateVO>(),
            ENotificationServiceType.Email,
            It.Is<Dictionary<string, string>>(d => d["MedicalName"] == "Dr. Test")), Times.Once);
    }

    // Cenário: ação Update com template de reagendamento.
    // Objetivo: usar template de reschedule.
    [Test]
    public async Task NotifyAsync_UpdateAction_UsesRescheduledTemplate()
    {
        // Arrange
        var context = new NotificationContext();
        SetupTemplate(context, EmailTemplateTagConstants.AppointmentRescheduled);
        var calendar = BuildCalendar();

        // Act
        await context.Service.NotifyAsync(calendar, EMedicalCalendarActionType.Update);

        // Assert
        context.Templates.Verify(x => x.GetNotificationTemplatesAsync(EmailTemplateTagConstants.AppointmentRescheduled), Times.Once);
    }

    // Cenário: ação Delete com template de cancelamento.
    // Objetivo: usar template de cancelamento.
    [Test]
    public async Task NotifyAsync_DeleteAction_UsesCancelledTemplate()
    {
        // Arrange
        var context = new NotificationContext();
        SetupTemplate(context, EmailTemplateTagConstants.AppointmentCancelled);
        var calendar = BuildCalendar();

        // Act
        await context.Service.NotifyAsync(calendar, EMedicalCalendarActionType.Delete);

        // Assert
        context.Templates.Verify(x => x.GetNotificationTemplatesAsync(EmailTemplateTagConstants.AppointmentCancelled), Times.Once);
    }

    // Cenário: ação NotificationDispatch.
    // Objetivo: usar template de dispatch.
    [Test]
    public async Task NotifyAsync_DispatchAction_UsesDispatchTemplate()
    {
        // Arrange
        var context = new NotificationContext();
        SetupTemplate(context, EmailTemplateTagConstants.NotificationDispatch);
        var calendar = BuildCalendar();

        // Act
        await context.Service.NotifyAsync(calendar, EMedicalCalendarActionType.NotificationDispatch);

        // Assert
        context.Templates.Verify(x => x.GetNotificationTemplatesAsync(EmailTemplateTagConstants.NotificationDispatch), Times.Once);
    }

    // Cenário: status Active mapeado para Scheduled.
    // Objetivo: selecionar template de agendamento pelo status.
    [Test]
    public async Task NotifyAsync_ActiveStatus_MapsToScheduledTemplate()
    {
        // Arrange
        var context = new NotificationContext();
        SetupTemplate(context, EmailTemplateTagConstants.AppointmentScheduledSuccess);
        var calendar = BuildCalendar(EStatusCalendar.Active);

        // Act
        await context.Service.NotifyAsync(calendar, EMedicalCalendarActionType.Add);

        // Assert
        context.Templates.Verify(x => x.GetNotificationTemplatesAsync(EmailTemplateTagConstants.AppointmentScheduledSuccess), Times.Once);
    }

    // Cenário: status Completed mapeado para Update.
    // Objetivo: selecionar template de atualização pelo status.
    [Test]
    public async Task NotifyAsync_CompletedStatus_MapsToUpdateTemplate()
    {
        // Arrange
        var context = new NotificationContext();
        SetupTemplate(context, EmailTemplateTagConstants.AppointmentRescheduled);
        var calendar = BuildCalendar(EStatusCalendar.Completed);

        // Act
        await context.Service.NotifyAsync(calendar, EMedicalCalendarActionType.Add);

        // Assert
        context.Templates.Verify(x => x.GetNotificationTemplatesAsync(EmailTemplateTagConstants.AppointmentRescheduled), Times.Once);
    }

    // Cenário: status Refused mapeado para Cancelled.
    // Objetivo: selecionar template de cancelamento pelo status.
    [Test]
    public async Task NotifyAsync_RefusedStatus_MapsToCancelledTemplate()
    {
        // Arrange
        var context = new NotificationContext();
        SetupTemplate(context, EmailTemplateTagConstants.AppointmentCancelled);
        var calendar = BuildCalendar(EStatusCalendar.Refused);

        // Act
        await context.Service.NotifyAsync(calendar, EMedicalCalendarActionType.Add);

        // Assert
        context.Templates.Verify(x => x.GetNotificationTemplatesAsync(EmailTemplateTagConstants.AppointmentCancelled), Times.Once);
    }

    // Cenário: status Canceled mapeado para Cancelled.
    // Objetivo: selecionar template de cancelamento pelo status.
    [Test]
    public async Task NotifyAsync_CanceledStatus_MapsToCancelledTemplate()
    {
        // Arrange
        var context = new NotificationContext();
        SetupTemplate(context, EmailTemplateTagConstants.AppointmentCancelled);
        var calendar = BuildCalendar(EStatusCalendar.Canceled);

        // Act
        await context.Service.NotifyAsync(calendar, EMedicalCalendarActionType.Add);

        // Assert
        context.Templates.Verify(x => x.GetNotificationTemplatesAsync(EmailTemplateTagConstants.AppointmentCancelled), Times.Once);
    }

    // Cenário: status NoShow mapeado para Update.
    // Objetivo: selecionar template de atualização pelo status.
    [Test]
    public async Task NotifyAsync_NoShowStatus_MapsToUpdateTemplate()
    {
        // Arrange
        var context = new NotificationContext();
        SetupTemplate(context, EmailTemplateTagConstants.AppointmentRescheduled);
        var calendar = BuildCalendar(EStatusCalendar.NoShow);

        // Act
        await context.Service.NotifyAsync(calendar, EMedicalCalendarActionType.Add);

        // Assert
        context.Templates.Verify(x => x.GetNotificationTemplatesAsync(EmailTemplateTagConstants.AppointmentRescheduled), Times.Once);
    }

    // Cenário: ação inválida com calendário nulo.
    // Objetivo: lançar ArgumentOutOfRangeException no switch default.
    [Test]
    public void NotifyAsync_InvalidActionWithNullCalendar_ThrowsArgumentOutOfRange()
    {
        // Arrange
        var context = new NotificationContext();
        // Status desconhecido preserva a action; action inválida cai no default do switch.
        var calendar = BuildCalendar();
        calendar.Status = (EStatusCalendar)12345;

        // Act
        var act = () => context.Service.NotifyAsync(calendar, (EMedicalCalendarActionType)999).GetAwaiter().GetResult();

        // Assert
        act.Should().Throw<ArgumentOutOfRangeException>();
    }

    // Cenário: calendário nulo com action de ciclo de vida preservada.
    // Objetivo: cobrir ramo calendar == null em changeTypeActionByStatus.
    [Test]
    public void NotifyAsync_NullCalendarWithAddAction_ThrowsNullReferenceAfterNullBranch()
    {
        // Arrange
        var context = new NotificationContext();

        // Act
        var act = () => context.Service.NotifyAsync(null!, EMedicalCalendarActionType.Add).GetAwaiter().GetResult();

        // Assert
        act.Should().Throw<NullReferenceException>();
    }

    private static MedicalCalendar BuildCalendar(EStatusCalendar status = EStatusCalendar.Scheduled) => new()
    {
        Title = "Consulta",
        StartDateTime = DateTime.UtcNow.AddDays(1),
        EndDateTime = DateTime.UtcNow.AddDays(1).AddHours(1),
        Description = "Desc",
        Location = "Room 1",
        Status = status,
        Medical = new Medical { Name = "Dr. Test" },
        Patient = new Patient { Name = "Patient Test" }
    };

    private static void SetupTemplate(NotificationContext context, string tag)
    {
        context.Templates.Setup(x => x.GetNotificationTemplatesAsync(tag))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<GetNotificationTemplateDto>
            {
                Success = true,
                Data = new GetNotificationTemplateDto { Subject = "Subject", Body = "<p>Body</p>", TemplateKey = tag }
            });
        context.SendNotification.Setup(x => x.SendNotificationAsync(
                It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.DataNotificationTemplateVO>(),
                It.IsAny<ENotificationServiceType>(),
                It.IsAny<Dictionary<string, string>>()))
            .Returns(Task.CompletedTask);
    }

    private sealed class NotificationContext
    {
        public Mock<ISharedServices> ServicesMock { get; } = new();
        public Mock<INotificationTemplateService> Templates { get; } = new();
        public Mock<ISendNotificationService> SendNotification { get; } = new();
        public MedicalCalenderNotificationService Service { get; }

        public NotificationContext()
        {
            ServicesMock.SetupGet(x => x.NotificationTemplateService).Returns(Templates.Object);
            ServicesMock.SetupGet(x => x.SendNotificationService).Returns(SendNotification.Object);
            Service = new MedicalCalenderNotificationService(ServicesMock.Object);
        }
    }
}
