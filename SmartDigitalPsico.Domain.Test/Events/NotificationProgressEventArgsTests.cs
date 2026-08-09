using SmartDigitalPsico.Domain.Events;

namespace SmartDigitalPsico.Domain.Test.Events;

[TestFixture]
public class NotificationProgressEventArgsTests
{
    // Cenário: O progresso possui total preenchido ou total zero.
    // Objetivo: Calcular percentual sem divisão por zero.
    [Test]
    public void Percentage_ProcessedAndTotal_ReturnsExpectedPercentage()
    {
        // Arrange
        var progress = new NotificationProgressEventArgs { Processed = 3, Total = 4 };
        var empty = new NotificationProgressEventArgs { Processed = 3, Total = 0 };
        // Act
        var percentage = progress.Percentage;
        // Assert
        using (Assert.EnterMultipleScope())
        {
            percentage.Should().Be(75);
            empty.Percentage.Should().Be(0);
        }
    }
}
