using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using System.Globalization;
using System.Security.Claims;

namespace SmartDigitalPsico.Domain.Test.API;

[TestFixture]
public class ApiBaseControllerTests
{
    [Test]
    public void GetUserIdCurrent_JwtClaim_ReturnsClaimIdentifier()
    {
        // Cenário: o usuário autenticado possui NameIdentifier JWT.
        // Objetivo: retornar o identificador do usuário atual.
        // Arrange
        var controller = CreateController(new ServiceCollection().BuildServiceProvider(), new ClaimsPrincipal(new ClaimsIdentity([new Claim(ClaimTypes.NameIdentifier, "42")], "test")));

        // Act
        var result = controller.GetCurrentUserId();

        // Assert
        result.Should().Be(42);
    }

    [Test]
    public async Task SetCurrentCulture_RepositoryUserWithLanguage_AppliesUserCulture()
    {
        // Cenário: o repositório retorna usuário com idioma definido.
        // Objetivo: aplicar a cultura do usuário autenticado.
        // Arrange
        var repository = new Mock<IUserRepository>();
        repository.Setup(x => x.FindByID(9)).ReturnsAsync(new User { Language = "pt-BR" });
        var services = new ServiceCollection().AddSingleton(repository.Object).BuildServiceProvider();
        var controller = CreateController(services, new ClaimsPrincipal(new ClaimsIdentity([new Claim(ClaimTypes.NameIdentifier, "9")], "test")));

        // Act
        await controller.ApplyCurrentCulture();

        // Assert
        CultureInfo.CurrentCulture.Name.Should().Be("pt-BR");
        repository.Verify(x => x.FindByID(9), Times.Once);
    }

    [Test]
    public async Task SetCurrentCulture_MissingRepositoryOrLanguage_DoesNotChangeCulture()
    {
        // Cenário: não há repositório ou o idioma do usuário é vazio.
        // Objetivo: concluir sem alterar a cultura atual.
        // Arrange
        var previous = CultureInfo.CurrentCulture;
        var withoutRepository = CreateController(new ServiceCollection().BuildServiceProvider(), new ClaimsPrincipal());
        var repository = new Mock<IUserRepository>();
        repository.Setup(x => x.FindByID(0)).ReturnsAsync(new User { Language = " " });
        var withEmptyLanguage = CreateController(new ServiceCollection().AddSingleton(repository.Object).BuildServiceProvider(), new ClaimsPrincipal());

        // Act
        await withoutRepository.ApplyCurrentCulture();
        await withEmptyLanguage.ApplyCurrentCulture();

        // Assert
        CultureInfo.CurrentCulture.Should().Be(previous);
        repository.Verify(x => x.FindByID(0), Times.Once);
    }

    private static TestApiBaseController CreateController(IServiceProvider services, ClaimsPrincipal user)
    {
        var controller = new TestApiBaseController(Options.Create(new AuthConfigurationDto { TypeApiCredential = ETypeApiCredential.Jwt }));
        controller.ControllerContext = new Microsoft.AspNetCore.Mvc.ControllerContext
        {
            HttpContext = new DefaultHttpContext { RequestServices = services, User = user }
        };
        return controller;
    }

    private sealed class TestApiBaseController(IOptions<AuthConfigurationDto> options) : ApiBaseController(options)
    {
        public long GetCurrentUserId() => GetUserIdCurrent();
        public Task ApplyCurrentCulture() => SetCurrentCulture();
    }
}
