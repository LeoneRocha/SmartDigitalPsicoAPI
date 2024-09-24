using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Constants;
using System.Text;
using SmartDigitalPsico.Domain.DTO.Patient.PatientNotificationMessage;

namespace SmartDigitalPsico.Domain.Hypermedia.Enricher.Principals.Patient
{
    public class GetPatientNotificationMessageEnricher : ContentResponseEnricher<GetPatientNotificationMessageVO>

    {
        protected override Task EnrichModel(GetPatientNotificationMessageVO content, IUrlHelper urlHelper)
        {
            var path = "api/Patient/v1/PatientNotificationMessage".ToLower();
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
