using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.Hypermedia.Constants;

namespace SmartDigitalPsico.Domain.Hypermedia.Enricher.Domains
{
    /// <summary>
    /// Classe responsável por GetOfficeEnricher.
    /// Responsabilidade: suporte a hypermedia/HATEOAS nas respostas.
    /// Relação: usado pelos Controllers na serialização.
    /// </summary>
    public class GetOfficeEnricher : SmartDigitalPsico.Core.SDK.Domain.Hypermedia.ContentResponseEnricher<GetOfficeDto>

    {
        /// <summary>
        /// Método EnrichModel: executa a operação EnrichModel.
        /// </summary>
        protected override Task EnrichModel(GetOfficeDto content, IUrlHelper urlHelper)
        {
            var path = "api/office/v1".ToLower();
            string link = GetLink(content.Id, urlHelper, path);

            content.Links.Add(new SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink()
            {
                Method = HttpActionVerb.GET,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultGet
            });
            content.Links.Add(new SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink()
            {
                Method = HttpActionVerb.POST,
                Href = link,
                Rel = RelationType.post,
                Type = ResponseTypeFormat.DefaultPost
            });
            content.Links.Add(new SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink()
            {
                Method = HttpActionVerb.PUT,
                Href = link,
                Rel = RelationType.put,
                Type = ResponseTypeFormat.DefaultPut
            });
            content.Links.Add(new SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink()
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
