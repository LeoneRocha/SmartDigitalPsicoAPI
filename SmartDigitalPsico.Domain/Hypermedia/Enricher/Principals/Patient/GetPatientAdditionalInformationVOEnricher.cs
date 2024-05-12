using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Constants;
using SmartDigitalPsico.Domain.VO.Patient.PatientAdditionalInformation;

namespace SmartDigitalPsico.Data.Model.Hypermedia.Enricher.Principals.Patient
{
    public class GetPatientAdditionalInformationVOEnricher : ContentResponseEnricher<GetPatientAdditionalInformationVO>

    { 
        protected override Task EnrichModel(GetPatientAdditionalInformationVO content, IUrlHelper urlHelper)
        {
            var path = "api/Patient/v1/PatientAdditionalInformation/".ToLower();
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
