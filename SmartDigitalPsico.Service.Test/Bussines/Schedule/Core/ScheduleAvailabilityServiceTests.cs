using SmartDigitalPsico.Service.Audit;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using Serilog;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Service.Schedule.Core.Queries;

using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Service.Test.Bussines.Schedule.Core;
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;

[TestFixture]
public class ScheduleAvailabilityServiceTests
{
    // Cenário: Uma grade recebe dados previamente carregados e perfil de trabalho.
    // Objetivo: Produzir os slots do dia sem nova consulta ao repositório.
    [Test]
    public async Task BuildGradeAsync_PreloadedItems_ReturnsWorkingDaySlots()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>(MockBehavior.Strict);
        var service = new ScheduleAvailabilityService(repository.Object, Mock.Of<IAppLogger>());
        var day = DateTime.UtcNow.Date.AddDays(3);
        var request = new ScheduleGradeRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            DisplayName = "Dra. Ana",
            TimeZone = "UTC",
            StartDate = day,
            EndDate = day,
            PreloadedItems = [],
            Constraints = new ScheduleOwnerConstraints
            {
                WorkingDays = [day.DayOfWeek],
                StartWorkingTime = TimeSpan.FromHours(9),
                EndWorkingTime = TimeSpan.FromHours(10),
                IntervalMinutes = 30,
                DisplayName = "Dra. Ana"
            }
        };

        // Act
        var result = await service.BuildGradeAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.OwnerKey.Should().Be("medical:1");
            result.Data.Days.Should().ContainSingle();
            result.Data.Days[0].TimeSlots.Should().NotBeEmpty();
            result.Data.Days[0].TimeSlots.Should().BeInAscendingOrder(x => x.StartTime);
        }
        repository.VerifyNoOtherCalls();
    }

    // Cenário: A grade não informa o proprietário obrigatório.
    // Objetivo: Retornar erro de validação sem buscar dados.
    [Test]
    public async Task BuildGradeAsync_RequestWithoutOwner_ReturnsValidationFailure()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>(MockBehavior.Strict);
        var service = new ScheduleAvailabilityService(repository.Object, Mock.Of<IAppLogger>());
        var request = new ScheduleGradeRequest();

        // Act
        var result = await service.BuildGradeAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Message.Should().Be("OwnerKey and Constraints are required.");
        }
        repository.VerifyNoOtherCalls();
    }
}
