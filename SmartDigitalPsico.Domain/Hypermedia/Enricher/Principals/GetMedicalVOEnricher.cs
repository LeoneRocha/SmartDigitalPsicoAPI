using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Constants;
using SmartDigitalPsico.Domain.VO.Medical;

namespace SmartDigitalPsico.Data.Model.Hypermedia.Enricher.Principals
{
    public class GetMedicalVOEnricher : ContentResponseEnricher<GetMedicalVO>

    { 
        protected override Task EnrichModel(GetMedicalVO content, IUrlHelper urlHelper)
        {
            var path = "api/Medical/v1".ToLower();
            string link = GetLink(content.Id, urlHelper, path);

            content.Links.Add(new HyperMediaLink()
            {
                Method = HttpActionVerb.GET,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultGet
            });
            content.Links.Add(new HyperMediaLink()
            {
                Method = HttpActionVerb.POST,
                Href = link,
                Rel = RelationType.post,
                Type = ResponseTypeFormat.DefaultPost
            });
            content.Links.Add(new HyperMediaLink()
            {
                Method = HttpActionVerb.PUT,
                Href = link,
                Rel = RelationType.put,
                Type = ResponseTypeFormat.DefaultPut
            });
            content.Links.Add(new HyperMediaLink()
            {
                Method = HttpActionVerb.DELETE,
                Href = link,
                Rel = RelationType.delete,
                Type = "long"
            });
            return Task.Run(() => { });
        } 
    }
}
