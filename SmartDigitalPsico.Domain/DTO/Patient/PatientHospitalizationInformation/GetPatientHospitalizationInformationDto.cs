using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientHospitalizationInformation
{
    /// <summary>
    /// Classe responsável por GetPatientHospitalizationInformationDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetPatientHospitalizationInformationDto : EntityDtoBase, ISupportsHyperMedia
    {  
        #region Relationship  
        public GetPatientDto Patient { get; set; } = new GetPatientDto();
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
        #endregion Relationship

        #region Columns 
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CID { get; set; } = string.Empty;
        public string Observation { get; set; } = string.Empty;
        #endregion Columns 
    }
}
