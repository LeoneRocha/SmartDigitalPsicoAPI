using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Localization;
using Moq;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Service.Test.TestSupport;
using System.Globalization;
using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.Test.DataEntity.SystemDomains;

[TestFixture]
public class ApplicationLanguageServiceTests
{
    // Cenário: consulta de todos os idiomas com o cache desabilitado.
    // Objetivo: buscar diretamente no repositório e retornar a lista mapeada.
    [Test]
    public async Task FindAll_CacheDisabled_ReturnsMappedList()
    {
        // Arrange
        var context = new ApplicationLanguageServiceContext();
        context.Cache.Setup(x => x.IsEnable()).Returns(false);
        context.Repository.Setup(x => x.FindAll()).ReturnsAsync(new List<ApplicationLanguage>
        {
            new() { Id = 1, Language = "en-US", LanguageKey = "key", LanguageValue = "value" }
        });

        // Act
        var result = await context.Service.FindAll();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().ContainSingle();
        }
    }

    // Cenário: recuperação de uma chave de localização já existente na base de dados.
    // Objetivo: retornar o valor persistido sem inserir um novo registro.
    [Test]
    public async Task GetLocalization_KeyExistsInDatabase_ReturnsStoredValue()
    {
        // Arrange
        var context = new ApplicationLanguageServiceContext();
        context.Cache.Setup(x => x.IsEnable()).Returns(false);
        context.Repository.Setup(x => x.ExistLanguage(It.IsAny<string>(), "SomeKey", "SharedResource")).ReturnsAsync(true);
        context.Repository.Setup(x => x.Find(It.IsAny<string>(), "SomeKey", "SharedResource")).ReturnsAsync(new ApplicationLanguage { LanguageValue = "Valor Armazenado" });

        // Act
        var result = await context.Service.GetLocalization<ISharedResource>("SomeKey", "Default", context.Cache.Object);

        // Assert
        result.Should().Be("Valor Armazenado");
    }

    // Cenário: recuperação de uma chave de localização inexistente.
    // Objetivo: inserir o idioma padrão e retornar uma mensagem de fallback.
    [Test]
    public async Task GetLocalization_KeyNotFound_InsertsDefaultLanguageAndReturnsFallback()
    {
        // Arrange
        var context = new ApplicationLanguageServiceContext();
        context.Cache.Setup(x => x.IsEnable()).Returns(false);
        context.Repository.Setup(x => x.ExistLanguage(It.IsAny<string>(), "MissingKey", "SharedResource")).ReturnsAsync(false);
        context.Repository.Setup(x => x.ExistLanguage("en-US", "MissingKey", "SharedResource")).ReturnsAsync(false);
        context.Repository.Setup(x => x.Create(It.IsAny<ApplicationLanguage>())).ReturnsAsync((ApplicationLanguage a) => { a.Id = 5; return a; });

        // Act
        var result = await context.Service.GetLocalization<ISharedResource>("MissingKey", "Default Message", context.Cache.Object);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Should().Contain("MissingKey");
            result.Should().Contain("Default Message");
        }
        context.Repository.Verify(x => x.Create(It.IsAny<ApplicationLanguage>()), Times.Once);
    }

    // Cenário: falha inesperada durante a consulta de localização.
    // Objetivo: capturar a exceção e retornar uma mensagem de fallback controlada.
    [Test]
    public async Task GetLocalization_RepositoryThrows_ReturnsControlledFallback()
    {
        // Arrange
        var context = new ApplicationLanguageServiceContext();
        context.Cache.Setup(x => x.IsEnable()).Returns(false);
        context.Repository.Setup(x => x.ExistLanguage(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).ThrowsAsync(new InvalidOperationException("boom"));

        // Act
        var result = await context.Service.GetLocalization<ISharedResource>("BrokenKey", "Default", context.Cache.Object);

        // Assert
        result.Should().Contain("BrokenKey");
    }

    // Cenário: persistência de um novo idioma padrão.
    // Objetivo: mapear e criar o registro através do repositório.
    [Test]
    public async Task Save_ValidItem_CreatesEntity()
    {
        // Arrange
        var context = new ApplicationLanguageServiceContext();
        context.Repository.Setup(x => x.Create(It.IsAny<ApplicationLanguage>())).ReturnsAsync((ApplicationLanguage a) => { a.Id = 9; return a; });

        // Act
        await context.Service.Save(new SmartDigitalPsico.Domain.DTO.Application.ADD.AddApplicationLanguageDto
        {
            Language = "en-US",
            LanguageKey = "key",
            LanguageValue = "value",
            ResourceKey = "SharedResource"
        });

        // Assert
        context.Repository.Verify(x => x.Create(It.IsAny<ApplicationLanguage>()), Times.Once);
    }

    // Cenário: remoção do cache de idiomas com o cache desabilitado.
    // Objetivo: não realizar nenhuma operação de remoção.
    [Test]
    public async Task RemoveCache_CacheDisabled_DoesNothing()
    {
        // Arrange
        var context = new ApplicationLanguageServiceContext();
        context.Cache.Setup(x => x.IsEnable()).Returns(false);

        // Act
        await context.Service.RemoveCache("SomeKey");

        // Assert
        context.Cache.Verify(x => x.Remove<object>(It.IsAny<string>()), Times.Never);
    }

    // Cenário: FindAll com cache habilitado e dados ausentes no cache.
    // Objetivo: buscar no repositório e persistir o resultado em cache.
    [Test]
    public async Task FindAll_CacheEnabledMiss_LoadsFromRepositoryAndCaches()
    {
        // Arrange
        var context = new ApplicationLanguageServiceContext();
        context.Cache.Setup(x => x.IsEnable()).Returns(true);
        context.Cache.Setup(x => x.GetSlidingExpiration()).Returns(DateTime.UtcNow.AddMinutes(30));
        context.Cache.Setup(x => x.TryGet(It.IsAny<string>(), out It.Ref<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetApplicationLanguageDto>>>.IsAny))
            .Returns(false);
        context.Cache.Setup(x => x.Set(It.IsAny<string>(), It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetApplicationLanguageDto>>>())).Returns(true);
        context.Repository.Setup(x => x.FindAll()).ReturnsAsync([new ApplicationLanguage { Id = 1, Language = "pt-BR", LanguageKey = "k", LanguageValue = "v", ResourceKey = "SharedResource" }]);

        // Act
        var result = await context.Service.FindAll();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().ContainSingle();
        }
        context.Cache.Verify(x => x.Set("FindAll_GetApplicationLanguageVO", It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetApplicationLanguageDto>>>()), Times.Once);
    }

    // Cenário: FindAll com cache habilitado e dados já presentes.
    // Objetivo: retornar dados cacheados sem consultar o repositório.
    [Test]
    public async Task FindAll_CacheEnabledHit_ReturnsCachedData()
    {
        // Arrange
        var context = new ApplicationLanguageServiceContext();
        var cached = new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetApplicationLanguageDto>>(
            new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<List<GetApplicationLanguageDto>> { Data = [new GetApplicationLanguageDto { Id = 99 }], Success = true },
            "FindAll_GetApplicationLanguageVO",
            DateTime.UtcNow.AddMinutes(30));
        context.Cache.Setup(x => x.IsEnable()).Returns(true);
        SetupTryGetCacheHit(context.Cache, "FindAll_GetApplicationLanguageVO", cached);

        // Act
        var result = await context.Service.FindAll();

        // Assert
        result.Data.Should().ContainSingle(x => x.Id == 99);

        context.Repository.Verify(x => x.FindAll(), Times.Never);
    }

    // Cenário: chave encontrada no cache de localização pela cultura atual.
    // Objetivo: retornar o valor cacheado sem consultar o banco.
    [Test]
    public async Task GetLocalization_KeyFoundInCache_ReturnsCachedValue()
    {
        // Arrange
        var context = new ApplicationLanguageServiceContext();
        var culture = CultureInfo.CurrentCulture.Name;
        var cached = new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetApplicationLanguageDto>>(
            new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<List<GetApplicationLanguageDto>>
            {
                Data =
                [
                    new GetApplicationLanguageDto { Language = culture, LanguageKey = "Welcome", LanguageValue = "Olá", ResourceKey = "SharedResource" }
                ],
                Success = true
            },
            "FindAll_GetApplicationLanguageVO",
            DateTime.UtcNow.AddMinutes(30));
        context.Cache.Setup(x => x.IsEnable()).Returns(true);
        context.Cache.Setup(x => x.Exists<GetApplicationLanguageDto>("FindAll_GetApplicationLanguageVO")).Returns(true);
        SetupTryGetCacheHit(context.Cache, "FindAll_GetApplicationLanguageVO", cached);

        // Act
        var result = await context.Service.GetLocalization<ISharedResource>("Welcome", "Default", context.Cache.Object);

        // Assert
        result.Should().Be("Olá");

        context.Repository.Verify(x => x.ExistLanguage(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Never);
    }

    // Cenário: chave ausente na cultura atual, mas presente em en-US no cache.
    // Objetivo: retornar fallback de cultura padrão do cache.
    [Test]
    public async Task GetLocalization_FallbackToEnUsInCache_ReturnsDefaultCultureValue()
    {
        // Arrange
        var context = new ApplicationLanguageServiceContext();
        var cached = new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetApplicationLanguageDto>>(
            new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<List<GetApplicationLanguageDto>>
            {
                Data =
                [
                    new GetApplicationLanguageDto { Language = "en-US", LanguageKey = "Greeting", LanguageValue = "Hello", ResourceKey = "SharedResource" }
                ],
                Success = true
            },
            "FindAll_GetApplicationLanguageVO",
            DateTime.UtcNow.AddMinutes(30));
        context.Cache.Setup(x => x.IsEnable()).Returns(true);
        context.Cache.Setup(x => x.Exists<GetApplicationLanguageDto>("FindAll_GetApplicationLanguageVO")).Returns(true);
        SetupTryGetCacheHit(context.Cache, "FindAll_GetApplicationLanguageVO", cached);
        context.Repository.Setup(x => x.ExistLanguage(It.IsAny<string>(), "Greeting", "SharedResource")).ReturnsAsync(false);
        context.Repository.Setup(x => x.ExistLanguage("en-US", "Greeting", "SharedResource")).ReturnsAsync(false);
        context.Repository.Setup(x => x.Create(It.IsAny<ApplicationLanguage>())).ReturnsAsync((ApplicationLanguage a) => { a.Id = 1; return a; });

        // Act
        var result = await context.Service.GetLocalization<ISharedResource>("Greeting", "Fallback", context.Cache.Object);

        // Assert
        result.Should().Be("Hello");
    }

    // Cenário: idioma padrão já existe ao inserir chave ausente.
    // Objetivo: não duplicar registro e retornar valor existente.
    [Test]
    public async Task GetLocalization_DefaultLanguageAlreadyExists_SkipsInsert()
    {
        // Arrange
        var context = new ApplicationLanguageServiceContext();
        context.Cache.Setup(x => x.IsEnable()).Returns(false);
        context.Repository.Setup(x => x.ExistLanguage(It.IsAny<string>(), "ExistingDefault", "SharedResource")).ReturnsAsync(false);
        context.Repository.Setup(x => x.ExistLanguage("en-US", "ExistingDefault", "SharedResource")).ReturnsAsync(true);

        // Act
        var result = await context.Service.GetLocalization<ISharedResource>("ExistingDefault", "Default Msg", context.Cache.Object);

        // Assert
        result.Should().BeEmpty();

        context.Repository.Verify(x => x.Create(It.IsAny<ApplicationLanguage>()), Times.Never);
    }

    // Cenário: falha ao inserir idioma padrão durante localização.
    // Objetivo: registrar erro e retornar fallback controlado.
    [Test]
    public async Task GetLocalization_InsertDefaultThrows_LogsAndReturnsFallback()
    {
        // Arrange
        var context = new ApplicationLanguageServiceContext();
        context.Cache.Setup(x => x.IsEnable()).Returns(false);
        context.Repository.Setup(x => x.ExistLanguage(It.IsAny<string>(), "BrokenInsert", "SharedResource")).ReturnsAsync(false);
        context.Repository.Setup(x => x.ExistLanguage("en-US", "BrokenInsert", "SharedResource")).ReturnsAsync(false);
        // Save() engole a exceção do Create e registra Error; o fluxo segue com mensagem default.
        context.Repository.Setup(x => x.Create(It.IsAny<ApplicationLanguage>())).ThrowsAsync(new InvalidOperationException("db error"));

        // Act
        var result = await context.Service.GetLocalization<ISharedResource>("BrokenInsert", "Default", context.Cache.Object);

        // Assert
        result.Should().Be("NotFoundLocalizationButInsertedDefault|BrokenInsert|Default");
        context.Context.Logger.Verify(
            x => x.Error(It.IsAny<Exception>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>()),
            Times.AtLeastOnce);
    }

    // Cenário: ExistLanguage do default en-US lança exceção.
    // Objetivo: cobrir catch de InsertLanguageNotFound.
    [Test]
    public async Task GetLocalization_ExistDefaultLanguageThrows_LogsAndReturnsEmpty()
    {
        // Arrange
        var previous = System.Globalization.CultureInfo.CurrentCulture;
        System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");
        try
        {
            var context = new ApplicationLanguageServiceContext();
            context.Cache.Setup(x => x.IsEnable()).Returns(false);
            context.Repository.Setup(x => x.ExistLanguage("pt-BR", "BrokenExist", "SharedResource")).ReturnsAsync(false);
            context.Repository.Setup(x => x.ExistLanguage("en-US", "BrokenExist", "SharedResource"))
                .ThrowsAsync(new InvalidOperationException("exist failed"));

            // Act
            var result = await context.Service.GetLocalization<ISharedResource>("BrokenExist", "Default", context.Cache.Object);

            // Assert
            result.Should().BeEmpty();
            context.Context.Logger.Verify(
                x => x.Error(It.IsAny<Exception>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>()),
                Times.Once);
        }
        finally
        {
            System.Globalization.CultureInfo.CurrentCulture = previous;
        }
    }

    // Cenário: remoção de cache habilitada.
    // Objetivo: invocar remoção no serviço de cache.
    [Test]
    public async Task RemoveCache_CacheEnabled_RemovesEntry()
    {
        // Arrange
        var context = new ApplicationLanguageServiceContext();
        context.Cache.Setup(x => x.IsEnable()).Returns(true);
        context.Cache.Setup(x => x.Remove<GetApplicationLanguageDto>("FindAll_GetApplicationLanguageVO")).Returns(true);

        // Act
        await context.Service.RemoveCache("FindAll_GetApplicationLanguageVO");

        // Assert
        context.Cache.Verify(x => x.Remove<GetApplicationLanguageDto>("FindAll_GetApplicationLanguageVO"), Times.Once);
    }

    // Cenário: SaveCache com overwrite após inserir idioma padrão.
    // Objetivo: recarregar cache quando chave ausente e cache habilitado.
    [Test]
    public async Task GetLocalization_NewKeyWithCacheEnabled_RefreshesCacheAfterInsert()
    {
        // Arrange
        var context = new ApplicationLanguageServiceContext();
        context.Cache.Setup(x => x.IsEnable()).Returns(true);
        context.Cache.Setup(x => x.Exists<GetApplicationLanguageDto>("FindAll_GetApplicationLanguageVO")).Returns(false);
        context.Cache.Setup(x => x.GetSlidingExpiration()).Returns(DateTime.UtcNow.AddMinutes(30));
        context.Cache.Setup(x => x.Set(It.IsAny<string>(), It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetApplicationLanguageDto>>>())).Returns(true);
        context.Cache.Setup(x => x.Remove<GetApplicationLanguageDto>("FindAll_GetApplicationLanguageVO")).Returns(true);
        context.Cache.Setup(x => x.TryGet(It.IsAny<string>(), out It.Ref<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetApplicationLanguageDto>>>.IsAny))
            .Returns(false);
        context.Repository.Setup(x => x.ExistLanguage(It.IsAny<string>(), "CacheRefresh", "SharedResource")).ReturnsAsync(false);
        context.Repository.Setup(x => x.ExistLanguage("en-US", "CacheRefresh", "SharedResource")).ReturnsAsync(false);
        context.Repository.Setup(x => x.Create(It.IsAny<ApplicationLanguage>())).ReturnsAsync((ApplicationLanguage a) => { a.Id = 8; return a; });
        context.Repository.Setup(x => x.FindAll()).ReturnsAsync([]);

        // Act
        var result = await context.Service.GetLocalization<ISharedResource>("CacheRefresh", "Default", context.Cache.Object);

        // Assert
        result.Should().Contain("CacheRefresh");

        context.Repository.Verify(x => x.FindAll(), Times.AtLeast(2));
    }

    // Cenário: helper estático com IStringLocalizer.
    // Objetivo: retornar a string localizada pela chave informada.
    [Test]
    public async Task GetLocalizationStatic_WithLocalizer_ReturnsLocalizedString()
    {
        // Arrange
        var localizer = new Mock<IStringLocalizer<ISharedResource>>();
        localizer.Setup(x => x["Welcome"]).Returns(new LocalizedString("Welcome", "Bem-vindo"));

        // Act
        var result = await ApplicationLanguageService.GetLocalization<ISharedResource>("Welcome", localizer.Object);

        // Assert
        result.Should().Be("Bem-vindo");
    }

    private static void SetupTryGetCacheHit(
        Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService> cache,
        string key,
        global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetApplicationLanguageDto>> cached)
    {
        cache.Setup(x => x.TryGet(key, out It.Ref<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetApplicationLanguageDto>>>.IsAny))
            .Returns((string _, out global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetApplicationLanguageDto>> value) =>
            {
                value = cached;
                return true;
            });
    }

    private sealed class ApplicationLanguageServiceContext
    {
        public ServiceTestContext Context { get; } = new();
        public Mock<IApplicationLanguageRepository> Repository => Context.ApplicationLanguageRepository;
        public Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService> Cache => Context.Cache;
        public Mock<IValidator<ApplicationLanguage>> Validator { get; } = new();
        public ApplicationLanguageService Service { get; }

        public ApplicationLanguageServiceContext()
        {
            Validator.Setup(x => x.ValidateAsync(It.IsAny<ApplicationLanguage>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
            Service = new ApplicationLanguageService(
                Context.SharedServices,
                Context.Config,
                Context.SharedRepositories,
                Repository.Object,
                Validator.Object);
        }
    }
}
