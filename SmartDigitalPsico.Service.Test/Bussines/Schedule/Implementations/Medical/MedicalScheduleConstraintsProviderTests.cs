using Moq;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical;
using SmartDigitalPsico.Service.Test.TestSupport;
using MedicalEntity = SmartDigitalPsico.Domain.ModelEntity.Medical;

namespace SmartDigitalPsico.Service.Test.Bussines.Schedule.Implementations.Medical;

[TestFixture]
public class MedicalScheduleConstraintsProviderTests
{
    // Cenário: médico existente.
    // Objetivo: retornar constraints com dados de trabalho.
    [Test]
    public async Task GetConstraintsAsync_ExistingMedical_ReturnsWorkingProfile()
    {
        // Arrange
        var ctx = new MedicalScheduleTestContext();
        ctx.MedicalRepository.Setup(x => x.FindByID(5)).ReturnsAsync(new MedicalEntity
        {
            Id = 5,
            Name = "Dr. Constraints",
            WorkingDays = [DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday],
            StartWorkingTime = TimeSpan.FromHours(8),
            EndWorkingTime = TimeSpan.FromHours(18),
            PatientIntervalTimeMinutes = 30
        });

        // Act
        var result = await ctx.ConstraintsProvider.GetConstraintsAsync(5);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.DisplayName.Should().Be("Dr. Constraints");
            result.IntervalMinutes.Should().Be(30);
            result.WorkingDays.Should().BeEquivalentTo([DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday]);
        }
    }

    // Cenário: médico inexistente.
    // Objetivo: lançar AppWarningException com mensagem localizada.
    [Test]
    public async Task GetMedicalAsync_MissingMedical_ThrowsAppWarning()
    {
        // Arrange
        var ctx = new MedicalScheduleTestContext();
        ctx.MedicalRepository.Setup(x => x.FindByID(999)).ReturnsAsync((MedicalEntity?)null);

        // Act
        var action = () => ctx.ConstraintsProvider.GetMedicalAsync(999);

        // Assert
        await action.Should().ThrowAsync<AppWarningException>();
    }

    // Cenário: conversão estática de entidade médica.
    // Objetivo: mapear campos nulos para valores padrão.
    [Test]
    public void ToConstraints_NullWorkingDays_ReturnsEmptyArray()
    {
        // Arrange
        var medical = new MedicalEntity
        {
            Name = "Dr. Empty",
            PatientIntervalTimeMinutes = 15,
            WorkingDays = null!
        };

        // Act
        var result = MedicalScheduleConstraintsProvider.ToConstraints(medical);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.WorkingDays.Should().BeEmpty();
            result.DisplayName.Should().Be("Dr. Empty");
        }
    }
}
