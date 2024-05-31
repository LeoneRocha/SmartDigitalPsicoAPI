using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Moq;
using SmartDigitalPsico.Data.Repository.CacheManager;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Domains;

namespace SmartDigitalPsico.Data.Test.Repository.CacheManager
{
    [TestFixture]
    public class MemoryCacheRepositoryTests
    {
        private MemoryCacheRepository? _memoryCacheRepository;
        private IOptions<CacheConfigurationVO>? _cacheConfig;
        private readonly string cacheKey = "GendercacheKey";

        [SetUp]
        public void Setup()
        {
            _memoryCacheRepository = getSetupRepo();
        }

        private MemoryCacheRepository getSetupRepo()
        {
            var cacheConfig = new CacheConfigurationVO
            {
                IsEnable = true,
                TypeCache = Domain.Enuns.ETypeLocationCache.Memory,
                ExtensionCache = ".json",
                PathCache = "./ResourcesTempCache",
                AbsoluteExpirationInHours = 1,
                AbsoluteExpirationInMinutes = 30,
                SlidingExpirationInMinutes = 15
                // Adicione outras propriedades conforme necessário
            };

            // Criar uma instância de IOptions<CacheConfigurationVO> usando Moq
            var mockOptions = new Mock<IOptions<CacheConfigurationVO>>();
            mockOptions.Setup(o => o.Value).Returns(cacheConfig);

            _cacheConfig = mockOptions.Object;

            var memoryCache = new MemoryCache(new MemoryCacheOptions());

            _memoryCacheRepository = new MemoryCacheRepository(memoryCache, _cacheConfig);

            return _memoryCacheRepository;
        }

        [Test]
        public void TryGet_KeyExists_ReturnsTrue()
        {
            // Arrange
            _memoryCacheRepository = getSetupRepo();

            var mockData = GenderMockHelper.GetMock().AsQueryable().ToArray();

            _memoryCacheRepository.Set(cacheKey, mockData);

            // Act
            var result = _memoryCacheRepository.TryGet<Gender[]>(cacheKey, out var actualValue);

            // Assert
            Assert.That(result, Is.True);
            Assert.That(actualValue, Is.EqualTo(mockData));
        }
        [Test]
        public void Set_ValidInput_ReturnsTrue()
        {
            // Arrange
            _memoryCacheRepository = getSetupRepo();

            var mockData = GenderMockHelper.GetMock().AsQueryable().ToArray();

            // Act
            var result = _memoryCacheRepository.Set(cacheKey, mockData);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void Remove_KeyExists_ReturnsTrue()
        {
            // Arrange 
            _memoryCacheRepository = getSetupRepo();

            var mockData = GenderMockHelper.GetMock().AsQueryable().ToArray();

            _memoryCacheRepository.Set(cacheKey, mockData);

            // Act
            var result = _memoryCacheRepository.Remove(cacheKey);

            // Assert
            Assert.That(result, Is.True);
        } 
    }
}
