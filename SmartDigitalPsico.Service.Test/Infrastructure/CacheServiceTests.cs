using SmartDigitalPsico.Service.Audit;
using Microsoft.Extensions.Options;
using Moq;

using SmartDigitalPsico.Domain.Interfaces.Application;
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
public class CacheServiceTests
{
    // Cenário: operações Set/Get/Exists/Remove no cache em memória.
    // Objetivo: invocar o repositório e respeitar configuração de expiração.
    [Test]
    public void MemoryCache_SetGetExistsRemove_Succeeds()
    {
        // Arrange
        var memory = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository>();
        var expected = new CacheValue { Value = "value" };
        memory.Setup(x => x.Set("customer", expected)).Returns(true);
        memory.Setup(x => x.TryGet("customer", out It.Ref<CacheValue?>.IsAny)).Returns((string _, out CacheValue? value) =>
        {
            value = expected;
            return true;
        });
        memory.Setup(x => x.Remove("customer")).Returns(true);
        var service = Create(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Memory, memory: memory);

        // Act
        var set = service.Set("customer", expected);
        var exists = service.Exists<CacheValue>("customer");
        var found = service.TryGet("customer", out CacheValue value);
        var removed = service.Remove<CacheValue>("customer");

        // Assert
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
    // Cenário: gravação de payload no cache em disco.
    // Objetivo: persistir valor e criar log de cache.
    [Test]
    public void DiskCache_SavePayload_WritesCacheLog()
    {
        // Arrange
        var disk = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository>();
        var logs = new Mock<IApplicationCacheLogRepository>();
        disk.Setup(x => x.SetAsync("payload", It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<string>>())).ReturnsAsync(true);
        logs.Setup(x => x.Create(It.IsAny<SmartDigitalPsico.Domain.EntityModels.ApplicationCacheLog>()))
            .ReturnsAsync(new SmartDigitalPsico.Domain.EntityModels.ApplicationCacheLog());
        var service = Create(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Disk, disk: disk, logs: logs);
        var payload = new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<string>("data", "payload", DateTime.Now.AddMinutes(10));

        // Act
        var result = service.Set("payload", payload);

        // Assert
        result.Should().BeTrue();

        disk.Verify(x => x.SetAsync("payload", payload), Times.Once);
        logs.Verify(x => x.Create(It.IsAny<SmartDigitalPsico.Domain.EntityModels.ApplicationCacheLog>()), Times.Once);
    }
    // Cenário: helpers estáticos com cache habilitado.
    // Objetivo: salvar e ler global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO com sucesso.
    [Test]
    public async Task StaticCacheHelpers_EnabledCache_SavesAndReads()
    {
        // Arrange
        var cache = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService>();
        cache.Setup(x => x.GetSlidingExpiration()).Returns(DateTime.Now.AddMinutes(5));
        cache.Setup(x => x.Set("result", It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<int>>())).Returns(true);
        cache.Setup(x => x.IsEnable()).Returns(true);
        cache.Setup(x => x.TryGet("result", out It.Ref<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<int>>.IsAny))
            .Returns((string _, out global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<int> item) =>
            {
                item = new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<int>(42, "result", DateTime.Now.AddMinutes(5));
                return true;
            });

        // Act
        await SmartDigitalPsico.Service.Infrastructure.Cache.CacheService.SaveDataToCache("result", 42, cache.Object);
        var result = await SmartDigitalPsico.Service.Infrastructure.Cache.CacheService.GetDataFromCache<int>(cache.Object, "result");

        // Assert
        result.Data.Should().Be(42);

        cache.Verify(x => x.Set("result", It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<int>>()), Times.Once);
    }
    // Cenário: backend sem suporte ou falha no repositório de disco.
    // Objetivo: retornar false sem lançar exceção.
    [Test]
    public void UnsupportedCacheAndRepositoryFailures_Failures_ReturnFalseWithoutThrowing()
    {
        // Arrange
        var disk = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository>();
        disk.Setup(x => x.TryGetAsync<CacheValue>(It.IsAny<string>())).ThrowsAsync(new InvalidOperationException());
        var service = Create(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Disk, disk: disk);
        var unsupported = Create(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.AzureRedis);

        // Act
        var exists = service.Exists<CacheValue>(null);
        var found = service.TryGet<CacheValue>(null, out var value);

        // Assert
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
    [TestCase(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.MongoDB)]
    [TestCase(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.AzureStorage)]
    [TestCase(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.AzureCosmoDB)]
    [TestCase(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.AzureRedis)]
    [TestCase((global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache)999)]
    public void UnsupportedLocation_SetExistsRemoveTryGet_NoThrow(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache type)
    {
        // Arrange
        var service = Create(type);

        // Act
        var set = service.Set("k", new CacheValue { Value = "v" });
        var exists = service.Exists<CacheValue>("k");
        var tryGet = service.TryGet<CacheValue>("k", out _);
        var removed = service.Remove<CacheValue>("k");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            set.Should().BeFalse();
            exists.Should().BeFalse();
            tryGet.Should().BeFalse();
            removed.Should().BeFalse();
        }
    }

    // Cenário: cache em disco expirado e valor nulo.
    // Objetivo: cobrir checkCacheIsValid e processCacheRepositoryDisk false.
    [Test]
    public void DiskCache_ExpiredAndNullValue_CoversValidationBranches()
    {
        // Arrange
        var disk = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository>();
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
        var service = Create(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Disk, disk: disk, logs: logs);

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
        var disk = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository>();
        disk.Setup(x => x.TryGetAsync<NullDataCacheEntry>("null-data"))
            .ReturnsAsync(new KeyValuePair<bool, NullDataCacheEntry>(true, new NullDataCacheEntry()));
        disk.Setup(x => x.TryGetAsync<NoDataPropertyCacheEntry>("no-data-prop"))
            .ReturnsAsync(new KeyValuePair<bool, NoDataPropertyCacheEntry>(true, new NoDataPropertyCacheEntry()));
        var service = Create(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Disk, disk: disk);

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

    private static SmartDigitalPsico.Service.Infrastructure.Cache.CacheService Create(
        global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache type,
        Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository>? memory = null,
        Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository>? disk = null,
        Mock<IApplicationCacheLogRepository>? logs = null)
        => new(
            (memory ?? new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository>()).Object,
            (disk ?? new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository>()).Object,
            (logs ?? new Mock<IApplicationCacheLogRepository>()).Object,
            Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
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
