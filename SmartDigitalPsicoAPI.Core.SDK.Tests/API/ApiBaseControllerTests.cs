using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using SmartDigitalPsicoAPI.Core.SDK.API;
using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.ModelEntity;
using System.Globalization;
using System.Security.Claims;

namespace SmartDigitalPsicoAPI.Core.SDK.Tests.API;

[TestFixture]
public class ApiBaseControllerTests
{
    [Test]
    public void GetUserIdCurrent_JwtClaim_ReturnsClaimIdentifier()
    {
        // CenÃ¡rio: o usuÃ¡rio autenticado possui NameIdentifier JWT.
        // Objetivo: retornar o identificador do usuÃ¡rio atual.
        // Arrange
        var controller = CreateController(new ServiceCollection().BuildServiceProvider(), new ClaimsPrincipal(new ClaimsIdentity([new Claim(ClaimTypes.NameIdentifier, "42")], "test")));

        // Act
        var result = controller.GetCurrentUserId();

        // Assert
        result.Should().Be(42);
    }

    private static TestApiBaseController CreateController(IServiceProvider services, ClaimsPrincipal user)
    {
        var controller = new TestApiBaseController(Options.Create(new AuthConfigurationDto { TypeApiCredential = SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.ETypeApiCredential.Jwt }));
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



