using Moq;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical;
using SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.Actions;
using SmartDigitalPsico.Service.Test.TestSupport;

namespace SmartDigitalPsico.Service.Test.Bussines.Schedule.Implementations.Medical.Actions;

[TestFixture]
public class MedicalScheduleFindServiceTests
{
    // Cenário: agenda encontrada por ID.
    // Objetivo: mapear pacote para DTO e retornar sucesso.
    [Test]
    public async Task FindByID_ExistingSchedule_ReturnsMappedDto()
    {
        // Arrange
        var ctx = new MedicalScheduleTestContext();
        var query = new Mock<IScheduleQueryService>();
        var package = new ScheduleCalendar
        {
            Id = 12,
            UniqueToken = "tok",
            OwnerKey = MedicalScheduleKeys.ForMedical(2),
            SubjectKey = MedicalScheduleKeys.ForPatient(1),
            ScheduleData = [new ScheduleCalendarItem { StartDateTime = DateTime.UtcNow, Title = "Consulta" }]
        };
        query.Setup(x => x.GetByIdAsync(12)).ReturnsAsync(new ServiceResponse<ScheduleCalendar?> { Success = true, Data = package });
        var service = new MedicalScheduleFindService(ctx.HostSupport, query.Object);

        // Act
        var result = await service.FindByID(12);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.Id.Should().Be(12);
        }
    }

    // Cenário: agenda inexistente.
    // Objetivo: retornar falha de registro não encontrado.
    [Test]
    public async Task FindByID_MissingSchedule_ReturnsNotFound()
    {
        // Arrange
        var ctx = new MedicalScheduleTestContext();
        var query = new Mock<IScheduleQueryService>();
        query.Setup(x => x.GetByIdAsync(404)).ReturnsAsync(new ServiceResponse<ScheduleCalendar?> { Success = false });
        var service = new MedicalScheduleFindService(ctx.HostSupport, query.Object);

        // Act
        var result = await service.FindByID(404);

        // Assert
        result.Success.Should().BeFalse();
    }
}
