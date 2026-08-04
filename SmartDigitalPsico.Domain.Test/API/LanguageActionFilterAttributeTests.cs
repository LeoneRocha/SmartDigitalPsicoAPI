using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Moq;
using SmartDigitalPsico.Domain.API;
using System.Globalization;

namespace SmartDigitalPsico.Domain.Test.API;

[TestFixture]
public class LanguageActionFilterAttributeTests
{
    [Test]
    public void OnActionExecuting_InformationEnabled_SetsRouteCulture()
    {
        // Cenário: a rota possui cultura e o log de informação está habilitado.
        // Objetivo: aplicar a cultura indicada na URL.
        // Arrange
        var logger = new Mock<ILogger>();
        logger.Setup(x => x.IsEnabled(LogLevel.Information)).Returns(true);
        var factory = new Mock<ILoggerFactory>();
        factory.Setup(x => x.CreateLogger("LanguageActionFilter")).Returns(logger.Object);
        var filter = new LanguageActionFilterAttribute(factory.Object);
        var routeData = new RouteData();
        routeData.Values["culture"] = "pt-BR";
        var context = new ActionExecutingContext(
            new ActionContext(new DefaultHttpContext(), routeData, new ActionDescriptor()),
            [],
            new Dictionary<string, object?>(),
            new object());

        // Act
        filter.OnActionExecuting(context);

        // Assert
        CultureInfo.CurrentCulture.Name.Should().Be("pt-BR");
        CultureInfo.CurrentUICulture.Name.Should().Be("pt-BR");
        logger.Verify(x => x.IsEnabled(LogLevel.Information), Times.Once);
    }

    [Test]
    public void OnActionExecuting_MissingCultureKey_UsesEmptyCulture()
    {
        // Cenário: rota sem chave culture.
        // Objetivo: cobrir coalescing para string.Empty.
        // Arrange
        var logger = new Mock<ILogger>();
        logger.Setup(x => x.IsEnabled(LogLevel.Information)).Returns(false);
        var factory = new Mock<ILoggerFactory>();
        factory.Setup(x => x.CreateLogger(It.IsAny<string>())).Returns(logger.Object);
        var filter = new LanguageActionFilterAttribute(factory.Object);
        var context = new ActionExecutingContext(
            new ActionContext(new DefaultHttpContext(), new RouteData(), new ActionDescriptor()),
            [],
            new Dictionary<string, object?>(),
            new object());

        // Act
        filter.OnActionExecuting(context);

        // Assert
        CultureInfo.CurrentCulture.Name.Should().BeEmpty();
    }

    [Test]
    public void OnActionExecuting_InformationDisabled_SetsCultureWithoutLogging()
    {
        // Cenário: a cultura existe, mas informação está desabilitada.
        // Objetivo: aplicar a cultura sem depender do log.
        // Arrange
        var logger = new Mock<ILogger>();
        logger.Setup(x => x.IsEnabled(LogLevel.Information)).Returns(false);
        var factory = new Mock<ILoggerFactory>();
        factory.Setup(x => x.CreateLogger(It.IsAny<string>())).Returns(logger.Object);
        var filter = new LanguageActionFilterAttribute(factory.Object);
        var routeData = new RouteData();
        routeData.Values["culture"] = "en-US";
        var context = new ActionExecutingContext(new ActionContext(new DefaultHttpContext(), routeData, new ActionDescriptor()), [], new Dictionary<string, object?>(), new object());

        // Act
        filter.OnActionExecuting(context);

        // Assert
        CultureInfo.CurrentCulture.Name.Should().Be("en-US");
        logger.Verify(x => x.IsEnabled(LogLevel.Information), Times.Once);
    }
}
