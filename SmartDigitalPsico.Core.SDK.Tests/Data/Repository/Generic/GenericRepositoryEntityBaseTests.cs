using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Repository.Generic;
using SmartDigitalPsico.Core.SDK.Domain.Contracts;

namespace SmartDigitalPsico.Core.SDK.Tests.Data.Repository.Generic;

[TestFixture]
public class GenericRepositoryEntityBaseTests
{
    [Test]
    public async Task CrudAndQuery_WithInMemoryContext_Succeed()
    {
        await using var context = CreateContext();
        var repository = new TestEntityRepository(context);

        var created = await repository.Create(new TestEntity { Name = "alpha" });
        created.Id.Should().BeGreaterThan(0);
        created.Enable.Should().BeTrue();
        created.CreatedDate.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(5));

        (await repository.Exists(created.Id)).Should().BeTrue();
        (await repository.FindByID(created.Id)).Name.Should().Be("alpha");
        (await repository.FindAsync(created.Id)).Should().NotBeNull();
        await repository.FindExistsByID(created.Id);

        created.Name = "beta";
        var updated = await repository.Update(created);
        updated.Name.Should().Be("beta");
        updated.ModifyDate.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(5));

        await repository.Create(new TestEntity { Name = "gamma" });
        (await repository.FindAll()).Should().HaveCount(2);
        (await repository.FindByCustomWhere(x => x.Name == "beta")).Should().ContainSingle();
        (await repository.FindByCustomWhereWithIncludes(x => x.Enable)).Should().HaveCount(2);
        (await repository.GetCount(x => x.Id > 0)).Should().Be(2);

        (await repository.EnableOrDisable(created.Id)).Should().BeTrue();
        (await repository.FindByID(created.Id)).Enable.Should().BeFalse();

        (await repository.Delete(created.Id)).Should().BeTrue();
        (await repository.Exists(created.Id)).Should().BeFalse();
    }

    [Test]
    public async Task Update_MissingEntity_Throws()
    {
        await using var context = CreateContext();
        var repository = new TestEntityRepository(context);

        var act = async () => await repository.Update(new TestEntity { Id = 999, Name = "missing" });
        await act.Should().ThrowAsync<InvalidOperationException>().WithMessage("Register not found");
    }

    [Test]
    public async Task FindById_WithIncludeActionAndExpressions_ReturnsEntity()
    {
        await using var context = CreateContext();
        var repository = new TestEntityRepository(context);
        var entity = await repository.Create(new TestEntity { Name = "include" });

        var byAction = await repository.FindByID(entity.Id, _ => { });
        var byIncludes = await repository.FindByID(entity.Id);

        using (Assert.EnterMultipleScope())
        {
            byAction.Name.Should().Be("include");
            byIncludes.Name.Should().Be("include");
            (await repository.FindAsync(entity.Id)).Should().NotBeNull();
        }
    }

    [Test]
    public async Task DatasetConstructor_UsesInjectedDbSet()
    {
        await using var context = CreateContext();
        var repository = new TestEntityRepository(context.Entities, context);
        var created = await repository.Create(new TestEntity { Name = "ctor" });
        (await repository.FindByID(created.Id)).Name.Should().Be("ctor");
    }

    [Test]
    public void DatasetConstructor_NullDataset_Throws()
    {
        var act = () => new TestEntityRepository(null!, null);
        act.Should().Throw<ArgumentNullException>();
    }

    private static TestDbContext CreateContext()
    {
        var options = new DbContextOptionsBuilder<TestDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString("N"))
            .Options;
        return new TestDbContext(options);
    }

    private sealed class TestEntity : EntityBase
    {
        public string Name { get; set; } = string.Empty;
    }

    private sealed class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options) { }
        public DbSet<TestEntity> Entities => Set<TestEntity>();
    }

    private sealed class TestEntityRepository : GenericRepositoryEntityBase<TestEntity>
    {
        public TestEntityRepository(DbContext context) : base(context) { }
        public TestEntityRepository(DbSet<TestEntity> dataset, DbContext? context) : base(dataset, context) { }
    }
}
