using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.Patient.ADD
{
    /// <summary>
    /// Classe responsável por AddPatientAdditionalInformationDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddPatientAdditionalInformationDto : SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd
    {
        #region Relationship 
        [Required]
        public long PatientId { get; set; }
        #endregion Relationship

        #region Columns 
        public string FollowUp_Psychiatric { get; set; } = string.Empty;
        public string FollowUp_Neurological { get; set; } = string.Empty;
        #endregion Columns 
    }
}
