using SmartDigitalPsico.Data.ConfigureFluentAPI.Mock;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Resiliency;

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

        [Test]
        public async Task FindAll_Success()
        {
            // Arrange
            var mockDataList = RoleGroupMockData.GetMock().Take(6).AsQueryable();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new RoleGroupRepository(_mockContext, new PolicyConfig());

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = listResult.Count;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<RoleGroup>>());
                Assert.That(listResult, Has.Count.EqualTo(6));
                Assert.That(listCount, Is.EqualTo(6));
            });
        }

        [Test]
        public async Task FindByIDs_Success()
        {
            // Arrange
            var roleGroupIds = new List<long> { 1, 2, 3 };

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new RoleGroupRepository(_mockContext, new PolicyConfig());

            // Act
            var result = await _entityRepository.FindByIDs(roleGroupIds);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.Not.Null);
                Assert.That(result, Is.InstanceOf<List<RoleGroup>>());
                Assert.That(result, Has.Count.EqualTo(3));
            });
        }
    }
}