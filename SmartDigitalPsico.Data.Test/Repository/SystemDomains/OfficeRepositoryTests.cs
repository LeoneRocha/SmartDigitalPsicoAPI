using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Resiliency;

namespace SmartDigitalPsico.Data.Test.Repository.SystemDomains
{
    [TestFixture]
    public class OfficeRepositoryTests : BaseTests
    {
        private OfficeRepository? _entityRepository;

        [SetUp]
        public override void Setup()
        {
            var mockData = OfficeMockData.GetMock().Take(3).AsQueryable();
            // Arrange 
            SetupContext(mockData);
        }
        private void SetupContext(IQueryable<Office> mockData)
        {
            var mockDataList = mockData.ToList();
            // Arrange
            _mockContext = new SmartDigitalPsicoDataContextTest();

            _mockContext.Offices.AddRange(mockDataList);
            _mockContext.SaveChanges();
        }

        [Test]
        public async Task FindAll_Success()
        {
            // Arrange
            var mockDataList = OfficeMockData.GetMock().Take(3).AsQueryable();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new OfficeRepository(_mockContext);

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = listResult.Count;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<Office>>());
                Assert.That(listResult, Has.Count.EqualTo(3));
                Assert.That(listCount, Is.EqualTo(3));
            });
        }

    }
}