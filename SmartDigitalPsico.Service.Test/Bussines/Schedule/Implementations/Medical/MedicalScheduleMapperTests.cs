using Bogus;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.Common;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.EntityModels.Schedule;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.Test.Bussines.Schedule.Implementations.Medical;

[TestFixture]
public class MedicalScheduleMapperTests
{
    // Cenário: Uma consulta médica tem dados de recorrência válidos.
    // Objetivo: Materializar a requisição de escrita com chaves clínicas e ocorrência.
    [Test]
    public void ToWriteRequest_ValidMedicalCalendar_ReturnsClinicalScheduleRequest()
    {
        // Arrange
        var start = new DateTime(2026, 8, 10, 9, 0, 0, DateTimeKind.Utc);
        var calendar = new Faker<MedicalCalendar>()
            .RuleFor(x => x.Id, 12)
            .RuleFor(x => x.MedicalId, 7)
            .RuleFor(x => x.PatientId, 21)
            .RuleFor(x => x.Title, "Consulta")
            .RuleFor(x => x.StartDateTime, start)
            .RuleFor(x => x.EndDateTime, start.AddMinutes(30))
            .RuleFor(x => x.Enable, true)
            .RuleFor(x => x.TokenRecurrence, " token-1 ")
            .RuleFor(x => x.Status, EStatusCalendar.PendingConfirmation)
            .Generate();

        // Act
        var result = MedicalScheduleMapper.ToWriteRequest(calendar);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.PackageId.Should().Be(12);
            result.OwnerKey.Should().Be(MedicalScheduleKeys.ForMedical(7));
            result.SubjectKey.Should().Be(MedicalScheduleKeys.ForPatient(21));
            result.UniqueToken.Should().Be("token-1");
            result.Items.Should().ContainSingle();
            result.Items[0].StartDateTime.Should().Be(start);
        }
    }

    // Cenário: Um pacote possui a chave do médico e do paciente.
    // Objetivo: Mapear o pacote para DTO preservando os identificadores e a ocorrência preferida.
    [Test]
    public void ToGetDto_PackageWithPreferredOccurrence_ReturnsMappedClinicalDto()
    {
        // Arrange
        var item = new ScheduleCalendarItem
        {
            Title = "Retorno",
            StartDateTime = new DateTime(2026, 8, 11, 10, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 8, 11, 10, 30, 0, DateTimeKind.Utc),
            TokenRecurrence = "recurrence-token",
            Status = EStatusCalendar.Confirmed
        };
        var package = new ScheduleCalendar
        {
            Id = 15,
            Enable = true,
            OwnerKey = MedicalScheduleKeys.ForMedical(9),
            SubjectKey = MedicalScheduleKeys.ForPatient(22),
            UniqueToken = "package-token",
            ScheduleData = [item]
        };

        // Act
        var result = MedicalScheduleMapper.ToGetDto(package, item);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Id.Should().Be(15);
            result.MedicalId.Should().Be(9);
            result.PatientId.Should().Be(22);
            result.Title.Should().Be("Retorno");
            result.TokenRecurrence.Should().Be("recurrence-token");
        }
    }

    // Cenário: Critério mensal informa mês e nenhum intervalo customizado.
    // Objetivo: Gerar o intervalo completo do mês solicitado.
    [Test]
    public void GetMonthRange_LeapYearFebruary_ReturnsEntireMonth()
    {

        // Arrange

        // Act
        var (start, end) = MedicalScheduleMapper.GetMonthRange(2028, 2);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            start.Should().Be(new DateTime(2028, 2, 1, 0, 0, 0, DateTimeKind.Utc));
            end.Should().Be(new DateTime(2028, 2, 29, 0, 0, 0, DateTimeKind.Utc));
        }
    }
    // Cenário: criação de write request sem token informado.
    // Objetivo: gerar token e mapear paciente opcional.
    [Test]
    public void ToWriteRequest_CreateWithoutToken_GeneratesTokenAndMapsOptionalPatient()
    {
        // Arrange
        var calendar = new MedicalCalendar
        {
            MedicalId = 4,
            Title = "First consultation",
            StartDateTime = new DateTime(2026, 9, 1, 8, 0, 0, DateTimeKind.Utc),
            EndDateTime = new DateTime(2026, 9, 1, 9, 0, 0, DateTimeKind.Utc),
            TokenRecurrence = " ",
            RecurrenceDays = null!,
        };

        // Act
        var result = MedicalScheduleMapper.ToWriteRequest(calendar);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.PackageId.Should().BeNull();
            result.SubjectKey.Should().BeNull();
            result.UniqueToken.Should().NotBeNullOrWhiteSpace();
            result.Items.Should().ContainSingle();
            result.Items[0].RecurrenceDays.Should().BeEmpty();
        }
    }
    // Cenário: atualização parcial de agenda.
    // Objetivo: mapear apenas a ocorrência seed.
    [Test]
    public void ToWriteRequest_PartialUpdate_MapsOnlySeedOccurrence()
    {
        // Arrange
        var start = new DateTime(2026, 9, 2, 10, 0, 0, DateTimeKind.Utc);
        var calendar = new MedicalCalendar
        {
            Id = 11,
            MedicalId = 4,
            TokenRecurrence = "fixed",
            Title = "Follow-up",
            StartDateTime = start,
            EndDateTime = start.AddMinutes(45),
            ReasonCancellation = null!
        };

        // Act
        var result = MedicalScheduleMapper.ToWriteRequest(calendar, isUpdate: true, updateSeries: false);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.IsUpdate.Should().BeTrue();
            result.UpdateSeries.Should().BeFalse();
            result.Items.Should().ContainSingle();
            result.Items[0].ReasonCancellation.Should().BeEmpty();
            result.Items[0].TokenRecurrence.Should().Be("fixed");
        }
    }
    // Cenário: mapeamentos de pacote/item com chaves inválidas e fallbacks.
    // Objetivo: aplicar fallbacks e datas preferenciais corretamente.
    [Test]
    public void PackageAndItemMappings_InvalidKeysAndFallbacks_MapCorrectly()
    {
        // Arrange
        var early = new ScheduleCalendarItem { Title = "early", StartDateTime = new DateTime(2026, 9, 3, 8, 0, 0), TokenRecurrence = "" };
        var late = new ScheduleCalendarItem
        {
            PackageId = 19,
            Title = "late",
            StartDateTime = new DateTime(2026, 9, 3, 11, 0, 0),
            SubjectKey = MedicalScheduleKeys.ForPatient(15),
            OwnerKey = MedicalScheduleKeys.ForMedical(8)
        };
        var package = new ScheduleCalendar
        {
            Id = 19,
            Enable = false,
            OwnerKey = "invalid",
            SubjectKey = "invalid",
            UniqueToken = "package-token",
            ScheduleData = [late, early]
        };

        // Act
        var dto = MedicalScheduleMapper.ToGetDto(package);
        var calendar = MedicalScheduleMapper.ToMedicalCalendarFromPackage(package, late.StartDateTime.AddMinutes(1));
        var read = MedicalScheduleMapper.ToMedicalCalendarReadModel(late, 0);
        var reads = MedicalScheduleMapper.ToMedicalCalendarReadModels([late], 8, 15);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            dto.Title.Should().Be("early");
            dto.MedicalId.Should().Be(0);
            dto.PatientId.Should().BeNull();
            dto.TokenRecurrence.Should().Be("package-token");
            calendar.Title.Should().Be("late");
            calendar.Id.Should().Be(19);
            calendar.Enable.Should().BeFalse();
            read.MedicalId.Should().Be(8);
            read.PatientId.Should().Be(15);
            reads[0].MedicalId.Should().Be(8);
        }
    }
    // Cenário: mapeamentos de grade/slots com bookings e dias vazios.
    // Objetivo: mapear nomes de pacientes e dias sem horários.
    [Test]
    public void GradeAndSlotMappings_BookingsAndEmptyDays_MapCorrectly()
    {
        // Arrange
        var booking = new ScheduleCalendarItem
        {
            PackageId = 30,
            Title = "Fallback",
            StartDateTime = new DateTime(2026, 9, 4, 9, 0, 0),
            EndDateTime = new DateTime(2026, 9, 4, 9, 30, 0),
            SubjectKey = MedicalScheduleKeys.ForPatient(71)
        };
        var day = new ScheduleDayDto
        {
            Date = booking.StartDateTime.Date,
            TimeSlots =
            [
                new ScheduleTimeSlotDto { StartTime = booking.StartDateTime, EndTime = booking.EndDateTime, IsAvailable = false, Booking = booking },
                new ScheduleTimeSlotDto { StartTime = booking.StartDateTime.AddHours(1), IsAvailable = true }
            ]
        };
        var grade = new ScheduleGradeResult { DisplayName = "Dr. Test", Days = [day] };

        // Act
        var slot = MedicalScheduleMapper.ToTimeSlotDto(day.TimeSlots[0], 8, new Dictionary<long, string> { [71] = "Patient name" });
        var calendar = MedicalScheduleMapper.ToCalendarDto(grade, 8, new Dictionary<long, string> { [71] = "Patient name" });
        var noBooking = MedicalScheduleMapper.ToTimeSlotDto(day.TimeSlots[1], 8);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            slot.MedicalCalendar!.Patient!.Name.Should().Be("Patient name");
            calendar.MedicalName.Should().Be("Dr. Test");
            calendar.Days[0].TimeSlots.Should().HaveCount(2);
            noBooking.MedicalCalendar.Should().BeNull();
        }
    }
    // Cenário: mapeamentos de request e appointment.
    // Objetivo: mapear entradas e preservar ordenação.
    [Test]
    public void RequestAndAppointmentMappings_InputsAndOrdering_MapCorrectly()
    {
        // Arrange
        var criteria = new CalendarCriteriaDto
        {
            MedicalId = 8,
            Year = 2026,
            Month = 9,
            FilterDaysAndTimesWithAppointments = true,
            StartDate = new DateTime(2026, 9, 5),
            EndDate = new DateTime(2026, 9, 6),
            FilterByDate = new DateTime(2026, 9, 5)
        };
        var constraints = new ScheduleOwnerConstraints { DisplayName = "Doctor" };
        var bookingCriteria = new ScheduleCriteriaDto
        {
            MedicalId = 8,
            PatientId = 71,
            Reason = "Reason",
            TimeZone = "UTC",
            AppointmentDateTime = new DateTime(2026, 9, 5, 10, 0, 0, DateTimeKind.Utc)
        };

        // Act
        var grade = MedicalScheduleMapper.ToGradeRequest(criteria, constraints, "UTC", ScheduleGradeMode.Monthly);
        var available = MedicalScheduleMapper.ToGradeRequest(criteria, constraints, "UTC", ScheduleGradeMode.AvailableOnly);
        var book = MedicalScheduleMapper.ToBookRequest(bookingCriteria, 30);
        var cancel = MedicalScheduleMapper.ToCancelRequest(bookingCriteria);
        var delete = MedicalScheduleMapper.ToDeleteTokenRequest(new DeleteMedicalCalendarDto { MedicalId = 8, PatientId = 71, TokenRecurrence = "token" });
        var appointments = MedicalScheduleMapper.ToAppointmentDtos(
        [
            new ScheduleCalendarItem { StartDateTime = bookingCriteria.AppointmentDateTime.AddHours(1), TimeZone = "UTC" },
            new ScheduleCalendarItem { StartDateTime = bookingCriteria.AppointmentDateTime, TimeZone = "UTC" }

        ], 8, "Doctor");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            grade.StartDate.Should().Be(criteria.StartDate!.Value.Date);
            grade.FilterDaysWithBookingsOnly.Should().BeTrue();
            available.FilterDaysWithBookingsOnly.Should().BeFalse();
            book.Item.EndDateTime.Should().Be(bookingCriteria.AppointmentDateTime.AddMinutes(30));
            cancel.Reason.Should().Be("Reason");
            delete.UniqueToken.Should().Be("token");
            appointments.Select(x => x.StartDateTime).Should().BeInAscendingOrder();
        }
    }

    // Cenário: série diária longa o suficiente para map paralelo em BuildItems.
    // Objetivo: cobrir Parallel.For quando intervals >= MapParallelThreshold.
    [Test]
    public void BuildItems_DailySeriesAboveParallelThreshold_MapsAllOccurrences()
    {
        // Arrange
        var threshold = Math.Max(ScheduleParallel.MapParallelThreshold, Environment.ProcessorCount);
        var start = new DateTime(2026, 1, 1, 8, 0, 0, DateTimeKind.Utc);
        var entity = new MedicalCalendar
        {
            Title = "Daily series",
            StartDateTime = start,
            EndDateTime = start.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Daily,
            RecurrenceCount = (short)threshold
        };

        // Act
        var result = MedicalScheduleMapper.BuildItems(entity, "series-token");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Should().HaveCount(threshold);
            result.Should().OnlyContain(x => x.TokenRecurrence == "series-token");
            result.Select(x => x.StartDateTime).Should().BeInAscendingOrder();
        }
    }
}
