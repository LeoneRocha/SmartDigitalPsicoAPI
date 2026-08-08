namespace SmartDigitalPsico.Domain.DTO.Patient.PatientHospitalizationInformation
{
    /// <summary>
    /// Classe responsável por UpdatePatientHospitalizationInformationDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdatePatientHospitalizationInformationDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBase
    {
        #region Columns  
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CID { get; set; } = string.Empty;
        public string Observation { get; set; } = string.Empty;
        #endregion Columns 
    }
}
