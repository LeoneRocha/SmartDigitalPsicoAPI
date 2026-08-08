using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using Serilog;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Service.Bussines.Schedule.Core.Commands;

namespace SmartDigitalPsico.Service.Test.Bussines.Schedule.Core;

[TestFixture]
public class ScheduleCommandServiceTests
{
    // Cenário: Uma criação não contém proprietário obrigatório.
    // Objetivo: Recusar a requisição antes de acessar dependências externas.
    [Test]
    public async Task CreateAsync_RequestWithoutOwner_ReturnsValidationFailure()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>(MockBehavior.Strict);
        var conflicts = new Mock<IScheduleConflictService>(MockBehavior.Strict);
        var service = new ScheduleCreateService(repository.Object, conflicts.Object, Mock.Of<IAppLogger>());
        var request = new ScheduleCalendarWriteRequest
        {
            TenantKey = "medical",
            Items = [new ScheduleCalendarItem()]
        };

        // Act
        var result = await service.CreateAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Message.Should().Contain("OwnerKey");
        }
        repository.VerifyNoOtherCalls();
        conflicts.VerifyNoOtherCalls();
    }

    // Cenário: Uma agenda válida não conflita com ocorrências existentes.
    // Objetivo: Persistir o pacote de agenda e retornar sucesso.
    [Test]
    public async Task CreateAsync_ConflictFreeRequest_PersistsSchedule()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var conflicts = new Mock<IScheduleConflictService>();
        var start = new DateTime(2026, 8, 15, 9, 0, 0, DateTimeKind.Utc);
        var request = new ScheduleCalendarWriteRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:7",
            SubjectKey = "patient:11",
            UniqueToken = "schedule-token",
            Enable = true,
            Items = [new ScheduleCalendarItem { StartDateTime = start, EndDateTime = start.AddMinutes(30) }]
        };
        repository.Setup(x => x.GetByUniqueTokenAsync("schedule-token")).Returns(Task.FromResult<ScheduleCalendar?>(null));
        conflicts.Setup(x => x.HasNoConflictBatchAsync("medical", "medical:7", request.Items, "schedule-token"))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = true, Data = true });
        repository.Setup(x => x.Create(It.IsAny<ScheduleCalendar>()))
            .ReturnsAsync((ScheduleCalendar entity) =>
            {
                entity.Id = 44;
                return entity;
            });
        var service = new ScheduleCreateService(repository.Object, conflicts.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.CreateAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.Id.Should().Be(44);
            result.Data.StartPeriod.Should().Be(start);
            result.Data.EndPeriod.Should().Be(start.AddMinutes(30));
        }
        repository.Verify(x => x.Create(It.Is<ScheduleCalendar>(x => x.UniqueToken == "schedule-token")), Times.Once);
    }

    // Cenário: A exclusão recebe um token inexistente.
    // Objetivo: Informar que a agenda não foi encontrada sem excluir registros.
    [Test]
    public async Task DeleteByTokenAsync_MissingSchedule_ReturnsNotFound()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        repository.Setup(x => x.GetByUniqueTokenAsync("missing")).Returns(Task.FromResult<ScheduleCalendar?>(null));
        var service = new ScheduleDeleteService(repository.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.DeleteByTokenAsync("missing");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Data.Should().BeFalse();
            result.Message.Should().Be("Agenda schedule not found.");
        }
        repository.Verify(x => x.Delete(It.IsAny<long>()), Times.Never);
    }

    // Cenário: A exclusão recebe uma agenda existente.
    // Objetivo: Remover a agenda correspondente ao token.
    [Test]
    public async Task DeleteByTokenAsync_ExistingSchedule_DeletesSchedule()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        repository.Setup(x => x.GetByUniqueTokenAsync("schedule-token"))
            .ReturnsAsync(new ScheduleCalendar { Id = 18, UniqueToken = "schedule-token" });
        repository.Setup(x => x.Delete(18)).ReturnsAsync(true);
        var service = new ScheduleDeleteService(repository.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.DeleteByTokenAsync("schedule-token");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeTrue();
        }
        repository.Verify(x => x.Delete(18), Times.Once);
    }

    // Cenário: O token filtrado não encontra pacote com os filtros, mas existe no fallback.
    // Objetivo: Excluir o pacote recuperado pelo token único.
    [Test]
    public async Task DeleteByTokenFilteredAsync_FallbackPackage_DeletesRange()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var request = new ScheduleDeleteTokenRequest { UniqueToken = "token", OwnerKey = "medical:1", SubjectKey = "patient:2" };
        var expected = new ScheduleCalendar { Id = 19, UniqueToken = "token" };
        repository.Setup(x => x.GetByTokenAsync("token", "medical:1", "patient:2")).ReturnsAsync(Array.Empty<ScheduleCalendar>());
        repository.Setup(x => x.GetByUniqueTokenAsync("token")).ReturnsAsync((ScheduleCalendar?)expected);
        repository.Setup(x => x.DeleteRangeAsync(It.IsAny<IEnumerable<ScheduleCalendar>>())).Returns(Task.CompletedTask);
        var service = new ScheduleDeleteService(repository.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.DeleteByTokenFilteredAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeTrue();
        }
        repository.Verify(x => x.DeleteRangeAsync(It.Is<IEnumerable<ScheduleCalendar>>(x => x.Single() == expected)), Times.Once);
    }

    // Cenário: Nenhum pacote corresponde ao token filtrado.
    // Objetivo: Informar ausência sem iniciar exclusão.
    [Test]
    public async Task DeleteByTokenFilteredAsync_MissingSchedule_ReturnsNotFound()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var request = new ScheduleDeleteTokenRequest { UniqueToken = "missing", OwnerKey = "medical:1" };
        repository.Setup(x => x.GetByTokenAsync("missing", "medical:1", null)).ReturnsAsync(Array.Empty<ScheduleCalendar>());
        repository.Setup(x => x.GetByUniqueTokenAsync("missing")).Returns(Task.FromResult<ScheduleCalendar?>(null));
        var service = new ScheduleDeleteService(repository.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.DeleteByTokenFilteredAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Data.Should().BeFalse();
            result.Message.Should().Be("Agenda schedule not found.");
        }
        repository.Verify(x => x.DeleteRangeAsync(It.IsAny<IEnumerable<ScheduleCalendar>>()), Times.Never);
    }

    // Cenário: O identificador da agenda não existe.
    // Objetivo: Recusar a exclusão por identificador.
    [Test]
    public async Task DeleteByIdAsync_MissingSchedule_ReturnsNotFound()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        repository.Setup(x => x.Exists(55)).ReturnsAsync(false);
        var service = new ScheduleDeleteService(repository.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.DeleteByIdAsync(55);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Data.Should().BeFalse();
            result.Message.Should().Be("Agenda schedule not found.");
        }
        repository.Verify(x => x.Delete(55), Times.Never);
    }

    // Cenário: O identificador da agenda existe.
    // Objetivo: Excluir o pacote correspondente.
    [Test]
    public async Task DeleteByIdAsync_ExistingSchedule_DeletesSchedule()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        repository.Setup(x => x.Exists(56)).ReturnsAsync(true);
        repository.Setup(x => x.Delete(56)).ReturnsAsync(true);
        var service = new ScheduleDeleteService(repository.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.DeleteByIdAsync(56);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeTrue();
        }
        repository.Verify(x => x.Delete(56), Times.Once);
    }

    // Cenário: BookAsync delega para CreateAsync com token gerado.
    // Objetivo: reservar horário e retornar pacote persistido.
    [Test]
    public async Task BookAsync_ValidRequest_PersistsSchedule()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var conflicts = new Mock<IScheduleConflictService>();
        var start = new DateTime(2026, 9, 1, 10, 0, 0, DateTimeKind.Utc);
        repository.Setup(x => x.GetByUniqueTokenAsync(It.IsAny<string>())).Returns(Task.FromResult<ScheduleCalendar?>(null));
        conflicts.Setup(x => x.HasNoConflictBatchAsync("medical", "medical:3", It.IsAny<ScheduleCalendarItem[]>(), It.IsAny<string>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = true, Data = true });
        repository.Setup(x => x.Create(It.IsAny<ScheduleCalendar>())).ReturnsAsync((ScheduleCalendar e) => { e.Id = 77; return e; });
        var service = new ScheduleCreateService(repository.Object, conflicts.Object, Mock.Of<IAppLogger>());
        var request = new ScheduleBookRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:3",
            SubjectKey = "patient:9",
            Item = new ScheduleCalendarItem { StartDateTime = start, EndDateTime = start.AddMinutes(30) }
        };

        // Act
        var result = await service.BookAsync(request);

        // Assert
        result.Success.Should().BeTrue();
        result.Data!.Id.Should().Be(77);
    }

    // Cenário: criação com token duplicado.
    // Objetivo: recusar criação informando que a agenda já existe.
    [Test]
    public async Task CreateAsync_DuplicateToken_ReturnsFailure()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var conflicts = new Mock<IScheduleConflictService>();
        var request = ValidCreateRequest();
        repository.Setup(x => x.GetByUniqueTokenAsync("dup-token")).ReturnsAsync(new ScheduleCalendar { Id = 1, UniqueToken = "dup-token" });
        var service = new ScheduleCreateService(repository.Object, conflicts.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.CreateAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Message.Should().Contain("already exists");
        }
        conflicts.VerifyNoOtherCalls();
    }

    // Cenário: conflito detectado na criação com erros detalhados.
    // Objetivo: propagar mensagem e lista de erros do serviço de conflito.
    [Test]
    public async Task CreateAsync_ConflictWithErrors_ReturnsConflictDetails()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var conflicts = new Mock<IScheduleConflictService>();
        var request = ValidCreateRequest();
        repository.Setup(x => x.GetByUniqueTokenAsync(request.UniqueToken)).Returns(Task.FromResult<ScheduleCalendar?>(null));
        conflicts.Setup(x => x.HasNoConflictBatchAsync(request.TenantKey, request.OwnerKey, request.Items, request.UniqueToken))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool>
            {
                Success = true,
                Data = false,
                Message = "Overlap",
                Errors = [new global::SmartDigitalPsico.Core.SDK.Domain.VO.ErrorResponse { Message = "Conflict detail" }]
            });
        var service = new ScheduleCreateService(repository.Object, conflicts.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.CreateAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Message.Should().Be("Overlap");
            result.Errors.Should().ContainSingle();
        }
    }

    // Cenário: exceção inesperada na criação.
    // Objetivo: registrar erro e retornar mensagem controlada.
    [Test]
    public async Task CreateAsync_RepositoryThrows_ReturnsControlledFailure()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var logger = new Mock<IAppLogger>();
        var conflicts = new Mock<IScheduleConflictService>();
        var request = ValidCreateRequest();
        repository.Setup(x => x.GetByUniqueTokenAsync(request.UniqueToken)).ThrowsAsync(new InvalidOperationException("inner"));
        var service = new ScheduleCreateService(repository.Object, conflicts.Object, logger.Object);

        // Act
        var result = await service.CreateAsync(request);

        // Assert
        result.Success.Should().BeFalse();

        logger.Verify(x => x.Error(It.IsAny<Exception>(), It.IsAny<string>(), It.IsAny<object[]>()), Times.Once);
    }

    // Cenário: exclusão por token lança exceção.
    // Objetivo: capturar erro e retornar falha controlada.
    [Test]
    public async Task DeleteByTokenAsync_RepositoryThrows_ReturnsControlledFailure()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var logger = new Mock<IAppLogger>();
        repository.Setup(x => x.GetByUniqueTokenAsync("tok")).ThrowsAsync(new InvalidOperationException("db"));
        var service = new ScheduleDeleteService(repository.Object, logger.Object);

        // Act
        var result = await service.DeleteByTokenAsync("tok");

        // Assert
        result.Success.Should().BeFalse();

        logger.Verify(x => x.Error(It.IsAny<Exception>(), It.IsAny<string>()), Times.Once);
    }

    // Cenário: exclusão filtrada lança exceção.
    // Objetivo: capturar erro e retornar falha controlada.
    [Test]
    public async Task DeleteByTokenFilteredAsync_RepositoryThrows_ReturnsControlledFailure()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var logger = new Mock<IAppLogger>();
        repository.Setup(x => x.GetByTokenAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string?>()))
            .ThrowsAsync(new InvalidOperationException("db"));
        var service = new ScheduleDeleteService(repository.Object, logger.Object);

        // Act
        var result = await service.DeleteByTokenFilteredAsync(new ScheduleDeleteTokenRequest { UniqueToken = "tok", OwnerKey = "o" });

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: exclusão por ID lança exceção.
    // Objetivo: capturar erro e retornar falha controlada.
    [Test]
    public async Task DeleteByIdAsync_RepositoryThrows_ReturnsControlledFailure()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var logger = new Mock<IAppLogger>();
        repository.Setup(x => x.Exists(1)).ThrowsAsync(new InvalidOperationException("db"));
        var service = new ScheduleDeleteService(repository.Object, logger.Object);

        // Act
        var result = await service.DeleteByIdAsync(1);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: criação sem UniqueToken gera token automaticamente.
    // Objetivo: cobrir geração de GUID quando token está vazio.
    [Test]
    public async Task CreateAsync_EmptyUniqueToken_GeneratesTokenAndPersists()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var conflicts = new Mock<IScheduleConflictService>();
        var start = new DateTime(2026, 8, 17, 9, 0, 0, DateTimeKind.Utc);
        var request = new ScheduleCalendarWriteRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:7",
            UniqueToken = " ",
            Items = [new ScheduleCalendarItem { StartDateTime = start, EndDateTime = start.AddMinutes(30) }]
        };
        repository.Setup(x => x.GetByUniqueTokenAsync(It.IsAny<string>())).Returns(Task.FromResult<ScheduleCalendar?>(null));
        conflicts.Setup(x => x.HasNoConflictBatchAsync("medical", "medical:7", request.Items, It.IsAny<string>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = true, Data = true });
        repository.Setup(x => x.Create(It.IsAny<ScheduleCalendar>())).ReturnsAsync((ScheduleCalendar e) => { e.Id = 50; return e; });
        var service = new ScheduleCreateService(repository.Object, conflicts.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.CreateAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            request.UniqueToken.Should().NotBeNullOrWhiteSpace();
        }
    }

    // Cenário: criação sem SubjectKey no pacote.
    // Objetivo: cobrir early-return de StampSubjectKey quando SubjectKey está vazio.
    [Test]
    public async Task CreateAsync_WithoutSubjectKey_SkipsStampingAndPersists()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var conflicts = new Mock<IScheduleConflictService>();
        var start = new DateTime(2026, 8, 18, 9, 0, 0, DateTimeKind.Utc);
        var item = new ScheduleCalendarItem { StartDateTime = start, EndDateTime = start.AddMinutes(30), SubjectKey = null };
        var request = new ScheduleCalendarWriteRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:7",
            UniqueToken = "no-subject",
            Items = [item]
        };
        repository.Setup(x => x.GetByUniqueTokenAsync("no-subject")).Returns(Task.FromResult<ScheduleCalendar?>(null));
        conflicts.Setup(x => x.HasNoConflictBatchAsync("medical", "medical:7", request.Items, "no-subject"))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = true, Data = true });
        repository.Setup(x => x.Create(It.IsAny<ScheduleCalendar>())).ReturnsAsync((ScheduleCalendar e) => { e.Id = 51; return e; });
        var service = new ScheduleCreateService(repository.Object, conflicts.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.CreateAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            item.SubjectKey.Should().BeNull();
        }
    }

    private static ScheduleCalendarWriteRequest ValidCreateRequest()
    {
        var start = new DateTime(2026, 8, 16, 9, 0, 0, DateTimeKind.Utc);
        return new ScheduleCalendarWriteRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:7",
            SubjectKey = "patient:11",
            UniqueToken = "dup-token",
            Items = [new ScheduleCalendarItem { StartDateTime = start, EndDateTime = start.AddMinutes(30), SubjectKey = null }]
        };
    }
}
