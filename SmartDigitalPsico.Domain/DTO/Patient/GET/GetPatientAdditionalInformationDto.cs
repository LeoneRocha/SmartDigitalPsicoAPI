using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;


namespace SmartDigitalPsico.Domain.DTO.Patient.GET
{
    /// <summary>
    /// Classe responsável por GetPatientAdditionalInformationDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetPatientAdditionalInformationDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBase, ISupportsHyperMedia
    { 
        #region Relationship  
        public GetPatientDto Patient { get; set; } = new GetPatientDto(); 
        public List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink>();
        #endregion Relationship

        #region Columns 
        public string FollowUp_Psychiatric { get; set; } = string.Empty;
        public string FollowUp_Neurological { get; set; } = string.Empty;
        #endregion Columns 
    }
}
