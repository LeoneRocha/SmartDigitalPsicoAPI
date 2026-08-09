using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Service.Test.Bussines.Schedule.Core;

[TestFixture]
public class ScheduleAvailabilityServiceFilterTests
{
    // Cenário: repositório lança exceção sem PreloadedItems.
    // Objetivo: cobrir o catch de BuildGradeAsync.
    [Test]
    public async Task BuildGradeAsync_RepositoryThrows_ReturnsFailure()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        repository.Setup(x => x.GetItemsForOwnerAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ThrowsAsync(new InvalidOperationException("db"));
        var service = new ScheduleAvailabilityService(repository.Object, Mock.Of<IAppLogger>());
        var day = DateTime.UtcNow.Date.AddDays(2);

        // Act
        var result = await service.BuildGradeAsync(CreateRequest(day, day, preloaded: null));

        // Assert
        result.Success.Should().BeFalse();
        result.Message.Should().Be("db");
    }

    // Cenário: EndDate anterior a StartDate.
    // Objetivo: cobrir dayCount <= 0.
    [Test]
    public async Task BuildGradeAsync_EndBeforeStart_ReturnsEmptyDays()
    {
        // Arrange
        var service = new ScheduleAvailabilityService(Mock.Of<IScheduleCalendarRepository>(), Mock.Of<IAppLogger>());
        var day = DateTime.UtcNow.Date.AddDays(2);

        // Act
        var result = await service.BuildGradeAsync(CreateRequest(day, day.AddDays(-1), preloaded: []));

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.Days.Should().BeEmpty();
        }
    }

    // Cenário: booking sobrepõe slot e filtros AvailableOnly/WorkingDays/Date/BookingsOnly.
    // Objetivo: cobrir ApplyFilters, match de booking e dias não úteis.
    [Test]
    public async Task BuildGradeAsync_BookingsAndFilters_CoversAvailabilityBranches()
    {
        // Arrange
        var service = new ScheduleAvailabilityService(Mock.Of<IScheduleCalendarRepository>(), Mock.Of<IAppLogger>());
        var day = DateTime.UtcNow.Date.AddDays(3);
        while (day.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
            day = day.AddDays(1);
        var booking = new ScheduleCalendarItem
        {
            StartDateTime = day.AddHours(9),
            EndDateTime = day.AddHours(9).AddMinutes(30),
            SubjectKey = "patient:1",
            Title = "Consulta"
        };
        var multiDay = new ScheduleCalendarItem
        {
            StartDateTime = day.AddHours(18),
            EndDateTime = day.AddDays(1).AddHours(10),
            SubjectKey = "patient:2"
        };
        var threshold = Math.Max(ScheduleParallel.MapParallelThreshold, Environment.ProcessorCount);
        var parallelBusy = Enumerable.Range(0, threshold)
            .Select(i => new ScheduleCalendarItem
            {
                StartDateTime = day.AddHours(14).AddMinutes(i),
                EndDateTime = day.AddHours(14).AddMinutes(i + 1),
                SubjectKey = $"p:{i}"
            })
            .ToArray();

        var request = new ScheduleGradeRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            DisplayName = "Dr",
            TimeZone = "UTC",
            StartDate = day,
            EndDate = day.AddDays(2),
            PreloadedItems = [booking, multiDay, .. parallelBusy],
            FilterDaysWithBookingsOnly = true,
            FilterByDate = day,
            FilterByWorkingDays = true,
            Mode = ScheduleGradeMode.AvailableOnly,
            Constraints = new ScheduleOwnerConstraints
            {
                WorkingDays = [day.DayOfWeek],
                StartWorkingTime = TimeSpan.FromHours(9),
                EndWorkingTime = TimeSpan.FromHours(17),
                IntervalMinutes = 30,
                DisplayName = "Dr"
            }
        };

        // Act
        var filtered = await service.BuildGradeAsync(request);
        var nonWorkingRequest = new ScheduleGradeRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            DisplayName = "Dr",
            TimeZone = "UTC",
            StartDate = day,
            EndDate = day,
            PreloadedItems = [booking],
            Constraints = new ScheduleOwnerConstraints
            {
                WorkingDays = [day.AddDays(1).DayOfWeek],
                StartWorkingTime = TimeSpan.FromHours(9),
                EndWorkingTime = TimeSpan.FromHours(12),
                IntervalMinutes = 30
            }
        };
        var nonWorking = await service.BuildGradeAsync(nonWorkingRequest);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            filtered.Success.Should().BeTrue();
            nonWorking.Success.Should().BeTrue();
            nonWorking.Data!.Days.SelectMany(d => d.TimeSlots).Should().OnlyContain(s => !s.IsAvailable || s.Booking != null);
        }
    }

    private static ScheduleGradeRequest CreateRequest(DateTime start, DateTime end, ScheduleCalendarItem[]? preloaded)
        => new()
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            DisplayName = "Dr",
            TimeZone = "UTC",
            StartDate = start,
            EndDate = end,
            PreloadedItems = preloaded,
            Constraints = new ScheduleOwnerConstraints
            {
                WorkingDays = [start.DayOfWeek, start.AddDays(1).DayOfWeek, start.AddDays(2).DayOfWeek],
                StartWorkingTime = TimeSpan.FromHours(9),
                EndWorkingTime = TimeSpan.FromHours(17),
                IntervalMinutes = 30,
                DisplayName = "Dr"
            }
        };
}
