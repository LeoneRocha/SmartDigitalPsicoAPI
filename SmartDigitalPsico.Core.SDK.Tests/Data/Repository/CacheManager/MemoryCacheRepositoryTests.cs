using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Moq;
using SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager;
using SmartDigitalPsico.Core.SDK.Domain.ModelEntity;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;

namespace SmartDigitalPsico.Core.SDK.Tests.Repository.CacheManager
{
    [TestFixture]
    public class MemoryCacheRepositoryTests
    {
        private MemoryCacheRepository? _memoryCacheRepository;
        private IOptions<CacheConfigurationDto>? _cacheConfig;
        private readonly string cacheKey = "GendercacheKey";

        [SetUp]
        public void Setup()
        {
            _memoryCacheRepository = getSetupRepo();
        }

        private MemoryCacheRepository getSetupRepo()
        {
            var cacheConfig = new CacheConfigurationDto
            {
                IsEnable = true,
                TypeCache = SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Memory,
                ExtensionCache = ".json",
                PathCache = "./ResourcesTempCache",
                AbsoluteExpirationInHours = 1,
                AbsoluteExpirationInMinutes = 30,
                SlidingExpirationInMinutes = 15 
            }; 
            var mockOptions = new Mock<IOptions<CacheConfigurationDto>>();
            mockOptions.Setup(o => o.Value).Returns(cacheConfig);

            _cacheConfig = mockOptions.Object;

            var memoryCache = new MemoryCache(new MemoryCacheOptions());

            _memoryCacheRepository = new MemoryCacheRepository(memoryCache, _cacheConfig);

            return _memoryCacheRepository;
        }

        // CenÃƒÂ¡rio: a chave jÃƒÂ¡ existe no cache em memÃƒÂ³ria.
        // Objetivo: retornar true e o valor armazenado ao consultar a chave.
        [Test]
        public void TryGet_KeyExists_ReturnsTrue()
        {
            // Arrange
            _memoryCacheRepository = getSetupRepo();

            var mockData = new TestEntity[] { new TestEntity { Id = 1 } };

            _memoryCacheRepository.Set(cacheKey, mockData);

            // Act
            var result = _memoryCacheRepository.TryGet<TestEntity[]>(cacheKey, out var actualValue);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.True);
                Assert.That(actualValue, Is.EqualTo(mockData));
            }
        }

        // CenÃƒÂ¡rio: entrada vÃƒÂ¡lida ÃƒÂ© enviada para o cache em memÃƒÂ³ria.
        // Objetivo: confirmar que Set persiste o valor com sucesso.
        [Test]
        public void Set_ValidInput_ReturnsTrue()
        {
            // Arrange
            _memoryCacheRepository = getSetupRepo();

            var mockData = new TestEntity[] { new TestEntity { Id = 1 } };

            // Act
            var result = _memoryCacheRepository.Set(cacheKey, mockData);

            // Assert
            Assert.That(result, Is.True);
        }

        // CenÃƒÂ¡rio: a chave jÃƒÂ¡ existe no cache em memÃƒÂ³ria.
        // Objetivo: confirmar que Remove remove a entrada com sucesso.
        [Test]
        public void Remove_KeyExists_ReturnsTrue()
        {
            // Arrange 
            _memoryCacheRepository = getSetupRepo();

            var mockData = new TestEntity[] { new TestEntity { Id = 1 } };

            _memoryCacheRepository.Set(cacheKey, mockData);

            // Act
            var result = _memoryCacheRepository.Remove(cacheKey);

            // Assert
            Assert.That(result, Is.True);
        }
    }
}



    public class TestEntity { public int Id { get; set; } }
