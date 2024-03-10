using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using System.Collections.Generic;

namespace SmartDigitalPsico.Domain.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
