using System.Collections.Generic;

namespace SmartDigitalPsico.Domain.Hypermedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
