using SmartDigitalPsico.Domain.VO.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientHospitalizationInformation
{
    public class UpdatePatientHospitalizationInformationVO : EntityVOBase
    {

        #region Columns 

        [MaxLength(255)]
        [Required]
        public string Description { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [MaxLength(20)]
        [Required]
        public string CID { get; set; } = string.Empty;

        [Required]
        public string Observation { get; set; } = string.Empty;

        #endregion Columns 
    }
}