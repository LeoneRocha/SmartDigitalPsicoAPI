using SmartDigitalPsico.Domain.VO.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientNotificationMessage
{
    public class UpdatePatientNotificationMessageVO : EntityVOBase
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