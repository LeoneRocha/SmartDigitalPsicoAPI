using Moq;
using SmartDigitalPsico.Core.SDK.Data.TableEntityRepository;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Core.SDK.Tests.Repository.Coverage;

[TestFixture]
public class GenericTableEntityRepositoryTests
{
    // CenÃ¡rio: adapter de tabela configurado para leitura e escrita.
    // Objetivo: delegar GetAll, GetById, Insert, Update e Delete ao contrato de storage.
    [Test]
    public async Task CrudOperations_WhenAdapterConfigured_DelegatesToStorageContract()
    {
        // Arrange
        var adapter = new Mock<IStorageTableContract<TestTableEntity>>();
        var entity = new TestTableEntity { PartitionKey = "tenant", RowKey = "row" };
        adapter.Setup(value => value.GetAllAsync()).ReturnsAsync([entity]);
        adapter.Setup(value => value.GetByIdAsync("tenant", "row")).ReturnsAsync(entity);
        var repository = new GenericTableEntityRepository<TestTableEntity>(adapter.Object, "ignored");

        // Act
        (await repository.GetAllAsync()).Should().ContainSingle();
        (await repository.GetByIdAsync("tenant", "row")).Should().BeSameAs(entity);
        await repository.InsertAsync(entity);
        await repository.UpdateAsync(entity);
        await repository.DeleteAsync("tenant", "row");

        // Assert
        adapter.Verify(value => value.InsertAsync(entity), Times.Once);
        adapter.Verify(value => value.UpdateAsync(entity), Times.Once);
        adapter.Verify(value => value.DeleteAsync("tenant", "row"), Times.Once);
    }

    // CenÃ¡rio: UpdateAsync recebe entidade cujo GetById retorna linha vazia/padrÃ£o.
    // Objetivo: inserir a entidade quando a linha ainda nÃ£o existe de fato.
    [Test]
    public async Task UpdateAsync_MissingRow_InsertsEntity()
    {
        // Arrange
        var adapter = new Mock<IStorageTableContract<TestTableEntity>>();
        var entity = new TestTableEntity { PartitionKey = "tenant", RowKey = "row" };
        adapter.Setup(value => value.GetByIdAsync("tenant", "row")).ReturnsAsync(new TestTableEntity());
        var repository = new GenericTableEntityRepository<TestTableEntity>(adapter.Object, "table");

        // Act
        await repository.UpdateAsync(entity);

        // Assert
        adapter.Verify(value => value.InsertAsync(entity), Times.Once);
        adapter.Verify(value => value.UpdateAsync(It.IsAny<TestTableEntity>()), Times.Never);
    }

    public sealed class TestTableEntity : BaseEntityTable
    {
    }
}


