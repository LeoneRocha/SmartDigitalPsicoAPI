using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Hypermedia.Enricher.Domains;
using SmartDigitalPsico.Domain.Hypermedia.Enricher.Principals;
using SmartDigitalPsico.Domain.Hypermedia.Enricher.Principals.Patient;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Filters;

namespace SmartDigitalPsico.Domain.Hypermedia
{
    /// <summary>
    /// Classe responsÃ¡vel por HyperMediaConfigure.
    /// Responsabilidade: suporte a hypermedia/HATEOAS nas respostas.
    /// RelaÃ§Ã£o: usado pelos Controllers na serializaÃ§Ã£o.
    /// </summary>
    public static class HyperMediaConfigure
    {
        /// <summary>
        /// MÃ©todo AddHyperMedia: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static void AddHyperMedia(IServiceCollection Service)
        {
            var filterOptions = new SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Filters.HyperMediaFilterOptions();

            addfilterOptions(filterOptions);

            Service.AddSingleton(filterOptions);
        }

        private static void addfilterOptions(SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Filters.HyperMediaFilterOptions filterOptions)
        {
            addDomains(filterOptions);
            addPrincipals(filterOptions);
        }

        private static void addPrincipals(SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Filters.HyperMediaFilterOptions filterOptions)
        {
            filterOptions.ContentResponseEnricherList.Add(new GetUserEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetMedicalEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetMedicalFileEnricher());

            addPatient(filterOptions);
        }

        private static void addPatient(SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Filters.HyperMediaFilterOptions filterOptions)
        {
            filterOptions.ContentResponseEnricherList.Add(new GetPatientAdditionalInformationEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientFileEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientHospitalizationInformationEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientMedicationInformationEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientNotificationMessageEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientRecordEnricher());
            filterOptions.ContentResponseEnricherList.Add(new GetPatientEnricher());
        }

        private static void addDomains(SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Filters.HyperMediaFilterOptions filterOptions)
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
