using Moq;
using SmartDigitalPsico.Data.TableEntityRepository;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Data.Test.Repository.Coverage;

[TestFixture]
public class GenericTableEntityRepositoryTests
{
    [Test]
    public async Task DelegatesReadInsertDeleteAndUpdatesExistingRows()
    {
        var adapter = new Mock<IStorageTableContract<TestTableEntity>>();
        var entity = new TestTableEntity { PartitionKey = "tenant", RowKey = "row" };
        adapter.Setup(value => value.GetAllAsync()).ReturnsAsync([entity]);
        adapter.Setup(value => value.GetByIdAsync("tenant", "row")).ReturnsAsync(entity);
        var repository = new GenericTableEntityRepository<TestTableEntity>(adapter.Object, "ignored");

        (await repository.GetAllAsync()).Should().ContainSingle();
        (await repository.GetByIdAsync("tenant", "row")).Should().BeSameAs(entity);
        await repository.InsertAsync(entity);
        await repository.UpdateAsync(entity);
        await repository.DeleteAsync("tenant", "row");

        adapter.Verify(value => value.InsertAsync(entity), Times.Once);
        adapter.Verify(value => value.UpdateAsync(entity), Times.Once);
        adapter.Verify(value => value.DeleteAsync("tenant", "row"), Times.Once);
    }

    [Test]
    public async Task UpdateAsync_MissingRow_InsertsEntity()
    {
        var adapter = new Mock<IStorageTableContract<TestTableEntity>>();
        var entity = new TestTableEntity { PartitionKey = "tenant", RowKey = "row" };
        adapter.Setup(value => value.GetByIdAsync("tenant", "row")).ReturnsAsync(new TestTableEntity());
        var repository = new GenericTableEntityRepository<TestTableEntity>(adapter.Object, "table");

        await repository.UpdateAsync(entity);

        adapter.Verify(value => value.InsertAsync(entity), Times.Once);
        adapter.Verify(value => value.UpdateAsync(It.IsAny<TestTableEntity>()), Times.Never);
    }

    public sealed class TestTableEntity : BaseEntityTable
    {
    }
}
