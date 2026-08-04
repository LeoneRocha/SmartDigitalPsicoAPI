using Microsoft.Extensions.Options;
using Moq;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.Infrastructure.CacheManager;

namespace SmartDigitalPsico.Service.Test.Infrastructure;

[TestFixture]
public class CacheServiceTests
{
    [Test]
    public void MemoryCache_InvokesSetGetExistsRemoveAndConfigurationMethods()
    {
        var memory = new Mock<IMemoryCacheRepository>();
        var expected = new CacheValue { Value = "value" };
        memory.Setup(x => x.Set("customer", expected)).Returns(true);
        memory.Setup(x => x.TryGet("customer", out It.Ref<CacheValue?>.IsAny)).Returns((string _, out CacheValue? value) =>
        {
            value = expected;
            return true;
        });
        memory.Setup(x => x.Remove("customer")).Returns(true);
        var service = Create(ETypeLocationCache.Memory, memory: memory);

        var set = service.Set("customer", expected);
        var exists = service.Exists<CacheValue>("customer");
        var found = service.TryGet("customer", out CacheValue value);
        var removed = service.Remove<CacheValue>("customer");

        using (Assert.EnterMultipleScope())
        {
            set.Should().BeTrue();
            exists.Should().BeTrue();
            found.Should().BeTrue();
            value.Value.Should().Be("value");
            removed.Should().BeTrue();
            service.IsEnable().Should().BeTrue();
            service.GetSlidingExpiration().Should().BeAfter(DateTime.Now);
        }
        memory.Verify(x => x.Set("customer", expected), Times.Once);
        memory.Verify(x => x.Remove("customer"), Times.Once);
    }

    [Test]
    public void DiskCache_SavesPayloadAndWritesCacheLog()
    {
        var disk = new Mock<IDiskCacheRepository>();
        var logs = new Mock<IApplicationCacheLogRepository>();
        disk.Setup(x => x.SetAsync("payload", It.IsAny<ServiceResponseCacheVO<string>>())).ReturnsAsync(true);
        logs.Setup(x => x.Create(It.IsAny<SmartDigitalPsico.Domain.ModelEntity.ApplicationCacheLog>()))
            .ReturnsAsync(new SmartDigitalPsico.Domain.ModelEntity.ApplicationCacheLog());
        var service = Create(ETypeLocationCache.Disk, disk: disk, logs: logs);
        var payload = new ServiceResponseCacheVO<string>("data", "payload", DateTime.Now.AddMinutes(10));

        var result = service.Set("payload", payload);

        result.Should().BeTrue();
        disk.Verify(x => x.SetAsync("payload", payload), Times.Once);
        logs.Verify(x => x.Create(It.IsAny<SmartDigitalPsico.Domain.ModelEntity.ApplicationCacheLog>()), Times.Once);
    }

    [Test]
    public async Task StaticCacheHelpers_SaveAndReadEnabledCache()
    {
        var cache = new Mock<ICacheService>();
        cache.Setup(x => x.GetSlidingExpiration()).Returns(DateTime.Now.AddMinutes(5));
        cache.Setup(x => x.Set("result", It.IsAny<ServiceResponseCacheVO<int>>())).Returns(true);
        cache.Setup(x => x.IsEnable()).Returns(true);
        cache.Setup(x => x.TryGet("result", out It.Ref<ServiceResponseCacheVO<int>>.IsAny))
            .Returns((string _, out ServiceResponseCacheVO<int> item) =>
            {
                item = new ServiceResponseCacheVO<int>(42, "result", DateTime.Now.AddMinutes(5));
                return true;
            });

        await CacheService.SaveDataToCache("result", 42, cache.Object);
        var result = await CacheService.GetDataFromCache<int>(cache.Object, "result");

        result.Data.Should().Be(42);
        cache.Verify(x => x.Set("result", It.IsAny<ServiceResponseCacheVO<int>>()), Times.Once);
    }

    [Test]
    public void UnsupportedCacheAndRepositoryFailures_ReturnFalseWithoutThrowing()
    {
        var disk = new Mock<IDiskCacheRepository>();
        disk.Setup(x => x.TryGetAsync<CacheValue>(It.IsAny<string>())).ThrowsAsync(new InvalidOperationException());
        var service = Create(ETypeLocationCache.Disk, disk: disk);
        var unsupported = Create(ETypeLocationCache.AzureRedis);

        var exists = service.Exists<CacheValue>(null);
        var found = service.TryGet<CacheValue>(null, out var value);

        using (Assert.EnterMultipleScope())
        {
            exists.Should().BeFalse();
            found.Should().BeFalse();
            value.Should().NotBeNull();
            unsupported.Set("anything", "value").Should().BeFalse();
            unsupported.Remove<string>("anything").Should().BeFalse();
        }
    }

    // Cenário: backends de cache ainda não implementados.
    // Objetivo: cobrir braços vazios do switch em Set/Exists/Remove/TryGet.
    [TestCase(ETypeLocationCache.MongoDB)]
    [TestCase(ETypeLocationCache.AzureStorage)]
    [TestCase(ETypeLocationCache.AzureCosmoDB)]
    [TestCase(ETypeLocationCache.AzureRedis)]
    [TestCase((ETypeLocationCache)999)]
    public void UnsupportedLocation_SetExistsRemoveTryGet_NoThrow(ETypeLocationCache type)
    {
        // Arrange
        var service = Create(type);

        // Act / Assert
        using (Assert.EnterMultipleScope())
        {
            service.Set("k", new CacheValue { Value = "v" }).Should().BeFalse();
            service.Exists<CacheValue>("k").Should().BeFalse();
            service.TryGet<CacheValue>("k", out _).Should().BeFalse();
            service.Remove<CacheValue>("k").Should().BeFalse();
        }
    }

    // Cenário: cache em disco expirado e valor nulo.
    // Objetivo: cobrir checkCacheIsValid e processCacheRepositoryDisk false.
    [Test]
    public void DiskCache_ExpiredAndNullValue_CoversValidationBranches()
    {
        // Arrange
        var disk = new Mock<IDiskCacheRepository>();
        var logs = new Mock<IApplicationCacheLogRepository>();
        var expired = new ExpirableCacheEntry
        {
            Data = "x",
            DateTimeSlidingExpiration = DateTime.Now.AddMinutes(-5).ToString("yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
        };
        disk.Setup(x => x.TryGetAsync<ExpirableCacheEntry>("k"))
            .ReturnsAsync(new KeyValuePair<bool, ExpirableCacheEntry>(true, expired));
        disk.Setup(x => x.RemoveAsync("k")).ReturnsAsync(true);
        logs.Setup(x => x.Delete("k")).ReturnsAsync(true);
        var service = Create(ETypeLocationCache.Disk, disk: disk, logs: logs);

        // Act
        var existsExpired = service.Exists<ExpirableCacheEntry>("k");
        var setNull = service.Set<string>("null-key", null!);
        var valid = new ExpirableCacheEntry
        {
            Data = "ok",
            DateTimeSlidingExpiration = DateTime.Now.AddMinutes(10).ToString("yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
        };
        disk.Setup(x => x.TryGetAsync<ExpirableCacheEntry>("valid"))
            .ReturnsAsync(new KeyValuePair<bool, ExpirableCacheEntry>(true, valid));
        var existsValid = service.Exists<ExpirableCacheEntry>("valid");
        var tryGetValid = service.TryGet("valid", out ExpirableCacheEntry loaded);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            existsExpired.Should().BeFalse();
            setNull.Should().BeFalse();
            existsValid.Should().BeTrue();
            tryGetValid.Should().BeTrue();
            loaded.Data.Should().Be("ok");
        }
        disk.Verify(x => x.RemoveAsync("k"), Times.AtLeastOnce);
    }

    // Cenário: entrada em disco com propriedade Data nula.
    // Objetivo: cobrir retorno false após valorData == null.
    [Test]
    public void DiskCache_NullDataProperty_ReturnsExistsFalse()
    {
        // Arrange
        var disk = new Mock<IDiskCacheRepository>();
        disk.Setup(x => x.TryGetAsync<NullDataCacheEntry>("null-data"))
            .ReturnsAsync(new KeyValuePair<bool, NullDataCacheEntry>(true, new NullDataCacheEntry()));
        disk.Setup(x => x.TryGetAsync<NoDataPropertyCacheEntry>("no-data-prop"))
            .ReturnsAsync(new KeyValuePair<bool, NoDataPropertyCacheEntry>(true, new NoDataPropertyCacheEntry()));
        var service = Create(ETypeLocationCache.Disk, disk: disk);

        // Act
        var existsNullData = service.Exists<NullDataCacheEntry>("null-data");
        var existsMissingProp = service.Exists<NoDataPropertyCacheEntry>("no-data-prop");

        // Assert — Data nulo invalida o cache; propriedade Data ausente usa sentinel e permanece válida.
        using (Assert.EnterMultipleScope())
        {
            existsNullData.Should().BeFalse();
            existsMissingProp.Should().BeTrue();
        }
    }

    private static CacheService Create(
        ETypeLocationCache type,
        Mock<IMemoryCacheRepository>? memory = null,
        Mock<IDiskCacheRepository>? disk = null,
        Mock<IApplicationCacheLogRepository>? logs = null)
        => new(
            (memory ?? new Mock<IMemoryCacheRepository>()).Object,
            (disk ?? new Mock<IDiskCacheRepository>()).Object,
            (logs ?? new Mock<IApplicationCacheLogRepository>()).Object,
            Options.Create(new CacheConfigurationDto
            {
                TypeCache = type,
                IsEnable = true,
                AbsoluteExpirationInHours = 1,
                SlidingExpirationInMinutes = 5
            }));
}

public sealed class CacheValue
{
    public string Value { get; set; } = string.Empty;
}

public sealed class ExpirableCacheEntry
{
    public string Data { get; set; } = string.Empty;
    public string DateTimeSlidingExpiration { get; set; } = string.Empty;
}

public sealed class NullDataCacheEntry
{
    public string? Data { get; set; }
    public string DateTimeSlidingExpiration { get; set; } = DateTime.Now.AddMinutes(10).ToString("yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
}

public sealed class NoDataPropertyCacheEntry
{
    public string DateTimeSlidingExpiration { get; set; } = DateTime.Now.AddMinutes(10).ToString("yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
}
