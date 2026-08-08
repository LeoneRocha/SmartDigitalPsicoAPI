using Moq;
using Serilog;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Service.Audit;

namespace SmartDigitalPsico.Service.Test.Audit;

[TestFixture]
public class AuditPersistenceLogServiceTests
{
    // Cenário: entradas de auditoria em lote.
    // Objetivo: registrar cada entrada via logger Information.
    [Test]
    public void SaveAuditEntries_MultipleEntries_LogsEachEntry()
    {
        // Arrange
        var logger = new Mock<ILogger>();
        var service = new AuditPersistenceLogService(logger.Object);
        var entries = new[]
        {
            new AuditDataEntityLog { TableName = "Patient", Operation = "Update", KeyValue = "1", UserAuditedId = 9, AuditDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc() },
            new AuditDataEntityLog { TableName = "Medical", Operation = "Insert", KeyValue = "2", AuditDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc() }
        };

        // Act
        service.SaveAuditEntries(entries);

        // Assert
        logger.Verify(x => x.Information(
            It.IsAny<string>(),
            It.IsAny<object[]>()), Times.Exactly(2));
    }

    // Cenário: entrada seletiva única.
    // Objetivo: registrar via Task.Run e logger Information.
    [Test]
    public async Task SaveAuditEntry_SingleEntry_LogsInformation()
    {
        // Arrange
        var logger = new Mock<ILogger>();
        var service = new AuditPersistenceLogService(logger.Object);
        var entry = new AuditDataSelectiveEntityLog
        {
            TableName = "Schedule",
            Operation = "Delete",
            KeyValue = "55",
            UserAuditedId = 3,
            AuditDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc()
        };

        // Act
        await service.SaveAuditEntry(entry);

        // Assert
        logger.Verify(x => x.Information(
            It.IsAny<string>(),
            It.IsAny<object[]>()), Times.Once);
    }
}
