using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientNotificationMessage
{
    public class AddPatientNotificationMessageDto : IEntityDtoAdd
    {
        #region Columns  
        [MaxLength(2000)]
        [Required]
        public string Message { get; set; } = string.Empty;

        [MaxLength(15)]
        public string CPF { get; set; } = string.Empty;

        [MaxLength(15)]
        public string RG { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        #endregion Columns  
    }
}