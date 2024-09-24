using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientNotificationMessage
{
    public class AddPatientNotificationMessageDto : IEntityDtoAdd
    {
        #region Columns  
        public string Message { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string RG { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        #endregion Columns  
    }
}