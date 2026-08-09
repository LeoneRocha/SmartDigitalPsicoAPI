using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Tests.Context;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Test.Repository.SystemDomains
{
    [TestFixture]
    public class RoleGroupRepositoryTests : BaseTests
    {
        private RoleGroupRepository? _entityRepository;

        [SetUp]
        public override void Setup()
        {
            var mockData = RoleGroupMockData.GetMock().Take(6).AsQueryable();
            // Arrange 
            SetupContext(mockData);
        }
        private void SetupContext(IQueryable<RoleGroup> mockData)
        {
            var mockDataList = mockData.ToList();
            // Arrange
            _mockContext = new SmartDigitalPsicoDataContextTest();

            _mockContext.RoleGroups.AddRange(mockDataList);
            _mockContext.SaveChanges();
        }

        // Cenário: existem role groups persistidos no contexto.
        // Objetivo: retornar a lista completa via FindAll.
        [Test]
        public async Task FindAll_WhenDataExists_ReturnsAllRoleGroups()
        {
            // Arrange
            var mockDataList = RoleGroupMockData.GetMock().Take(6).AsQueryable();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new RoleGroupRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = listResult.Count;

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<RoleGroup>>());
                Assert.That(listResult, Has.Count.EqualTo(6));
                Assert.That(listCount, Is.EqualTo(6));
            }
        }

        // Cenário: busca por um subconjunto de IDs existentes.
        // Objetivo: retornar apenas os role groups correspondentes.
        [Test]
        public async Task FindByIDs_MatchingIds_ReturnsMatchingRoleGroups()
        {
            // Arrange
            var roleGroupIds = new List<long> { 1, 2, 3 };

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new RoleGroupRepository(_mockContext);

            // Act
            var result = await _entityRepository.FindByIDs(roleGroupIds);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<List<RoleGroup>>());
                Assert.That(result, Has.Count.EqualTo(3));
            }
        }

        // Cenário: lista de IDs nula.
        // Objetivo: cobrir retorno antecipado de FindByIDs.
        [Test]
        public async Task FindByIDs_NullIds_ReturnsEmptyList()
        {
            // Arrange
            _entityRepository = new RoleGroupRepository(_mockContext!);

            // Act
            var result = await _entityRepository.FindByIDs(null);

            // Assert
            result.Should().BeEmpty();
        }
    }
}
