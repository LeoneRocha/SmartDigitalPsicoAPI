using SmartDigitalPsico.Domain.DTO.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientNotificationMessage
{
    public class UpdatePatientNotificationMessageDto : EntityDtoBase
    {
        #region Columns  
        [MaxLength(2000)]
        [Required]
        public string Message { get; set; } = string.Empty;

        public bool IsReaded { get; set; }

        public bool Notified { get; set; }

        #endregion Columns  
    }
}