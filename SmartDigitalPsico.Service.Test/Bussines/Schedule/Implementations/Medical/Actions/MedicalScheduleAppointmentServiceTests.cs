using SmartDigitalPsico.Service;
using FluentValidation.Results;
using Moq;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Service.Test.TestSupport;
using MedicalEntity = SmartDigitalPsico.Domain.EntityModels.Medical;

using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Service.Test.Bussines.Schedule.Implementations.Medical.Actions;
    using Medical = global::SmartDigitalPsico.Domain.EntityModels.Medical;
                                
[TestFixture]
public class MedicalScheduleAppointmentServiceTests
{
    // Cenário: solicitação de agendamento com critérios inválidos.
    // Objetivo: retornar falha de validação sem tentar reservar.
    [Test]
    public async Task RequestAppointment_InvalidCriteria_ReturnsValidationFailure()
    {
        // Arrange
        var context = new AppointmentServiceContext();
        var invalidResult = new ValidationResult(new[] { new ValidationFailure("MedicalId", "Required") });
        context.ScheduleCriteriaDtoValidator.Setup(x => x.ValidateAsync(It.IsAny<ScheduleCriteriaDto>(), It.IsAny<CancellationToken>())).ReturnsAsync(invalidResult);

        // Act
        var result = await context.Service.RequestAppointment(new ScheduleCriteriaDto());

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: solicitação de agendamento válida do tipo Schedule.
    // Objetivo: reservar o horário e retornar sucesso.
    [Test]
    public async Task RequestAppointment_ValidScheduleType_BooksSuccessfully()
    {
        // Arrange
        var context = new AppointmentServiceContext();
        context.ScheduleCriteriaDtoValidator.Setup(x => x.ValidateAsync(It.IsAny<ScheduleCriteriaDto>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.MedicalRepository.Setup(x => x.FindByID(3)).ReturnsAsync(new MedicalEntity { Id = 3, PatientIntervalTimeMinutes = 30 });
        context.CreateService.Setup(x => x.BookAsync(It.IsAny<ScheduleBookRequest>())).ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendar> { Success = true, Data = new ScheduleCalendar { Id = 55 } });

        var criteria = new ScheduleCriteriaDto { ScheduleType = EScheduleCalendarType.Schedule, MedicalId = 3, PatientId = 10, AppointmentDateTime = DateTime.UtcNow };

        // Act
        var result = await context.Service.RequestAppointment(criteria);

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: solicitação de cancelamento válida.
    // Objetivo: cancelar a ocorrência e remover os registros de notificação associados.
    [Test]
    public async Task RequestAppointment_ValidCancellationType_CancelsAndRemovesNotifications()
    {
        // Arrange
        var context = new AppointmentServiceContext();
        context.ScheduleCriteriaDtoValidator.Setup(x => x.ValidateAsync(It.IsAny<ScheduleCriteriaDto>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        var token = Guid.NewGuid();
        context.UpdateService.Setup(x => x.CancelOccurrenceAsync(It.IsAny<ScheduleCancelRequest>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCancelResult> { Success = true, Data = new ScheduleCancelResult { PackageId = 7, UniqueToken = token.ToString() } });
        context.NotificationRecordsRepository.Setup(x => x.DeleteByTokenAndEventAsync(token, It.IsAny<DateTime>())).ReturnsAsync(true);

        var criteria = new ScheduleCriteriaDto { ScheduleType = EScheduleCalendarType.Cancellation, MedicalId = 3, PatientId = 10, AppointmentDateTime = DateTime.UtcNow };

        // Act
        var result = await context.Service.RequestAppointment(criteria);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
        }
        context.NotificationRecordsRepository.Verify(x => x.DeleteByTokenAndEventAsync(token, It.IsAny<DateTime>()), Times.Once);
    }

    // Cenário: falha inesperada durante a solicitação de agendamento.
    // Objetivo: capturar a exceção e retornar falha controlada.
    [Test]
    public async Task RequestAppointment_ValidatorThrows_ReturnsControlledFailure()
    {
        // Arrange
        var context = new AppointmentServiceContext();
        context.ScheduleCriteriaDtoValidator.Setup(x => x.ValidateAsync(It.IsAny<ScheduleCriteriaDto>(), It.IsAny<CancellationToken>())).ThrowsAsync(new InvalidOperationException("boom"));

        // Act
        var result = await context.Service.RequestAppointment(new ScheduleCriteriaDto());

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: tipo de operação de agenda não suportado.
    // Objetivo: retornar falha genérica quando ScheduleType é desconhecido.
    [Test]
    public async Task RequestAppointment_UnsupportedScheduleType_ReturnsGenericFailure()
    {
        // Arrange
        var context = new AppointmentServiceContext();
        context.ScheduleCriteriaDtoValidator.Setup(x => x.ValidateAsync(It.IsAny<ScheduleCriteriaDto>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        var criteria = new ScheduleCriteriaDto
        {
            ScheduleType = (EScheduleCalendarType)999,
            MedicalId = 3,
            PatientId = 10,
            AppointmentDateTime = DateTime.UtcNow
        };

        // Act
        var result = await context.Service.RequestAppointment(criteria);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: busca de compromissos com critérios inválidos.
    // Objetivo: retornar falha de validação.
    [Test]
    public async Task GetAppointments_InvalidCriteria_ReturnsValidationFailure()
    {
        // Arrange
        var context = new AppointmentServiceContext();
        var invalidResult = new ValidationResult(new[] { new ValidationFailure("MedicalId", "Required") });
        context.AppointmentCriteriaDtoValidator.Setup(x => x.ValidateAsync(It.IsAny<AppointmentCriteriaDto>(), It.IsAny<CancellationToken>())).ReturnsAsync(invalidResult);

        // Act
        var result = await context.Service.GetAppointments(new AppointmentCriteriaDto());

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: busca de compromissos sem itens encontrados.
    // Objetivo: retornar falha de ausência de registros.
    [Test]
    public async Task GetAppointments_NoItemsFound_ReturnsNotFoundFailure()
    {
        // Arrange
        var context = new AppointmentServiceContext();
        context.AppointmentCriteriaDtoValidator.Setup(x => x.ValidateAsync(It.IsAny<AppointmentCriteriaDto>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.AppointmentQuery.Setup(x => x.GetItemsForOwnerSubjectAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendarItem[]> { Success = true, Data = [] });

        var criteria = new AppointmentCriteriaDto { MedicalId = 3, PatientId = 10, Year = 2026, Month = 1 };

        // Act
        var result = await context.Service.GetAppointments(criteria);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: busca de compromissos com itens válidos.
    // Objetivo: retornar a lista de compromissos mapeada.
    [Test]
    public async Task GetAppointments_ValidItems_ReturnsMappedAppointments()
    {
        // Arrange
        var context = new AppointmentServiceContext();
        context.AppointmentCriteriaDtoValidator.Setup(x => x.ValidateAsync(It.IsAny<AppointmentCriteriaDto>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        var items = new[] { new ScheduleCalendarItem { StartDateTime = DateTime.UtcNow, TimeZone = "UTC" } };
        context.AppointmentQuery.Setup(x => x.GetItemsForOwnerSubjectAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendarItem[]> { Success = true, Data = items });
        context.MedicalRepository.Setup(x => x.FindByID(3)).ReturnsAsync(new MedicalEntity { Id = 3, Name = "Dr. House" });

        var criteria = new AppointmentCriteriaDto { MedicalId = 3, PatientId = 10, Year = 2026, Month = 1 };

        // Act
        var result = await context.Service.GetAppointments(criteria);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().ContainSingle();
        }
    }

    // Cenário: falha inesperada durante a busca de compromissos.
    // Objetivo: capturar a exceção e retornar falha controlada.
    [Test]
    public async Task GetAppointments_ValidatorThrows_ReturnsControlledFailure()
    {
        // Arrange
        var context = new AppointmentServiceContext();
        context.AppointmentCriteriaDtoValidator.Setup(x => x.ValidateAsync(It.IsAny<AppointmentCriteriaDto>(), It.IsAny<CancellationToken>())).ThrowsAsync(new InvalidOperationException("boom"));

        // Act
        var result = await context.Service.GetAppointments(new AppointmentCriteriaDto());

        // Assert
        result.Success.Should().BeFalse();
    }

    private sealed class AppointmentServiceContext
    {
        public MedicalScheduleTestContext Shared { get; } = new();
        public Mock<IScheduleCreateService> CreateService { get; } = new();
        public Mock<IScheduleUpdateService> UpdateService { get; } = new();
        public Mock<IScheduleAppointmentQueryService> AppointmentQuery { get; } = new();

        public Mock<Domain.Interfaces.Medical.IMedicalRepository> MedicalRepository => Shared.MedicalRepository;
        public Mock<FluentValidation.IValidator<ScheduleCriteriaDto>> ScheduleCriteriaDtoValidator => Shared.ScheduleCriteriaDtoValidator;
        public Mock<FluentValidation.IValidator<AppointmentCriteriaDto>> AppointmentCriteriaDtoValidator => Shared.AppointmentCriteriaDtoValidator;
        public Mock<Domain.Interfaces.Notification.INotificationRecordsRepository> NotificationRecordsRepository => Shared.NotificationRecordsRepository;

        public MedicalScheduleAppointmentService Service { get; }

        public AppointmentServiceContext()
        {
            Service = new MedicalScheduleAppointmentService(
                Shared.HostSupport,
                CreateService.Object,
                UpdateService.Object,
                AppointmentQuery.Object,
                Shared.ConstraintsProvider,
                Shared.NotificationAdapter,
                Shared.Validators.Object);
        }
    }
}
