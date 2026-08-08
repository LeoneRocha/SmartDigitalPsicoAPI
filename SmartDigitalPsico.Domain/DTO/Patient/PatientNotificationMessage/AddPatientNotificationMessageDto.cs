using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientNotificationMessage
{
    /// <summary>
    /// Classe responsável por AddPatientNotificationMessageDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddPatientNotificationMessageDto : SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd
    {
        #region Columns  
        public string Message { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string RG { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        #endregion Columns  
    }
}
