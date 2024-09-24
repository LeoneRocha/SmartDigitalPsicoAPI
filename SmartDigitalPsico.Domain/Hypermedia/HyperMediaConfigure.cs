using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Hypermedia.Enricher.Domains;
using SmartDigitalPsico.Domain.Hypermedia.Enricher.Principals;
using SmartDigitalPsico.Domain.Hypermedia.Enricher.Principals.Patient;
using SmartDigitalPsico.Domain.Hypermedia.Filters;

namespace SmartDigitalPsico.Domain.Hypermedia
{
    public static class HyperMediaConfigure
    {
        public static void AddHyperMedia(IServiceCollection Service)
        {
            var filterOptions = new HyperMediaFilterOptions();

            addfilterOptions(filterOptions);

            Service.AddSingleton(filterOptions);
        }

        private static void addfilterOptions(HyperMediaFilterOptions filterOptions)
        {
            addDomains(filterOptions);
            addPrincipals(filterOptions);
        }

        private static void addPrincipals(HyperMediaFilterOptions filterOptions)
        {
            filterOptions.ContentResponseEnricherList.Add(new GetUserEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetMedicalEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetMedicalFileEnricher());

            addPatient(filterOptions);
        }

        private static void addPatient(HyperMediaFilterOptions filterOptions)
        {
            filterOptions.ContentResponseEnricherList.Add(new GetPatientAdditionalInformationEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientFileEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientHospitalizationInformationEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientMedicationInformationEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientNotificationMessageEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientRecordEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientEnricher());
        }

        private static void addDomains(HyperMediaFilterOptions filterOptions)
        {
            filterOptions.ContentResponseEnricherList.Add(new GetApplicationConfigSettingEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetApplicationLanguageEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetGenderEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetOfficeEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetRoleGroupEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetSpecialtyEnricher());
        }
    }
}
