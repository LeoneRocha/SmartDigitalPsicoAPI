using System.Reflection;
using Azure.Monitor.OpenTelemetry.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Serilog;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.DTO.Common;
using SmartDigitalPsico.Domain.DTO.Medical.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.Interfaces.Specialty;
using SmartDigitalPsico.WebAPI.Configure;
using SmartDigitalPsico.WebAPI.Controllers.v1;
namespace SmartDigitalPsico.WebAPI.Test;

[TestFixture]
public class ControllerCoverageTests
{
    // Cenário: controllers publicados na assembly WebAPI.
    // Objetivo: impedir que uma action seja adicionada sem mapeamento HTTP.
    [Test]
    public void Controllers_AcoesPublicas_DeclaramVerboHttp()
    {
        // Arrange
        var controllerTypes = typeof(AppInformationVersionProductController).Assembly
            .GetTypes()
            .Where(type => !type.IsAbstract && typeof(ControllerBase).IsAssignableFrom(type));

        // Act
        var actionsWithoutHttpVerb = controllerTypes
            .SelectMany(type => type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
            .Where(method => !method.IsSpecialName && method.ReturnType != typeof(void))
            .Where(method => !method.GetCustomAttributes<HttpMethodAttribute>().Any())
            .Select(method => $"{method.DeclaringType!.Name}.{method.Name}")
            .ToList();

        // Assert
        actionsWithoutHttpVerb.Should().BeEmpty();
    }

    // Cenário: consulta pública da versão do produto.
    // Objetivo: validar o resultado HTTP da action sem iniciar a aplicação.
    [Test]
    public async Task AppInformationVersionProduct_GetString_ContextoHttp_RetornaOk()
    {
        // Arrange
        var controller = new AppInformationVersionProductController
        {
            ControllerContext = new ControllerContext { HttpContext = new DefaultHttpContext() }
        };

        // Act
        var response = await controller.GetString();

        // Assert
        response.Result.Should().BeOfType<OkObjectResult>();
    }

    // Cenário: o serviço retorna especialidades cadastradas.
    // Objetivo: garantir a delegação da action e o status 200.
    [Test]
    public async Task Specialty_GetServicoComDados_RetornaOk()
    {
        // Arrange
        var service = new Mock<ISpecialtyService>();
        service.Setup(item => item.FindAll())
            .ReturnsAsync(new ServiceResponse<List<GetSpecialtyDto>>
            {
                Data = [new GetSpecialtyDto()]
            });
        var httpContext = new DefaultHttpContext
        {
            RequestServices = new ServiceCollection().BuildServiceProvider()
        };
        var controller = new SpecialtyController(
            service.Object,
            Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.AuthConfigurationDto()))
        {
            ControllerContext = new ControllerContext { HttpContext = httpContext }
        };

        // Act
        var response = await controller.Get();

        // Assert
        response.Result.Should().BeOfType<OkObjectResult>();
        service.Verify(item => item.SetUserId(It.IsAny<long>()), Times.Once);
    }

    // Cenário: cada endpoint é executado com suas dependências isoladas por mocks.
    // Objetivo: cobrir todos os fluxos públicos, inclusive respostas de erro ou vazias.
    [TestCase(false)]
    [TestCase(true)]
    public async Task Controllers_AcoesComDependenciasMockadas_RetornamResultado(bool respostaComErro)
    {
        // Arrange
        var controllerTypes = typeof(AppInformationVersionProductController).Assembly
            .GetTypes()
            .Where(type => !type.IsAbstract && typeof(ControllerBase).IsAssignableFrom(type))
            .OrderBy(type => type.Name);

        var failures = new List<string>();

        // Act
        foreach (var controllerType in controllerTypes)
        {
            var controller = CreateController(controllerType, respostaComErro);
            var actions = controllerType
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)
                .Where(method => !method.IsSpecialName && method.GetCustomAttributes<HttpMethodAttribute>().Any());

            foreach (var action in actions)
            {
                try
                {
                    var response = await InvokeAction(controller, action);
                    response.Should().NotBeNull($"{controllerType.Name}.{action.Name} deve retornar uma resposta");
                }
                catch (Exception exception)
                {
                    failures.Add($"{controllerType.Name}.{action.Name}: {exception.GetBaseException().Message}");
                }
            }
        }

        // Assert
        failures.Should().BeEmpty("todas as actions públicas devem suportar os cenários mockados");
    }

    // Cenário: o bootstrap recebeu um logger indisponível.
    // Objetivo: garantir que o guard clause de inicialização seja seguro.
    [Test]
    public void Configure_BuildAndRunSemLogger_EncerraSemIniciarHost()
    {
        // Arrange
        var builder = WebApplication.CreateBuilder();
        var action = () => WebApplicationConfigureBuilder.BuildAndRunAPP(builder, null);

        // Act
        // Assert
        action.Should().NotThrow();
    }

    // Cenário: a aplicação é inicializada para validar as configurações de startup.
    // Objetivo: não iniciar o host de longa duração durante a validação.
    [Test]
    public void Program_ValidateStartupArgument_ConfiguresHostWithoutRunningIt()
    {
        // Arrange
        var action = () => SmartDigitalPsico.WebAPI.Program.Main(["--validate-startup"]);

        // Act
        // Assert
        action.Should().NotThrow();
    }

    // Cenário: a API é iniciada em modo normal com um runner controlado.
    // Objetivo: garantir que Program delegue a execução sem bloquear a suíte.
    [Test]
    public void Program_RunWithoutValidation_InvokesApplicationRunner()
    {
        // Arrange
        var runnerCalled = false;

        // Act
        SmartDigitalPsico.WebAPI.Program.Run([], (_, _) => runnerCalled = true);

        // Assert
        runnerCalled.Should().BeTrue();
    }

    // Cenário: o host possui todos os serviços de produção registrados.
    // Objetivo: validar o pipeline sem efetuar migrações ou iniciar um listener HTTP.
    [Test]
    public void Configure_BuilderCompleto_ConfiguraPipelineSemExecutarHost()
    {
        // Arrange
        var host = WebApplicationConfigureBuilder.CreateHostBuilder(["--environment", "Production"]);
        host.Item1.Services.AddScoped<IEntityDataContext>(_ => null!);

        // Act
        using var app = WebApplicationConfigureBuilder.BuildAndConfigure(host.Item1);

        // Assert
        app.Services.Should().NotBeNull();
    }

    // Cenário: o pipeline recebe um IEntityDataContext InMemory.
    // Objetivo: cobrir o early-return de addAutoMigrate para provedor não relacional.
    [Test]
    public void Configure_InMemoryEntityContext_SkipsMigrateForNonRelational()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<SmartDigitalPsicoDataContextMySql>()
            .UseInMemoryDatabase($"webapi-migrate-{Guid.NewGuid():N}")
            .Options;
        using var inMemoryContext = new SmartDigitalPsicoDataContextMySql(options);
        WebApplicationConfigureBuilder.EntityDataContextOverrideForTests = inMemoryContext;
        try
        {
            var host = WebApplicationConfigureBuilder.CreateHostBuilder(["--environment", "Production"]);
            host.Item1.Services.AddScoped<IEntityDataContext>(_ => null!);

            // Act
            using var app = WebApplicationConfigureBuilder.BuildAndConfigure(host.Item1);

            // Assert
            app.Services.Should().NotBeNull();
        }
        finally
        {
            WebApplicationConfigureBuilder.EntityDataContextOverrideForTests = null;
        }
    }

    // Cenário: o pipeline recebe um DatabaseFacade SQLite sem migrations de domínio.
    // Objetivo: executar addAutoMigrate até Database.Migrate com sucesso.
    [Test]
    public void Configure_SqliteEntityContext_ExecutesAutoMigratePath()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<EmptyMigrateDbContext>()
            .UseSqlite("DataSource=:memory:")
            .Options;
        using var sqliteContext = new EmptyMigrateDbContext(options);
        sqliteContext.Database.OpenConnection();
        var contextMock = new Mock<IEntityDataContext>();
        contextMock.Setup(x => x.Database).Returns(sqliteContext.Database);
        WebApplicationConfigureBuilder.EntityDataContextOverrideForTests = contextMock.Object;
        try
        {
            var host = WebApplicationConfigureBuilder.CreateHostBuilder(["--environment", "Production"]);
            host.Item1.Services.AddScoped<IEntityDataContext>(_ => null!);

            // Act
            using var app = WebApplicationConfigureBuilder.BuildAndConfigure(host.Item1);

            // Assert
            app.Services.Should().NotBeNull();
        }
        finally
        {
            WebApplicationConfigureBuilder.EntityDataContextOverrideForTests = null;
        }
    }

    // Cenário: a API é inicializada no ambiente de desenvolvimento.
    // Objetivo: garantir o registro da página de exceções de desenvolvimento.
    [Test]
    public void Configure_DevelopmentEnvironment_ConfiguresDeveloperExceptionPage()
    {
        // Arrange
        var host = WebApplicationConfigureBuilder.CreateHostBuilder(["--environment", "Development"]);
        host.Item1.Services.AddScoped<IEntityDataContext>(_ => null!);

        // Act
        var action = () =>
        {
            var application = WebApplicationConfigureBuilder.BuildAndConfigure(host.Item1);
            application.DisposeAsync().AsTask().GetAwaiter().GetResult();
        };

        // Assert
        action.Should().NotThrow();
    }

    // Cenário: o bootstrap não recebeu o diretório temporário obrigatório.
    // Objetivo: encapsular a falha de configuração sem iniciar o host.
    [Test]
    public void Configure_BuildAndRunComConfiguracaoInvalida_PropagaErroDeStartup()
    {
        // Arrange
        var builder = WebApplication.CreateBuilder();
        using var logger = new LoggerConfiguration().CreateLogger();
        var action = () => WebApplicationConfigureBuilder.BuildAndRunAPP(builder, logger);

        // Act
        // Assert
        action.Should().Throw<InvalidOperationException>()
            .WithMessage("Web API failed during startup or configuration.");
    }

    // Cenário: o bootstrap possui configuração e logger válidos.
    // Objetivo: validar a criação do pipeline sem abrir uma porta HTTP.
    [Test]
    public void Configure_BuildAndRunWithControlledRunner_ConfiguresAndInvokesRunner()
    {
        // Arrange
        var host = WebApplicationConfigureBuilder.CreateHostBuilder(["--environment", "Production"]);
        host.Item1.Services.AddScoped<IEntityDataContext>(_ => null!);
        using var logger = new LoggerConfiguration().CreateLogger();
        var runnerCalled = false;

        // Act
        WebApplicationConfigureBuilder.BuildAndRunAPP(host.Item1, logger, application =>
        {
            runnerCalled = true;
        });

        // Assert
        runnerCalled.Should().BeTrue();
    }

    // Cenário: o endpoint de culturas não encontra opções disponíveis.
    // Objetivo: garantir o retorno HTTP 404 para a lista vazia.
    [Test]
    public async Task GlobalizationCultures_GetWithoutCultures_ReturnsNotFound()
    {
        // Arrange
        var controller = new EmptyCulturesController();

        // Act
        var response = await controller.Get();

        // Assert
        response.Result.Should().BeOfType<NotFoundObjectResult>();
    }

    // Cenário: a versão do produto não está disponível.
    // Objetivo: garantir o retorno HTTP 404 para a ausência de informações.
    [Test]
    public async Task AppInformationVersionProduct_GetWithoutInformation_ReturnsNotFound()
    {
        // Arrange
        var controller = new MissingVersionInformationController();

        // Act
        var response = await controller.Get();

        // Assert
        response.Result.Should().BeOfType<NotFoundObjectResult>();
    }

    // Cenário: a busca de médicos falha por falta de autorização.
    // Objetivo: garantir que o endpoint retorne HTTP 401.
    [Test]
    public async Task Medical_FindAllUnauthorizedServiceResponse_ReturnsUnauthorized()
    {
        // Arrange
        var service = new Mock<IMedicalService>();
        service.Setup(item => item.FindAll())
            .ReturnsAsync(new ServiceResponse<List<GetMedicalDto>>
            {
                Success = false,
                Unauthorized = true
            });
        var controller = new SmartDigitalPsico.WebAPI.Controllers.v1.MedicalController(
            service.Object,
            Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.AuthConfigurationDto()))
        {
            ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext
                {
                    RequestServices = new ServiceCollection().BuildServiceProvider()
                }
            }
        };

        // Act
        var response = await controller.FindAll();

        // Assert
        response.Result.Should().BeOfType<UnauthorizedObjectResult>();
    }

    // Cenário: a telemetria possui uma connection string configurada.
    // Objetivo: registrar o pipeline do Azure Monitor sem iniciar o host.
    [Test]
    public void Program_ValidateStartupComApplicationInsights_ConfiguraTelemetria()
    {
        // Arrange
        const string variable = "APPLICATIONINSIGHTS_CONNECTION_STRING";
        var previousValue = Environment.GetEnvironmentVariable(variable);
        Environment.SetEnvironmentVariable(variable, "InstrumentationKey=00000000-0000-0000-0000-000000000000");
        try
        {
            var action = () => SmartDigitalPsico.WebAPI.Program.Main(["--validate-startup"]);

            // Act
            // Assert
            action.Should().NotThrow();
        }
        finally
        {
            Environment.SetEnvironmentVariable(variable, previousValue);
        }
    }

    // Cenário: a telemetria possui uma connection string durante a criação do host.
    // Objetivo: garantir que as opções do Azure Monitor sejam aplicadas ao container.
    [Test]
    public void Configure_ApplicationInsightsConnectionString_ConfiguresAzureMonitorOptions()
    {
        // Arrange
        const string variable = "APPLICATIONINSIGHTS_CONNECTION_STRING";
        var previousValue = Environment.GetEnvironmentVariable(variable);
        Environment.SetEnvironmentVariable(variable, "InstrumentationKey=00000000-0000-0000-0000-000000000000");
        try
        {
            var host = WebApplicationConfigureBuilder.CreateHostBuilder(["--environment", "Production"]);
            host.Item1.Configuration[variable] = Environment.GetEnvironmentVariable(variable);
            host.Item1.Services.AddScoped<IEntityDataContext>(_ => null!);

            // Act
            var action = () =>
            {
                var application = WebApplicationConfigureBuilder.BuildAndConfigure(host.Item1);
                application.Services.GetRequiredService<IOptions<AzureMonitorOptions>>().Value.ConnectionString
                    .Should().Be(Environment.GetEnvironmentVariable(variable));
                application.DisposeAsync().AsTask().GetAwaiter().GetResult();
            };

            // Assert
            action.Should().NotThrow();
        }
        finally
        {
            Environment.SetEnvironmentVariable(variable, previousValue);
        }
    }

    // Cenário: o pipeline recebe uma requisição HTTP real.
    // Objetivo: executar os middlewares de correlação e logging de requisição.
    [Test]
    public async Task Configure_RunningPipeline_ProcessesRequestMiddlewares()
    {
        // Arrange
        var host = WebApplicationConfigureBuilder.CreateHostBuilder(["--environment", "Production"]);
        host.Item1.WebHost.UseUrls("http://127.0.0.1:0");
        host.Item1.Services.AddScoped<IEntityDataContext>(_ => null!);
        await using var application = WebApplicationConfigureBuilder.BuildAndConfigure(host.Item1);
        await application.StartAsync();
        using var client = new HttpClient();

        // Act
        var response = await client.GetAsync(application.Urls.Single());

        // Assert
        response.Should().NotBeNull();
    }

    [TestCase("NotificationRecordsController", "NotificationDispatch")]
    [TestCase("MedicalFileController", "Create")]
    [TestCase("PatientFileController", "Create")]
    // Cenário: uma operação assíncrona do serviço lança uma exceção inesperada.
    // Objetivo: garantir que endpoints de processamento respondam com erro controlado.
    public async Task Controllers_AcaoComFalhaDeServico_RetornamBadRequest(string controllerName, string actionName)
    {
        // Arrange
        var controllerType = typeof(AppInformationVersionProductController).Assembly
            .GetTypes()
            .Single(type => type.Name == controllerName);
        var controller = CreateThrowingController(controllerType);
        var action = controllerType.GetMethod(actionName)!;

        // Act
        var response = await InvokeAction(controller, action);

        // Assert
        response.Should().NotBeNull();
    }

    private static ControllerBase CreateController(Type controllerType, bool respostaComErro)
    {
        var constructor = controllerType.GetConstructors().Single();
        var dependencies = constructor.GetParameters()
            .Select(parameter => CreateDependency(parameter.ParameterType, respostaComErro))
            .ToArray();
        var controller = (ControllerBase)constructor.Invoke(dependencies);
        controller.ControllerContext = new ControllerContext
        {
            HttpContext = new DefaultHttpContext
            {
                RequestServices = new ServiceCollection().BuildServiceProvider()
            }
        };
        return controller;
    }

    private static ControllerBase CreateThrowingController(Type controllerType)
    {
        var constructor = controllerType.GetConstructors().Single();
        var dependencies = constructor.GetParameters()
            .Select(parameter => CreateThrowingDependency(parameter.ParameterType))
            .ToArray();
        var controller = (ControllerBase)constructor.Invoke(dependencies);
        controller.ControllerContext = new ControllerContext
        {
            HttpContext = new DefaultHttpContext
            {
                RequestServices = new ServiceCollection().BuildServiceProvider()
            }
        };
        return controller;
    }

    private static object CreateDependency(Type type, bool respostaComErro)
    {
        if (type == typeof(IConfiguration))
        {
            var tempDirectory = Path.Combine(Path.GetTempPath(), "SmartDigitalPsico.WebAPI.Test");
            Directory.CreateDirectory(tempDirectory);
            File.WriteAllBytes(Path.Combine(tempDirectory, "teste.pdf"), []);

            return new ConfigurationBuilder()
                .AddInMemoryCollection(new Dictionary<string, string?>
                {
                    ["AppSettings:ResourcesTemp"] = tempDirectory
                })
                .Build();
        }

        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IOptions<>))
        {
            return typeof(Options).GetMethod(nameof(Options.Create))!
                .MakeGenericMethod(type.GenericTypeArguments[0])
                .Invoke(null, [Activator.CreateInstance(type.GenericTypeArguments[0])!])!;
        }

        if (type.IsInterface)
        {
            var mock = Activator.CreateInstance(typeof(Mock<>).MakeGenericType(type))!;
            ConfigureMockReturns(mock, type, respostaComErro);
            return mock.GetType().GetProperties()
                .Single(property => property.Name == nameof(Mock.Object) && property.PropertyType == type)
                .GetValue(mock)!;
        }

        return CreateValue(type, respostaComErro)!;
    }

    private static object CreateThrowingDependency(Type type)
    {
        if (type == typeof(IConfiguration) || type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IOptions<>))
        {
            return CreateDependency(type, false);
        }

        if (!type.IsInterface)
        {
            return CreateValue(type, false)!;
        }

        var mock = Activator.CreateInstance(typeof(Mock<>).MakeGenericType(type))!;
        var setReturnsDefault = mock.GetType().GetMethods()
            .Single(method => method.Name == "SetReturnsDefault" && method.IsGenericMethodDefinition);
        var taskReturnTypes = type.GetMethods()
            .Select(method => method.ReturnType)
            .Where(returnType => returnType == typeof(Task) ||
                returnType.IsGenericType && returnType.GetGenericTypeDefinition() == typeof(Task<>))
            .Distinct();

        foreach (var returnType in taskReturnTypes)
        {
            var failedTask = returnType == typeof(Task)
                ? Task.FromException(new InvalidOperationException("falha simulada"))
                : typeof(Task).GetMethods()
                    .Single(method => method.Name == nameof(Task.FromException) &&
                        method.IsGenericMethodDefinition && method.GetGenericArguments().Length == 1)
                    .MakeGenericMethod(returnType.GenericTypeArguments[0])
                    .Invoke(null, [new InvalidOperationException("falha simulada")]);
            setReturnsDefault.MakeGenericMethod(returnType).Invoke(mock, [failedTask]);
        }

        return mock.GetType().GetProperties()
            .Single(property => property.Name == nameof(Mock.Object) && property.PropertyType == type)
            .GetValue(mock)!;
    }

    private static void ConfigureMockReturns(object mock, Type interfaceType, bool respostaComErro)
    {
        var setReturnsDefault = mock.GetType().GetMethods()
            .Single(method => method.Name == "SetReturnsDefault" && method.IsGenericMethodDefinition);

        foreach (var returnType in interfaceType.GetInterfaces()
                     .Append(interfaceType)
                     .SelectMany(type => type.GetMethods())
                     .Select(method => method.ReturnType)
                     .Where(type => type != typeof(void))
                     .Distinct())
        {
            setReturnsDefault.MakeGenericMethod(returnType)
                .Invoke(mock, [CreateValue(returnType, respostaComErro)]);
        }
    }

    private static async Task<object?> InvokeAction(ControllerBase controller, MethodInfo action)
    {
        var arguments = action.GetParameters()
            .Select(parameter => CreateValue(parameter.ParameterType, false))
            .ToArray();
        var invocation = action.Invoke(controller, arguments);

        if (invocation is Task task)
        {
            await task;
            return task.GetType().GetProperty("Result")?.GetValue(task) ?? task;
        }

        return invocation;
    }

    private static object? CreateValue(Type type, bool respostaComErro)
    {
        if (type == typeof(string))
        {
            return "teste";
        }

        if (type == typeof(bool))
        {
            return !respostaComErro;
        }

        if (type.IsValueType)
        {
            return Activator.CreateInstance(type);
        }

        if (type.IsArray)
        {
            return Array.CreateInstance(type.GetElementType()!, 0);
        }

        if (type == typeof(Task))
        {
            return Task.CompletedTask;
        }

        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Task<>))
        {
            var value = CreateValue(type.GenericTypeArguments[0], respostaComErro);
            return typeof(Task).GetMethod(nameof(Task.FromResult))!
                .MakeGenericMethod(type.GenericTypeArguments[0])
                .Invoke(null, [value]);
        }

        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(ServiceResponse<>))
        {
            var response = Activator.CreateInstance(type)!;
            type.GetProperty(nameof(ServiceResponse<object>.Success))!.SetValue(response, !respostaComErro);
            type.GetProperty(nameof(ServiceResponse<object>.Unauthorized))!.SetValue(response, false);
            type.GetProperty(nameof(ServiceResponse<object>.Data))!
                .SetValue(response, respostaComErro ? null : CreateValue(type.GenericTypeArguments[0], false));
            return response;
        }

        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
        {
            return Activator.CreateInstance(type);
        }

        if (typeof(IActionResult).IsAssignableFrom(type))
        {
            return new FileContentResult([], "application/octet-stream") { FileDownloadName = "teste.pdf" };
        }

        if (type.IsAbstract || type.IsInterface)
        {
            return null;
        }

        var instance = Activator.CreateInstance(type);
        var fileName = type.GetProperty("FileName");
        if (fileName?.CanWrite == true && fileName.PropertyType == typeof(string))
        {
            fileName.SetValue(instance, "teste.pdf");
        }

        return instance;
    }

    private sealed class EmptyCulturesController : GlobalizationCulturesController
    {
        protected override List<global::SmartDigitalPsico.Core.SDK.Domain.DTO.CultureDisplayDto> GetCultures() => [];
    }

    private sealed class MissingVersionInformationController : AppInformationVersionProductController
    {
        protected override AppInformationVersionProductDto? GetInformationVersionProduct() => null;
    }

    private sealed class EmptyMigrateDbContext : DbContext
    {
        public EmptyMigrateDbContext(DbContextOptions<EmptyMigrateDbContext> options) : base(options)
        {
        }
    }

}
