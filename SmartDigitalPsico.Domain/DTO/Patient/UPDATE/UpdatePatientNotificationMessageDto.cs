namespace SmartDigitalPsico.Domain.DTO.Patient.UPDATE
{
    /// <summary>
    /// Classe responsável por UpdatePatientNotificationMessageDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdatePatientNotificationMessageDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBase
    {
        #region Columns   
        public string Message { get; set; } = string.Empty;
        public bool IsReaded { get; set; }
        public bool Notified { get; set; }
        #endregion Columns  
    }
}
