using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Data.Tests.Context;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Resiliency;

namespace SmartDigitalPsico.Data.Test.Repository.SystemDomains
{
    [TestFixture]
    public class ApplicationCacheLogRepositoryTests : BaseTests
    {
        private ApplicationCacheLogRepository? _entityRepository;

        [SetUp]
        public override void Setup()
        {
            var mockData = ApplicationCacheLogMockHelper.GetMock().Take(1).AsQueryable();
            // Arrange 
            SetupContext(mockData);
        }
        private void SetupContext(IQueryable<ApplicationCacheLog> mockData)
        {
            var mockDataList = mockData.ToList();
            // Arrange
            _mockContext = new SmartDigitalPsicoDataContextTest();

            _mockContext.ApplicationCacheLogs.AddRange(mockDataList);
            _mockContext.SaveChanges();
        }

        [Test]
        public async Task FindAll_Success()
        {
            // Arrange
            var mockDataList = ApplicationCacheLogMockHelper.GetMock().Take(1).AsQueryable().ToList();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new ApplicationCacheLogRepository(_mockContext, new PolicyConfig());;

            // Act
            var listResult = await _entityRepository.FindAll();
            var listCount = listResult.Count;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(listResult, Is.Not.Null);
                Assert.That(listResult, Is.InstanceOf<List<ApplicationCacheLog>>());
                Assert.That(listResult, Has.Count.EqualTo(1));
                Assert.That(listCount, Is.EqualTo(1));
                Assert.That(mockDataList, Has.Count.EqualTo(1));
            });
        }

        [Test]
        public async Task Delete_Success()
        {
            // Arrange
            var mockDataList = ApplicationCacheLogMockHelper.GetMock().Take(1).AsQueryable().ToList();
            var existingEnity = mockDataList[0];
            existingEnity.Id = 2;
            existingEnity.CacheKey = Guid.NewGuid().ToString();

            // Inicialize  Repository
            _mockContext = _mockContext ?? new SmartDigitalPsicoDataContextTest();
            _entityRepository = new ApplicationCacheLogRepository(_mockContext, new PolicyConfig());;

            _mockContext.ApplicationCacheLogs.Add(existingEnity);
            await _mockContext.SaveChangesAsync();

            // Act
            var result = await _entityRepository.Delete(existingEnity.CacheKey);

            var target = await _mockContext.ApplicationCacheLogs.FirstOrDefaultAsync(x => x.CacheKey.Equals(existingEnity.CacheKey, StringComparison.OrdinalIgnoreCase));

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True);
                Assert.That(target, Is.Null);
            });
        }
    }
}