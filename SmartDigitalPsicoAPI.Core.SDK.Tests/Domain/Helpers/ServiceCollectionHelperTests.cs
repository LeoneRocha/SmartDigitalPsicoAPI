using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using System.Reflection;

namespace SmartDigitalPsicoAPI.Core.SDK.Tests.Helpers;

[TestFixture]
public class ServiceCollectionHelperTests
{
    [Test]
    public void FilterItems_FiltersProvidedSets_ReturnsRemainingItems()
    {
        // CenÃ¡rio: uma sequÃªncia contÃ©m itens em dois filtros.
        // Objetivo: remover todos os itens filtrados.
        // Arrange
        var items = new[] { 1, 2, 3, 4 };

        // Act
        var result = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.ServiceCollectionHelper.FilterItems(items, [2], [4]);

        // Assert
        result.Should().BeEquivalentTo([1, 3]);
    }

    [Test]
    public void GetRegisteredInterfaces_ScopedServices_ReturnsOnlyScopedTypes()
    {
        // CenÃ¡rio: a coleÃ§Ã£o possui serviÃ§os com escopos distintos.
        // Objetivo: retornar exclusivamente interfaces scoped.
        // Arrange
        IServiceCollection services = new ServiceCollection();
        services.AddScoped<ITestRepository, TestRepository>();
        services.AddSingleton<ITestService, TestService>();

        // Act
        var result = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.ServiceCollectionHelper.GetRegisteredInterfaces(services);

        // Assert
        result.Should().Contain(typeof(ITestRepository));
        result.Should().NotContain(typeof(ITestService));
    }

    [Test]
    public void GetInterfaces_MatchingSuffix_ReturnsInterfaceAndImplementation()
    {
        // CenÃ¡rio: o assembly possui classes com e sem sufixo de repositÃ³rio.
        // Objetivo: localizar somente implementaÃ§Ãµes com interface correspondente.
        // Arrange
        var assembly = Assembly.GetExecutingAssembly();

        // Act
        var result = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.ServiceCollectionHelper.GetInterfaces(["Repository"], assembly);

        // Assert
        result.Should().ContainSingle(x => x.InterfaceType == typeof(ITestRepository) && x.ImplementationType == typeof(TestRepository));
    }

    [Test]
    public void RegisterInterfaces_IgnoredInterface_RegistersOnlyEligibleServices()
    {
        // CenÃ¡rio: uma interface encontrada estÃ¡ na lista de exclusÃ£o.
        // Objetivo: registrar somente implementaÃ§Ãµes permitidas como scoped.
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.ServiceCollectionHelper.RegisterInterfaces(services, ["Repository"], [typeof(IIgnoredRepository)], [Assembly.GetExecutingAssembly()]);

        // Assert
        services.Should().ContainSingle(x => x.ServiceType == typeof(ITestRepository) && x.ImplementationType == typeof(TestRepository) && x.Lifetime == ServiceLifetime.Scoped);
        services.Should().NotContain(x => x.ServiceType == typeof(IIgnoredRepository));
    }

    public interface ITestRepository;
    public interface IIgnoredRepository;
    public interface ITestService;
    public sealed class TestRepository : ITestRepository;
    public sealed class IgnoredRepository : IIgnoredRepository;
    public sealed class TestService : ITestService;
}


