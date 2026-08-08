using Moq;
using Serilog;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Service.Bussines.Schedule.Core.Queries;

namespace SmartDigitalPsico.Service.Test.Bussines.Schedule.Core;

[TestFixture]
public class ScheduleQueryServiceTests
{
    // Cenário: Uma agenda é consultada por token existente.
    // Objetivo: Retornar o pacote encontrado com sucesso.
    [Test]
    public async Task GetByTokenAsync_ExistingToken_ReturnsSchedule()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var expected = new ScheduleCalendar { Id = 31, UniqueToken = "token-31" };
        repository.Setup(x => x.GetByUniqueTokenAsync("token-31")).ReturnsAsync(expected);
        var service = new ScheduleQueryService(repository.Object, Mock.Of<IScheduleConflictService>(), Mock.Of<ILogger>());

        // Act
        var result = await service.GetByTokenAsync("token-31");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeSameAs(expected);
        }
    }

    // Cenário: A consulta por identificador falha no repositório.
    // Objetivo: Traduzir a exceção em uma resposta de falha.
    [Test]
    public async Task GetByIdAsync_RepositoryThrows_ReturnsFailure()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        repository.Setup(x => x.FindByID(31)).ThrowsAsync(new InvalidOperationException("database unavailable"));
        var service = new ScheduleQueryService(repository.Object, Mock.Of<IScheduleConflictService>(), Mock.Of<ILogger>());

        // Act
        var result = await service.GetByIdAsync(31);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Message.Should().Be("database unavailable");
            result.Data.Should().BeNull();
        }
    }

    // Cenário: O serviço de conflito detecta conflito em uma consulta de horário.
    // Objetivo: Expor o resultado inverso como conflito existente.
    [Test]
    public async Task HasConflictAsync_ConflictServiceRejects_ReturnsConflict()
    {
        // Arrange
        var conflicts = new Mock<IScheduleConflictService>();
        conflicts.Setup(x => x.HasNoConflictAsync(It.IsAny<SmartDigitalPsico.Domain.Validation.Schedule.ScheduleCalendarConflictRequest>()))
            .ReturnsAsync(new global::SmartDigitalPsicoAPI.Core.SDK.Domain.VO.ServiceResponse<bool>
            {
                Success = true,
                Data = false,
                Message = "conflict"
            });
        var service = new ScheduleQueryService(Mock.Of<IScheduleCalendarRepository>(), conflicts.Object, Mock.Of<ILogger>());

        // Act
        var result = await service.HasConflictAsync("medical", "medical:1", new DateTime(2026, 8, 20, 9, 0, 0, DateTimeKind.Utc));

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeTrue();
            result.Message.Should().Be("conflict");
        }
    }

    // Cenário: A agenda existe para o identificador informado.
    // Objetivo: Retornar a entidade consultada com sucesso.
    [Test]
    public async Task GetByIdAsync_ExistingId_ReturnsSchedule()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var expected = new ScheduleCalendar { Id = 32, UniqueToken = "token-32" };
        repository.Setup(x => x.FindByID(32)).ReturnsAsync(expected);
        var service = new ScheduleQueryService(repository.Object, Mock.Of<IScheduleConflictService>(), Mock.Of<ILogger>());

        // Act
        var result = await service.GetByIdAsync(32);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeSameAs(expected);
        }
    }

    // Cenário: A agenda não existe para o identificador informado.
    // Objetivo: Sinalizar ausência sem lançar exceção.
    [Test]
    public async Task GetByIdAsync_MissingId_ReturnsFailure()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        repository.Setup(x => x.FindByID(404)).Returns(Task.FromResult<ScheduleCalendar>(null!));
        var service = new ScheduleQueryService(repository.Object, Mock.Of<IScheduleConflictService>(), Mock.Of<ILogger>());

        // Act
        var result = await service.GetByIdAsync(404);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Data.Should().BeNull();
        }
    }

    // Cenário: Há pacotes que se sobrepõem ao período solicitado.
    // Objetivo: Delegar a consulta com tenant e intervalo corretos.
    [Test]
    public async Task GetOverlappingPeriodAsync_ValidPeriod_ReturnsPackages()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var start = new DateTime(2026, 8, 20, 9, 0, 0, DateTimeKind.Utc);
        var expected = new[] { new ScheduleCalendar { Id = 1 } };
        repository.Setup(x => x.GetOverlappingByOwnerAsync("medical", "medical:1", start, start.AddHours(1)))
            .ReturnsAsync(expected);
        var service = new ScheduleQueryService(repository.Object, Mock.Of<IScheduleConflictService>(), Mock.Of<ILogger>());

        // Act
        var result = await service.GetOverlappingPeriodAsync("medical", "medical:1", start, start.AddHours(1));

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeSameAs(expected);
        }
    }

    // Cenário: O proprietário possui itens no período solicitado.
    // Objetivo: Retornar os itens carregados pelo repositório.
    [Test]
    public async Task GetItemsForOwnerAsync_ValidPeriod_ReturnsItems()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var start = new DateTime(2026, 8, 20, 9, 0, 0, DateTimeKind.Utc);
        var expected = new[] { new ScheduleCalendarItem { StartDateTime = start } };
        repository.Setup(x => x.GetItemsForOwnerAsync("medical", "medical:1", start, start.AddHours(1)))
            .ReturnsAsync(expected);
        var service = new ScheduleQueryService(repository.Object, Mock.Of<IScheduleConflictService>(), Mock.Of<ILogger>());

        // Act
        var result = await service.GetItemsForOwnerAsync("medical", "medical:1", start, start.AddHours(1));

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeSameAs(expected);
        }
    }

    // Cenário: Um horário específico possui item de agenda.
    // Objetivo: Retornar o item correspondente.
    [Test]
    public async Task GetItemAsync_MatchingItem_ReturnsItem()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var appointment = new DateTime(2026, 8, 20, 9, 0, 0, DateTimeKind.Utc);
        var expected = new ScheduleCalendarItem { StartDateTime = appointment };
        repository.Setup(x => x.GetItemAsync("medical", "medical:1", "patient:2", appointment)).ReturnsAsync(expected);
        var service = new ScheduleQueryService(repository.Object, Mock.Of<IScheduleConflictService>(), Mock.Of<ILogger>());

        // Act
        var result = await service.GetItemAsync("medical", "medical:1", "patient:2", appointment);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeSameAs(expected);
        }
    }

    // Cenário: A validação de conflito falha.
    // Objetivo: Preservar a falha e não declarar conflito.
    [Test]
    public async Task HasConflictAsync_ConflictCheckFails_ReturnsFailure()
    {
        // Arrange
        var conflicts = new Mock<IScheduleConflictService>();
        conflicts.Setup(x => x.HasNoConflictAsync(It.IsAny<SmartDigitalPsico.Domain.Validation.Schedule.ScheduleCalendarConflictRequest>()))
            .ReturnsAsync(new global::SmartDigitalPsicoAPI.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = false, Data = false, Message = "indisponível" });
        var service = new ScheduleQueryService(Mock.Of<IScheduleCalendarRepository>(), conflicts.Object, Mock.Of<ILogger>());

        // Act
        var result = await service.HasConflictAsync("medical", "medical:1", DateTime.UtcNow);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Data.Should().BeFalse();
            result.Message.Should().Be("indisponível");
        }
    }
}
