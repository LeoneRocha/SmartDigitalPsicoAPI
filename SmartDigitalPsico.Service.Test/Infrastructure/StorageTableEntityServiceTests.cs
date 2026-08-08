using SmartDigitalPsico.Service.Audit;
using Moq;

namespace SmartDigitalPsico.Service.Test.Infrastructure;
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;

[TestFixture]
public class StorageTableEntityServiceTests
{
    // Cenário: fábrica cria contrato interno e operações são delegadas.
    // Objetivo: cobrir ctor e todos os métodos públicos do SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageTableEntityService.
    [Test]
    public async Task StorageTableEntityService_AllOperations_DelegateToFactoryRepository()
    {
        // Arrange
        var inner = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<ProbeTableEntity>>();
        var entity = new ProbeTableEntity { PartitionKey = "p", RowKey = "r" };
        inner.Setup(x => x.GetAllAsync()).ReturnsAsync([entity]);
        inner.Setup(x => x.GetByIdAsync("p", "r")).ReturnsAsync(entity);
        var factory = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageTableRepositoryFactory>();
        factory.Setup(f => f.Create<ProbeTableEntity>(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EStorageAdapterType.Azure, "t")).Returns(inner.Object);
        var sut = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageTableEntityService<ProbeTableEntity>(factory.Object, "t");

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

    public sealed class ProbeTableEntity : SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL.BaseEntityTable
    {
    }
}
