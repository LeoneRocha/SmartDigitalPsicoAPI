using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using Serilog;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Service.Audit;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.Test.Audit;
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;

[TestFixture]
public class AuditPersistenceLogServiceTests
{
    // Cenário: entradas de auditoria em lote.
    // Objetivo: registrar cada entrada via logger Information.
    [Test]
    public void SaveAuditEntries_MultipleEntries_LogsEachEntry()
    {
        // Arrange
        var logger = new Mock<IAppLogger>();
        var service = new AuditPersistenceLogService(logger.Object);
        var entries = new[]
        {
            new AuditDataEntityLog { TableName = "Patient", Operation = "Update", KeyValue = "1", UserAuditedId = 9, AuditDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc() },
            new AuditDataEntityLog { TableName = "Medical", Operation = "Insert", KeyValue = "2", AuditDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc() }
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
        var logger = new Mock<IAppLogger>();
        var service = new AuditPersistenceLogService(logger.Object);
        var entry = new AuditDataSelectiveEntityLog
        {
            TableName = "Schedule",
            Operation = "Delete",
            KeyValue = "55",
            UserAuditedId = 3,
            AuditDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc()
        };

        // Act
        await service.SaveAuditEntry(entry);

        // Assert
        logger.Verify(x => x.Information(
            It.IsAny<string>(),
            It.IsAny<object[]>()), Times.Once);
    }
}
