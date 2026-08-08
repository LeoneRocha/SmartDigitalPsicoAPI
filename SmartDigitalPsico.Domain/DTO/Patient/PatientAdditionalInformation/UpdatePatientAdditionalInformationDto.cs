using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientAdditionalInformation
{
    /// <summary>
    /// Classe responsável por UpdatePatientAdditionalInformationDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdatePatientAdditionalInformationDto : SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Contracts.EntityDtoBase
    {
        public string FollowUp_Psychiatric { get; set; } = string.Empty;
        public string FollowUp_Neurological { get; set; } = string.Empty;
    }
}
