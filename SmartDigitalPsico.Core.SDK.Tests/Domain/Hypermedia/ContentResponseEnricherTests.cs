using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.AppException;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Core.SDK.Tests.Domain.Hypermedia;

[TestFixture]
public class ContentResponseEnricherTests
{
    [Test]
    public void CanEnrich_CompatibleTypes_IdentifiesSupportedContents()
    {
        var enricher = new TestEnricher();

        using (Assert.EnterMultipleScope())
        {
            enricher.CanEnrich(typeof(HyperDto)).Should().BeTrue();
            enricher.CanEnrich(typeof(List<HyperDto>)).Should().BeTrue();
            enricher.CanEnrich(typeof(ServiceResponse<HyperDto>)).Should().BeTrue();
            enricher.CanEnrich(typeof(ServiceResponse<List<HyperDto>>)).Should().BeTrue();
            enricher.CanEnrich(typeof(PagedSearchVO<HyperDto>)).Should().BeTrue();
            enricher.CanEnrich(typeof(string)).Should().BeFalse();
        }
    }

    [Test]
    public async Task Enrich_OkResponses_EnrichesModelAndCollections()
    {
        var enricher = new TestEnricher();
        var contexts = new object[]
        {
            new HyperDto(),
            new List<HyperDto> { new() },
            new ServiceResponse<HyperDto> { Data = new HyperDto() },
            new ServiceResponse<List<HyperDto>> { Data = [new HyperDto()] },
            new PagedSearchVO<HyperDto> { List = [new HyperDto()] }
        }.Select(CreateResultContext).ToList();

        foreach (var context in contexts)
            await enricher.Enrich(context);

        enricher.EnrichedCount.Should().Be(5);
    }

    [Test]
    public void CanEnrich_FilterInterface_EvaluatesResults()
    {
        IResponseEnricher enricher = new TestEnricher();
        var nonOk = enricher.CanEnrich(CreateResultContext(new NotFoundResult()));
        var compatible = enricher.CanEnrich(CreateResultContext(new HyperDto()));
        var nullBody = () => enricher.CanEnrich(CreateResultContext(new OkObjectResult(null)));

        using (Assert.EnterMultipleScope())
        {
            nonOk.Should().BeFalse();
            compatible.Should().BeTrue();
            nullBody.Should().Throw<AppWarningException>();
        }
    }

    [Test]
    public async Task EnrichModel_GetLink_BuildsUrl()
    {
        var enricher = new LinkingEnricher();
        await enricher.Enrich(CreateResultContext(new HyperDto { Id = 7 }));
        enricher.LastLink.Should().Contain("api/test");
    }

    [Test]
    public void PagedSearchVO_Constructors_ResolvePageDefaults()
    {
        var defaultPaged = new PagedSearchVO<HyperDto>();
        var configured = new PagedSearchVO<HyperDto>(3, 25, "Name", "asc", new Dictionary<string, object>());
        var shortCtor = new PagedSearchVO<HyperDto>(4, "Name", "desc");
        var sized = new PagedSearchVO<HyperDto>(2, 15, "Id", "asc");

        using (Assert.EnterMultipleScope())
        {
            defaultPaged.GetCurrentPage().Should().Be(2);
            defaultPaged.GetPageSize().Should().Be(10);
            configured.GetCurrentPage().Should().Be(3);
            configured.GetPageSize().Should().Be(25);
            shortCtor.GetPageSize().Should().Be(10);
            sized.GetPageSize().Should().Be(15);
        }
    }

    private static ResultExecutingContext CreateResultContext(object result)
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

    private sealed class HyperDto : ISupportsHyperMedia
    {
        public long Id { get; set; }
        public List<HyperMediaLink> Links { get; set; } = [];
    }

    private sealed class TestEnricher : ContentResponseEnricher<HyperDto>
    {
        public int EnrichedCount { get; private set; }

        protected override Task EnrichModel(HyperDto content, IUrlHelper urlHelper)
        {
            EnrichedCount++;
            return Task.CompletedTask;
        }
    }

    private sealed class LinkingEnricher : ContentResponseEnricher<HyperDto>
    {
        public string LastLink { get; private set; } = string.Empty;

        protected override Task EnrichModel(HyperDto content, IUrlHelper urlHelper)
        {
            LastLink = GetLink(content.Id, urlHelper, "items");
            return Task.CompletedTask;
        }
    }
}
