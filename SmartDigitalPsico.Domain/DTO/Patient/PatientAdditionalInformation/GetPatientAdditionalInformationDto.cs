using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;


namespace SmartDigitalPsico.Domain.DTO.Patient.PatientAdditionalInformation
{
    /// <summary>
    /// Classe responsável por GetPatientAdditionalInformationDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetPatientAdditionalInformationDto : SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Contracts.EntityDtoBase, ISupportsHyperMedia
    { 
        #region Relationship  
        public GetPatientDto Patient { get; set; } = new GetPatientDto(); 
        public List<SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.HyperMediaLink>();
        #endregion Relationship

        #region Columns 
        public string FollowUp_Psychiatric { get; set; } = string.Empty;
        public string FollowUp_Neurological { get; set; } = string.Empty;
        #endregion Columns 
    }
}
