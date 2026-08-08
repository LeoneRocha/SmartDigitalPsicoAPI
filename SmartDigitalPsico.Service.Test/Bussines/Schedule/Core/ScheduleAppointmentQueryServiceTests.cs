using SmartDigitalPsico.Service.Audit;
using Moq;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
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
public class ScheduleAppointmentQueryServiceTests
{
    // Cenário: Existem agendamentos para o proprietário e paciente.
    // Objetivo: Retornar os itens consultados pelo intervalo informado.
    [Test]
    public async Task GetItemsForOwnerSubjectAsync_MatchingItems_ReturnsItems()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var start = new DateTime(2026, 8, 1, 0, 0, 0, DateTimeKind.Utc);
        var end = start.AddMonths(1);
        var expected = new[] { new ScheduleCalendarItem { StartDateTime = start.AddHours(9) } };
        repository.Setup(x => x.GetItemsForOwnerSubjectAsync("medical", "medical:1", "patient:2", start, end))
            .ReturnsAsync(expected);
        var service = new ScheduleAppointmentQueryService(repository.Object);

        // Act
        var result = await service.GetItemsForOwnerSubjectAsync("medical", "medical:1", "patient:2", start, end);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeSameAs(expected);
        }
    }

    // Cenário: A consulta não restringe o paciente.
    // Objetivo: Encaminhar subject nulo ao repositório.
    [Test]
    public async Task GetItemsForOwnerSubjectAsync_NullSubject_ReturnsOwnerItems()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var start = new DateTime(2026, 8, 1, 0, 0, 0, DateTimeKind.Utc);
        var expected = Array.Empty<ScheduleCalendarItem>();
        repository.Setup(x => x.GetItemsForOwnerSubjectAsync("medical", "medical:1", null, start, start.AddDays(1)))
            .ReturnsAsync(expected);
        var service = new ScheduleAppointmentQueryService(repository.Object);

        // Act
        var result = await service.GetItemsForOwnerSubjectAsync("medical", "medical:1", null, start, start.AddDays(1));

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeEmpty();
        }
        repository.Verify(x => x.GetItemsForOwnerSubjectAsync("medical", "medical:1", null, start, start.AddDays(1)), Times.Once);
    }
}
