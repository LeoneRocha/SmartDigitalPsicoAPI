using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Constants;
using System.Text;
using SmartDigitalPsico.Domain.DTO.Patient.PatientNotificationMessage;

namespace SmartDigitalPsico.Domain.Hypermedia.Enricher.Principals.Patient
{
    /// <summary>
    /// Classe responsável por GetPatientNotificationMessageEnricher.
    /// Responsabilidade: suporte a hypermedia/HATEOAS nas respostas.
    /// Relação: usado pelos Controllers na serialização.
    /// </summary>
    public class GetPatientNotificationMessageEnricher : ContentResponseEnricher<GetPatientNotificationMessageVO>

    {
        /// <summary>
        /// Método EnrichModel: executa a operação EnrichModel.
        /// </summary>
        protected override Task EnrichModel(GetPatientNotificationMessageVO content, IUrlHelper urlHelper)
        {
            var path = "api/Patient/v1/PatientNotificationMessage".ToLower();
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
