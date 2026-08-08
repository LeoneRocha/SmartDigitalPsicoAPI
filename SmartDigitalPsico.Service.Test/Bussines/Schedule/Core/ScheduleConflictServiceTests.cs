using SmartDigitalPsico.Service.Audit;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using Serilog;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Domain.Validation;
using SmartDigitalPsico.Service.Schedule.Core.Conflict;

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
public class ScheduleConflictServiceTests
{
    // Cenário: O lote não possui itens.
    // Objetivo: Considerar a operação livre de conflito sem consultar persistência.
    [Test]
    public async Task HasNoConflictBatchAsync_EmptyItems_ReturnsSuccess()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>(MockBehavior.Strict);
        var service = new ScheduleConflictService(repository.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.HasNoConflictBatchAsync("medical", "medical:1", [], null);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeTrue();
        }
        repository.VerifyNoOtherCalls();
    }

    // Cenário: O mesmo lote contém dois horários sobrepostos.
    // Objetivo: Retornar detalhe de conflito antes de aceitar a agenda.
    [Test]
    public async Task HasNoConflictBatchAsync_SelfOverlappingItems_ReturnsConflict()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var start = new DateTime(2026, 8, 20, 9, 0, 0, DateTimeKind.Utc);
        repository.Setup(x => x.GetOverlappingByOwnerAsync("medical", "medical:1", start, start.AddHours(2)))
            .ReturnsAsync(Array.Empty<ScheduleCalendar>());
        var service = new ScheduleConflictService(repository.Object, Mock.Of<IAppLogger>());
        var items = new[]
        {
            new ScheduleCalendarItem { StartDateTime = start, EndDateTime = start.AddHours(1), SubjectKey = "patient:1" },
            new ScheduleCalendarItem { StartDateTime = start.AddMinutes(30), EndDateTime = start.AddHours(2), SubjectKey = "patient:2" }
        };

        // Act
        var result = await service.HasNoConflictBatchAsync("medical", "medical:1", items, null);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeFalse();
            result.Errors.Should().NotBeEmpty();
            result.Message.Should().Contain("conflict");
        }
    }

    // Cenário: Um item novo coincide com ocorrência persistida.
    // Objetivo: Recusar o lote e expor o conflito existente.
    [Test]
    public async Task HasNoConflictBatchAsync_ExistingOverlap_ReturnsConflict()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var start = new DateTime(2026, 8, 20, 9, 0, 0, DateTimeKind.Utc);
        repository.Setup(x => x.GetOverlappingByOwnerAsync("medical", "medical:1", start, start.AddHours(1)))
            .ReturnsAsync(
            [
                new ScheduleCalendar
                {
                    UniqueToken = "existing",
                    SubjectKey = "patient:3",
                    ScheduleData = [new ScheduleCalendarItem { StartDateTime = start.AddMinutes(15), EndDateTime = start.AddMinutes(45) }]
                }
            ]);
        var service = new ScheduleConflictService(repository.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.HasNoConflictBatchAsync(
            "medical",
            "medical:1",
            [new ScheduleCalendarItem { StartDateTime = start, EndDateTime = start.AddHours(1), SubjectKey = "patient:2" }],
            null);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeFalse();
            result.Errors.Should().ContainSingle();
        }
    }

    // Cenário: O repositório falha durante a busca de ocorrências.
    // Objetivo: Converter a exceção em resposta de falha.
    [Test]
    public async Task HasNoConflictBatchAsync_RepositoryThrows_ReturnsFailure()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var start = new DateTime(2026, 8, 20, 9, 0, 0, DateTimeKind.Utc);
        repository.Setup(x => x.GetOverlappingByOwnerAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ThrowsAsync(new InvalidOperationException("indisponível"));
        var service = new ScheduleConflictService(repository.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.HasNoConflictBatchAsync(
            "medical",
            "medical:1",
            [new ScheduleCalendarItem { StartDateTime = start, EndDateTime = start.AddHours(1) }],
            null);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Data.Should().BeFalse();
            result.Message.Should().Be("indisponível");
        }
    }

    // Cenário: verificação single-item sem conflito.
    // Objetivo: retornar sucesso via validator.
    [Test]
    public async Task HasNoConflictAsync_NoOverlap_ReturnsSuccess()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        repository.Setup(x => x.GetOverlappingByOwnerAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync(Array.Empty<ScheduleCalendar>());
        var service = new ScheduleConflictService(repository.Object, Mock.Of<IAppLogger>());
        var start = new DateTime(2026, 8, 21, 9, 0, 0, DateTimeKind.Utc);
        var request = new ScheduleCalendarConflictRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            StartDateTime = start,
            EndDateTime = start.AddHours(1)
        };

        // Act
        var result = await service.HasNoConflictAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeTrue();
        }
    }

    // Cenário: ocorrências canceladas são ignoradas no batch.
    // Objetivo: permitir criação quando conflito é apenas com status cancelado.
    [Test]
    public async Task HasNoConflictBatchAsync_CanceledExistingIgnored_ReturnsSuccess()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var start = new DateTime(2026, 8, 22, 9, 0, 0, DateTimeKind.Utc);
        repository.Setup(x => x.GetOverlappingByOwnerAsync("medical", "medical:1", start, start.AddHours(1)))
            .ReturnsAsync(
            [
                new ScheduleCalendar
                {
                    UniqueToken = "canceled-pkg",
                    ScheduleData = [new ScheduleCalendarItem { StartDateTime = start, EndDateTime = start.AddHours(1), Status = EStatusCalendar.Canceled }]
                }
            ]);
        var service = new ScheduleConflictService(repository.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.HasNoConflictBatchAsync(

        // Assert
            "medical",
            "medical:1",
            [new ScheduleCalendarItem { StartDateTime = start, EndDateTime = start.AddHours(1) }],
            null);

        result.Data.Should().BeTrue();
    }

    // Cenário: token excluído é ignorado na verificação de conflito.
    // Objetivo: não considerar o próprio pacote como conflito.
    [Test]
    public async Task HasNoConflictBatchAsync_ExcludeToken_SkipsSamePackage()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var start = new DateTime(2026, 8, 23, 9, 0, 0, DateTimeKind.Utc);
        repository.Setup(x => x.GetOverlappingByOwnerAsync("medical", "medical:1", start, start.AddHours(1)))
            .ReturnsAsync(
            [
                new ScheduleCalendar
                {
                    UniqueToken = "self-token",
                    ScheduleData = [new ScheduleCalendarItem { StartDateTime = start, EndDateTime = start.AddHours(1), TokenRecurrence = "self-token" }]
                }
            ]);
        var service = new ScheduleConflictService(repository.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.HasNoConflictBatchAsync(

        // Assert
            "medical",
            "medical:1",
            [new ScheduleCalendarItem { StartDateTime = start, EndDateTime = start.AddHours(1) }],
            "self-token");

        result.Data.Should().BeTrue();
    }

    // Cenário: pares sem sobreposição no self-check e lote grande contra existentes.
    // Objetivo: cobrir continue em FindSelfOverlapErrors e Parallel.For em FindConflictsAgainstExisting.
    [Test]
    public async Task HasNoConflictBatchAsync_NonOverlappingPairsAndParallelExistingCheck_ReturnsExpectedConflicts()
    {
        // Arrange — self-overlap: item 0 vs 1 não sobrepõe (continue), 0 vs 2 sobrepõe
        var repository = new Mock<IScheduleCalendarRepository>();
        var start = new DateTime(2026, 8, 24, 9, 0, 0, DateTimeKind.Utc);
        repository.Setup(x => x.GetOverlappingByOwnerAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync(Array.Empty<ScheduleCalendar>());
        var service = new ScheduleConflictService(repository.Object, Mock.Of<IAppLogger>());
        var selfCheckItems = new[]
        {
            new ScheduleCalendarItem { StartDateTime = start, EndDateTime = start.AddHours(1), SubjectKey = "patient:1" },
            new ScheduleCalendarItem { StartDateTime = start.AddHours(3), EndDateTime = start.AddHours(4), SubjectKey = "patient:2" },
            new ScheduleCalendarItem { StartDateTime = start.AddMinutes(30), EndDateTime = start.AddHours(2), SubjectKey = "patient:3" }
        };

        // Act
        var selfResult = await service.HasNoConflictBatchAsync("medical", "medical:1", selfCheckItems, null);

        // Assert
        selfResult.Data.Should().BeFalse();

        // Arrange — parallel path: lote >= CpuCount com conflitos e alguns sem overlap
        var batchSize = Math.Max(Environment.ProcessorCount, 8);
        var existingStart = new DateTime(2026, 9, 1, 10, 0, 0, DateTimeKind.Utc);
        var existing = new ScheduleCalendarItem { StartDateTime = existingStart, EndDateTime = existingStart.AddHours(1) };
        repository.Setup(x => x.GetOverlappingByOwnerAsync("medical", "medical:1", It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync([new ScheduleCalendar { UniqueToken = "pkg", ScheduleData = [existing] }]);
        var batchItems = new ScheduleCalendarItem[batchSize];
        for (var i = 0; i < batchSize; i++)
        {
            var offset = i < batchSize - 2 ? TimeSpan.Zero : TimeSpan.FromHours(5);
            batchItems[i] = new ScheduleCalendarItem
            {
                StartDateTime = existingStart.Add(offset),
                EndDateTime = existingStart.AddHours(1).Add(offset),
                SubjectKey = $"patient:{i}"
            };
        }

        // Act
        var batchResult = await service.HasNoConflictBatchAsync("medical", "medical:1", batchItems, null);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            batchResult.Data.Should().BeFalse();
            batchResult.Errors.Should().NotBeEmpty();
        }
    }

    // Cenário: mais conflitos que MaxErrors no lote paralelo.
    // Objetivo: cobrir early-return quando bag atinge o limite de erros.
    [Test]
    public async Task HasNoConflictBatchAsync_ManyParallelConflicts_CapsErrorsAtMax()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var existingStart = new DateTime(2026, 9, 2, 10, 0, 0, DateTimeKind.Utc);
        var existing = new ScheduleCalendarItem { StartDateTime = existingStart, EndDateTime = existingStart.AddHours(1) };
        repository.Setup(x => x.GetOverlappingByOwnerAsync("medical", "medical:1", It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync([new ScheduleCalendar { UniqueToken = "pkg", ScheduleData = [existing] }]);
        var items = Enumerable.Range(0, 25)
            .Select(i => new ScheduleCalendarItem
            {
                StartDateTime = existingStart.AddMinutes(i),
                EndDateTime = existingStart.AddHours(1).AddMinutes(i),
                SubjectKey = $"patient:{i}"
            })
            .ToArray();
        var service = new ScheduleConflictService(repository.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.HasNoConflictBatchAsync("medical", "medical:1", items, null);

        // Assert
        result.Data.Should().BeFalse();
        result.Errors!.Count.Should().BeLessThanOrEqualTo(20);
    }
}
