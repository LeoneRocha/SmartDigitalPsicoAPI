using Moq;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical;
using SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.Actions;
using SmartDigitalPsico.Service.Test.TestSupport;
using MedicalEntity = SmartDigitalPsico.Domain.ModelEntity.Medical;

namespace SmartDigitalPsico.Service.Test.Bussines.Schedule.Implementations.Medical.Actions;

[TestFixture]
public class MedicalScheduleGradeServiceTests
{
    // Cenário: critérios inválidos no modo mensal.
    // Objetivo: cobrir ValidateCriteriaAsync com falha.
    [Test]
    public async Task GetMonthlyCalendar_InvalidCriteria_ReturnsValidationFailure()
    {
        // Arrange
        var ctx = Create(out var query, out var availability, out var sut);
        ctx.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 3 });

        // Act
        var result = await sut.GetMonthlyCalendar(new CalendarCriteriaDto

        // Assert
        {
            MedicalId = 0,
            Month = 1,
            Year = 2025,
            IntervalInMinutes = 30
        });

        result.Success.Should().BeFalse();
        result.Errors.Should().NotBeEmpty();
    }

    // Cenário: grade mensal com bookings e nomes de pacientes.
    // Objetivo: cobrir fluxo feliz e ResolvePatientNamesAsync.
    [Test]
    public async Task GetMonthlyCalendar_ValidCriteria_ReturnsCalendarWithPatientNames()
    {
        // Arrange
        var ctx = Create(out var query, out var availability, out var sut);
        var day = new DateTime(2025, 6, 2);
        SetupHappyPath(ctx, query, availability, day);

        // Act
        var result = await sut.GetMonthlyCalendar(ValidCriteria(day));

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().NotBeNull();
            result.Data!.MedicalId.Should().Be(3);
        }
    }

    // Cenário: usuário sem permissão, availability falha e paciente batch falha.
    // Objetivo: cobrir ramos de erro de BuildGradeAsync.
    [Test]
    public async Task GetMonthlyCalendar_PermissionAvailabilityAndPatientErrors_ReturnFailures()
    {
        // Arrange
        var ctx = Create(out var query, out var availability, out var sut);
        var day = new DateTime(2025, 6, 2);
        ctx.MedicalRepository.Setup(x => x.FindByID(3)).ReturnsAsync(CreateMedical());
        ctx.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 99, TimeZone = "UTC" });

        // Act
        var denied = await sut.GetMonthlyCalendar(ValidCriteria(day));

        ctx.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 3, TimeZone = "UTC" });
        query.Setup(x => x.GetItemsForOwnerAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync(new ServiceResponse<ScheduleCalendarItem[]> { Success = true, Data = [] });
        availability.Setup(x => x.BuildGradeAsync(It.IsAny<ScheduleGradeRequest>()))
            .ReturnsAsync(new ServiceResponse<ScheduleGradeResult> { Success = false, Message = "grade-fail" });
        var gradeFail = await sut.GetMonthlyCalendar(ValidCriteria(day));

        availability.Setup(x => x.BuildGradeAsync(It.IsAny<ScheduleGradeRequest>()))
            .ReturnsAsync(new ServiceResponse<ScheduleGradeResult>
            {
                Success = true,
                Data = new ScheduleGradeResult
                {
                    OwnerKey = MedicalScheduleKeys.ForMedical(3),
                    Days =
                    [
                        new ScheduleDayDto
                        {
                            Date = day,
                            TimeSlots =
                            [
                                new ScheduleTimeSlotDto
                                {
                                    StartTime = day.AddHours(9),
                                    EndTime = day.AddHours(9).AddMinutes(30),
                                    Booking = new ScheduleCalendarItem { SubjectKey = MedicalScheduleKeys.ForPatient(8) }
                                }
                            ]
                        }
                    ]
                }
            });
        ctx.PatientRepository.Setup(x => x.FindByCustomWhere(It.IsAny<System.Linq.Expressions.Expression<Func<Patient, bool>>>()))
            .ThrowsAsync(new InvalidOperationException("patients"));
        var patientFail = await sut.GetMonthlyCalendar(ValidCriteria(day));

        ctx.Context.UserRepository.Setup(x => x.FindByID(1)).Returns(Task.FromResult<User>(null!));

        var missingUser = await sut.GetMonthlyCalendar(ValidCriteria(day));
        var available = await sut.GetAvailableMedicalCalendar(ValidCriteria(day));

        // Assert
        using (Assert.EnterMultipleScope())
        {
            denied.Success.Should().BeFalse();
            gradeFail.Success.Should().BeFalse();
            gradeFail.Message.Should().Be("grade-fail");
            patientFail.Success.Should().BeTrue();
            missingUser.Success.Should().BeFalse();
            available.Success.Should().BeFalse();
        }
    }

    // Cenário: intervalo do médico inválido após aplicar constraints (modo mensal).
    // Objetivo: falhar na segunda ValidateCriteriaAsync.
    [Test]
    public async Task GetMonthlyCalendar_InvalidIntervalFromConstraints_ReturnsValidationFailure()
    {
        // Arrange
        var ctx = Create(out _, out _, out var sut);
        var day = new DateTime(2025, 6, 2);
        ctx.MedicalRepository.Setup(x => x.FindByID(3)).ReturnsAsync(new MedicalEntity
        {
            Id = 3,
            Name = "Dr",
            PatientIntervalTimeMinutes = 5,
            WorkingDays = [DayOfWeek.Monday],
            StartWorkingTime = TimeSpan.FromHours(9),
            EndWorkingTime = TimeSpan.FromHours(17)
        });
        ctx.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 3, TimeZone = "UTC" });

        // Act
        var result = await sut.GetMonthlyCalendar(ValidCriteria(day));

        // Assert
        result.Success.Should().BeFalse();
        result.Errors.Should().NotBeEmpty();
    }

    // Cenário: modo AvailableOnly com médico diferente do usuário logado.
    // Objetivo: cobrir bloqueio user.MedicalId != criteria.MedicalId (sem CalendarCriteriaValidator).
    [Test]
    public async Task GetAvailableMedicalCalendar_UserMedicalMismatch_ReturnsCalendarError()
    {
        // Arrange
        var ctx = Create(out _, out _, out var sut);
        var day = new DateTime(2025, 6, 2);
        ctx.MedicalRepository.Setup(x => x.FindByID(3)).ReturnsAsync(CreateMedical());
        ctx.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 99, TimeZone = "UTC" });

        // Act
        var result = await sut.GetAvailableMedicalCalendar(ValidCriteria(day));

        // Assert
        result.Success.Should().BeFalse();
        result.Data.Should().NotBeNull();
    }

    // Cenário: booking com SubjectKey inválido no slot.
    // Objetivo: cobrir ResolvePatientNamesAsync quando nenhum patientId válido é extraído.
    [Test]
    public async Task GetMonthlyCalendar_InvalidBookingSubjectKey_ReturnsCalendarWithoutPatientNames()
    {
        // Arrange
        var ctx = Create(out var query, out var availability, out var sut);
        var day = new DateTime(2025, 6, 3);
        ctx.MedicalRepository.Setup(x => x.FindByID(3)).ReturnsAsync(CreateMedical());
        ctx.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 3, TimeZone = "UTC" });
        query.Setup(x => x.GetItemsForOwnerAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync(new ServiceResponse<ScheduleCalendarItem[]> { Success = true, Data = [] });
        availability.Setup(x => x.BuildGradeAsync(It.IsAny<ScheduleGradeRequest>()))
            .ReturnsAsync(new ServiceResponse<ScheduleGradeResult>
            {
                Success = true,
                Data = new ScheduleGradeResult
                {
                    OwnerKey = MedicalScheduleKeys.ForMedical(3),
                    DisplayName = "Dr",
                    Days =
                    [
                        new ScheduleDayDto
                        {
                            Date = day,
                            TimeSlots =
                            [
                                new ScheduleTimeSlotDto
                                {
                                    StartTime = day.AddHours(9),
                                    EndTime = day.AddHours(9).AddMinutes(30),
                                    Booking = new ScheduleCalendarItem { SubjectKey = "invalid-subject" }
                                }
                            ]
                        }
                    ]
                }
            });

        // Act
        var result = await sut.GetMonthlyCalendar(ValidCriteria(day));

        // Assert
        result.Success.Should().BeTrue();
        ctx.PatientRepository.Verify(
            x => x.FindByCustomWhere(It.IsAny<System.Linq.Expressions.Expression<Func<Patient, bool>>>()),
            Times.Never);
    }

    private static void SetupHappyPath(
        MedicalScheduleTestContext ctx,
        Mock<IScheduleQueryService> query,
        Mock<IScheduleAvailabilityService> availability,
        DateTime day)
    {
        ctx.MedicalRepository.Setup(x => x.FindByID(3)).ReturnsAsync(CreateMedical());
        ctx.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 3, TimeZone = "UTC" });
        query.Setup(x => x.GetItemsForOwnerAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync(new ServiceResponse<ScheduleCalendarItem[]>
            {
                Success = true,
                Data =
                [
                    new ScheduleCalendarItem
                    {
                        StartDateTime = day.AddHours(9),
                        EndDateTime = day.AddHours(9).AddMinutes(30),
                        SubjectKey = MedicalScheduleKeys.ForPatient(8)
                    }
                ]
            });
        availability.Setup(x => x.BuildGradeAsync(It.IsAny<ScheduleGradeRequest>()))
            .ReturnsAsync(new ServiceResponse<ScheduleGradeResult>
            {
                Success = true,
                Data = new ScheduleGradeResult
                {
                    OwnerKey = MedicalScheduleKeys.ForMedical(3),
                    DisplayName = "Dr",
                    Days =
                    [
                        new ScheduleDayDto
                        {
                            Date = day,
                            TimeSlots =
                            [
                                new ScheduleTimeSlotDto
                                {
                                    StartTime = day.AddHours(9),
                                    EndTime = day.AddHours(9).AddMinutes(30),
                                    Booking = new ScheduleCalendarItem { SubjectKey = MedicalScheduleKeys.ForPatient(8) }
                                }
                            ]
                        }
                    ]
                }
            });
        ctx.PatientRepository.Setup(x => x.FindByCustomWhere(It.IsAny<System.Linq.Expressions.Expression<Func<Patient, bool>>>()))
            .ReturnsAsync([new Patient { Id = 8, Name = "Ana" }, new Patient { Id = 9, Name = " " }]);
    }

    private static CalendarCriteriaDto ValidCriteria(DateTime day) => new()
    {
        MedicalId = 3,
        Month = day.Month,
        Year = day.Year,
        StartDate = day,
        EndDate = day,
        IntervalInMinutes = 30
    };

    private static MedicalEntity CreateMedical() => new()
    {
        Id = 3,
        Name = "Dr",
        PatientIntervalTimeMinutes = 30,
        WorkingDays = [DayOfWeek.Monday],
        StartWorkingTime = TimeSpan.FromHours(9),
        EndWorkingTime = TimeSpan.FromHours(17)
    };

    private static MedicalScheduleTestContext Create(
        out Mock<IScheduleQueryService> query,
        out Mock<IScheduleAvailabilityService> availability,
        out MedicalScheduleGradeService sut)
    {
        var ctx = new MedicalScheduleTestContext();
        ctx.HostSupport.SetUserId(1);
        query = new Mock<IScheduleQueryService>();
        availability = new Mock<IScheduleAvailabilityService>();
        sut = new MedicalScheduleGradeService(ctx.HostSupport, query.Object, availability.Object, ctx.ConstraintsProvider);
        sut.SetUserId(1);
        return ctx;
    }
}
