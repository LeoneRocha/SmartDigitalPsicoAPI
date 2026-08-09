using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Schedule;
using SmartDigitalPsico.Domain.Validation;
namespace SmartDigitalPsico.Domain.Test.Validation;

[TestFixture]
public class ScheduleCalendarConflictValidatorBranchTests
{
    // Cenário: EndDateTime nulo na requisição.
    // Objetivo: usar StartDateTime como fim e não encontrar conflito.
    [Test]
    public async Task HasNoConflictAsync_NullEndDateTime_UsesStartAsEnd()
    {
        // Arrange
        var start = new DateTime(2025, 6, 1, 10, 0, 0);
        var repo = new Mock<IScheduleCalendarRepository>();
        repo.Setup(r => r.GetConflictingItemsAsync("sdp", "m:1", start, start)).ReturnsAsync([]);

        // Act
        var ok = await ScheduleCalendarConflictValidator.HasNoConflictAsync(
            new ScheduleCalendarConflictRequest
            {
                TenantKey = "sdp",
                OwnerKey = "m:1",
                StartDateTime = start,
                EndDateTime = null
            },
            repo.Object);

        // Assert
        ok.Should().BeTrue();
        repo.Verify(r => r.GetConflictingItemsAsync("sdp", "m:1", start, start), Times.Once);
    }

    // Cenário: itens cancelados/recusados/ativos sobrepostos.
    // Objetivo: cobrir ramos do predicado Any por status.
    [TestCase(EStatusCalendar.Canceled, true)]
    [TestCase(EStatusCalendar.Refused, true)]
    [TestCase(EStatusCalendar.Active, false)]
    public async Task HasNoConflictAsync_StatusVariants_ReturnsExpected(EStatusCalendar status, bool noConflict)
    {
        // Arrange
        var start = new DateTime(2025, 6, 1, 10, 0, 0);
        var end = start.AddHours(1);
        var repo = new Mock<IScheduleCalendarRepository>();
        repo.Setup(r => r.GetConflictingItemsAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync(
            [
                new ScheduleCalendarItem
                {
                    Status = status,
                    StartDateTime = start,
                    EndDateTime = end,
                    TokenRecurrence = "tok"
                }
            ]);

        // Act
        var result = await ScheduleCalendarConflictValidator.HasNoConflictAsync(
            new ScheduleCalendarConflictRequest
            {
                TenantKey = "sdp",
                OwnerKey = "o",
                StartDateTime = start,
                EndDateTime = end
            },
            repo.Object);

        // Assert
        result.Should().Be(noConflict);
    }

    // Cenário: ExcludeToken igual ao TokenRecurrence do item sobreposto.
    // Objetivo: ignorar a série atual e retornar sem conflito.
    [Test]
    public async Task HasNoConflictAsync_ExcludeTokenMatch_IgnoresSameSeries()
    {
        // Arrange
        var start = new DateTime(2025, 6, 1, 10, 0, 0);
        var end = start.AddHours(1);
        var repo = new Mock<IScheduleCalendarRepository>();
        repo.Setup(r => r.GetConflictingItemsAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync(
            [
                new ScheduleCalendarItem
                {
                    Status = EStatusCalendar.Active,
                    StartDateTime = start,
                    EndDateTime = end,
                    TokenRecurrence = "tok"
                }
            ]);

        // Act
        var result = await ScheduleCalendarConflictValidator.HasNoConflictAsync(
            new ScheduleCalendarConflictRequest
            {
                TenantKey = "sdp",
                OwnerKey = "o",
                StartDateTime = start,
                EndDateTime = end,
                ExcludeToken = "tok"
            },
            repo.Object);

        // Assert
        result.Should().BeTrue();
    }

    // Cenário: ExcludeToken diferente e horários sem sobreposição.
    // Objetivo: cobrir mismatch de token e ramo sem overlap.
    [Test]
    public async Task HasNoConflictAsync_ExcludeMismatchAndNoOverlap_CoversPredicateSides()
    {
        // Arrange
        var start = new DateTime(2025, 6, 1, 10, 0, 0);
        var end = start.AddHours(1);
        var repo = new Mock<IScheduleCalendarRepository>();
        repo.Setup(r => r.GetConflictingItemsAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync(
            [
                new ScheduleCalendarItem
                {
                    Status = EStatusCalendar.Active,
                    StartDateTime = start.AddHours(3),
                    EndDateTime = start.AddHours(4),
                    TokenRecurrence = "other"
                },
                new ScheduleCalendarItem
                {
                    Status = EStatusCalendar.Active,
                    StartDateTime = start,
                    EndDateTime = end,
                    TokenRecurrence = "other"
                }
            ]);

        // Act
        var withMismatch = await ScheduleCalendarConflictValidator.HasNoConflictAsync(
            new ScheduleCalendarConflictRequest
            {
                TenantKey = "sdp",
                OwnerKey = "o",
                StartDateTime = start,
                EndDateTime = end,
                ExcludeToken = "tok"
            },
            repo.Object);
        var whitespaceExclude = await ScheduleCalendarConflictValidator.HasNoConflictAsync(
            new ScheduleCalendarConflictRequest
            {
                TenantKey = "sdp",
                OwnerKey = "o",
                StartDateTime = start,
                EndDateTime = end,
                ExcludeToken = " "
            },
            repo.Object);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            withMismatch.Should().BeFalse();
            whitespaceExclude.Should().BeFalse();
        }
    }

    // Cenário: validator FluentValidation com repositório sem conflitos.
    // Objetivo: cobrir NoConflict via ValidateAsync.
    [Test]
    public async Task ValidateAsync_NoConflicts_IsValid()
    {
        // Arrange
        var start = new DateTime(2025, 6, 1, 10, 0, 0);
        var repo = new Mock<IScheduleCalendarRepository>();
        repo.Setup(r => r.GetConflictingItemsAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync([]);
        var validator = new ScheduleCalendarConflictValidator(repo.Object);

        // Act
        var result = await validator.ValidateAsync(new ScheduleCalendarConflictRequest
        {
            TenantKey = "sdp",
            OwnerKey = "m:1",
            StartDateTime = start,
            EndDateTime = start.AddHours(1)
        });

        // Assert
        result.IsValid.Should().BeTrue();
    }
}
