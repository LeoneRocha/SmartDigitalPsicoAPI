using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Moq;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Domain.EntityModels;
namespace SmartDigitalPsico.Data.Test.Repository.CacheManager
{
    [TestFixture]
    public class MemoryCacheRepositoryTests
    {
        private SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.MemoryCacheRepository? _memoryCacheRepository;
        private IOptions<SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto>? _cacheConfig;
        private readonly string cacheKey = "GendercacheKey";

        [SetUp]
        public void Setup()
        {
            _memoryCacheRepository = getSetupRepo();
        }

        private SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.MemoryCacheRepository getSetupRepo()
        {
            var cacheConfig = new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
            {
                IsEnable = true,
                TypeCache = SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Memory,
                ExtensionCache = ".json",
                PathCache = "./ResourcesTempCache",
                AbsoluteExpirationInHours = 1,
                AbsoluteExpirationInMinutes = 30,
                SlidingExpirationInMinutes = 15
            };
            var mockOptions = new Mock<IOptions<SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto>>();
            mockOptions.Setup(o => o.Value).Returns(cacheConfig);

            _cacheConfig = mockOptions.Object;

            var memoryCache = new MemoryCache(new MemoryCacheOptions());

            _memoryCacheRepository = new SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.MemoryCacheRepository(memoryCache, _cacheConfig);

            return _memoryCacheRepository;
        }

        // Cenário: a chave já existe no cache em memória.
        // Objetivo: retornar true e o valor armazenado ao consultar a chave.
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
            using (Assert.EnterMultipleScope())
            {
                Assert.That(result, Is.True);
                Assert.That(actualValue, Is.EqualTo(mockData));
            }
        }

        // Cenário: entrada válida é enviada para o cache em memória.
        // Objetivo: confirmar que Set persiste o valor com sucesso.
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

        // Cenário: a chave já existe no cache em memória.
        // Objetivo: confirmar que Remove remove a entrada com sucesso.
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
