using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;
using Moq;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.Test.Infrastructure.Authentication;

[TestFixture]
public class TableStorageTokenSessionAdapterTests
{
    // Cenário: sessão existente no table storage.
    // Objetivo: mapear entidade para domínio.
    [Test]
    public async Task GetSessionAsync_ExistingEntity_ReturnsMappedSession()
    {
        // Arrange
        var tableEntity = new UserTokenSessionTableEntity { RowKey = "42", RefreshToken = "rt" };
        var storage = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<UserTokenSessionTableEntity>>();
        storage.Setup(x => x.GetByIdAsync("UserTokenSession", "42")).ReturnsAsync(tableEntity);
        var mapper = new Mock<IAppMapper>();
        mapper.Setup(x => x.Map<UserTokenSession>(tableEntity)).Returns(new UserTokenSession { UserId = 42, RefreshToken = "rt" });
        var adapter = new TableStorageTokenSessionAdapter(mapper.Object, storage.Object);

        // Act
        var result = await adapter.GetSessionAsync(42);

        // Assert
        result!.UserId.Should().Be(42);
        result.RefreshToken.Should().Be("rt");
    }

    // Cenário: persistência de nova sessão.
    // Objetivo: definir chaves e atualizar no table storage.
    [Test]
    public async Task SaveSessionAsync_NewSession_UpdatesTableEntity()
    {
        // Arrange
        var storage = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<UserTokenSessionTableEntity>>();
        storage.Setup(x => x.GetByIdAsync("UserTokenSession", "7")).Returns(Task.FromResult<UserTokenSessionTableEntity>(null!));
        storage.Setup(x => x.UpdateAsync(It.IsAny<UserTokenSessionTableEntity>())).Returns(Task.CompletedTask);
        var mapper = new Mock<IAppMapper>();
        mapper.Setup(x => x.Map<UserTokenSessionTableEntity>(It.IsAny<UserTokenSession>()))
            .Returns(new UserTokenSessionTableEntity());
        var adapter = new TableStorageTokenSessionAdapter(mapper.Object, storage.Object);
        var session = new UserTokenSession { UserId = 7, RefreshToken = "new-rt", ExpiresAt = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc().AddDays(1) };

        // Act
        await adapter.SaveSessionAsync(session);

        // Assert
        storage.Verify(x => x.UpdateAsync(It.Is<UserTokenSessionTableEntity>(e =>
            e.PartitionKey == "UserTokenSession" && e.RowKey == "7")), Times.Once);
        storage.Verify(x => x.DeleteAsync(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
    }

    // Cenário: sessão expirada já existente.
    // Objetivo: excluir registro expirado antes de atualizar.
    [Test]
    public async Task SaveSessionAsync_ExpiredExistingSession_DeletesBeforeUpdate()
    {
        // Arrange
        var expired = new UserTokenSessionTableEntity
        {
            PartitionKey = "UserTokenSession",
            RowKey = "8",
            ExpiresAt = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc().AddHours(-1)
        };
        var storage = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<UserTokenSessionTableEntity>>();
        storage.Setup(x => x.GetByIdAsync("UserTokenSession", "8")).ReturnsAsync(expired);
        storage.Setup(x => x.DeleteAsync("UserTokenSession", "8")).Returns(Task.CompletedTask);
        storage.Setup(x => x.UpdateAsync(It.IsAny<UserTokenSessionTableEntity>())).Returns(Task.CompletedTask);
        var mapper = new Mock<IAppMapper>();
        mapper.Setup(x => x.Map<UserTokenSessionTableEntity>(It.IsAny<UserTokenSession>()))
            .Returns(new UserTokenSessionTableEntity());
        var adapter = new TableStorageTokenSessionAdapter(mapper.Object, storage.Object);

        // Act
        await adapter.SaveSessionAsync(new UserTokenSession { UserId = 8, RefreshToken = "rt", ExpiresAt = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc().AddDays(1) });

        // Assert
        storage.Verify(x => x.DeleteAsync("UserTokenSession", "8"), Times.Once);
        storage.Verify(x => x.UpdateAsync(It.IsAny<UserTokenSessionTableEntity>()), Times.Once);
    }
}
