using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants;

namespace SmartDigitalPsico.Domain.Hypermedia.Enricher.Domains
{
    /// <summary>
    /// Classe responsável por GetSpecialtyEnricher.
    /// Responsabilidade: suporte a hypermedia/HATEOAS nas respostas.
    /// Relação: usado pelos Controllers na serialização.
    /// </summary>
    public class GetSpecialtyEnricher : SmartDigitalPsico.Core.SDK.Domain.Hypermedia.ContentResponseEnricher<GetSpecialtyDto>

    {
        /// <summary>
        /// Método EnrichModel: executa a operação EnrichModel.
        /// </summary>
        protected override Task EnrichModel(GetSpecialtyDto content, IUrlHelper urlHelper)
        {
            var path = "api/Specialty/v1".ToLower();
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
