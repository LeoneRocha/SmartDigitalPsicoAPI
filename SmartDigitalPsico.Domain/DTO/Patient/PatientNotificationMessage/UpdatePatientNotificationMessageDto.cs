using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientNotificationMessage
{
    public class UpdatePatientNotificationMessageDto : EntityDtoBase
    {
        #region Columns   
        public string Message { get; set; } = string.Empty;
        public bool IsReaded { get; set; }
        public bool Notified { get; set; }
        #endregion Columns  
    }
}