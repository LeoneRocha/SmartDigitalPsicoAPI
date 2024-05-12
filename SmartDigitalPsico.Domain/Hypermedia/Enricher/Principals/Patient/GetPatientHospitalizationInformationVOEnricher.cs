using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Constants;
using SmartDigitalPsico.Domain.VO.Patient.PatientHospitalizationInformation;

namespace SmartDigitalPsico.Data.Model.Hypermedia.Enricher.Principals.Patient
{
    public class GetPatientHospitalizationInformationVOEnricher : ContentResponseEnricher<GetPatientHospitalizationInformationVO>

    { 
        protected override Task EnrichModel(GetPatientHospitalizationInformationVO content, IUrlHelper urlHelper)
        {
            var path = "api/Patient/v1/PatientHospitalizationInformation/".ToLower();
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
