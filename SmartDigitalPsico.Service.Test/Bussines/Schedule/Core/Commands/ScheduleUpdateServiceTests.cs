using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using Serilog;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Service.Bussines.Schedule.Core.Commands;

using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Service.Test.Bussines.Schedule.Core.Commands;

[TestFixture]
public class ScheduleUpdateServiceTests
{
    // Cenário: requisição sem itens obrigatórios.
    // Objetivo: retornar falha de validação sem consultar o repositório.
    [Test]
    public async Task UpdateAsync_MissingRequiredFields_ReturnsValidationFailure()
    {
        // Arrange
        var context = new ScheduleUpdateContext();
        var request = new ScheduleCalendarWriteRequest { UniqueToken = "", TenantKey = "t", OwnerKey = "o" };

        // Act
        var result = await context.Service.UpdateAsync(request);

        // Assert
        result.Success.Should().BeFalse();

        context.Repository.Verify(x => x.GetByUniqueTokenAsync(It.IsAny<string>()), Times.Never);
    }

    // Cenário: agenda não encontrada por token nem por ID.
    // Objetivo: retornar falha de "não encontrado".
    [Test]
    public async Task UpdateAsync_ScheduleNotFound_ReturnsFailure()
    {
        // Arrange
        var context = new ScheduleUpdateContext();
        var request = ValidRequest();
        context.Repository.Setup(x => x.GetByUniqueTokenAsync(request.UniqueToken)).Returns(Task.FromResult<ScheduleCalendar?>(null));

        // Act
        var result = await context.Service.UpdateAsync(request);

        // Assert
        result.Success.Should().BeFalse();
        result.Message.Should().Contain("not found");
    }

    // Cenário: existe conflito de horário detectado pelo serviço de conflitos.
    // Objetivo: retornar falha com a mensagem de conflito.
    [Test]
    public async Task UpdateAsync_ConflictDetected_ReturnsConflictFailure()
    {
        // Arrange
        var context = new ScheduleUpdateContext();
        var request = ValidRequest();
        var entity = new ScheduleCalendar { Id = 1, UniqueToken = request.UniqueToken };
        context.Repository.Setup(x => x.GetByUniqueTokenAsync(request.UniqueToken)).ReturnsAsync(entity);
        context.ConflictService.Setup(x => x.HasNoConflictBatchAsync(request.TenantKey, request.OwnerKey, request.Items, entity.UniqueToken))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = true, Data = false, Message = "Conflito detectado" });

        // Act
        var result = await context.Service.UpdateAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Message.Should().Be("Conflito detectado");
        }
        context.Repository.Verify(x => x.Update(It.IsAny<ScheduleCalendar>()), Times.Never);
    }

    // Cenário: atualização válida substituindo toda a série.
    // Objetivo: persistir os novos itens e recalcular o período.
    [Test]
    public async Task UpdateAsync_ValidSeriesReplace_UpdatesAndReturnsEntity()
    {
        // Arrange
        var context = new ScheduleUpdateContext();
        var request = ValidRequest();
        request.IsUpdate = true;
        request.UpdateSeries = true;
        var entity = new ScheduleCalendar { Id = 2, UniqueToken = request.UniqueToken, ScheduleData = [] };
        context.Repository.Setup(x => x.GetByUniqueTokenAsync(request.UniqueToken)).ReturnsAsync(entity);
        context.ConflictService.Setup(x => x.HasNoConflictBatchAsync(request.TenantKey, request.OwnerKey, request.Items, entity.UniqueToken))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = true, Data = true });
        context.Repository.Setup(x => x.Update(It.IsAny<ScheduleCalendar>())).ReturnsAsync((ScheduleCalendar e) => e);

        // Act
        var result = await context.Service.UpdateAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.ScheduleData.Should().HaveCount(1);
        }
    }

    // Cenário: atualização parcial de uma ocorrência (não é série completa).
    // Objetivo: mesclar o item recebido com os itens existentes por data de início.
    [Test]
    public async Task UpdateAsync_PartialOccurrenceUpdate_MergesWithExistingItems()
    {
        // Arrange
        var context = new ScheduleUpdateContext();
        var start = DateTime.UtcNow.Date.AddDays(1).AddHours(10);
        var existingItem = new ScheduleCalendarItem { StartDateTime = start, Title = "Old" };
        var entity = new ScheduleCalendar { Id = 3, UniqueToken = "token-3", ScheduleData = [existingItem] };

        var request = new ScheduleCalendarWriteRequest
        {
            UniqueToken = "token-3",
            TenantKey = "tenant",
            OwnerKey = "medical:1",
            IsUpdate = true,
            UpdateSeries = false,
            Items = [new ScheduleCalendarItem { StartDateTime = start, Title = "New" }]
        };
        context.Repository.Setup(x => x.GetByUniqueTokenAsync("token-3")).ReturnsAsync(entity);
        context.ConflictService.Setup(x => x.HasNoConflictBatchAsync(request.TenantKey, request.OwnerKey, request.Items, entity.UniqueToken))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = true, Data = true });
        context.Repository.Setup(x => x.Update(It.IsAny<ScheduleCalendar>())).ReturnsAsync((ScheduleCalendar e) => e);

        // Act
        var result = await context.Service.UpdateAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.ScheduleData.Should().ContainSingle(i => i.Title == "New");
        }
    }

    // Cenário: busca por PackageId localiza a entidade antes do token.
    // Objetivo: priorizar o resultado de FindByID quando disponível.
    [Test]
    public async Task UpdateAsync_WithPackageId_UsesFindByID()
    {
        // Arrange
        var context = new ScheduleUpdateContext();
        var request = ValidRequest();
        request.PackageId = 9;
        var entity = new ScheduleCalendar { Id = 9, UniqueToken = request.UniqueToken, ScheduleData = [] };
        context.Repository.Setup(x => x.FindByID(9)).ReturnsAsync(entity);
        context.ConflictService.Setup(x => x.HasNoConflictBatchAsync(request.TenantKey, request.OwnerKey, request.Items, entity.UniqueToken))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = true, Data = true });
        context.Repository.Setup(x => x.Update(It.IsAny<ScheduleCalendar>())).ReturnsAsync((ScheduleCalendar e) => e);

        // Act
        var result = await context.Service.UpdateAsync(request);

        // Assert
        result.Success.Should().BeTrue();

        context.Repository.Verify(x => x.GetByUniqueTokenAsync(It.IsAny<string>()), Times.Never);
    }

    // Cenário: uma exceção inesperada ocorre durante a atualização.
    // Objetivo: registrar o erro e retornar uma falha controlada.
    [Test]
    public async Task UpdateAsync_RepositoryThrows_ReturnsControlledFailure()
    {
        // Arrange
        var context = new ScheduleUpdateContext();
        var request = ValidRequest();
        context.Repository.Setup(x => x.GetByUniqueTokenAsync(request.UniqueToken)).ThrowsAsync(new InvalidOperationException("db down"));

        // Act
        var result = await context.Service.UpdateAsync(request);

        // Assert
        result.Success.Should().BeFalse();

        context.Logger.Verify(x => x.Error(It.IsAny<Exception>(), It.IsAny<string>(), It.IsAny<object[]>()), Times.Once);
    }

    // Cenário: cancelamento de ocorrência inexistente.
    // Objetivo: retornar falha informando que o agendamento não foi encontrado.
    [Test]
    public async Task CancelOccurrenceAsync_MissingItem_ReturnsFailure()
    {
        // Arrange
        var context = new ScheduleUpdateContext();
        var request = new ScheduleCancelRequest { TenantKey = "tenant", OwnerKey = "medical:1", AppointmentDateTime = DateTime.UtcNow };
        context.Repository.Setup(x => x.GetItemAsync("tenant", "medical:1", null, request.AppointmentDateTime))
            .Returns(Task.FromResult<ScheduleCalendarItem?>(null));

        // Act
        var result = await context.Service.CancelOccurrenceAsync(request);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: item existe, mas nenhum pacote sobreposto contém a ocorrência.
    // Objetivo: retornar falha informando que o pacote não foi encontrado.
    [Test]
    public async Task CancelOccurrenceAsync_MissingPackage_ReturnsFailure()
    {
        // Arrange
        var context = new ScheduleUpdateContext();
        var appointment = DateTime.UtcNow;
        var request = new ScheduleCancelRequest { TenantKey = "tenant", OwnerKey = "medical:1", AppointmentDateTime = appointment };
        context.Repository.Setup(x => x.GetItemAsync("tenant", "medical:1", null, appointment))
            .ReturnsAsync(new ScheduleCalendarItem { StartDateTime = appointment });
        context.Repository.Setup(x => x.GetOverlappingByOwnerAsync("tenant", "medical:1", appointment, appointment.AddMinutes(1)))
            .ReturnsAsync([]);

        // Act
        var result = await context.Service.CancelOccurrenceAsync(request);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: cancelamento válido de uma ocorrência pendente de confirmação.
    // Objetivo: marcar a ocorrência como cancelada e persistir a alteração.
    [Test]
    public async Task CancelOccurrenceAsync_ValidPendingConfirmation_MarksCanceledAndPersists()
    {
        // Arrange
        var context = new ScheduleUpdateContext();
        var appointment = DateTime.UtcNow;
        var request = new ScheduleCancelRequest { TenantKey = "tenant", OwnerKey = "medical:1", AppointmentDateTime = appointment, Reason = "Client request" };
        var item = new ScheduleCalendarItem { StartDateTime = appointment, Status = EStatusCalendar.PendingConfirmation };
        context.Repository.Setup(x => x.GetItemAsync("tenant", "medical:1", null, appointment)).ReturnsAsync(item);

        var package = new ScheduleCalendar
        {
            Id = 5,
            UniqueToken = "tok-5",
            SubjectKey = null,
            ScheduleData = [item]
        };
        context.Repository.Setup(x => x.GetOverlappingByOwnerAsync("tenant", "medical:1", appointment, appointment.AddMinutes(1)))
            .ReturnsAsync([package]);
        context.Repository.Setup(x => x.Update(package)).ReturnsAsync(package);

        // Act
        var result = await context.Service.CancelOccurrenceAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.NewStatus.Should().Be(EStatusCalendar.Canceled);
            item.ReasonCancellation.Should().Be("Client request");
        }
    }

    // Cenário: cancelamento de ocorrência já confirmada.
    // Objetivo: marcar a ocorrência como pendente de cancelamento.
    [Test]
    public async Task CancelOccurrenceAsync_ConfirmedOccurrence_MarksPendingCancellation()
    {
        // Arrange
        var context = new ScheduleUpdateContext();
        var appointment = DateTime.UtcNow;
        var request = new ScheduleCancelRequest { TenantKey = "tenant", OwnerKey = "medical:1", AppointmentDateTime = appointment };
        var item = new ScheduleCalendarItem { StartDateTime = appointment, Status = EStatusCalendar.Confirmed };
        context.Repository.Setup(x => x.GetItemAsync("tenant", "medical:1", null, appointment)).ReturnsAsync(item);

        var package = new ScheduleCalendar { Id = 6, UniqueToken = "tok-6", ScheduleData = [item] };
        context.Repository.Setup(x => x.GetOverlappingByOwnerAsync("tenant", "medical:1", appointment, appointment.AddMinutes(1)))
            .ReturnsAsync([package]);
        context.Repository.Setup(x => x.Update(package)).ReturnsAsync(package);

        // Act
        var result = await context.Service.CancelOccurrenceAsync(request);

        // Assert
        result.Data!.NewStatus.Should().Be(EStatusCalendar.PendingCancellation);
    }

    // Cenário: exceção inesperada durante o cancelamento.
    // Objetivo: registrar o erro e retornar falha controlada.
    [Test]
    public async Task CancelOccurrenceAsync_RepositoryThrows_ReturnsControlledFailure()
    {
        // Arrange
        var context = new ScheduleUpdateContext();
        var request = new ScheduleCancelRequest { TenantKey = "tenant", OwnerKey = "medical:1", AppointmentDateTime = DateTime.UtcNow };
        context.Repository.Setup(x => x.GetItemAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string?>(), It.IsAny<DateTime>()))
            .ThrowsAsync(new InvalidOperationException("boom"));

        // Act
        var result = await context.Service.CancelOccurrenceAsync(request);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: atualização parcial com merge no mesmo dia (horário diferente).
    // Objetivo: substituir ocorrência do mesmo dia mantendo demais itens.
    [Test]
    public async Task UpdateAsync_SameDayDifferentTime_MergesByDay()
    {
        // Arrange
        var context = new ScheduleUpdateContext();
        var day = DateTime.UtcNow.Date.AddDays(5);
        var morning = day.AddHours(9);
        var afternoon = day.AddHours(14);
        var existingItem = new ScheduleCalendarItem { StartDateTime = morning, Title = "Morning" };
        var entity = new ScheduleCalendar { Id = 10, UniqueToken = "token-10", ScheduleData = [existingItem] };
        var request = new ScheduleCalendarWriteRequest
        {
            UniqueToken = "token-10",
            TenantKey = "tenant",
            OwnerKey = "medical:1",
            IsUpdate = true,
            UpdateSeries = false,
            Items = [new ScheduleCalendarItem { StartDateTime = afternoon, Title = "Afternoon" }]
        };
        context.Repository.Setup(x => x.GetByUniqueTokenAsync("token-10")).ReturnsAsync(entity);
        context.ConflictService.Setup(x => x.HasNoConflictBatchAsync(request.TenantKey, request.OwnerKey, request.Items, entity.UniqueToken))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = true, Data = true });
        context.Repository.Setup(x => x.Update(It.IsAny<ScheduleCalendar>())).ReturnsAsync((ScheduleCalendar e) => e);

        // Act
        var result = await context.Service.UpdateAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.ScheduleData.Should().ContainSingle(i => i.Title == "Afternoon" && i.StartDateTime == afternoon);
        }
    }

    // Cenário: atualização adiciona ocorrência em dia novo.
    // Objetivo: cobrir ramo de append em MergeByStartDateTime.
    [Test]
    public async Task UpdateAsync_NewDayOccurrence_AppendsToScheduleData()
    {
        // Arrange
        var context = new ScheduleUpdateContext();
        var day1 = DateTime.UtcNow.Date.AddDays(5);
        var day2 = day1.AddDays(2);
        var existingItem = new ScheduleCalendarItem { StartDateTime = day1.AddHours(9), Title = "Day1" };
        var entity = new ScheduleCalendar { Id = 12, UniqueToken = "token-12", ScheduleData = [existingItem] };
        var request = new ScheduleCalendarWriteRequest
        {
            UniqueToken = "token-12",
            TenantKey = "tenant",
            OwnerKey = "medical:1",
            SubjectKey = "patient:5",
            IsUpdate = true,
            UpdateSeries = false,
            Items =
            [
                new ScheduleCalendarItem { StartDateTime = day2.AddHours(10), Title = "Day2", SubjectKey = null }
            ]
        };
        context.Repository.Setup(x => x.GetByUniqueTokenAsync("token-12")).ReturnsAsync(entity);
        context.ConflictService.Setup(x => x.HasNoConflictBatchAsync(request.TenantKey, request.OwnerKey, It.IsAny<ScheduleCalendarItem[]>(), entity.UniqueToken))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = true, Data = true });
        context.Repository.Setup(x => x.Update(It.IsAny<ScheduleCalendar>())).ReturnsAsync((ScheduleCalendar e) => e);

        // Act
        var result = await context.Service.UpdateAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.ScheduleData.Should().HaveCount(2);
            result.Data.ScheduleData.Should().Contain(i => i.Title == "Day2");
            result.Data.ScheduleData.Single(i => i.Title == "Day2").SubjectKey.Should().Be("patient:5");
        }
    }

    // Cenário: cancelamento ignora ocorrências com horário diferente no pacote.
    // Objetivo: percorrer loop com continue quando StartDateTime difere.
    [Test]
    public async Task CancelOccurrenceAsync_DifferentStartTimeInPackage_SkipsNonMatchingItem()
    {
        // Arrange
        var context = new ScheduleUpdateContext();
        var appointment = DateTime.UtcNow;
        var other = appointment.AddHours(2);
        var request = new ScheduleCancelRequest { TenantKey = "tenant", OwnerKey = "medical:1", AppointmentDateTime = appointment };
        var matchingItem = new ScheduleCalendarItem { StartDateTime = appointment, Status = EStatusCalendar.PendingConfirmation };
        var otherItem = new ScheduleCalendarItem { StartDateTime = other, Status = EStatusCalendar.Confirmed };
        context.Repository.Setup(x => x.GetItemAsync("tenant", "medical:1", null, appointment)).ReturnsAsync(matchingItem);
        var package = new ScheduleCalendar { Id = 11, UniqueToken = "tok-11", ScheduleData = [matchingItem, otherItem] };
        context.Repository.Setup(x => x.GetOverlappingByOwnerAsync("tenant", "medical:1", appointment, appointment.AddMinutes(1)))
            .ReturnsAsync([package]);
        context.Repository.Setup(x => x.Update(package)).ReturnsAsync(package);

        // Act
        var result = await context.Service.CancelOccurrenceAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            otherItem.Status.Should().Be(EStatusCalendar.Confirmed);
            matchingItem.Status.Should().Be(EStatusCalendar.Canceled);
            result.Success.Should().BeTrue();
        }
    }

    private static ScheduleCalendarWriteRequest ValidRequest() => new()
    {
        UniqueToken = "token-1",
        TenantKey = "tenant",
        OwnerKey = "medical:1",
        Items = [new ScheduleCalendarItem { StartDateTime = DateTime.UtcNow.AddDays(1) }]
    };

    private sealed class ScheduleUpdateContext
    {
        public Mock<IScheduleCalendarRepository> Repository { get; } = new();
        public Mock<IScheduleConflictService> ConflictService { get; } = new();
        public Mock<IAppLogger> Logger { get; } = new();
        public ScheduleUpdateService Service { get; }

        public ScheduleUpdateContext()
        {
            Service = new ScheduleUpdateService(Repository.Object, ConflictService.Object, Logger.Object);
        }
    }
}
