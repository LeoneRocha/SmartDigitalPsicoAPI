using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.DTO.User;
using SmartDigitalPsico.Domain.Hypermedia.Constants;

namespace SmartDigitalPsico.Domain.Hypermedia.Enricher.Principals
{
    /// <summary>
    /// Classe responsável por GetUserEnricher.
    /// Responsabilidade: suporte a hypermedia/HATEOAS nas respostas.
    /// Relação: usado pelos Controllers na serialização.
    /// </summary>
    public class GetUserEnricher : ContentResponseEnricher<GetUserDto>

    {
        /// <summary>
        /// Método EnrichModel: executa a operação EnrichModel.
        /// </summary>
        protected override Task EnrichModel(GetUserDto content, IUrlHelper urlHelper)
        {
            var path = "api/user/v1".ToLower();
            string link = GetLink(content.Id, urlHelper, path);

            content.Links.Add(new SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.HyperMediaLink()
            {
                Method = HttpActionVerb.GET,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultGet
            });
            content.Links.Add(new SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.HyperMediaLink()
            {
                Method = HttpActionVerb.POST,
                Href = link,
                Rel = RelationType.post,
                Type = ResponseTypeFormat.DefaultPost
            });
            content.Links.Add(new SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.HyperMediaLink()
            {
                Method = HttpActionVerb.PUT,
                Href = link,
                Rel = RelationType.put,
                Type = ResponseTypeFormat.DefaultPut
            });
            content.Links.Add(new SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.HyperMediaLink()
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
