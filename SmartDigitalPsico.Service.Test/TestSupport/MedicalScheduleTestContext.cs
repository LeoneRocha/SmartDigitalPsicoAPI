using FluentValidation;
using Moq;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.DTO;
using SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical;

namespace SmartDigitalPsico.Service.Test.TestSupport;

/// <summary>
/// Contexto compartilhado para os testes comportamentais dos serviços de agenda médica (Medical Schedule Actions).
/// Centraliza os mocks de baixo nível (repositórios, validators, notificações) reaproveitando o ServiceTestContext.
/// </summary>
public sealed class MedicalScheduleTestContext
{
    public ServiceTestContext Context { get; } = new();

    public Mock<IMedicalRepository> MedicalRepository { get; } = new();
    public Mock<IPatientRepository> PatientRepository { get; } = new();
    public Mock<IPatientRepositories> PatientRepositories { get; } = new();

    public Mock<IValidator<MedicalCalendar>> EntityValidator { get; } = new();
    public Mock<IValidator<AppointmentCriteriaDto>> AppointmentCriteriaDtoValidator { get; } = new();
    public Mock<IValidator<RecordsList<MedicalCalendar>>> MedicalCalendarListValidator { get; } = new();
    public Mock<IValidator<ScheduleCriteriaDto>> ScheduleCriteriaDtoValidator { get; } = new();
    public Mock<IMedicalCalendarValidators> Validators { get; } = new();

    public Mock<IMedicalCalenderNotificationService> MedicalCalenderNotification { get; } = new();
    public Mock<INotificationRecordsService> NotificationRecordsService { get; } = new();
    public Mock<INotificationRecordsRepository> NotificationRecordsRepository { get; } = new();

    public MedicalScheduleHostSupport HostSupport { get; }
    public MedicalScheduleConstraintsProvider ConstraintsProvider { get; }
    public MedicalScheduleNotificationAdapter NotificationAdapter { get; }

    public MedicalScheduleTestContext()
    {
        PatientRepositories.SetupGet(x => x.MedicalRepository).Returns(MedicalRepository.Object);
        PatientRepositories.SetupGet(x => x.PatientRepository).Returns(PatientRepository.Object);
        PatientRepositories.SetupGet(x => x.SharedRepositories).Returns(Context.SharedRepositories);

        Validators.SetupGet(x => x.EntityValidator).Returns(EntityValidator.Object);
        Validators.SetupGet(x => x.AppointmentCriteriaDtoValidator).Returns(AppointmentCriteriaDtoValidator.Object);
        Validators.SetupGet(x => x.MedicalCalendarListValidator).Returns(MedicalCalendarListValidator.Object);
        Validators.SetupGet(x => x.ScheduleCriteriaDtoValidator).Returns(ScheduleCriteriaDtoValidator.Object);

        HostSupport = new MedicalScheduleHostSupport(Context.SharedServices, Context.Config, Validators.Object, PatientRepositories.Object);
        ConstraintsProvider = new MedicalScheduleConstraintsProvider(MedicalRepository.Object, Context.Language.Object, Context.Cache.Object);
        NotificationAdapter = new MedicalScheduleNotificationAdapter(PatientRepositories.Object, MedicalCalenderNotification.Object, NotificationRecordsService.Object, NotificationRecordsRepository.Object);
    }
}
