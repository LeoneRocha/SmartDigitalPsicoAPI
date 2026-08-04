using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.Helpers;
using System.Globalization;

namespace SmartDigitalPsico.Domain.Test.Helpers;

[TestFixture]
public class RequestCultureMiddlewareTests
{
    [Test]
    public async Task Invoke_CultureHeader_SetsCultureAndInvokesNext()
    {
        // Cenário: a requisição informa uma cultura válida.
        // Objetivo: aplicar a cultura antes de chamar o próximo middleware.
        // Arrange
        var context = new DefaultHttpContext();
        context.Request.Headers["X-Culture"] = "pt-BR";
        var invoked = false;
        var middleware = new RequestCultureMiddleware(_ =>
        {
            invoked = true;
            return Task.CompletedTask;
        });

        // Act
        await middleware.Invoke(context);

        // Assert
        invoked.Should().BeTrue();
        CultureInfo.CurrentCulture.Name.Should().Be("pt-BR");
        CultureInfo.CurrentUICulture.Name.Should().Be("pt-BR");
    }

    [Test]
    public async Task Invoke_EmptyCultureHeader_InvokesNextWithoutChangingCulture()
    {
        // Cenário: a requisição não informa cultura.
        // Objetivo: continuar o pipeline sem criar CultureInfo.
        // Arrange
        var previous = CultureInfo.CurrentCulture;
        var context = new DefaultHttpContext();
        var middleware = new RequestCultureMiddleware(_ => Task.CompletedTask);

        // Act
        await middleware.Invoke(context);

        // Assert
        CultureInfo.CurrentCulture.Should().Be(previous);
    }
}
