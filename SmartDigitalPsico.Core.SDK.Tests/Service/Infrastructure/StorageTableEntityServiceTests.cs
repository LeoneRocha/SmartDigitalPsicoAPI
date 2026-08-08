using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure;

namespace SmartDigitalPsico.Core.SDK.Tests.Infrastructure;

[TestFixture]
public class StorageTableEntityServiceTests
{
    // CenÃ¡rio: fÃ¡brica cria contrato interno e operaÃ§Ãµes sÃ£o delegadas.
    // Objetivo: cobrir ctor e todos os mÃ©todos pÃºblicos do StorageTableEntityService.
    [Test]
    public async Task StorageTableEntityService_AllOperations_DelegateToFactoryRepository()
    {
        // Arrange
        var inner = new Mock<IStorageTableContract<ProbeTableEntity>>();
        var entity = new ProbeTableEntity { PartitionKey = "p", RowKey = "r" };
        inner.Setup(x => x.GetAllAsync()).ReturnsAsync([entity]);
        inner.Setup(x => x.GetByIdAsync("p", "r")).ReturnsAsync(entity);
        var factory = new Mock<IStorageTableRepositoryFactory>();
        factory.Setup(f => f.Create<ProbeTableEntity>(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EStorageAdapterType.Azure, "t")).Returns(inner.Object);
        var sut = new StorageTableEntityService<ProbeTableEntity>(factory.Object, "t");

        // Act
        await sut.InsertAsync(entity);
        await sut.UpdateAsync(entity);
        await sut.DeleteAsync("p", "r");
        var all = await sut.GetAllAsync();
        var byId = await sut.GetByIdAsync("p", "r");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            all.Should().ContainSingle();
            byId.RowKey.Should().Be("r");
        }
        inner.Verify(x => x.InsertAsync(entity), Times.Once);
        inner.Verify(x => x.UpdateAsync(entity), Times.Once);
        inner.Verify(x => x.DeleteAsync("p", "r"), Times.Once);
    }

    public sealed class ProbeTableEntity : BaseEntityTable
    {
    }
}


