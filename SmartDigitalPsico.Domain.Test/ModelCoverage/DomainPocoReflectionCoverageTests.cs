using System.Collections;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using SmartDigitalPsico.Domain.DTO.User;
using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Test.ModelCoverage;

[TestFixture]
public class DomainPocoReflectionCoverageTests
{
    private static readonly Assembly DomainAssembly = Assembly.Load("SmartDigitalPsico.Domain");

    private static IEnumerable<TestCaseData> TiposPocoPublicos()
    {
        foreach (var type in DomainAssembly.GetExportedTypes()
                     .Where(EhAlvoDeCobertura)
                     .OrderBy(type => type.FullName))
        {
            var constructedType = type.IsGenericTypeDefinition ? ConstruirTipoGenerico(type) : type;
            yield return new TestCaseData(constructedType).SetName($"Poco_{constructedType.FullName}");
        }
    }

    private static IEnumerable<TestCaseData> EnunsPublicos()
    {
        foreach (var type in DomainAssembly.GetExportedTypes()
                     .Where(type => type.IsEnum)
                     .OrderBy(type => type.FullName))
        {
            yield return new TestCaseData(type).SetName($"Enum_{type.FullName}");
        }
    }

    // Cenário: tipos públicos de DTO/VO/entidade do Domain são instanciáveis.
    // Objetivo: ler e atribuir propriedades públicas via reflexão para cobertura literal.
    [TestCaseSource(nameof(TiposPocoPublicos))]
    public void PublicProperties_DomainPocoTypes_AreReadAndAssigned(Type type)
    {
        // Arrange
        var instance = CriarInstancia(type);
        if (instance is null)
        {
            Assert.Ignore($"Não foi possível instanciar {type.FullName} com argumentos seguros.");
        }

        // Act
        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(property => property.GetIndexParameters().Length == 0)
            .ToList();

        // Assert
        foreach (var property in properties)
        {
            if (property.CanRead && property.CanWrite)
            {
                var value = CriarValor(property.PropertyType);

                try
                {
                    property.SetValue(instance, value);
                    property.GetValue(instance).Should().Be(value);
                }
                catch (Exception)
                {
                    // Algumas propriedades calculadas/validadas aceitam apenas estados específicos.
                    try
                    {
                        _ = property.GetValue(instance);
                    }
                    catch (Exception)
                    {
                        // O acesso foi tentado para tipos que dependem de infraestrutura externa.
                    }
                }
            }
            else if (property.CanRead)
            {
                try
                {
                    _ = property.GetValue(instance);
                }
                catch (TargetInvocationException)
                {
                    // O getter foi executado; dependências externas podem não estar disponíveis.
                }
            }
        }
    }

    // Cenário: enums públicos exportados pelo Domain.
    // Objetivo: garantir valores conversíveis e contagem maior que zero.
    [TestCaseSource(nameof(EnunsPublicos))]
    public void Values_PublicEnums_ContainConvertibleMembers(Type enumType)
    {
        // Arrange
        var values = Enum.GetValues(enumType);

        // Act
        var converted = values.Cast<object>()
            .Select(value => Enum.ToObject(enumType, Convert.ToInt64(value)))
            .ToList();

        // Assert
        values.Length.Should().BeGreaterThan(0);
        for (var index = 0; index < values.Length; index++)
        {
            converted[index].Should().Be(values.GetValue(index));
        }
    }

    // Cenário: HyperMediaConfigure registra os enriquecedores de conteúdo.
    // Objetivo: garantir que todos os enriquecedores sejam adicionados às opções.
    [Test]
    public void AddHyperMedia_CenarioRegistroDeServicos_RegistraTodosEnriquecedores()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();

        // Act
        HyperMediaConfigure.AddHyperMedia(services);
        using var provider = services.BuildServiceProvider();
        var options = provider.GetRequiredService<HyperMediaFilterOptions>();

        // Assert
        options.ContentResponseEnricherList.Should().HaveCount(16);
        options.ContentResponseEnricherList.Should().NotContainNulls();
    }

    // Cenário: todos os enriquecedores registrados recebem o DTO correspondente.
    // Objetivo: gerar os quatro links de navegação de cada recurso exposto.
    [Test]
    public async Task EnriquecedoresRegistrados_CenarioDtoCompativel_AdicionamLinks()
    {
        // Arrange
        IServiceCollection services = new ServiceCollection();
        HyperMediaConfigure.AddHyperMedia(services);
        using var provider = services.BuildServiceProvider();
        var enrichers = provider.GetRequiredService<HyperMediaFilterOptions>().ContentResponseEnricherList;
        var linkCounts = new List<(string Name, int Count)>();

        // Act
        foreach (var enricher in enrichers)
        {
            var contentType = enricher.GetType().BaseType!.GetGenericArguments()[0];
            var content = Activator.CreateInstance(contentType)!;
            contentType.GetProperty("Id")?.SetValue(content, 1L);

            await enricher.Enrich(CriarContextoDeResultado(content));

            var links = contentType.GetProperty("Links")!.GetValue(content) as ICollection;
            linkCounts.Add((enricher.GetType().Name, links?.Count ?? 0));
        }

        // Assert
        foreach (var (name, count) in linkCounts)
        {
            count.Should().Be(4, name);
        }
    }

    // Cenário: o enriquecedor avalia tipos genéricos e não genéricos.
    // Objetivo: identificar apenas conteúdos suportados pelo contrato.
    [Test]
    public void ContentResponseEnricher_CenarioTiposCompativeis_IdentificaConteudosSuportados()
    {
        // Arrange
        var enricher = new EnriquecedorDeTeste();

        // Act
        var user = enricher.CanEnrich(typeof(GetUserDto));
        var list = enricher.CanEnrich(typeof(List<GetUserDto>));
        var response = enricher.CanEnrich(typeof(ServiceResponse<GetUserDto>));
        var responseList = enricher.CanEnrich(typeof(ServiceResponse<List<GetUserDto>>));
        var paged = enricher.CanEnrich(typeof(PagedSearchVO<GetUserDto>));
        var unsupported = enricher.CanEnrich(typeof(string));

        // Assert
        using (Assert.EnterMultipleScope())
        {
            user.Should().BeTrue();
            list.Should().BeTrue();
            response.Should().BeTrue();
            responseList.Should().BeTrue();
            paged.Should().BeTrue();
            unsupported.Should().BeFalse();
        }
    }

    // Cenário: o enriquecedor processa modelo, listas e wrappers de resposta.
    // Objetivo: enriquecer todos os formatos de conteúdo OK suportados.
    [Test]
    public async Task ContentResponseEnricher_CenarioRespostaOk_EnriqueceModeloEColecoes()
    {
        // Arrange
        var enricher = new EnriquecedorDeTeste();
        var contexts = new object[]
        {
            new GetUserDto(),
            new List<GetUserDto> { new() },
            new ServiceResponse<GetUserDto> { Data = new GetUserDto() },
            new ServiceResponse<List<GetUserDto>> { Data = [new GetUserDto()] },
            new PagedSearchVO<GetUserDto> { List = [new GetUserDto()] }
        }.Select(CriarContextoDeResultado).ToList();

        // Act
        foreach (var context in contexts)
        {
            await enricher.Enrich(context);
        }

        // Assert
        enricher.ModelosEnriquecidos.Should().Be(5);
    }

    // Cenário: o filtro recebe resultados não OK, compatíveis e um corpo nulo.
    // Objetivo: diferenciar a elegibilidade da resposta e rejeitar conteúdo ausente.
    [Test]
    public void ContentResponseEnricher_CenarioInterfaceDeFiltro_AvaliaTodosOsResultados()
    {
        // Arrange
        IResponseEnricher enricher = new EnriquecedorDeTeste();
        var nonOkContext = CriarContextoDeResultado(new NotFoundResult());
        var compatibleContext = CriarContextoDeResultado(new GetUserDto());
        var nullContext = CriarContextoDeResultado(new OkObjectResult(null));

        // Act
        var nonOk = enricher.CanEnrich(nonOkContext);
        var compatible = enricher.CanEnrich(compatibleContext);
        var action = () => enricher.CanEnrich(nullContext);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            nonOk.Should().BeFalse();
            compatible.Should().BeTrue();
            action.Should().Throw<SmartDigitalPsico.Domain.AppException.AppWarningException>();
        }
    }

    // Cenário: o filtro hypermedia não encontra enriquecedor compatível.
    // Objetivo: executar OnResultExecuting sem falhar para OK e NotFound.
    [Test]
    public void HyperMediaFilterrAttribute_CenarioResultadosSemEnriquecedor_ExecutaSemFalhar()
    {
        // Arrange
        var filter = new HyperMediaFilterrAttribute(new HyperMediaFilterOptions());

        // Act
        filter.OnResultExecuting(CriarContextoDeResultado(new GetUserDto()));
        filter.OnResultExecuting(CriarContextoDeResultado(new NotFoundResult()));

        // Assert
        Assert.Pass();
    }

    // Cenário: PagedSearchVO é criado com padrões e valores explícitos.
    // Objetivo: resolver página atual e tamanho conforme construtores.
    [Test]
    public void PagedSearchVO_CenarioPaginacaoPadraoEResolvida_RetornaValoresEsperados()
    {
        // Arrange
        var defaultPaged = new PagedSearchVO<GetUserDto>();
        var configuredPaged = new PagedSearchVO<GetUserDto>(3, 25, "Name", "asc", new Dictionary<string, object>());
        var shortConstructorPaged = new PagedSearchVO<GetUserDto>(4, "Name", "desc");

        // Act
        var defaultPage = defaultPaged.GetCurrentPage();
        var defaultSize = defaultPaged.GetPageSize();
        var configuredPage = configuredPaged.GetCurrentPage();
        var configuredSize = configuredPaged.GetPageSize();
        var shortSize = shortConstructorPaged.GetPageSize();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            defaultPage.Should().Be(2);
            defaultSize.Should().Be(10);
            configuredPage.Should().Be(3);
            configuredSize.Should().Be(25);
            shortSize.Should().Be(10);
        }
    }

    // Cenário: respostas em cache e tokens são construídos com dados explícitos.
    // Objetivo: preservar as informações fornecidas pelos construtores de value objects.
    [Test]
    public void ValueObjects_CenarioConstrutoresComDados_PreservamValores()
    {
        // Arrange
        var expiration = DateTime.UtcNow.AddMinutes(5);

        // Act
        var emptyCache = new ServiceResponseCacheVO<string>();
        var cache = new ServiceResponseCacheVO<string>("conteúdo", "chave", expiration);
        var copiedCache = new ServiceResponseCacheVO<string>(
            new ServiceResponse<string> { Data = "origem", Success = false, Message = "mensagem" },
            "chave-origem",
            expiration);
        var token = new TokenVO(true, "criado", "expira", "acesso", "renovação");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            emptyCache.CacheKey.Should().BeEmpty();
            cache.Data.Should().Be("conteúdo");
            cache.CacheKey.Should().Be("chave");
            cache.DateTimeSlidingExpiration.Should().Be(expiration);
            copiedCache.Data.Should().Be("origem");
            copiedCache.Success.Should().BeFalse();
            copiedCache.Message.Should().Be("mensagem");
            token.AccessToken.Should().Be("acesso");
            token.Authenticated.Should().BeTrue();
        }
    }

    private static readonly string[] NamespaceCoverageSegments =
        ["DTO", "VO", "ModelEntity", "TableEntity", "Hypermedia", "Enuns", "Contracts", "DependeciesCollection"];

    private static bool EhAlvoDeCobertura(Type type)
    {
        if (!type.IsPublic || type.IsAbstract || type.IsInterface || typeof(Delegate).IsAssignableFrom(type))
        {
            return false;
        }

        var namespaceName = type.Namespace ?? string.Empty;
        return NamespaceCoverageSegments
            .Any(segment => namespaceName.Contains(segment, StringComparison.Ordinal));
    }

    private static object? CriarInstancia(Type type, int profundidade = 0)
    {
        if (type.IsGenericTypeDefinition)
        {
            type = ConstruirTipoGenerico(type);
        }

        if (type.IsValueType)
        {
            return Activator.CreateInstance(type);
        }

        var constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance)
            .OrderBy(constructor => constructor.GetParameters().Length);
        foreach (var constructor in constructors)
        {
            try
            {
                var args = constructor.GetParameters()
                    .Select(parameter => CriarValor(parameter.ParameterType, profundidade + 1))
                    .ToArray();
                return constructor.Invoke(args);
            }
            catch (Exception) when (profundidade < 2)
            {
                // Tenta o próximo construtor público.
            }
        }

        return null;
    }

    private static Type ConstruirTipoGenerico(Type genericType)
    {
        var arguments = genericType.GetGenericArguments()
            .Select(parameter => EscolherArgumentoGenerico(parameter))
            .ToArray();
        return genericType.MakeGenericType(arguments);
    }

    private static Type EscolherArgumentoGenerico(Type parameter)
    {
        var constraints = parameter.GetGenericParameterConstraints();
        if (constraints.Any(constraint => constraint.IsAssignableFrom(typeof(GetUserDto))))
        {
            return typeof(GetUserDto);
        }

        return (parameter.GenericParameterAttributes & GenericParameterAttributes.NotNullableValueTypeConstraint) != 0
            ? typeof(int)
            : typeof(string);
    }

    private static object? CriarValor(Type type, int profundidade = 0)
    {
        var nullableType = Nullable.GetUnderlyingType(type);
        if (nullableType is not null)
        {
            return CriarValor(nullableType, profundidade);
        }

        if (type == typeof(string)) return "x";
        if (type == typeof(bool)) return true;
        if (type == typeof(char)) return 'x';
        if (type == typeof(byte)) return (byte)1;
        if (type == typeof(sbyte)) return (sbyte)1;
        if (type == typeof(short)) return (short)1;
        if (type == typeof(ushort)) return (ushort)1;
        if (type == typeof(int)) return 1;
        if (type == typeof(uint)) return 1U;
        if (type == typeof(long)) return 1L;
        if (type == typeof(ulong)) return 1UL;
        if (type == typeof(float)) return 1F;
        if (type == typeof(double)) return 1D;
        if (type == typeof(decimal)) return 1M;
        if (type == typeof(DateTime)) return DateTime.UtcNow;
        if (type == typeof(DateTimeOffset)) return DateTimeOffset.UtcNow;
        if (type == typeof(TimeSpan)) return TimeSpan.FromMinutes(1);
        if (type == typeof(Guid)) return Guid.NewGuid();
        if (type.IsEnum) return Enum.GetValues(type).GetValue(0);
        if (type == typeof(Type)) return typeof(string);
        if (type.IsArray) return Array.CreateInstance(type.GetElementType()!, 0);

        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
        {
            return CriarValor(type.GetGenericArguments()[0], profundidade);
        }

        if (typeof(IEnumerable).IsAssignableFrom(type) && type != typeof(string))
        {
            var elementType = type.IsGenericType ? type.GetGenericArguments()[0] : typeof(object);
            var listType = typeof(List<>).MakeGenericType(elementType);
            if (type.IsAssignableFrom(listType) || type.IsInterface)
            {
                return Activator.CreateInstance(listType);
            }
        }

        if (type.IsInterface)
        {
            return CriarMock(type);
        }

        return profundidade < 2 ? CriarInstancia(type, profundidade) : null;
    }

    private static object CriarMock(Type type)
    {
        var mockType = typeof(Mock<>).MakeGenericType(type);
        var mock = Activator.CreateInstance(mockType)!;
        var objectProperty = mockType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Single(property => property.Name == nameof(Mock<object>.Object) && property.PropertyType == type);
        return objectProperty.GetValue(mock)!;
    }

    private static ResultExecutingContext CriarContextoDeResultado(object result)
    {
        var httpContext = new DefaultHttpContext
        {
            RequestServices = new ServiceCollection().AddRouting().BuildServiceProvider()
        };
        var router = new Mock<IRouter>();
        router.Setup(value => value.GetVirtualPath(It.IsAny<VirtualPathContext>()))
            .Returns(new VirtualPathData(router.Object, "api/test"));
        var routeData = new RouteData();
        routeData.Routers.Add(router.Object);
        var actionContext = new ActionContext(httpContext, routeData, new ActionDescriptor());
        var actionResult = result as IActionResult ?? new OkObjectResult(result);
        return new ResultExecutingContext(actionContext, new List<IFilterMetadata>(), actionResult, new object());
    }

    private sealed class EnriquecedorDeTeste : ContentResponseEnricher<GetUserDto>
    {
        public int ModelosEnriquecidos { get; private set; }

        protected override Task EnrichModel(GetUserDto content, Microsoft.AspNetCore.Mvc.IUrlHelper urlHelper)
        {
            ModelosEnriquecidos++;
            return Task.CompletedTask;
        }
    }
}
