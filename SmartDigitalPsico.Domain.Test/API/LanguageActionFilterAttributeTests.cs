using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Domain.API;
using System.Globalization;

namespace SmartDigitalPsico.Domain.Test.API;

[TestFixture]
public class LanguageActionFilterAttributeTests
{
    [Test]
    public void OnActionExecuting_InformationEnabled_SetsRouteCulture()
    {
        var logger = new Mock<IAppLogger>();
        logger.Setup(x => x.IsEnabled(ELogLevel.Information)).Returns(true);
        var filter = new LanguageActionFilterAttribute(logger.Object);
        var routeData = new RouteData();
        routeData.Values["culture"] = "pt-BR";
        var context = new ActionExecutingContext(
            new ActionContext(new DefaultHttpContext(), routeData, new ActionDescriptor()),
            [],
            new Dictionary<string, object?>(),
            new object());

        filter.OnActionExecuting(context);

        CultureInfo.CurrentCulture.Name.Should().Be("pt-BR");
        CultureInfo.CurrentUICulture.Name.Should().Be("pt-BR");
        logger.Verify(x => x.IsEnabled(ELogLevel.Information), Times.Once);
    }

    [Test]
    public void OnActionExecuting_MissingCultureKey_UsesEmptyCulture()
    {
        var logger = new Mock<IAppLogger>();
        logger.Setup(x => x.IsEnabled(ELogLevel.Information)).Returns(false);
        var filter = new LanguageActionFilterAttribute(logger.Object);
        var context = new ActionExecutingContext(
            new ActionContext(new DefaultHttpContext(), new RouteData(), new ActionDescriptor()),
            [],
            new Dictionary<string, object?>(),
            new object());

        filter.OnActionExecuting(context);

        CultureInfo.CurrentCulture.Name.Should().BeEmpty();
    }

    [Test]
    public void OnActionExecuting_InformationDisabled_SetsCultureWithoutLogging()
    {
        var logger = new Mock<IAppLogger>();
        logger.Setup(x => x.IsEnabled(ELogLevel.Information)).Returns(false);
        var filter = new LanguageActionFilterAttribute(logger.Object);
        var routeData = new RouteData();
        routeData.Values["culture"] = "en-US";
        var context = new ActionExecutingContext(new ActionContext(new DefaultHttpContext(), routeData, new ActionDescriptor()), [], new Dictionary<string, object?>(), new object());

        filter.OnActionExecuting(context);

        CultureInfo.CurrentCulture.Name.Should().Be("en-US");
        logger.Verify(x => x.IsEnabled(ELogLevel.Information), Times.Once);
    }
}
