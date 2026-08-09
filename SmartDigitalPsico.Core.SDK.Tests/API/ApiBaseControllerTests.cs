using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Core.SDK.API;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using System.Security.Claims;

namespace SmartDigitalPsico.Core.SDK.Tests.API;

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

    private static TestApiBaseController CreateController(IServiceProvider services, ClaimsPrincipal user)
    {
        var controller = new TestApiBaseController(Options.Create(new AuthConfigurationDto { TypeApiCredential = SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeApiCredential.Jwt }));
        controller.ControllerContext = new Microsoft.AspNetCore.Mvc.ControllerContext
        {
            HttpContext = new DefaultHttpContext { RequestServices = services, User = user }
        };
        return controller;
    }

    private sealed class TestApiBaseController(IOptions<AuthConfigurationDto> options) : ApiBaseController(options)
    {
        public long GetCurrentUserId() => GetUserIdCurrent();

    }
}

