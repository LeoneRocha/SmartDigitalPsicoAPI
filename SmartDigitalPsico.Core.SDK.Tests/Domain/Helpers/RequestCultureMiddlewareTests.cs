using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;
using System.Globalization;

namespace SmartDigitalPsico.Core.SDK.Tests.Helpers;

[TestFixture]
public class RequestCultureMiddlewareTests
{
    [Test]
    public async Task Invoke_CultureHeader_SetsCultureAndInvokesNext()
    {
        // CenÃ¡rio: a requisiÃ§Ã£o informa uma cultura vÃ¡lida.
        // Objetivo: aplicar a cultura antes de chamar o prÃ³ximo middleware.
        // Arrange
        var context = new DefaultHttpContext();
        context.Request.Headers["X-Culture"] = "pt-BR";
        var invoked = false;
        string? cultureDuringNext = null;
        string? uiCultureDuringNext = null;
        var middleware = new SmartDigitalPsico.Core.SDK.Domain.Helpers.RequestCultureMiddleware(_ =>
        {
            // Captura dentro do pipeline: apÃ³s o await o AsyncLocal pode voltar ao default da thread.
            invoked = true;
            cultureDuringNext = CultureInfo.CurrentCulture.Name;
            uiCultureDuringNext = CultureInfo.CurrentUICulture.Name;
            return Task.CompletedTask;
        });

        // Act
        await middleware.Invoke(context);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            invoked.Should().BeTrue();
            cultureDuringNext.Should().Be("pt-BR");
            uiCultureDuringNext.Should().Be("pt-BR");
        }
    }

    [Test]
    public async Task Invoke_EmptyCultureHeader_InvokesNextWithoutChangingCulture()
    {
        // CenÃ¡rio: a requisiÃ§Ã£o nÃ£o informa cultura.
        // Objetivo: continuar o pipeline sem criar CultureInfo.
        // Arrange
        var previous = CultureInfo.CurrentCulture;
        var context = new DefaultHttpContext();
        var middleware = new SmartDigitalPsico.Core.SDK.Domain.Helpers.RequestCultureMiddleware(_ => Task.CompletedTask);

        // Act
        await middleware.Invoke(context);

        // Assert
        CultureInfo.CurrentCulture.Should().Be(previous);
    }
}


