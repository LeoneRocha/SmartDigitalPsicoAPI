using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Model.Hypermedia.Enricher;
using SmartDigitalPsico.Data.Model.Hypermedia.Enricher.Domains;
using SmartDigitalPsico.Data.Model.Hypermedia.Enricher.Principals;
using SmartDigitalPsico.Data.Model.Hypermedia.Enricher.Principals.Patient;
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
            filterOptions.ContentResponseEnricherList.Add(new GetUserVOEnricher());

            filterOptions.ContentResponseEnricherList.Add(new GetMedicalVOEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetMedicalFileVOEnricher());

            addPatient(filterOptions);
        }

        private static void addPatient(HyperMediaFilterOptions filterOptions)
        {
            filterOptions.ContentResponseEnricherList.Add(new GetPatientAdditionalInformationVOEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientFileVOEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientHospitalizationInformationVOEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientMedicationInformationVOEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientNotificationMessageVOEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientRecordVOEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientVOEnricher());
        }

        private static void addDomains(HyperMediaFilterOptions filterOptions)
        {
            filterOptions.ContentResponseEnricherList.Add(new GetApplicationConfigSettingVOEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetApplicationLanguageVOEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetGenderVOEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetOfficeVOEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetRoleGroupVOEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetSpecialtyVOEnricher());
        }
    }
}
