using FluentValidation.Results;
using Moq;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.Common;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical;
using SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.Actions;
using SmartDigitalPsico.Service.Test.TestSupport;

using SmartDigitalPsico.Domain.DTO.Notification.Common;
using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Service.Test.Bussines.Schedule.Implementations.Medical.Actions;

[TestFixture]
public class MedicalScheduleCreateUpdateServiceTests
{
    // Cenário: criação de agenda médica válida.
    // Objetivo: persistir, registrar notificações e retornar sucesso.
    [Test]
    public async Task Create_ValidDto_PersistsAndNotifies()
    {
        // Arrange
        var context = new CreateUpdateContext();
        context.Shared.EntityValidator.Setup(x => x.ValidateAsync(It.IsAny<MedicalCalendar>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        var start = DateTime.UtcNow.AddDays(1);
        var package = new ScheduleCalendar
        {
            Id = 10,
            UniqueToken = "token-1",
            OwnerKey = MedicalScheduleKeys.ForMedical(2),
            SubjectKey = MedicalScheduleKeys.ForPatient(1),
            ScheduleData = [new ScheduleCalendarItem { StartDateTime = start, Title = "Consulta" }]
        };
        context.CreateService.Setup(x => x.CreateAsync(It.IsAny<ScheduleCalendarWriteRequest>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendar> { Success = true, Data = package });
        context.Shared.NotificationRecordsService.Setup(x => x.CreateOrUpdateNotificationRecordsAsync(It.IsAny<SmartDigitalPsico.Domain.DTO.Notification.Common.GenerateNotificationRecordsDto>()))
            .Returns(Task.CompletedTask);
        context.Shared.MedicalCalenderNotification.Setup(x => x.NotifyAsync(It.IsAny<MedicalCalendar>(), It.IsAny<EMedicalCalendarActionType>()))
            .Returns(Task.CompletedTask);

        // Act
        var result = await context.CreateServiceImpl.Create(new AddMedicalCalendarDto
        {
            PatientId = 1,
            MedicalId = 2,
            Title = "Consulta",
            StartDateTime = start
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.Id.Should().Be(10);
        }
        context.Shared.MedicalCalenderNotification.Verify(x => x.NotifyAsync(It.IsAny<MedicalCalendar>(), EMedicalCalendarActionType.Add), Times.Once);
    }

    // Cenário: falha de validação na criação.
    // Objetivo: retornar erro sem persistir.
    [Test]
    public async Task Create_ValidationFailure_ReturnsError()
    {
        // Arrange
        var context = new CreateUpdateContext();
        context.Shared.EntityValidator.Setup(x => x.ValidateAsync(It.IsAny<MedicalCalendar>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult([new ValidationFailure("Title", "Required")]));

        // Act
        var result = await context.CreateServiceImpl.Create(new AddMedicalCalendarDto { MedicalId = 1, StartDateTime = DateTime.UtcNow });

        // Assert
        result.Success.Should().BeFalse();

        context.CreateService.Verify(x => x.CreateAsync(It.IsAny<ScheduleCalendarWriteRequest>()), Times.Never);
    }

    // Cenário: persistência falha na criação.
    // Objetivo: propagar mensagem de erro do serviço core.
    [Test]
    public async Task Create_PersistFailure_ReturnsFailure()
    {
        // Arrange
        var context = new CreateUpdateContext();
        context.Shared.EntityValidator.Setup(x => x.ValidateAsync(It.IsAny<MedicalCalendar>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.CreateService.Setup(x => x.CreateAsync(It.IsAny<ScheduleCalendarWriteRequest>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendar> { Success = false, Message = "Conflict" });

        // Act
        var result = await context.CreateServiceImpl.Create(new AddMedicalCalendarDto { MedicalId = 1, StartDateTime = DateTime.UtcNow });

        // Assert
        result.Success.Should().BeFalse();
        result.Message.Should().Be("Conflict");
    }

    // Cenário: exceção inesperada na criação.
    // Objetivo: capturar e retornar falha controlada.
    [Test]
    public async Task Create_UnexpectedException_ReturnsControlledFailure()
    {
        // Arrange
        var context = new CreateUpdateContext();
        context.Shared.EntityValidator.Setup(x => x.ValidateAsync(It.IsAny<MedicalCalendar>(), It.IsAny<CancellationToken>()))
            .ThrowsAsync(new InvalidOperationException("boom"));

        // Act
        var result = await context.CreateServiceImpl.Create(new AddMedicalCalendarDto { MedicalId = 1, StartDateTime = DateTime.UtcNow });

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: atualização de agenda inexistente.
    // Objetivo: retornar falha de registro não encontrado.
    [Test]
    public async Task Update_ScheduleNotFound_ReturnsFailure()
    {
        // Arrange
        var context = new CreateUpdateContext();
        context.QueryService.Setup(x => x.GetByIdAsync(99)).ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendar?> { Success = false });

        // Act
        var result = await context.UpdateServiceImpl.Update(new UpdateMedicalCalendarDto { Id = 99, StartDateTime = DateTime.UtcNow });

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: atualização de ocorrência cancelada.
    // Objetivo: bloquear alteração e retornar erro de calendário.
    [Test]
    public async Task Update_CanceledOccurrence_ReturnsCalendarError()
    {
        // Arrange
        var context = new CreateUpdateContext();
        var start = DateTime.UtcNow.AddDays(2);
        var dto = new ScheduleCalendar
        {
            Id = 5,
            UniqueToken = "tok",
            ScheduleData =
            [
                new ScheduleCalendarItem { StartDateTime = start, Status = EStatusCalendar.Canceled }
            ]
        };
        context.QueryService.Setup(x => x.GetByIdAsync(5)).ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendar?> { Success = true, Data = dto });

        // Act
        var result = await context.UpdateServiceImpl.Update(new UpdateMedicalCalendarDto

        // Assert
        {
            Id = 5,
            StartDateTime = start,
            Status = EStatusCalendar.Active
        });

        result.Success.Should().BeFalse();
    }

    // Cenário: atualização válida de agenda ativa.
    // Objetivo: persistir, notificar e retornar DTO atualizado.
    [Test]
    public async Task Update_ValidActiveSchedule_PersistsAndNotifies()
    {
        // Arrange
        var context = new CreateUpdateContext();
        var start = DateTime.UtcNow.AddDays(3);
        var existingDto = new ScheduleCalendar
        {
            Id = 7,
            UniqueToken = "tok-7",
            ScheduleData = [new ScheduleCalendarItem { StartDateTime = start, Status = EStatusCalendar.Confirmed }]
        };
        context.QueryService.Setup(x => x.GetByIdAsync(7)).ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendar?> { Success = true, Data = existingDto });
        context.Shared.EntityValidator.Setup(x => x.ValidateAsync(It.IsAny<MedicalCalendar>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        var persisted = new ScheduleCalendar
        {
            Id = 7,
            UniqueToken = "tok-7",
            OwnerKey = MedicalScheduleKeys.ForMedical(3),
            SubjectKey = MedicalScheduleKeys.ForPatient(4),
            ScheduleData = [new ScheduleCalendarItem { StartDateTime = start, Title = "Updated", Status = EStatusCalendar.Confirmed }]
        };
        context.UpdateService.Setup(x => x.UpdateAsync(It.IsAny<ScheduleCalendarWriteRequest>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendar> { Success = true, Data = persisted });
        context.Shared.NotificationRecordsService.Setup(x => x.CreateOrUpdateNotificationRecordsAsync(It.IsAny<SmartDigitalPsico.Domain.DTO.Notification.Common.GenerateNotificationRecordsDto>()))
            .Returns(Task.CompletedTask);
        context.Shared.MedicalCalenderNotification.Setup(x => x.NotifyAsync(It.IsAny<MedicalCalendar>(), It.IsAny<EMedicalCalendarActionType>()))
            .Returns(Task.CompletedTask);

        // Act
        var result = await context.UpdateServiceImpl.Update(new UpdateMedicalCalendarDto
        {
            Id = 7,
            MedicalId = 3,
            PatientId = 4,
            Title = "Updated",
            StartDateTime = start,
            Status = EStatusCalendar.Confirmed
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.Title.Should().Be("Updated");
        }
        context.Shared.MedicalCalenderNotification.Verify(x => x.NotifyAsync(It.IsAny<MedicalCalendar>(), EMedicalCalendarActionType.Update), Times.Once);
    }

    // Cenário: persistência falha na atualização.
    // Objetivo: retornar mensagem de erro do serviço core.
    [Test]
    public async Task Update_PersistFailure_ReturnsFailure()
    {
        // Arrange
        var context = new CreateUpdateContext();
        var start = DateTime.UtcNow.AddDays(4);
        var existingDto = new ScheduleCalendar
        {
            Id = 8,
            UniqueToken = "tok-8",
            ScheduleData = [new ScheduleCalendarItem { StartDateTime = start, Status = EStatusCalendar.Active }]
        };
        context.QueryService.Setup(x => x.GetByIdAsync(8)).ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendar?> { Success = true, Data = existingDto });
        context.Shared.EntityValidator.Setup(x => x.ValidateAsync(It.IsAny<MedicalCalendar>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.UpdateService.Setup(x => x.UpdateAsync(It.IsAny<ScheduleCalendarWriteRequest>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendar> { Success = false, Message = "Update failed" });

        // Act
        var result = await context.UpdateServiceImpl.Update(new UpdateMedicalCalendarDto

        // Assert
        {
            Id = 8,
            MedicalId = 1,
            StartDateTime = start,
            Status = EStatusCalendar.Active
        });

        result.Success.Should().BeFalse();
        result.Message.Should().Be("Update failed");
    }

    // Cenário: exceção inesperada na atualização.
    // Objetivo: capturar e retornar falha controlada.
    [Test]
    public async Task Update_UnexpectedException_ReturnsControlledFailure()
    {
        // Arrange
        var context = new CreateUpdateContext();
        context.QueryService.Setup(x => x.GetByIdAsync(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException("boom"));

        // Act
        var result = await context.UpdateServiceImpl.Update(new UpdateMedicalCalendarDto { Id = 1, StartDateTime = DateTime.UtcNow });

        // Assert
        result.Success.Should().BeFalse();
    }

    private sealed class CreateUpdateContext
    {
        public MedicalScheduleTestContext Shared { get; } = new();
        public Mock<IScheduleCreateService> CreateService { get; } = new();
        public Mock<IScheduleUpdateService> UpdateService { get; } = new();
        public Mock<IScheduleQueryService> QueryService { get; } = new();
        public MedicalScheduleCreateService CreateServiceImpl { get; }
        public MedicalScheduleUpdateService UpdateServiceImpl { get; }

        public CreateUpdateContext()
        {
            CreateServiceImpl = new MedicalScheduleCreateService(Shared.HostSupport, CreateService.Object, Shared.NotificationAdapter);
            UpdateServiceImpl = new MedicalScheduleUpdateService(Shared.HostSupport, QueryService.Object, UpdateService.Object, Shared.NotificationAdapter);
        }
    }
}
