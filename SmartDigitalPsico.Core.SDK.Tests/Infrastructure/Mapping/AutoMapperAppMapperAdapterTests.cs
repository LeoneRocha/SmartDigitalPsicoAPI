using AutoMapper;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;
using SmartDigitalPsico.Core.SDK.Infrastructure.Mapping;

namespace SmartDigitalPsico.Core.SDK.Tests.Infrastructure.Mapping;

[TestFixture]
public class AutoMapperAppMapperAdapterTests
{
    [Test]
    public void Map_TDestination_ForwardsToAutoMapper()
    {
        var inner = new Mock<IMapper>();
        inner.Setup(x => x.Map<string>(It.IsAny<object>())).Returns("mapped");
        IAppMapper mapper = new AutoMapperAppMapperAdapter(inner.Object);

        var result = mapper.Map<string>(new { Id = 1 });

        result.Should().Be("mapped");
        inner.Verify(x => x.Map<string>(It.IsAny<object>()), Times.Once);
    }

    [Test]
    public void Map_SourceAndDestination_ForwardsToAutoMapper()
    {
        var inner = new Mock<IMapper>();
        var dest = new Dest();
        inner.Setup(x => x.Map(It.IsAny<Source>(), It.IsAny<Dest>())).Returns(dest);
        IAppMapper mapper = new AutoMapperAppMapperAdapter(inner.Object);

        var result = mapper.Map(new Source(), dest);

        result.Should().BeSameAs(dest);
    }

    [Test]
    public void Constructor_NullMapper_Throws()
    {
        Action act = () => _ = new AutoMapperAppMapperAdapter(null!);
        act.Should().Throw<ArgumentNullException>();
    }

    private sealed class Source { }
    private sealed class Dest { }
}
