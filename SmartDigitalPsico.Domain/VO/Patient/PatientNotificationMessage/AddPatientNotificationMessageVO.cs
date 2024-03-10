using SmartDigitalPsico.Domain.VO.Contracts;
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
        public string? Cpf { get; set; }

        [MaxLength(15)]
        public string Rg { get; set; }

        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        #endregion Columns  
    }
}