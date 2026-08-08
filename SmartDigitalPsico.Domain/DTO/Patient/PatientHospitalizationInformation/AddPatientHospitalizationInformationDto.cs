using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientHospitalizationInformation
{
    /// <summary>
    /// Classe responsável por AddPatientHospitalizationInformationDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddPatientHospitalizationInformationDto : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityDtoAdd
    {

        #region Relationship 
        public long PatientId { get; set; }
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
