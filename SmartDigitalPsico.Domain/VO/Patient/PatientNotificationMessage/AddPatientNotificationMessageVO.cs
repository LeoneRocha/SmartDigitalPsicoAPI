using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientNotificationMessage
{
    public class AddPatientNotificationMessageVO : IEntityVOAdd
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